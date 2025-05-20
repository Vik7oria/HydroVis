namespace ReliefVisualisation
{
    partial class FormChartFromDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChartFromDB));
            this.treeViewHydroposts = new System.Windows.Forms.TreeView();
            this.chartFromDataBase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTypeOfGraphic = new System.Windows.Forms.GroupBox();
            this.radioButtonHysteresis = new System.Windows.Forms.RadioButton();
            this.radioButtonWaterLevel = new System.Windows.Forms.RadioButton();
            this.radioButtonHydrograph = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonMakeCraphic = new System.Windows.Forms.Button();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelTreePath = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownMinY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxY = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownMinX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxX = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMinMaxY = new System.Windows.Forms.CheckBox();
            this.checkBoxMinMaxX = new System.Windows.Forms.CheckBox();
            this.panelHydroposts = new System.Windows.Forms.Panel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelTools = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonChartColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxChartSeries = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxChartSeriesName = new System.Windows.Forms.TextBox();
            this.buttonClearSelectedSeries = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAxesInterval = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chartFromDataBase)).BeginInit();
            this.groupBoxTypeOfGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).BeginInit();
            this.panelHydroposts.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewHydroposts
            // 
            this.treeViewHydroposts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewHydroposts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewHydroposts.Location = new System.Drawing.Point(0, 44);
            this.treeViewHydroposts.Name = "treeViewHydroposts";
            this.treeViewHydroposts.Size = new System.Drawing.Size(283, 504);
            this.treeViewHydroposts.TabIndex = 0;
            this.treeViewHydroposts.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewHydroposts_BeforeSelect);
            this.treeViewHydroposts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewHydroposts_AfterSelect);
            // 
            // chartFromDataBase
            // 
            this.chartFromDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartFromDataBase.BorderlineColor = System.Drawing.Color.Black;
            this.chartFromDataBase.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.Name = "ChartArea1";
            this.chartFromDataBase.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartFromDataBase.Legends.Add(legend1);
            this.chartFromDataBase.Location = new System.Drawing.Point(3, 44);
            this.chartFromDataBase.Name = "chartFromDataBase";
            this.chartFromDataBase.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chartFromDataBase.Size = new System.Drawing.Size(716, 546);
            this.chartFromDataBase.TabIndex = 1;
            this.chartFromDataBase.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Гидроузлы";
            // 
            // groupBoxTypeOfGraphic
            // 
            this.groupBoxTypeOfGraphic.Controls.Add(this.radioButtonHysteresis);
            this.groupBoxTypeOfGraphic.Controls.Add(this.radioButtonWaterLevel);
            this.groupBoxTypeOfGraphic.Controls.Add(this.radioButtonHydrograph);
            this.groupBoxTypeOfGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTypeOfGraphic.Location = new System.Drawing.Point(2, 3);
            this.groupBoxTypeOfGraphic.Name = "groupBoxTypeOfGraphic";
            this.groupBoxTypeOfGraphic.Size = new System.Drawing.Size(220, 105);
            this.groupBoxTypeOfGraphic.TabIndex = 3;
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
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(6, 21);
            this.dateTimePicker.MaxDate = new System.DateTime(2025, 5, 20, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(137, 22);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2024, 1, 1, 8, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 49);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(137, 22);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Value = new System.DateTime(2024, 12, 31, 8, 0, 0, 0);
            // 
            // buttonMakeCraphic
            // 
            this.buttonMakeCraphic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMakeCraphic.BackColor = System.Drawing.Color.LightCyan;
            this.buttonMakeCraphic.Enabled = false;
            this.buttonMakeCraphic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMakeCraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMakeCraphic.Location = new System.Drawing.Point(88, 554);
            this.buttonMakeCraphic.Name = "buttonMakeCraphic";
            this.buttonMakeCraphic.Size = new System.Drawing.Size(87, 35);
            this.buttonMakeCraphic.TabIndex = 6;
            this.buttonMakeCraphic.Text = "Построить";
            this.buttonMakeCraphic.UseVisualStyleBackColor = false;
            this.buttonMakeCraphic.Click += new System.EventHandler(this.ButtonMakeChart_Click);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.DecimalPlaces = 3;
            this.numericUpDownX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownX.Location = new System.Drawing.Point(67, 42);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(108, 22);
            this.numericUpDownX.TabIndex = 7;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.DecimalPlaces = 3;
            this.numericUpDownY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownY.Location = new System.Drawing.Point(67, 70);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(108, 22);
            this.numericUpDownY.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ось X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ось Y";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.LightCyan;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(196, 554);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 35);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClearChart_Click);
            // 
            // labelTreePath
            // 
            this.labelTreePath.AutoSize = true;
            this.labelTreePath.BackColor = System.Drawing.Color.LightCyan;
            this.labelTreePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTreePath.Location = new System.Drawing.Point(3, 7);
            this.labelTreePath.Name = "labelTreePath";
            this.labelTreePath.Size = new System.Drawing.Size(155, 16);
            this.labelTreePath.TabIndex = 14;
            this.labelTreePath.Text = "Выбранный гидроузел";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Image = global::HydroVis.Properties.Resources.downloadIcon24;
            this.buttonSave.Location = new System.Drawing.Point(676, 7);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(43, 35);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSaveChart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Макс.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Мин.";
            // 
            // numericUpDownMinY
            // 
            this.numericUpDownMinY.DecimalPlaces = 3;
            this.numericUpDownMinY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMinY.Location = new System.Drawing.Point(67, 130);
            this.numericUpDownMinY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownMinY.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownMinY.Name = "numericUpDownMinY";
            this.numericUpDownMinY.Size = new System.Drawing.Size(108, 22);
            this.numericUpDownMinY.TabIndex = 16;
            // 
            // numericUpDownMaxY
            // 
            this.numericUpDownMaxY.DecimalPlaces = 3;
            this.numericUpDownMaxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMaxY.Location = new System.Drawing.Point(67, 158);
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
            this.numericUpDownMaxY.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Макс.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Мин.";
            // 
            // numericUpDownMinX
            // 
            this.numericUpDownMinX.DecimalPlaces = 3;
            this.numericUpDownMinX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMinX.Location = new System.Drawing.Point(67, 218);
            this.numericUpDownMinX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownMinX.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownMinX.Name = "numericUpDownMinX";
            this.numericUpDownMinX.Size = new System.Drawing.Size(108, 22);
            this.numericUpDownMinX.TabIndex = 21;
            // 
            // numericUpDownMaxX
            // 
            this.numericUpDownMaxX.DecimalPlaces = 3;
            this.numericUpDownMaxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMaxX.Location = new System.Drawing.Point(67, 246);
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
            this.numericUpDownMaxX.TabIndex = 22;
            // 
            // checkBoxMinMaxY
            // 
            this.checkBoxMinMaxY.AutoSize = true;
            this.checkBoxMinMaxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMinMaxY.Location = new System.Drawing.Point(6, 109);
            this.checkBoxMinMaxY.Name = "checkBoxMinMaxY";
            this.checkBoxMinMaxY.Size = new System.Drawing.Size(67, 20);
            this.checkBoxMinMaxY.TabIndex = 27;
            this.checkBoxMinMaxY.Text = "Ось Y";
            this.checkBoxMinMaxY.UseVisualStyleBackColor = true;
            this.checkBoxMinMaxY.CheckedChanged += new System.EventHandler(this.checkBoxMinMaxY_CheckedChanged);
            // 
            // checkBoxMinMaxX
            // 
            this.checkBoxMinMaxX.AutoSize = true;
            this.checkBoxMinMaxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMinMaxX.Location = new System.Drawing.Point(6, 193);
            this.checkBoxMinMaxX.Name = "checkBoxMinMaxX";
            this.checkBoxMinMaxX.Size = new System.Drawing.Size(66, 20);
            this.checkBoxMinMaxX.TabIndex = 28;
            this.checkBoxMinMaxX.Text = "Ось X";
            this.checkBoxMinMaxX.UseVisualStyleBackColor = true;
            this.checkBoxMinMaxX.CheckedChanged += new System.EventHandler(this.checkBoxMinMaxX_CheckedChanged);
            // 
            // panelHydroposts
            // 
            this.panelHydroposts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHydroposts.Controls.Add(this.label1);
            this.panelHydroposts.Controls.Add(this.buttonClear);
            this.panelHydroposts.Controls.Add(this.buttonMakeCraphic);
            this.panelHydroposts.Controls.Add(this.treeViewHydroposts);
            this.panelHydroposts.Location = new System.Drawing.Point(963, 3);
            this.panelHydroposts.Name = "panelHydroposts";
            this.panelHydroposts.Size = new System.Drawing.Size(286, 595);
            this.panelHydroposts.TabIndex = 29;
            // 
            // panelChart
            // 
            this.panelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChart.Controls.Add(this.labelTreePath);
            this.panelChart.Controls.Add(this.chartFromDataBase);
            this.panelChart.Controls.Add(this.buttonSave);
            this.panelChart.Location = new System.Drawing.Point(235, 3);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(722, 595);
            this.panelChart.TabIndex = 30;
            // 
            // panelTools
            // 
            this.panelTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTools.Controls.Add(this.groupBox3);
            this.panelTools.Controls.Add(this.groupBox2);
            this.panelTools.Controls.Add(this.groupBox1);
            this.panelTools.Controls.Add(this.groupBoxTypeOfGraphic);
            this.panelTools.Location = new System.Drawing.Point(3, 3);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(226, 595);
            this.panelTools.TabIndex = 31;
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
            this.groupBox3.Location = new System.Drawing.Point(2, 482);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 107);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Переименовать / удалить";
            // 
            // buttonChartColor
            // 
            this.buttonChartColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChartColor.Location = new System.Drawing.Point(190, 44);
            this.buttonChartColor.Name = "buttonChartColor";
            this.buttonChartColor.Size = new System.Drawing.Size(24, 24);
            this.buttonChartColor.TabIndex = 35;
            this.buttonChartColor.UseVisualStyleBackColor = true;
            this.buttonChartColor.Click += new System.EventHandler(this.buttonSeriesColor_Click);
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
            this.buttonClearSelectedSeries.Click += new System.EventHandler(this.ButtonClearSelectedSeries_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(2, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 82);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Даты";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAxesInterval);
            this.groupBox1.Controls.Add(this.numericUpDownMinY);
            this.groupBox1.Controls.Add(this.numericUpDownY);
            this.groupBox1.Controls.Add(this.numericUpDownMaxY);
            this.groupBox1.Controls.Add(this.checkBoxMinMaxX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericUpDownX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxMinMaxY);
            this.groupBox1.Controls.Add(this.numericUpDownMaxX);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numericUpDownMinX);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(2, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 274);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки графика";
            // 
            // checkBoxAxesInterval
            // 
            this.checkBoxAxesInterval.AutoSize = true;
            this.checkBoxAxesInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAxesInterval.Location = new System.Drawing.Point(6, 21);
            this.checkBoxAxesInterval.Name = "checkBoxAxesInterval";
            this.checkBoxAxesInterval.Size = new System.Drawing.Size(99, 20);
            this.checkBoxAxesInterval.TabIndex = 29;
            this.checkBoxAxesInterval.Text = "Интервал";
            this.checkBoxAxesInterval.UseVisualStyleBackColor = true;
            this.checkBoxAxesInterval.CheckedChanged += new System.EventHandler(this.checkBoxAxesInterval_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5944F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.17453F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23107F));
            this.tableLayoutPanel1.Controls.Add(this.panelHydroposts, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelChart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelTools, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1252, 601);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // FormChartFromDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 609);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChartFromDB";
            this.Text = "Построение графиков из базы данных";
            ((System.ComponentModel.ISupportInitialize)(this.chartFromDataBase)).EndInit();
            this.groupBoxTypeOfGraphic.ResumeLayout(false);
            this.groupBoxTypeOfGraphic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).EndInit();
            this.panelHydroposts.ResumeLayout(false);
            this.panelHydroposts.PerformLayout();
            this.panelChart.ResumeLayout(false);
            this.panelChart.PerformLayout();
            this.panelTools.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewHydroposts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFromDataBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTypeOfGraphic;
        private System.Windows.Forms.RadioButton radioButtonHydrograph;
        private System.Windows.Forms.RadioButton radioButtonWaterLevel;
        private System.Windows.Forms.RadioButton radioButtonHysteresis;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttonMakeCraphic;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelTreePath;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownMinY;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownMinX;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxX;
        private System.Windows.Forms.CheckBox checkBoxMinMaxY;
        private System.Windows.Forms.CheckBox checkBoxMinMaxX;
        private System.Windows.Forms.Panel panelHydroposts;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxAxesInterval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxChartSeriesName;
        private System.Windows.Forms.ComboBox comboBoxChartSeries;
        private System.Windows.Forms.Button buttonClearSelectedSeries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonChartColor;
    }
}