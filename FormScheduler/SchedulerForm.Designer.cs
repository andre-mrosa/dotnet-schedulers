namespace FormScheduler
{
    partial class SchedulerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulerForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tsEnabled = new DevExpress.XtraEditors.ToggleSwitch();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiClear = new DevExpress.XtraBars.BarButtonItem();
            this.seDayOfMonth = new DevExpress.XtraEditors.SpinEdit();
            this.ceDiaUtilMensal = new DevExpress.XtraEditors.CheckEdit();
            this.seOffsetDias = new DevExpress.XtraEditors.SpinEdit();
            this.ccbeDaysOfWeek = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.tseHora = new DevExpress.XtraEditors.TimeSpanEdit();
            this.rgFrequency = new DevExpress.XtraEditors.RadioGroup();
            this.cbeArgument = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gcSchedules = new DevExpress.XtraGrid.GridControl();
            this.gvSchedules = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFrequency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRunTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBtnRemove = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFrequency = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDayOfWeek = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHour = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDiaUtilMensal = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciArgument = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDayOfMonth = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOffsetDias = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDayOfMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceDiaUtilMensal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seOffsetDias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbeDaysOfWeek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tseHora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgFrequency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeArgument.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDayOfWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDiaUtilMensal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciArgument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDayOfMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOffsetDias)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tsEnabled);
            this.layoutControl1.Controls.Add(this.seDayOfMonth);
            this.layoutControl1.Controls.Add(this.ceDiaUtilMensal);
            this.layoutControl1.Controls.Add(this.seOffsetDias);
            this.layoutControl1.Controls.Add(this.ccbeDaysOfWeek);
            this.layoutControl1.Controls.Add(this.tseHora);
            this.layoutControl1.Controls.Add(this.rgFrequency);
            this.layoutControl1.Controls.Add(this.cbeArgument);
            this.layoutControl1.Controls.Add(this.gcSchedules);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 33);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1115, 624);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tsEnabled
            // 
            this.tsEnabled.Location = new System.Drawing.Point(104, 77);
            this.tsEnabled.MenuManager = this.barManager1;
            this.tsEnabled.Name = "tsEnabled";
            this.tsEnabled.Properties.OffText = "Off";
            this.tsEnabled.Properties.OnText = "On";
            this.tsEnabled.Size = new System.Drawing.Size(999, 24);
            this.tsEnabled.StyleController = this.layoutControl1;
            this.tsEnabled.TabIndex = 5;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiSave,
            this.bbiClear});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Adicionar";
            this.bbiSave.Id = 0;
            this.bbiSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiSave.ImageOptions.SvgImage")));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1115, 33);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 657);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1115, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 624);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1115, 33);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 624);
            // 
            // bbiClear
            // 
            this.bbiClear.Caption = "Remover";
            this.bbiClear.Id = 1;
            this.bbiClear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiClear.ImageOptions.SvgImage")));
            this.bbiClear.Name = "bbiClear";
            this.bbiClear.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // seDayOfMonth
            // 
            this.seDayOfMonth.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seDayOfMonth.Location = new System.Drawing.Point(229, 51);
            this.seDayOfMonth.Name = "seDayOfMonth";
            this.seDayOfMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seDayOfMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seDayOfMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seDayOfMonth.Properties.IsFloatValue = false;
            this.seDayOfMonth.Properties.MaskSettings.Set("mask", "N00");
            this.seDayOfMonth.Properties.MaxValue = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.seDayOfMonth.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seDayOfMonth.Size = new System.Drawing.Size(144, 22);
            this.seDayOfMonth.StyleController = this.layoutControl1;
            this.seDayOfMonth.TabIndex = 2;
            // 
            // ceDiaUtilMensal
            // 
            this.ceDiaUtilMensal.Location = new System.Drawing.Point(12, 51);
            this.ceDiaUtilMensal.Name = "ceDiaUtilMensal";
            this.ceDiaUtilMensal.Properties.Caption = "1º dia útil do mês";
            this.ceDiaUtilMensal.Size = new System.Drawing.Size(121, 20);
            this.ceDiaUtilMensal.StyleController = this.layoutControl1;
            this.ceDiaUtilMensal.TabIndex = 8;
            this.ceDiaUtilMensal.CheckedChanged += new System.EventHandler(this.ceDiaUtilMensal_CheckedChanged);
            // 
            // seOffsetDias
            // 
            this.seOffsetDias.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seOffsetDias.Location = new System.Drawing.Point(833, 51);
            this.seOffsetDias.Name = "seOffsetDias";
            this.seOffsetDias.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seOffsetDias.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seOffsetDias.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seOffsetDias.Properties.IsFloatValue = false;
            this.seOffsetDias.Properties.MaskSettings.Set("mask", "N00");
            this.seOffsetDias.Properties.MaxValue = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.seOffsetDias.Size = new System.Drawing.Size(144, 22);
            this.seOffsetDias.StyleController = this.layoutControl1;
            this.seOffsetDias.TabIndex = 9;
            // 
            // ccbeDaysOfWeek
            // 
            this.ccbeDaysOfWeek.EditValue = "";
            this.ccbeDaysOfWeek.Location = new System.Drawing.Point(469, 51);
            this.ccbeDaysOfWeek.Name = "ccbeDaysOfWeek";
            this.ccbeDaysOfWeek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbeDaysOfWeek.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Segunda-feira"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Terça-feira"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Quarta-feira"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Quinta-feira"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Sexta-feira"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Sábado"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Domingo")});
            this.ccbeDaysOfWeek.Size = new System.Drawing.Size(268, 22);
            this.ccbeDaysOfWeek.StyleController = this.layoutControl1;
            this.ccbeDaysOfWeek.TabIndex = 3;
            // 
            // tseHora
            // 
            this.tseHora.EditValue = System.TimeSpan.Parse("00:00:00");
            this.tseHora.Location = new System.Drawing.Point(982, 51);
            this.tseHora.Name = "tseHora";
            this.tseHora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tseHora.Properties.MaskSettings.Set("mask", "hh:mm:ss");
            this.tseHora.Properties.MaxValue = System.TimeSpan.Parse("23:59:59");
            this.tseHora.Properties.MinValue = System.TimeSpan.Parse("00:00:00");
            this.tseHora.Size = new System.Drawing.Size(121, 22);
            this.tseHora.StyleController = this.layoutControl1;
            this.tseHora.TabIndex = 4;
            // 
            // rgFrequency
            // 
            this.rgFrequency.Location = new System.Drawing.Point(104, 12);
            this.rgFrequency.MaximumSize = new System.Drawing.Size(0, 40);
            this.rgFrequency.Name = "rgFrequency";
            this.rgFrequency.Properties.Columns = 3;
            this.rgFrequency.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Diária"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Semanal"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Mensal")});
            this.rgFrequency.Size = new System.Drawing.Size(999, 35);
            this.rgFrequency.StyleController = this.layoutControl1;
            this.rgFrequency.TabIndex = 0;
            this.rgFrequency.SelectedIndexChanged += new System.EventHandler(this.rgFrequency_SelectedIndexChanged);
            // 
            // cbeArgument
            // 
            this.cbeArgument.Location = new System.Drawing.Point(104, 105);
            this.cbeArgument.Name = "cbeArgument";
            this.cbeArgument.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeArgument.Properties.Items.AddRange(new object[] {
            "AUTO",
            "SAFT"});
            this.cbeArgument.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeArgument.Size = new System.Drawing.Size(999, 22);
            this.cbeArgument.StyleController = this.layoutControl1;
            this.cbeArgument.TabIndex = 6;
            this.cbeArgument.ToolTip = "AUTO - Processa o job de integração pendente (encomendas ADVANCECARE -> PHC)\r\nSAF" +
    "T - Gera os ficheiros SAF-T mensais\r\n";
            this.cbeArgument.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cbeArgument.ToolTipTitle = "Info";
            // 
            // gcSchedules
            // 
            this.gcSchedules.Location = new System.Drawing.Point(24, 163);
            this.gcSchedules.MainView = this.gvSchedules;
            this.gcSchedules.Name = "gcSchedules";
            this.gcSchedules.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoBtnRemove});
            this.gcSchedules.Size = new System.Drawing.Size(1067, 427);
            this.gcSchedules.TabIndex = 7;
            this.gcSchedules.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSchedules});
            // 
            // gvSchedules
            // 
            this.gvSchedules.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFrequency,
            this.colRunTime,
            this.colDays,
            this.colDay,
            this.colArg,
            this.colRemove});
            this.gvSchedules.GridControl = this.gcSchedules;
            this.gvSchedules.Name = "gvSchedules";
            this.gvSchedules.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.GvSchedules_CustomColumnDisplayText);
            // 
            // colFrequency
            // 
            this.colFrequency.Caption = "Frequência";
            this.colFrequency.FieldName = "Frequency";
            this.colFrequency.Name = "colFrequency";
            this.colFrequency.Visible = true;
            this.colFrequency.VisibleIndex = 0;
            // 
            // colRunTime
            // 
            this.colRunTime.Caption = "Hora";
            this.colRunTime.FieldName = "RunTime";
            this.colRunTime.Name = "colRunTime";
            this.colRunTime.Visible = true;
            this.colRunTime.VisibleIndex = 1;
            // 
            // colDays
            // 
            this.colDays.Caption = "Dias";
            this.colDays.FieldName = "SelectedDaysOfWeek";
            this.colDays.Name = "colDays";
            this.colDays.Visible = true;
            this.colDays.VisibleIndex = 2;
            // 
            // colDay
            // 
            this.colDay.Caption = "Dia Mês";
            this.colDay.FieldName = "DayOfMonth";
            this.colDay.Name = "colDay";
            this.colDay.Visible = true;
            this.colDay.VisibleIndex = 3;
            // 
            // colArg
            // 
            this.colArg.Caption = "Argumento";
            this.colArg.FieldName = "Argument";
            this.colArg.Name = "colArg";
            this.colArg.Visible = true;
            this.colArg.VisibleIndex = 4;
            // 
            // colRemove
            // 
            this.colRemove.Caption = "Remover";
            this.colRemove.ColumnEdit = this.repoBtnRemove;
            this.colRemove.Name = "colRemove";
            this.colRemove.Visible = true;
            this.colRemove.VisibleIndex = 5;
            // 
            // repoBtnRemove
            // 
            this.repoBtnRemove.AutoHeight = false;
            this.repoBtnRemove.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repoBtnRemove.Name = "repoBtnRemove";
            this.repoBtnRemove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repoBtnRemove.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RepoBtnRemove_ButtonClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFrequency,
            this.lciDiaUtilMensal,
            this.lciDayOfMonth,
            this.lciDayOfWeek,
            this.lciOffsetDias,
            this.lciHour,
            this.layoutControlItem1,
            this.lciArgument,
            this.emptySpaceItem1,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1115, 624);
            this.Root.TextVisible = false;
            // 
            // lciFrequency
            // 
            this.lciFrequency.Control = this.rgFrequency;
            this.lciFrequency.Location = new System.Drawing.Point(0, 0);
            this.lciFrequency.Name = "lciFrequency";
            this.lciFrequency.Size = new System.Drawing.Size(1095, 39);
            this.lciFrequency.Text = "Frequência";
            this.lciFrequency.TextSize = new System.Drawing.Size(80, 13);
            // 
            // lciDayOfWeek
            // 
            this.lciDayOfWeek.BestFitWeight = 150;
            this.lciDayOfWeek.Control = this.ccbeDaysOfWeek;
            this.lciDayOfWeek.Location = new System.Drawing.Point(365, 39);
            this.lciDayOfWeek.Name = "lciDayOfWeek";
            this.lciDayOfWeek.Size = new System.Drawing.Size(364, 26);
            this.lciDayOfWeek.Text = "Dias da semana";
            this.lciDayOfWeek.TextSize = new System.Drawing.Size(80, 13);
            // 
            // lciHour
            // 
            this.lciHour.Control = this.tseHora;
            this.lciHour.Location = new System.Drawing.Point(878, 39);
            this.lciHour.Name = "lciHour";
            this.lciHour.Size = new System.Drawing.Size(217, 26);
            this.lciHour.Text = "Hora";
            this.lciHour.TextSize = new System.Drawing.Size(80, 13);
            // 
            // lciDiaUtilMensal
            // 
            this.lciDiaUtilMensal.Control = this.ceDiaUtilMensal;
            this.lciDiaUtilMensal.Location = new System.Drawing.Point(0, 39);
            this.lciDiaUtilMensal.Name = "lciDiaUtilMensal";
            this.lciDiaUtilMensal.Size = new System.Drawing.Size(125, 26);
            this.lciDiaUtilMensal.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tsEnabled;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 65);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1095, 28);
            this.layoutControlItem1.Text = "Ativo";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(80, 13);
            // 
            // lciArgument
            // 
            this.lciArgument.Control = this.cbeArgument;
            this.lciArgument.Location = new System.Drawing.Point(0, 93);
            this.lciArgument.Name = "lciArgument";
            this.lciArgument.Size = new System.Drawing.Size(1095, 26);
            this.lciArgument.Text = "Argumento";
            this.lciArgument.TextSize = new System.Drawing.Size(80, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 594);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1095, 10);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGrid});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 119);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1095, 475);
            this.layoutControlGroup1.Text = "Agendamentos Ativos";
            // 
            // lciGrid
            // 
            this.lciGrid.Control = this.gcSchedules;
            this.lciGrid.Location = new System.Drawing.Point(0, 0);
            this.lciGrid.Name = "lciGrid";
            this.lciGrid.Size = new System.Drawing.Size(1071, 431);
            this.lciGrid.Text = " ";
            this.lciGrid.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciGrid.TextVisible = false;
            // 
            // lciDayOfMonth
            // 
            this.lciDayOfMonth.Control = this.seDayOfMonth;
            this.lciDayOfMonth.Location = new System.Drawing.Point(125, 39);
            this.lciDayOfMonth.Name = "lciDayOfMonth";
            this.lciDayOfMonth.Size = new System.Drawing.Size(240, 26);
            this.lciDayOfMonth.Text = "Dia do mês";
            this.lciDayOfMonth.TextSize = new System.Drawing.Size(80, 13);
            // 
            // lciOffsetDias
            // 
            this.lciOffsetDias.Control = this.seOffsetDias;
            this.lciOffsetDias.Location = new System.Drawing.Point(125, 39);
            this.lciOffsetDias.Name = "lciOffsetDias";
            this.lciOffsetDias.Size = new System.Drawing.Size(240, 26);
            this.lciOffsetDias.Text = "Dias a somar";
            this.lciOffsetDias.TextSize = new System.Drawing.Size(80, 13);
            // 
            // SchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 657);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SchedulerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamentos";
            this.Load += new System.EventHandler(this.SchedulerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tsEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDayOfMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceDiaUtilMensal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seOffsetDias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbeDaysOfWeek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tseHora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgFrequency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeArgument.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSchedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSchedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDayOfWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDiaUtilMensal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciArgument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDayOfMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOffsetDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.RadioGroup rgFrequency;
        private DevExpress.XtraLayout.LayoutControlItem lciFrequency;
        private DevExpress.XtraEditors.TimeSpanEdit tseHora;
        private DevExpress.XtraLayout.LayoutControlItem lciHour;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SpinEdit seDayOfMonth;
        private DevExpress.XtraEditors.CheckEdit ceDiaUtilMensal;
        private DevExpress.XtraEditors.SpinEdit seOffsetDias;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccbeDaysOfWeek;
        private DevExpress.XtraLayout.LayoutControlItem lciDayOfWeek;
        private DevExpress.XtraLayout.LayoutControlItem lciDayOfMonth;
        private DevExpress.XtraLayout.LayoutControlItem lciDiaUtilMensal;
        private DevExpress.XtraLayout.LayoutControlItem lciOffsetDias;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.ToggleSwitch tsEnabled;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiClear;
        private DevExpress.XtraGrid.GridControl gcSchedules;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSchedules;
        private DevExpress.XtraEditors.ComboBoxEdit cbeArgument;
        private DevExpress.XtraLayout.LayoutControlItem lciArgument;
        private DevExpress.XtraLayout.LayoutControlItem lciGrid;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtnRemove;
        private DevExpress.XtraGrid.Columns.GridColumn colFrequency;
        private DevExpress.XtraGrid.Columns.GridColumn colRunTime;
        private DevExpress.XtraGrid.Columns.GridColumn colDays;
        private DevExpress.XtraGrid.Columns.GridColumn colDay;
        private DevExpress.XtraGrid.Columns.GridColumn colArg;
        private DevExpress.XtraGrid.Columns.GridColumn colRemove;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    }
}
