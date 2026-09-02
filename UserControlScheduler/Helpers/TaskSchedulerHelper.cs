using UserControlScheduler.Models.Enums;
using Microsoft.Win32.TaskScheduler;
using Nager.Date;
using System;
using System.Linq;

namespace UserControlScheduler.Helpers
{
    /// <summary>
    /// Agenda execuções periódicas de um executável através do Windows Task Scheduler.
    /// </summary>
    public static class TaskSchedulerHelper
    {
        /// <summary>
        /// Configura a tarefa agendada adaptando-se a qualquer frequência escolhida.
        /// </summary>
        public static void ConfigurarTarefaDinamica(
            string taskName,
            string exePath,
            ScheduleFrequencyEnum frequencia,
            TimeSpan horaExecucao,
            DaysOfTheWeek diasSemana = 0,
            int[] diasMes = null,
            string argumentos = null)
        {
            using (TaskService ts = new TaskService())
            {
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Execução agendada.";

                // 1. Criar a variável base para o gatilho
                Trigger trigger;

                // 2. Construir o gatilho consoante a frequência pedida
                switch (frequencia)
                {
                    case ScheduleFrequencyEnum.Daily:
                        trigger = new DailyTrigger { DaysInterval = 1 };
                        break;

                    case ScheduleFrequencyEnum.Weekly:
                        if (diasSemana == 0) throw new ArgumentException("Tem de selecionar pelo menos um dia da semana.");
                        trigger = new WeeklyTrigger { DaysOfWeek = diasSemana, WeeksInterval = 1 };
                        break;

                    case ScheduleFrequencyEnum.Monthly:
                        if (diasMes == null || diasMes.Length == 0) throw new ArgumentException("Tem de selecionar pelo menos um dia do mês.");
                        trigger = new MonthlyTrigger { DaysOfMonth = diasMes };
                        break;

                    default:
                        throw new InvalidOperationException("Frequência desconhecida.");
                }

                // 3. Configurar a hora de arranque (comum a todos)
                trigger.StartBoundary = DateTime.Today + horaExecucao;
                td.Triggers.Add(trigger);

                // 4. Configurar a Ação (Chamar o Integrador)
                td.Actions.Add(new ExecAction(exePath, argumentos, workingDirectory: null));
                td.Settings.StartWhenAvailable = true;

                // 5. APAGAR a tarefa antiga primeiro (garante que não há conflitos de atualização)
                ts.RootFolder.DeleteTask(taskName, exceptionOnNotExists: false);

                // 6. Registar a nova tarefa limpa
                ts.RootFolder.RegisterTaskDefinition(taskName, td);
            }
        }

        /// <summary>
        /// Remove a tarefa do Agendador de Tarefas do Windows.
        /// </summary>
        public static void RemoverTarefa(string taskName)
        {
            using (TaskService ts = new TaskService())
            {
                // Apaga a tarefa e ignora caso ela não exista (exceptionOnNotExists: false)
                ts.RootFolder.DeleteTask(taskName, exceptionOnNotExists: false);
            }
        }

        /// <summary>
        /// Calcula o 1º dia útil (não fim de semana, não feriado em Portugal) do mês indicado,
        /// somando depois offsetDiasCorridos dias de calendário (mesma lógica de cálculo de dia
        /// útil já usada em Program.cs.ValidateSaftScheduler, generalizada para qualquer mês).
        /// </summary>
        public static DateTime CalcularPrimeiroDiaUtil(int ano, int mes, int offsetDiasCorridos)
        {
            DateTime data = new DateTime(ano, mes, 1);
            while (DateSystem.IsWeekend(data, CountryCode.PT) || DateSystem.IsPublicHoliday(data, CountryCode.PT))
            {
                data = data.AddDays(1);
            }

            return data.AddDays(offsetDiasCorridos);
        }

        /// <summary>
        /// Configura (ou revalida) uma tarefa mensal cujo dia de execução é o 1º dia útil do mês
        /// (+ offsetDias dias corridos). Sem correspondência direta num MonthlyTrigger do Task
        /// Scheduler (que não conhece feriados portugueses), por isso usa-se um TimeTrigger para a
        /// próxima ocorrência calculada - o que exige que este método seja chamado periodicamente
        /// (ver revalidação no arranque da aplicação) para ir avançando a tarefa mês a mês.
        /// Só recria a tarefa quando a data configurada não é a correta, para não bater
        /// desnecessariamente no Task Scheduler em todos os arranques.
        /// </summary>
        public static void ConfigurarTarefaMensalDiaUtil(
            string taskName,
            string exePath,
            int offsetDias,
            TimeSpan horaExecucao,
            string argumentos,
            string descricao)
        {
            DateTime proximoMes = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1);
            DateTime dataAlvo = CalcularPrimeiroDiaUtil(proximoMes.Year, proximoMes.Month, offsetDias) + horaExecucao;

            using (TaskService ts = new TaskService())
            {
                Task existingTask = ts.GetTask(taskName);
                if (existingTask != null)
                {
                    bool dataCorreta = existingTask.Definition.Triggers
                        .Any(t => t.StartBoundary.Year == dataAlvo.Year &&
                                  t.StartBoundary.Month == dataAlvo.Month &&
                                  t.StartBoundary.Day == dataAlvo.Day);

                    if (dataCorreta) return;

                    ts.RootFolder.DeleteTask(taskName, exceptionOnNotExists: false);
                }

                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = descricao;
                td.Triggers.Add(new TimeTrigger { StartBoundary = dataAlvo });
                td.Actions.Add(new ExecAction(exePath, argumentos, workingDirectory: null));
                td.Settings.StartWhenAvailable = true;

                ts.RootFolder.RegisterTaskDefinition(taskName, td);
            }
        }
    }
}
