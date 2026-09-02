using UserControlScheduler.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace UserControlScheduler.Helpers
{
    /// <summary>
    /// Persistência dos agendamentos configurados em SchedulerUserControl. Grava num ficheiro JSON numa
    /// subpasta "Schedules" ao lado do executável do processo anfitrião - não contém dados
    /// sensíveis, por isso um ficheiro de texto simples (sem cifra) é suficiente.
    /// </summary>
    public static class Settings
    {
        private static string SchedulesPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Schedules", "schedules.json");

        public static List<ScheduleModel> GetScheduleConfiguration()
        {
            try
            {
                if (!File.Exists(SchedulesPath)) return new List<ScheduleModel>();

                string json = File.ReadAllText(SchedulesPath);
                return JsonConvert.DeserializeObject<List<ScheduleModel>>(json) ?? new List<ScheduleModel>();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro ao carregar as configurações de agendamento: " + ex.Message);
                return new List<ScheduleModel>();
            }
        }

        public static bool SaveScheduleConfiguration(List<ScheduleModel> schedules)
        {
            try
            {
                string dir = Path.GetDirectoryName(SchedulesPath);
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                string json = JsonConvert.SerializeObject(schedules, Formatting.Indented);

                // Escrita atómica: evita deixar o ficheiro corrompido se o processo for
                // interrompido a meio da gravação.
                string tempPath = SchedulesPath + "." + Guid.NewGuid().ToString("N") + ".tmp";
                File.WriteAllText(tempPath, json);

                try
                {
                    if (File.Exists(SchedulesPath))
                        File.Replace(tempPath, SchedulesPath, null);
                    else
                        File.Move(tempPath, SchedulesPath);
                }
                catch
                {
                    try { if (File.Exists(tempPath)) File.Delete(tempPath); } catch { /* nada a fazer */ }
                    throw;
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro ao gravar as configurações de agendamento: " + ex.Message);
                return false;
            }
        }
    }
}
