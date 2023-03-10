namespace PseudoRandomGeneratorAnalysis
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.buttonsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonRun = new System.Windows.Forms.Button();
            this.ButtonRerun = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.StaticInfo = new System.Windows.Forms.GroupBox();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelIn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelSi = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LabelD = new System.Windows.Forms.Label();
            this.LabelM = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.generatorParameters = new System.Windows.Forms.GroupBox();
            this.InputContainer = new System.Windows.Forms.Panel();
            this.panelInputM = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GeneratorChoose = new System.Windows.Forms.ComboBox();
            this.panelInputSi = new System.Windows.Forms.Panel();
            this.InputCount = new System.Windows.Forms.NumericUpDown();
            this.LabelInputSi = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MyConsole = new System.Windows.Forms.RichTextBox();
            this.MyConsoleProgressBar = new System.Windows.Forms.ProgressBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BaseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ControlPanel.SuspendLayout();
            this.buttonsContainer.SuspendLayout();
            this.StaticInfo.SuspendLayout();
            this.generatorParameters.SuspendLayout();
            this.InputContainer.SuspendLayout();
            this.panelInputM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelInputSi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputCount)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseChart)).BeginInit();
            this.TabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.buttonsContainer);
            this.ControlPanel.Controls.Add(this.StaticInfo);
            this.ControlPanel.Controls.Add(this.generatorParameters);
            this.ControlPanel.Controls.Add(this.groupBox1);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(300, 749);
            this.ControlPanel.TabIndex = 1;
            // 
            // buttonsContainer
            // 
            this.buttonsContainer.AutoSize = true;
            this.buttonsContainer.Controls.Add(this.ButtonRun);
            this.buttonsContainer.Controls.Add(this.ButtonRerun);
            this.buttonsContainer.Controls.Add(this.ButtonSave);
            this.buttonsContainer.Controls.Add(this.ButtonClear);
            this.buttonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsContainer.Location = new System.Drawing.Point(0, 663);
            this.buttonsContainer.Name = "buttonsContainer";
            this.buttonsContainer.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.buttonsContainer.Size = new System.Drawing.Size(300, 86);
            this.buttonsContainer.TabIndex = 5;
            // 
            // ButtonRun
            // 
            this.ButtonRun.Location = new System.Drawing.Point(23, 8);
            this.ButtonRun.Name = "ButtonRun";
            this.ButtonRun.Size = new System.Drawing.Size(99, 32);
            this.ButtonRun.TabIndex = 4;
            this.ButtonRun.Text = "Запуск";
            this.ButtonRun.UseVisualStyleBackColor = true;
            this.ButtonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // ButtonRerun
            // 
            this.ButtonRerun.Location = new System.Drawing.Point(128, 8);
            this.ButtonRerun.Name = "ButtonRerun";
            this.ButtonRerun.Size = new System.Drawing.Size(134, 32);
            this.ButtonRerun.TabIndex = 4;
            this.ButtonRerun.Text = "Перезапуск";
            this.ButtonRerun.UseVisualStyleBackColor = true;
            this.ButtonRerun.Click += new System.EventHandler(this.ButtonRerun_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(23, 46);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(99, 32);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Сохр.";
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(128, 46);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(134, 32);
            this.ButtonClear.TabIndex = 4;
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // StaticInfo
            // 
            this.StaticInfo.Controls.Add(this.LabelTime);
            this.StaticInfo.Controls.Add(this.LabelIn);
            this.StaticInfo.Controls.Add(this.label7);
            this.StaticInfo.Controls.Add(this.label2);
            this.StaticInfo.Controls.Add(this.LabelSi);
            this.StaticInfo.Controls.Add(this.label17);
            this.StaticInfo.Controls.Add(this.label16);
            this.StaticInfo.Controls.Add(this.LabelD);
            this.StaticInfo.Controls.Add(this.LabelM);
            this.StaticInfo.Controls.Add(this.label15);
            this.StaticInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.StaticInfo.Location = new System.Drawing.Point(0, 227);
            this.StaticInfo.Name = "StaticInfo";
            this.StaticInfo.Padding = new System.Windows.Forms.Padding(30, 10, 60, 10);
            this.StaticInfo.Size = new System.Drawing.Size(300, 167);
            this.StaticInfo.TabIndex = 3;
            this.StaticInfo.TabStop = false;
            this.StaticInfo.Text = "Свойства";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(77, 119);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(40, 22);
            this.LabelTime.TabIndex = 0;
            this.LabelTime.Text = "___";
            // 
            // LabelIn
            // 
            this.LabelIn.AutoSize = true;
            this.LabelIn.Location = new System.Drawing.Point(77, 97);
            this.LabelIn.Name = "LabelIn";
            this.LabelIn.Size = new System.Drawing.Size(40, 22);
            this.LabelIn.TabIndex = 0;
            this.LabelIn.Text = "___";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "t = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "in = ";
            // 
            // LabelSi
            // 
            this.LabelSi.AutoSize = true;
            this.LabelSi.Location = new System.Drawing.Point(77, 75);
            this.LabelSi.Name = "LabelSi";
            this.LabelSi.Size = new System.Drawing.Size(40, 22);
            this.LabelSi.TabIndex = 0;
            this.LabelSi.Text = "___";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(35, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 22);
            this.label17.TabIndex = 0;
            this.label17.Text = "σ = ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 22);
            this.label16.TabIndex = 0;
            this.label16.Text = "D = ";
            // 
            // LabelD
            // 
            this.LabelD.AutoSize = true;
            this.LabelD.Location = new System.Drawing.Point(77, 53);
            this.LabelD.Name = "LabelD";
            this.LabelD.Size = new System.Drawing.Size(40, 22);
            this.LabelD.TabIndex = 0;
            this.LabelD.Text = "___";
            // 
            // LabelM
            // 
            this.LabelM.AutoSize = true;
            this.LabelM.Location = new System.Drawing.Point(77, 31);
            this.LabelM.Name = "LabelM";
            this.LabelM.Size = new System.Drawing.Size(40, 22);
            this.LabelM.TabIndex = 0;
            this.LabelM.Text = "___";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 22);
            this.label15.TabIndex = 0;
            this.label15.Text = "m = ";
            // 
            // generatorParameters
            // 
            this.generatorParameters.AutoSize = true;
            this.generatorParameters.Controls.Add(this.InputContainer);
            this.generatorParameters.Controls.Add(this.ButtonReset);
            this.generatorParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.generatorParameters.Location = new System.Drawing.Point(0, 111);
            this.generatorParameters.Margin = new System.Windows.Forms.Padding(4);
            this.generatorParameters.Name = "generatorParameters";
            this.generatorParameters.Padding = new System.Windows.Forms.Padding(30, 10, 60, 10);
            this.generatorParameters.Size = new System.Drawing.Size(300, 116);
            this.generatorParameters.TabIndex = 2;
            this.generatorParameters.TabStop = false;
            this.generatorParameters.Text = "Параметры";
            // 
            // InputContainer
            // 
            this.InputContainer.AutoSize = true;
            this.InputContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InputContainer.Controls.Add(this.panelInputM);
            this.InputContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputContainer.Location = new System.Drawing.Point(30, 31);
            this.InputContainer.Name = "InputContainer";
            this.InputContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InputContainer.Size = new System.Drawing.Size(210, 44);
            this.InputContainer.TabIndex = 9;
            // 
            // panelInputM
            // 
            this.panelInputM.AutoSize = true;
            this.panelInputM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelInputM.Controls.Add(this.numericUpDown1);
            this.panelInputM.Controls.Add(this.label1);
            this.panelInputM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInputM.Location = new System.Drawing.Point(0, 0);
            this.panelInputM.Name = "panelInputM";
            this.panelInputM.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panelInputM.Size = new System.Drawing.Size(210, 34);
            this.panelInputM.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(25, 0);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(185, 28);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "σ ";
            // 
            // ButtonReset
            // 
            this.ButtonReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonReset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonReset.Location = new System.Drawing.Point(30, 75);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(210, 31);
            this.ButtonReset.TabIndex = 6;
            this.ButtonReset.Text = "Сброс";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panelInputSi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(30, 10, 60, 10);
            this.groupBox1.Size = new System.Drawing.Size(300, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.GeneratorChoose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(30, 65);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panel1.Size = new System.Drawing.Size(210, 36);
            this.panel1.TabIndex = 8;
            // 
            // GeneratorChoose
            // 
            this.GeneratorChoose.DisplayMember = "0";
            this.GeneratorChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneratorChoose.FormattingEnabled = true;
            this.GeneratorChoose.Location = new System.Drawing.Point(0, 0);
            this.GeneratorChoose.Name = "GeneratorChoose";
            this.GeneratorChoose.Size = new System.Drawing.Size(210, 30);
            this.GeneratorChoose.TabIndex = 6;
            this.GeneratorChoose.SelectedIndexChanged += new System.EventHandler(this.GeneratorChoose_SelectedIndexChanged);
            // 
            // panelInputSi
            // 
            this.panelInputSi.AutoSize = true;
            this.panelInputSi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelInputSi.Controls.Add(this.InputCount);
            this.panelInputSi.Controls.Add(this.LabelInputSi);
            this.panelInputSi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInputSi.Location = new System.Drawing.Point(30, 31);
            this.panelInputSi.Name = "panelInputSi";
            this.panelInputSi.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panelInputSi.Size = new System.Drawing.Size(210, 34);
            this.panelInputSi.TabIndex = 7;
            // 
            // InputCount
            // 
            this.InputCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputCount.Location = new System.Drawing.Point(25, 0);
            this.InputCount.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.InputCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InputCount.Name = "InputCount";
            this.InputCount.Size = new System.Drawing.Size(185, 28);
            this.InputCount.TabIndex = 5;
            this.InputCount.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // LabelInputSi
            // 
            this.LabelInputSi.AutoSize = true;
            this.LabelInputSi.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelInputSi.Location = new System.Drawing.Point(0, 0);
            this.LabelInputSi.Name = "LabelInputSi";
            this.LabelInputSi.Size = new System.Drawing.Size(25, 22);
            this.LabelInputSi.TabIndex = 1;
            this.LabelInputSi.Text = "σ ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MyConsole);
            this.tabPage2.Controls.Add(this.MyConsoleProgressBar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(990, 720);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Консоль";
            // 
            // MyConsole
            // 
            this.MyConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.MyConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyConsole.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyConsole.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.MyConsole.Location = new System.Drawing.Point(0, 0);
            this.MyConsole.Name = "MyConsole";
            this.MyConsole.ReadOnly = true;
            this.MyConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MyConsole.Size = new System.Drawing.Size(990, 697);
            this.MyConsole.TabIndex = 0;
            this.MyConsole.Text = "";
            // 
            // MyConsoleProgressBar
            // 
            this.MyConsoleProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MyConsoleProgressBar.Location = new System.Drawing.Point(0, 697);
            this.MyConsoleProgressBar.Maximum = 1000;
            this.MyConsoleProgressBar.Name = "MyConsoleProgressBar";
            this.MyConsoleProgressBar.Size = new System.Drawing.Size(990, 23);
            this.MyConsoleProgressBar.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BaseChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(990, 714);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Анализ распределения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BaseChart
            // 
            chartArea3.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "x";
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisY.Title = "f(x)";
            chartArea3.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.Name = "Histogram";
            chartArea4.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.Title = "x";
            chartArea4.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea4.AxisY.Maximum = 1D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisY.Title = "F(x)";
            chartArea4.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.Name = "Graphic";
            this.BaseChart.ChartAreas.Add(chartArea3);
            this.BaseChart.ChartAreas.Add(chartArea4);
            this.BaseChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseChart.Location = new System.Drawing.Point(4, 4);
            this.BaseChart.Margin = new System.Windows.Forms.Padding(4);
            this.BaseChart.Name = "BaseChart";
            this.BaseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.BaseChart.Size = new System.Drawing.Size(982, 706);
            this.BaseChart.TabIndex = 0;
            this.BaseChart.Text = "BaseChart";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(998, 749);
            this.TabControl.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ControlPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1302, 749);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 749);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Анализ рандомайзеров";
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.buttonsContainer.ResumeLayout(false);
            this.StaticInfo.ResumeLayout(false);
            this.StaticInfo.PerformLayout();
            this.generatorParameters.ResumeLayout(false);
            this.generatorParameters.PerformLayout();
            this.InputContainer.ResumeLayout(false);
            this.InputContainer.PerformLayout();
            this.panelInputM.ResumeLayout(false);
            this.panelInputM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelInputSi.ResumeLayout(false);
            this.panelInputSi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputCount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseChart)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.GroupBox StaticInfo;
        private System.Windows.Forms.Label LabelSi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LabelD;
        private System.Windows.Forms.Label LabelM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown InputCount;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonRerun;
        private System.Windows.Forms.Button ButtonRun;
        private System.Windows.Forms.GroupBox generatorParameters;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Label LabelInputSi;
        private System.Windows.Forms.Label LabelIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar MyConsoleProgressBar;
        private System.Windows.Forms.RichTextBox MyConsole;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart BaseChart;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel buttonsContainer;
        private System.Windows.Forms.Panel panelInputSi;
        private System.Windows.Forms.Panel panelInputM;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel InputContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox GeneratorChoose;
    }
}

