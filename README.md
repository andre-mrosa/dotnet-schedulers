# .Net Schedulers

Dois componentes WinForms/DevExpress reutilizáveis para agendar execuções periódicas de um
executável (diário, semanal, mensal - dia fixo ou 1º dia útil do mês com offset em dias
corridos), via Windows Task Scheduler.

- **UserControlScheduler** - `SchedulerUserControl`, para embutir dentro de outro form/painel.
- **FormScheduler** - `SchedulerForm`, standalone, pronto a abrir diretamente (`new SchedulerForm().ShowDialog()` ou como MDI child).

Os dois projetos são independentes um do outro (cada um traz a sua própria cópia de
`ScheduleModel`, dos enums e dos helpers) - podes copiar só a pasta de que precisas para outro
projeto sem teres de arrastar o resto.

## Como funciona

- `TaskSchedulerHelper.ConfigurarTarefaDinamica` regista uma tarefa Diária/Semanal/Mensal (dia
  fixo) no Windows Task Scheduler.
- Para "1º dia útil do mês (+ X dias)", não há um `MonthlyTrigger` nativo que conheça feriados
  portugueses - `TaskSchedulerHelper.ConfigurarTarefaMensalDiaUtil` calcula a data da próxima
  ocorrência (via `Nager.Date`) e regista um `TimeTrigger` só para essa data. **Isto exige que a
  aplicação anfitriã chame `ConfigurarTarefaMensalDiaUtil` novamente em cada arranque** (com os
  mesmos parâmetros) para o agendamento avançar mês a mês - o método só recria a tarefa quando a
  data configurada deixa de ser a correta, por isso é seguro chamá-lo sempre no arranque.
- `Helpers/Settings.cs` persiste os agendamentos configurados em `Schedules/schedules.json`, ao
  lado do executável do processo anfitrião.

## Requisitos

- .NET Framework 4.8, WinForms.
- **DevExpress WinForms v25.2** instalado na máquina que compila o projeto (licença comercial -
  por isso os assemblies não estão incluídos neste repositório nem são restaurados via NuGet).
  Se a instalação não estiver em `C:\Program Files\DevExpress 25.2\Components\Bin\Framework\`,
  compila com `msbuild /p:DevExpressAssembliesPath=<caminho>\` a apontar para essa pasta.
- Pacotes NuGet públicos: `Nager.Date`, `Newtonsoft.Json`, `TaskScheduler`
  (`Microsoft.Win32.TaskScheduler`).

## Argumentos da tarefa

O combo de "Argumento" no formulário vem pré-preenchido com `AUTO`/`SAFT` como exemplo - edita
`cbeArgument.Properties.Items` no `.Designer.cs` para os argumentos que a tua aplicação
realmente aceita na linha de comandos.
