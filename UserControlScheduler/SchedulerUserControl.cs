using UserControlScheduler.Models;
using UserControlScheduler.Models.Enums;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraSplashScreen;
using Microsoft.Win32.TaskScheduler;
using UserControlScheduler.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace UserControlScheduler
{
    /// <summary>
    /// Versão standalone (Form) do agendador - conteúdo idêntico a SchedulerUserControl, para uso
    /// direto sem necessidade de o hospedar dentro de outro form/painel. Mantida como cópia
    /// intencional (não composição) para que ambas - UserControl e Form - possam ser reutilizadas
    /// de forma independente noutros projetos.
    /// </summary>
    public partial class SchedulerUserControl : XtraUserControl
    {
        private BindingList<ScheduleModel> _schedulesList = new BindingList<ScheduleModel>();

        public SchedulerUserControl()
        {
            InitializeComponent();
        }

        private void GvSchedules_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "SelectedDaysOfWeek" && e.Value is List<string> list)
            {
                e.DisplayText = string.Join(", ", list);
            }
        }

        private void RepoBtnRemove_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (gvSchedules.GetFocusedRow() is ScheduleModel schedule)
            {
                if (XtraMessageBox.Show("Remover agendamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        TaskSchedulerHelper.RemoverTarefa(schedule.TaskName);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        XtraMessageBox.Show("Execute a aplicação como Administrador para remover a tarefa do sistema.", "Sem Permissões", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Ocorreu um erro ao remover a tarefa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _schedulesList.Remove(schedule);
                    Settings.SaveScheduleConfiguration(_schedulesList.ToList());
                }
            }
        }

        private void SchedulerUserControl_Load(object sender, EventArgs e)
        {
            using (IOverlaySplashScreenHandle splashScreenHandler = SplashScreenManager.ShowOverlayForm(this))
            {
                var savedSchedules = Settings.GetScheduleConfiguration();
                _schedulesList = new BindingList<ScheduleModel>(savedSchedules);
                gcSchedules.DataSource = _schedulesList;

                rgFrequency.SelectedIndex = 0;
                tseHora.TimeSpan = TimeSpan.Zero;
                tsEnabled.IsOn = true;
                seDayOfMonth.Value = 1;
                ceDiaUtilMensal.Checked = false;
                seOffsetDias.Value = 0;
                ccbeDaysOfWeek.SetEditValue(string.Empty);
                cbeArgument.SelectedIndex = 0;

                AtualizarVisibilidadeControlos();
            }
        }

        private void rgFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarVisibilidadeControlos();
        }

        private void ceDiaUtilMensal_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarVisibilidadeControlos();
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            tseHora.DoValidate();
            try
            {
                TimeSpan hora = tseHora.TimeSpan;
                int selecao = rgFrequency.SelectedIndex;
                string exePath = Application.ExecutablePath;

                var newSchedule = new ScheduleModel
                {
                    Frequency = (ScheduleFrequencyEnum)selecao,
                    RunTime = hora,
                    DayOfMonth = Convert.ToInt32(seDayOfMonth.Value),
                    MonthlyMode = ceDiaUtilMensal.Checked ? MonthlyScheduleModeEnum.FirstBusinessDay : MonthlyScheduleModeEnum.FixedDay,
                    OffsetDays = Convert.ToInt32(seOffsetDias.Value),
                    SelectedDaysOfWeek = ccbeDaysOfWeek.EditValue?.ToString()?
                        .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList() ?? new List<string>(),
                    IsEnabled = tsEnabled.IsOn,
                    Argument = cbeArgument.Text
                };

                if (selecao == 0) // Diário
                {
                    TaskSchedulerHelper.ConfigurarTarefaDinamica(newSchedule.TaskName, exePath, ScheduleFrequencyEnum.Daily, hora, argumentos: newSchedule.Argument);
                }
                else if (selecao == 1) // Weekly
                {
                    DaysOfTheWeek diasEscolhidos = ObterDiasSemanaSelecionados();

                    if (diasEscolhidos == 0)
                    {
                        XtraMessageBox.Show("Selecione pelo menos um dia da semana.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    TaskSchedulerHelper.ConfigurarTarefaDinamica(newSchedule.TaskName, exePath, ScheduleFrequencyEnum.Weekly, hora, diasSemana: diasEscolhidos, argumentos: newSchedule.Argument);
                }
                else if (selecao == 2) // Monthly
                {
                    if (newSchedule.MonthlyMode == MonthlyScheduleModeEnum.FirstBusinessDay)
                    {
                        string descricao = "Execução agendada - 1º dia útil do mês"
                            + (newSchedule.OffsetDays != 0 ? $" + {newSchedule.OffsetDays} dia(s)" : "") + ".";

                        TaskSchedulerHelper.ConfigurarTarefaMensalDiaUtil(newSchedule.TaskName, exePath, newSchedule.OffsetDays, hora, newSchedule.Argument, descricao);
                    }
                    else
                    {
                        int diaEscolhido = Convert.ToInt32(seDayOfMonth.Value);
                        int[] diasDoMes = new int[] { diaEscolhido };

                        TaskSchedulerHelper.ConfigurarTarefaDinamica(newSchedule.TaskName, exePath, ScheduleFrequencyEnum.Monthly, hora, diasMes: diasDoMes, argumentos: newSchedule.Argument);
                    }
                }

                _schedulesList.Add(newSchedule);

                if (!Settings.SaveScheduleConfiguration(_schedulesList.ToList()))
                {
                    XtraMessageBox.Show("Ocorreu um erro ao guardar as configurações de sincronização automática no ficheiro de configs.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Rollback add
                    _schedulesList.RemoveAt(_schedulesList.Count - 1);
                    return;
                }

                string mensagemStatus = tsEnabled.IsOn ? "ativada" : "desativada";
                XtraMessageBox.Show($"Configuração guardada com sucesso!\nA sincronização automática encontra-se {mensagemStatus}.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {
                XtraMessageBox.Show("Execute a aplicação como Administrador para configurar a tarefa.", "Sem Permissões");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Ocorreu um erro ao guardar o agendamento: {ex.Message}", "Erro");
            }
        }

        /// <summary>
        /// Reposiciona explicitamente os itens da 2ª linha (dia da semana / dia do mês / 1º dia
        /// útil + dias a somar / hora) em vez de confiar só em Visibility + BestFit(). O
        /// colapso automático de espaço da LayoutControl quando um item é escondido depende da
        /// ordem/pesos internos e não estava a libertar o espaço de forma fiável com 4 itens
        /// concorrentes nesta linha (ficavam espaços vazios, ou "Dias a somar" caía para uma
        /// linha própria) - por isso aqui fixa-se a posição de cada item visível manualmente.
        /// </summary>
        private void AtualizarVisibilidadeControlos()
        {
            layoutControl1.BeginUpdate();
            lcgControl.BestFit();
            try
            {
                lciDayOfWeek.Visibility = LayoutVisibility.Never;
                lciDayOfMonth.Visibility = LayoutVisibility.Never;
                lciDiaUtilMensal.Visibility = LayoutVisibility.Never;
                lciOffsetDias.Visibility = LayoutVisibility.Never;

                // 0 = Diário | 1 = Weekly | 2 = Monthly
                switch (rgFrequency.SelectedIndex)
                {
                    case 0:
                        // Diário: Apenas a hora
                        break;
                    case 1:
                        // Weekly: Mostra a escolha dos dias da semana
                        lciDayOfWeek.Visibility = LayoutVisibility.Always;
                        break;
                    case 2:
                        // Monthly: 1º dia útil do mês (checkbox) + dia fixo OU dias a somar, no
                        // mesmo slot (mutuamente exclusivos), sempre seguido da hora.
                        lciDiaUtilMensal.Visibility = LayoutVisibility.Always;
                        seDayOfMonth.Size = seOffsetDias.Size;

                        if (ceDiaUtilMensal.Checked)
                        {
                            lciOffsetDias.Visibility = LayoutVisibility.Always;
                        }
                        else
                        {
                            lciDayOfMonth.Visibility = LayoutVisibility.Always;
                        }

                        break;
                }
            }
            finally
            {
                layoutControl1.EndUpdate();
            }
        }

        private DaysOfTheWeek ObterDiasSemanaSelecionados()
        {
            DaysOfTheWeek resultado = 0;
            string selecionados = ccbeDaysOfWeek.EditValue?.ToString() ?? "";

            // O DevExpress devolve uma string separada por vírgulas (ex: "Segunda, Quarta, Sexta")
            if (selecionados.Contains("Segunda-feira")) resultado |= DaysOfTheWeek.Monday;
            if (selecionados.Contains("Terça-feira")) resultado |= DaysOfTheWeek.Tuesday;
            if (selecionados.Contains("Quarta-feira")) resultado |= DaysOfTheWeek.Wednesday;
            if (selecionados.Contains("Quinta-feira")) resultado |= DaysOfTheWeek.Thursday;
            if (selecionados.Contains("Sexta-feira")) resultado |= DaysOfTheWeek.Friday;
            if (selecionados.Contains("Sábado")) resultado |= DaysOfTheWeek.Saturday;
            if (selecionados.Contains("Domingo")) resultado |= DaysOfTheWeek.Sunday;

            return resultado;
        }
    }
}
