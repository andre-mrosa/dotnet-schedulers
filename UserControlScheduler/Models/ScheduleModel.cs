using UserControlScheduler.Models.Enums;
using System;
using System.Collections.Generic;

namespace UserControlScheduler.Models
{
    public class ScheduleModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        // Frequência escolhida (Mapeia perfeitamente para o SelectedIndex do RadioGroup)
        public ScheduleFrequencyEnum Frequency { get; set; }

        // Hora de Execução
        public TimeSpan RunTime { get; set; }

        // Dias da Semana (Para o formato Semanal)
        public List<string> SelectedDaysOfWeek { get; set; } = new List<string>();

        // Dia do Mês (Para o formato Mensal, quando MonthlyMode == FixedDay)
        public int DayOfMonth { get; set; }

        // Para o formato Mensal: dia fixo do mês, ou 1º dia útil (+ OffsetDays)
        public MonthlyScheduleModeEnum MonthlyMode { get; set; } = MonthlyScheduleModeEnum.FixedDay;

        // Dias corridos a somar ao 1º dia útil do mês (só relevante quando MonthlyMode == FirstBusinessDay)
        public int OffsetDays { get; set; }

        public bool IsEnabled { get; set; }

        public string Argument { get; set; }

        public string TaskName => $"ScheduledTask_{Id}";
    }
}