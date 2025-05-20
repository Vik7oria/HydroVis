namespace ReliefVisualisation
{
    partial class FormChartFromFile
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChartFromFile));
            this.chartFile = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_QtDraw = new System.Windows.Forms.Button();
            this.textBoxFileQ = new System.Windows.Forms.TextBox();
            this.button_fileQBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMinMaxX = new System.Windows.Forms.CheckBox();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMinMaxY = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownMinX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownMaxY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinY = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAxesInterval = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_NB = new System.Windows.Forms.RadioButton();
            this.radioButton_VB = new System.Windows.Forms.RadioButton();
            this.groupBoxTypeOfGraphic = new System.Windows.Forms.GroupBox();
            this.radioButtonHysteresis = new System.Windows.Forms.RadioButton();
            this.radioButtonWaterLevel = new System.Windows.Forms.RadioButton();
            this.radioButtonHydrograph = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonChartColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxChartSeries = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxChartSeriesName = new System.Windows.Forms.TextBox();
            this.buttonClearSelectedSeries = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinY)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxTypeOfGraphic.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartFile
            // 
            this.chartFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartFile.BorderlineColor = System.Drawing.Color.Black;
            this.chartFile.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.Name = "ChartArea1";
            this.chartFile.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartFile.Legends.Add(legend1);
            this.chartFile.Location = new System.Drawing.Point(236, 62);
            this.chartFile.Name = "chartFile";
            this.chartFile.Size = new System.Drawing.Size(828, 608);
            this.chartFile.TabIndex = 0;
            this.chartFile.Text = "chart1";
            // 
            // button_QtDraw
            // 
            this.button_QtDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_QtDraw.BackColor = System.Drawing.Color.LightCyan;
            this.button_QtDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_QtDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_QtDraw.Location = new System.Drawing.Point(10, 634);
            this.button_QtDraw.Name = "button_QtDraw";
            this.button_QtDraw.Size = new System.Drawing.Size(99, 37);
            this.button_QtDraw.TabIndex = 1;
            this.button_QtDraw.Text = "Построить";
            this.button_QtDraw.UseVisualStyleBackColor = false;
            this.button_QtDraw.Click += new System.EventHandler(this.ButtonMakeChart_Click);
            // 
            // textBoxFileQ
            // 
            this.textBoxFileQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileQ.BackColor = System.Drawing.Color.White;
            this.textBoxFileQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFileQ.Location = new System.Drawing.Point(10, 30);
            this.textBoxFileQ.Name = "textBoxFileQ";
            this.textBoxFileQ.ReadOnly = true;
            this.textBoxFileQ.Size = new System.Drawing.Size(889, 22);
            this.textBoxFileQ.TabIndex = 2;
            // 
            // button_fileQBrowse
            // 
            this.button_fileQBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_fileQBrowse.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_fileQBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_fileQBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_fileQBrowse.Location = new System.Drawing.Point(905, 24);
            this.button_fileQBrowse.Name = "button_fileQBrowse";
            this.button_fileQBrowse.Size = new System.Drawing.Size(42, 36);
            this.button_fileQBrowse.TabIndex = 11;
            this.button_fileQBrowse.Text = "...";
            this.button_fileQBrowse.UseVisualStyleBackColor = false;
            this.button_fileQBrowse.Click += new System.EventHandler(this.ButtonFilePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Файл с данными:";
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Clear.BackColor = System.Drawing.Color.LightCyan;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Clear.Location = new System.Drawing.Point(148, 634);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(82, 37);
            this.button_Clear.TabIndex = 18;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.ButtonClearChart_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Image = global::HydroVis.Properties.Resources.downloadIcon24;
            this.buttonSave.Location = new System.Drawing.Point(1025, 23);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(39, 37);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSaveChart_Click);
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.DecimalPlaces = 3;
            this.numericUpDownY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownY.Location = new System.Drawing.Point(84, 70);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(108, 22);
            this.numericUpDownY.TabIndex = 30;
            // 
            // checkBoxMinMaxX
            // 
            this.checkBoxMinMaxX.AutoSize = true;
            this.checkBoxMinMaxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMinMaxX.Location = new System.Drawing.Point(7, 181);
            this.checkBoxMinMaxX.Name = "checkBoxMinMaxX";
            this.checkBoxMinMaxX.Size = new System.Drawing.Size(66, 20);
            this.checkBoxMinMaxX.TabIndex = 43;
            this.checkBoxMinMaxX.Text = "Ось X";
            this.checkBoxMinMaxX.UseVisualStyleBackColor = true;
            this.checkBoxMinMaxX.CheckedChanged += new System.EventHandler(this.checkBoxMinMaxX_CheckedChanged);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.DecimalPlaces = 3;
            this.numericUpDownX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownX.Location = new System.Drawing.Point(84, 42);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(108, 22);
            this.numericUpDownX.TabIndex = 29;
            // 
            // checkBoxMinMaxY
            // 
            this.checkBoxMinMaxY.AutoSize = true;
            this.checkBoxMinMaxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMinMaxY.Location = new System.Drawing.Point(7, 101);
            this.checkBoxMinMaxY.Name = "checkBoxMinMaxY";
            this.checkBoxMinMaxY.Size = new System.Drawing.Size(67, 20);
            this.checkBoxMinMaxY.TabIndex = 42;
            this.checkBoxMinMaxY.Text = "Ось Y";
            this.checkBoxMinMaxY.UseVisualStyleBackColor = true;
            this.checkBoxMinMaxY.CheckedChanged += new System.EventHandler(this.checkBoxMinMaxY_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(4, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Макс.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(4, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Мин.";
            // 
            // numericUpDownMinX
            // 
            this.numericUpDownMinX.DecimalPlaces = 3;
            this.numericUpDownMinX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMinX.Location = new System.Drawing.Point(84, 206);
            this.numericUpDownMinX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMinX.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownMinX.Name = "numericUpDownMinX";
            this.numericUpDownMinX.Size = new System.Drawing.Size(108, 22);
            this.numericUpDownMinX.TabIndex = 38;
            // 
            // numericUpDownMaxX
            // 
            this.numericUpDownMaxX.DecimalPlaces = 3;
            this.numericUpDownMaxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMaxX.Location = new System.Drawing.Point(84, 234);
            this.numericUpDownMaxX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMaxX.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxX.Name = "numericUpDownMaxX";
            this.numericUpDownMaxX.Size = new System.Drawing.Size(108, 22);
            this.numericUpDownMaxX.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ось X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Макс.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ось Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Мин.";
            // 
            // numericUpDownMaxY
            // 
            this.numericUpDownMaxY.DecimalPlaces = 3;
            this.numericUpDownMaxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMaxY.Location = new System.Drawing.Point(84, 150);
            this.numericUpDownMaxY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMaxY.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxY.Name = "numericUpDownMaxY";
            this.numericUpDownMaxY.Size = new System.Drawing.Size(108, 22);
            this.numericUpDownMaxY.TabIndex = 35;
            // 
            // numericUpDownMinY
            // 
            this.numericUpDownMinY.DecimalPlaces = 3;
            this.numericUpDownMinY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMinY.Location = new System.Drawing.Point(84, 122);
            this.numericUpDownMinY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMinY.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownMinY.Name = "numericUpDownMinY";
            this.numericUpDownMinY.Size = new System.Drawing.Size(108, 22);
            this.numericUpDownMinY.TabIndex = 34;
            // 
            // checkBoxAxesInterval
            // 
            this.checkBoxAxesInterval.AutoSize = true;
            this.checkBoxAxesInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAxesInterval.Location = new System.Drawing.Point(6, 21);
            this.checkBoxAxesInterval.Name = "checkBoxAxesInterval";
            this.checkBoxAxesInterval.Size = new System.Drawing.Size(99, 20);
            this.checkBoxAxesInterval.TabIndex = 45;
            this.checkBoxAxesInterval.Text = "Интервал";
            this.checkBoxAxesInterval.UseVisualStyleBackColor = true;
            this.checkBoxAxesInterval.CheckedChanged += new System.EventHandler(this.checkBoxAxesInterval_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_NB);
            this.groupBox1.Controls.Add(this.radioButton_VB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(10, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 55);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_NB
            // 
            this.radioButton_NB.AutoSize = true;
            this.radioButton_NB.Enabled = false;
            this.radioButton_NB.Location = new System.Drawing.Point(7, 32);
            this.radioButton_NB.Name = "radioButton_NB";
            this.radioButton_NB.Size = new System.Drawing.Size(113, 20);
            this.radioButton_NB.TabIndex = 1;
            this.radioButton_NB.TabStop = true;
            this.radioButton_NB.Text = "Нижний бьеф";
            this.radioButton_NB.UseVisualStyleBackColor = true;
            // 
            // radioButton_VB
            // 
            this.radioButton_VB.AutoSize = true;
            this.radioButton_VB.Checked = true;
            this.radioButton_VB.Enabled = false;
            this.radioButton_VB.Location = new System.Drawing.Point(7, 9);
            this.radioButton_VB.Name = "radioButton_VB";
            this.radioButton_VB.Size = new System.Drawing.Size(117, 20);
            this.radioButton_VB.TabIndex = 0;
            this.radioButton_VB.TabStop = true;
            this.radioButton_VB.Text = "Верхний бьеф";
            this.radioButton_VB.UseVisualStyleBackColor = true;
            // 
            // groupBoxTypeOfGraphic
            // 
            this.groupBoxTypeOfGraphic.Controls.Add(this.radioButtonHysteresis);
            this.groupBoxTypeOfGraphic.Controls.Add(this.radioButtonWaterLevel);
            this.groupBoxTypeOfGraphic.Controls.Add(this.radioButtonHydrograph);
            this.groupBoxTypeOfGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTypeOfGraphic.Location = new System.Drawing.Point(10, 62);
            this.groupBoxTypeOfGraphic.Name = "groupBoxTypeOfGraphic";
            this.groupBoxTypeOfGraphic.Size = new System.Drawing.Size(220, 105);
            this.groupBoxTypeOfGraphic.TabIndex = 47;
            this.groupBoxTypeOfGraphic.TabStop = false;
            this.groupBoxTypeOfGraphic.Text = "Выбор графика";
            // 
            // radioButtonHysteresis
            // 
            this.radioButtonHysteresis.AutoSize = true;
            this.radioButtonHysteresis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonHysteresis.Location = new System.Drawing.Point(6, 73);
            this.radioButtonHysteresis.Name = "radioButtonHysteresis";
            this.radioButtonHysteresis.Size = new System.Drawing.Size(101, 20);
            this.radioButtonHysteresis.TabIndex = 2;
            this.radioButtonHysteresis.Text = "Гистерезис";
            this.radioButtonHysteresis.UseVisualStyleBackColor = true;
            // 
            // radioButtonWaterLevel
            // 
            this.radioButtonWaterLevel.AutoSize = true;
            this.radioButtonWaterLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWaterLevel.Location = new System.Drawing.Point(6, 47);
            this.radioButtonWaterLevel.Name = "radioButtonWaterLevel";
            this.radioButtonWaterLevel.Size = new System.Drawing.Size(117, 20);
            this.radioButtonWaterLevel.TabIndex = 1;
            this.radioButtonWaterLevel.Text = "Уровень воды";
            this.radioButtonWaterLevel.UseVisualStyleBackColor = true;
            // 
            // radioButtonHydrograph
            // 
            this.radioButtonHydrograph.AutoSize = true;
            this.radioButtonHydrograph.Checked = true;
            this.radioButtonHydrograph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonHydrograph.Location = new System.Drawing.Point(6, 21);
            this.radioButtonHydrograph.Name = "radioButtonHydrograph";
            this.radioButtonHydrograph.Size = new System.Drawing.Size(107, 20);
            this.radioButtonHydrograph.TabIndex = 0;
            this.radioButtonHydrograph.TabStop = true;
            this.radioButtonHydrograph.Text = "Расход воды";
            this.radioButtonHydrograph.UseVisualStyleBackColor = true;
            this.radioButtonHydrograph.CheckedChanged += new System.EventHandler(this.radioButtonHydrograph_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxAxesInterval);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericUpDownX);
            this.groupBox2.Controls.Add(this.numericUpDownY);
            this.groupBox2.Controls.Add(this.checkBoxMinMaxX);
            this.groupBox2.Controls.Add(this.numericUpDownMinY);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.checkBoxMinMaxY);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numericUpDownMaxY);
            this.groupBox2.Controls.Add(this.numericUpDownMinX);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numericUpDownMaxX);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(10, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 264);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки графика";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonChartColor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBoxChartSeries);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxChartSeriesName);
            this.groupBox3.Controls.Add(this.buttonClearSelectedSeries);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(10, 501);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 107);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Переименовать / удалить";
            // 
            // buttonChartColor
            // 
            this.buttonChartColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChartColor.Location = new System.Drawing.Point(190, 44);
            this.buttonChartColor.Name = "buttonChartColor";
            this.buttonChartColor.Size = new System.Drawing.Size(24, 24);
            this.buttonChartColor.TabIndex = 37;
            this.buttonChartColor.UseVisualStyleBackColor = true;
            this.buttonChartColor.Click += new System.EventHandler(this.buttonChartColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Название";
            // 
            // comboBoxChartSeries
            // 
            this.comboBoxChartSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChartSeries.FormattingEnabled = true;
            this.comboBoxChartSeries.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxChartSeries.Location = new System.Drawing.Point(4, 44);
            this.comboBoxChartSeries.Name = "comboBoxChartSeries";
            this.comboBoxChartSeries.Size = new System.Drawing.Size(42, 24);
            this.comboBoxChartSeries.TabIndex = 30;
            this.comboBoxChartSeries.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartSeries_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Номер";
            // 
            // textBoxChartSeriesName
            // 
            this.textBoxChartSeriesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChartSeriesName.Location = new System.Drawing.Point(52, 45);
            this.textBoxChartSeriesName.Name = "textBoxChartSeriesName";
            this.textBoxChartSeriesName.Size = new System.Drawing.Size(132, 22);
            this.textBoxChartSeriesName.TabIndex = 31;
            this.textBoxChartSeriesName.TextChanged += new System.EventHandler(this.textBoxChartSeriesName_TextChanged);
            // 
            // buttonClearSelectedSeries
            // 
            this.buttonClearSelectedSeries.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonClearSelectedSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearSelectedSeries.Location = new System.Drawing.Point(89, 73);
            this.buttonClearSelectedSeries.Name = "buttonClearSelectedSeries";
            this.buttonClearSelectedSeries.Size = new System.Drawing.Size(54, 24);
            this.buttonClearSelectedSeries.TabIndex = 32;
            this.buttonClearSelectedSeries.Text = "X";
            this.buttonClearSelectedSeries.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClearSelectedSeries.UseVisualStyleBackColor = false;
            this.buttonClearSelectedSeries.Click += new System.EventHandler(this.buttonClearSelectedSeries_Click);
            // 
            // FormChartFromFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 677);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_QtDraw);
            this.Controls.Add(this.groupBoxTypeOfGraphic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_fileQBrowse);
            this.Controls.Add(this.textBoxFileQ);
            this.Controls.Add(this.chartFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChartFromFile";
            this.Text = "Построение графиков из файлов";
            ((System.ComponentModel.ISupportInitialize)(this.chartFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinY)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTypeOfGraphic.ResumeLayout(false);
            this.groupBoxTypeOfGraphic.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFile;
        private System.Windows.Forms.Button button_QtDraw;
        private System.Windows.Forms.TextBox textBoxFileQ;
        private System.Windows.Forms.Button button_fileQBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.CheckBox checkBoxMinMaxX;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.CheckBox checkBoxMinMaxY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownMinX;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxY;
        private System.Windows.Forms.NumericUpDown numericUpDownMinY;
        private System.Windows.Forms.CheckBox checkBoxAxesInterval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_NB;
        private System.Windows.Forms.RadioButton radioButton_VB;
        private System.Windows.Forms.GroupBox groupBoxTypeOfGraphic;
        private System.Windows.Forms.RadioButton radioButtonHysteresis;
        private System.Windows.Forms.RadioButton radioButtonWaterLevel;
        private System.Windows.Forms.RadioButton radioButtonHydrograph;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxChartSeries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxChartSeriesName;
        private System.Windows.Forms.Button buttonClearSelectedSeries;
        private System.Windows.Forms.Button buttonChartColor;
    }
}