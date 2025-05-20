namespace ReliefVisualisation
{
    partial class FormReliefVisualisation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReliefVisualisation));
            this.buttonVisualizeRelief = new System.Windows.Forms.Button();
            this.textBoxReliefPath = new System.Windows.Forms.TextBox();
            this.buttonReliefPath = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBoxControlPointsPath = new System.Windows.Forms.TextBox();
            this.buttonControlPointsPath = new System.Windows.Forms.Button();
            this.buttonAddControlPoints = new System.Windows.Forms.Button();
            this.pictureBoxRelief = new System.Windows.Forms.PictureBox();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxHigh = new System.Windows.Forms.GroupBox();
            this.numericUpDownHighMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHighMin = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_multicolor = new System.Windows.Forms.RadioButton();
            this.radioButton_gray = new System.Windows.Forms.RadioButton();
            this.buttonAddWaterLayer = new System.Windows.Forms.Button();
            this.chartForControlPoint = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonCreateHydrograph = new System.Windows.Forms.Button();
            this.textBoxHydrographPath = new System.Windows.Forms.TextBox();
            this.buttonHydrographPath = new System.Windows.Forms.Button();
            this.panelHydrograph = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonHydrographClear = new System.Windows.Forms.Button();
            this.labelControlPoint = new System.Windows.Forms.Label();
            this.groupBoxTypeOfGraphic = new System.Windows.Forms.GroupBox();
            this.radioButtonHysteresis = new System.Windows.Forms.RadioButton();
            this.radioButtonEtat = new System.Windows.Forms.RadioButton();
            this.radioButtonQt = new System.Windows.Forms.RadioButton();
            this.CreateChartFromDB_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateChartFromFile_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessData_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MapOfHydroposts_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxAxesInterval = new System.Windows.Forms.CheckBox();
            this.numericUpDownMinY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxY = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMinMaxX = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxMinMaxY = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownMaxX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinX = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxChartSeries = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxChartSeriesName = new System.Windows.Forms.TextBox();
            this.buttonClearSelectedSeries = new System.Windows.Forms.Button();
            this.buttonChartColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRelief)).BeginInit();
            this.groupBoxHigh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartForControlPoint)).BeginInit();
            this.panelHydrograph.SuspendLayout();
            this.groupBoxTypeOfGraphic.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinX)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVisualizeRelief
            // 
            this.buttonVisualizeRelief.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVisualizeRelief.BackColor = System.Drawing.Color.LightCyan;
            this.buttonVisualizeRelief.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVisualizeRelief.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVisualizeRelief.Location = new System.Drawing.Point(1147, 3);
            this.buttonVisualizeRelief.Name = "buttonVisualizeRelief";
            this.buttonVisualizeRelief.Size = new System.Drawing.Size(216, 23);
            this.buttonVisualizeRelief.TabIndex = 5;
            this.buttonVisualizeRelief.Text = "Визуализировать рельеф";
            this.buttonVisualizeRelief.UseVisualStyleBackColor = false;
            this.buttonVisualizeRelief.Click += new System.EventHandler(this.ButtonVisualizeRelief_Click);
            // 
            // textBoxReliefPath
            // 
            this.textBoxReliefPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReliefPath.BackColor = System.Drawing.Color.White;
            this.textBoxReliefPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReliefPath.Location = new System.Drawing.Point(199, 4);
            this.textBoxReliefPath.Name = "textBoxReliefPath";
            this.textBoxReliefPath.ReadOnly = true;
            this.textBoxReliefPath.Size = new System.Drawing.Size(896, 22);
            this.textBoxReliefPath.TabIndex = 7;
            // 
            // buttonReliefPath
            // 
            this.buttonReliefPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReliefPath.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonReliefPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReliefPath.Location = new System.Drawing.Point(1101, 3);
            this.buttonReliefPath.Name = "buttonReliefPath";
            this.buttonReliefPath.Size = new System.Drawing.Size(42, 23);
            this.buttonReliefPath.TabIndex = 6;
            this.buttonReliefPath.Text = "...";
            this.buttonReliefPath.UseVisualStyleBackColor = false;
            this.buttonReliefPath.Click += new System.EventHandler(this.ButtonReliefPath_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBoxControlPointsPath
            // 
            this.textBoxControlPointsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxControlPointsPath.BackColor = System.Drawing.Color.White;
            this.textBoxControlPointsPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxControlPointsPath.Location = new System.Drawing.Point(199, 36);
            this.textBoxControlPointsPath.Name = "textBoxControlPointsPath";
            this.textBoxControlPointsPath.ReadOnly = true;
            this.textBoxControlPointsPath.Size = new System.Drawing.Size(896, 22);
            this.textBoxControlPointsPath.TabIndex = 9;
            // 
            // buttonControlPointsPath
            // 
            this.buttonControlPointsPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonControlPointsPath.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonControlPointsPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonControlPointsPath.Location = new System.Drawing.Point(1101, 35);
            this.buttonControlPointsPath.Name = "buttonControlPointsPath";
            this.buttonControlPointsPath.Size = new System.Drawing.Size(42, 23);
            this.buttonControlPointsPath.TabIndex = 10;
            this.buttonControlPointsPath.Text = "...";
            this.buttonControlPointsPath.UseVisualStyleBackColor = false;
            this.buttonControlPointsPath.Click += new System.EventHandler(this.ButtonControlPointsPath_Click);
            // 
            // buttonAddControlPoints
            // 
            this.buttonAddControlPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddControlPoints.BackColor = System.Drawing.Color.LightCyan;
            this.buttonAddControlPoints.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddControlPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddControlPoints.Location = new System.Drawing.Point(1147, 35);
            this.buttonAddControlPoints.Name = "buttonAddControlPoints";
            this.buttonAddControlPoints.Size = new System.Drawing.Size(216, 23);
            this.buttonAddControlPoints.TabIndex = 11;
            this.buttonAddControlPoints.Text = "Добавить контрольные точки";
            this.buttonAddControlPoints.UseVisualStyleBackColor = false;
            this.buttonAddControlPoints.Click += new System.EventHandler(this.ButtonAddControlPoints_Click);
            // 
            // pictureBoxRelief
            // 
            this.pictureBoxRelief.Location = new System.Drawing.Point(275, 72);
            this.pictureBoxRelief.Name = "pictureBoxRelief";
            this.pictureBoxRelief.Size = new System.Drawing.Size(690, 410);
            this.pictureBoxRelief.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRelief.TabIndex = 12;
            this.pictureBoxRelief.TabStop = false;
            this.pictureBoxRelief.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxRelief_MouseClick);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(218, 150);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Минимум";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Максимум";
            // 
            // groupBoxHigh
            // 
            this.groupBoxHigh.BackColor = System.Drawing.Color.White;
            this.groupBoxHigh.Controls.Add(this.numericUpDownHighMax);
            this.groupBoxHigh.Controls.Add(this.label1);
            this.groupBoxHigh.Controls.Add(this.numericUpDownHighMin);
            this.groupBoxHigh.Controls.Add(this.label2);
            this.groupBoxHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxHigh.Location = new System.Drawing.Point(7, 96);
            this.groupBoxHigh.Name = "groupBoxHigh";
            this.groupBoxHigh.Size = new System.Drawing.Size(184, 85);
            this.groupBoxHigh.TabIndex = 17;
            this.groupBoxHigh.TabStop = false;
            this.groupBoxHigh.Text = "Высота";
            // 
            // numericUpDownHighMax
            // 
            this.numericUpDownHighMax.DecimalPlaces = 3;
            this.numericUpDownHighMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownHighMax.Location = new System.Drawing.Point(78, 51);
            this.numericUpDownHighMax.Name = "numericUpDownHighMax";
            this.numericUpDownHighMax.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownHighMax.TabIndex = 25;
            // 
            // numericUpDownHighMin
            // 
            this.numericUpDownHighMin.DecimalPlaces = 3;
            this.numericUpDownHighMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownHighMin.Location = new System.Drawing.Point(78, 24);
            this.numericUpDownHighMin.Name = "numericUpDownHighMin";
            this.numericUpDownHighMin.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownHighMin.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radioButton_multicolor);
            this.groupBox1.Controls.Add(this.radioButton_gray);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(7, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 71);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Палитра";
            // 
            // radioButton_multicolor
            // 
            this.radioButton_multicolor.AutoSize = true;
            this.radioButton_multicolor.Checked = true;
            this.radioButton_multicolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_multicolor.Location = new System.Drawing.Point(9, 43);
            this.radioButton_multicolor.Name = "radioButton_multicolor";
            this.radioButton_multicolor.Size = new System.Drawing.Size(118, 20);
            this.radioButton_multicolor.TabIndex = 1;
            this.radioButton_multicolor.TabStop = true;
            this.radioButton_multicolor.Text = "многоцветная";
            this.radioButton_multicolor.UseVisualStyleBackColor = true;
            // 
            // radioButton_gray
            // 
            this.radioButton_gray.AutoSize = true;
            this.radioButton_gray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_gray.Location = new System.Drawing.Point(9, 20);
            this.radioButton_gray.Name = "radioButton_gray";
            this.radioButton_gray.Size = new System.Drawing.Size(126, 20);
            this.radioButton_gray.TabIndex = 0;
            this.radioButton_gray.TabStop = true;
            this.radioButton_gray.Text = "оттенки серого";
            this.radioButton_gray.UseVisualStyleBackColor = true;
            this.radioButton_gray.CheckedChanged += new System.EventHandler(this.radioButton_gray_CheckedChanged);
            // 
            // buttonAddWaterLayer
            // 
            this.buttonAddWaterLayer.BackColor = System.Drawing.Color.LightCyan;
            this.buttonAddWaterLayer.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAddWaterLayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddWaterLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddWaterLayer.Location = new System.Drawing.Point(7, 264);
            this.buttonAddWaterLayer.Name = "buttonAddWaterLayer";
            this.buttonAddWaterLayer.Size = new System.Drawing.Size(184, 35);
            this.buttonAddWaterLayer.TabIndex = 19;
            this.buttonAddWaterLayer.Text = "Добавить слой воды";
            this.buttonAddWaterLayer.UseVisualStyleBackColor = false;
            this.buttonAddWaterLayer.Click += new System.EventHandler(this.ButtonAddWaterLayer_Click);
            // 
            // chartForControlPoint
            // 
            this.chartForControlPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartForControlPoint.BorderlineColor = System.Drawing.Color.Black;
            this.chartForControlPoint.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.Name = "ChartArea1";
            this.chartForControlPoint.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartForControlPoint.Legends.Add(legend1);
            this.chartForControlPoint.Location = new System.Drawing.Point(3, 3);
            this.chartForControlPoint.Name = "chartForControlPoint";
            this.chartForControlPoint.Size = new System.Drawing.Size(347, 290);
            this.chartForControlPoint.TabIndex = 20;
            this.chartForControlPoint.Text = "chart1";
            // 
            // buttonCreateHydrograph
            // 
            this.buttonCreateHydrograph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateHydrograph.BackColor = System.Drawing.Color.LightCyan;
            this.buttonCreateHydrograph.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateHydrograph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateHydrograph.Location = new System.Drawing.Point(51, 327);
            this.buttonCreateHydrograph.Name = "buttonCreateHydrograph";
            this.buttonCreateHydrograph.Size = new System.Drawing.Size(160, 37);
            this.buttonCreateHydrograph.TabIndex = 21;
            this.buttonCreateHydrograph.Text = "Построить гидрограф";
            this.buttonCreateHydrograph.UseVisualStyleBackColor = false;
            this.buttonCreateHydrograph.Click += new System.EventHandler(this.ButtonCreateHydrograph_Click);
            // 
            // textBoxHydrographPath
            // 
            this.textBoxHydrographPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHydrographPath.BackColor = System.Drawing.Color.White;
            this.textBoxHydrographPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHydrographPath.Location = new System.Drawing.Point(3, 299);
            this.textBoxHydrographPath.Name = "textBoxHydrographPath";
            this.textBoxHydrographPath.ReadOnly = true;
            this.textBoxHydrographPath.Size = new System.Drawing.Size(347, 22);
            this.textBoxHydrographPath.TabIndex = 22;
            // 
            // buttonHydrographPath
            // 
            this.buttonHydrographPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHydrographPath.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonHydrographPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHydrographPath.Location = new System.Drawing.Point(3, 327);
            this.buttonHydrographPath.Name = "buttonHydrographPath";
            this.buttonHydrographPath.Size = new System.Drawing.Size(42, 37);
            this.buttonHydrographPath.TabIndex = 23;
            this.buttonHydrographPath.Text = "...";
            this.buttonHydrographPath.UseVisualStyleBackColor = false;
            this.buttonHydrographPath.Click += new System.EventHandler(this.ButtonHydrographPath_Click);
            // 
            // panelHydrograph
            // 
            this.panelHydrograph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHydrograph.BackColor = System.Drawing.Color.White;
            this.panelHydrograph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHydrograph.Controls.Add(this.buttonSave);
            this.panelHydrograph.Controls.Add(this.buttonHydrographClear);
            this.panelHydrograph.Controls.Add(this.chartForControlPoint);
            this.panelHydrograph.Controls.Add(this.buttonHydrographPath);
            this.panelHydrograph.Controls.Add(this.textBoxHydrographPath);
            this.panelHydrograph.Controls.Add(this.buttonCreateHydrograph);
            this.panelHydrograph.Location = new System.Drawing.Point(1008, 72);
            this.panelHydrograph.Name = "panelHydrograph";
            this.panelHydrograph.Size = new System.Drawing.Size(355, 379);
            this.panelHydrograph.TabIndex = 24;
            this.panelHydrograph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHydrograph_MouseDown);
            this.panelHydrograph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHydrograph_MouseMove);
            this.panelHydrograph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHydrograph_MouseUp);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Image = global::HydroVis.Properties.Resources.downloadIcon24;
            this.buttonSave.Location = new System.Drawing.Point(311, 327);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(39, 37);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonHydrographClear
            // 
            this.buttonHydrographClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHydrographClear.BackColor = System.Drawing.Color.LightCyan;
            this.buttonHydrographClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHydrographClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHydrographClear.Location = new System.Drawing.Point(222, 327);
            this.buttonHydrographClear.Name = "buttonHydrographClear";
            this.buttonHydrographClear.Size = new System.Drawing.Size(83, 37);
            this.buttonHydrographClear.TabIndex = 24;
            this.buttonHydrographClear.Text = "Очистить";
            this.buttonHydrographClear.UseVisualStyleBackColor = false;
            this.buttonHydrographClear.Click += new System.EventHandler(this.buttonHydrographClear_Click);
            // 
            // labelControlPoint
            // 
            this.labelControlPoint.AutoSize = true;
            this.labelControlPoint.BackColor = System.Drawing.Color.White;
            this.labelControlPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlPoint.Location = new System.Drawing.Point(1005, 563);
            this.labelControlPoint.Name = "labelControlPoint";
            this.labelControlPoint.Size = new System.Drawing.Size(133, 16);
            this.labelControlPoint.TabIndex = 25;
            this.labelControlPoint.Text = "Контрольная точка";
            this.labelControlPoint.Visible = false;
            // 
            // groupBoxTypeOfGraphic
            // 
            this.groupBoxTypeOfGraphic.Controls.Add(this.radioButtonHysteresis);
            this.groupBoxTypeOfGraphic.Controls.Add(this.radioButtonEtat);
            this.groupBoxTypeOfGraphic.Controls.Add(this.radioButtonQt);
            this.groupBoxTypeOfGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTypeOfGraphic.Location = new System.Drawing.Point(7, 305);
            this.groupBoxTypeOfGraphic.Name = "groupBoxTypeOfGraphic";
            this.groupBoxTypeOfGraphic.Size = new System.Drawing.Size(184, 96);
            this.groupBoxTypeOfGraphic.TabIndex = 48;
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
            // radioButtonEtat
            // 
            this.radioButtonEtat.AutoSize = true;
            this.radioButtonEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonEtat.Location = new System.Drawing.Point(6, 47);
            this.radioButtonEtat.Name = "radioButtonEtat";
            this.radioButtonEtat.Size = new System.Drawing.Size(117, 20);
            this.radioButtonEtat.TabIndex = 1;
            this.radioButtonEtat.Text = "Уровень воды";
            this.radioButtonEtat.UseVisualStyleBackColor = true;
            // 
            // radioButtonQt
            // 
            this.radioButtonQt.AutoSize = true;
            this.radioButtonQt.Checked = true;
            this.radioButtonQt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonQt.Location = new System.Drawing.Point(6, 21);
            this.radioButtonQt.Name = "radioButtonQt";
            this.radioButtonQt.Size = new System.Drawing.Size(107, 20);
            this.radioButtonQt.TabIndex = 0;
            this.radioButtonQt.TabStop = true;
            this.radioButtonQt.Text = "Расход воды";
            this.radioButtonQt.UseVisualStyleBackColor = true;
            // 
            // CreateChartFromDB_ToolStripMenuItem
            // 
            this.CreateChartFromDB_ToolStripMenuItem.BackColor = System.Drawing.Color.LightCyan;
            this.CreateChartFromDB_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateChartFromDB_ToolStripMenuItem.Name = "CreateChartFromDB_ToolStripMenuItem";
            this.CreateChartFromDB_ToolStripMenuItem.Size = new System.Drawing.Size(183, 21);
            this.CreateChartFromDB_ToolStripMenuItem.Text = "График из базы данных";
            this.CreateChartFromDB_ToolStripMenuItem.Click += new System.EventHandler(this.CreateChartFromDB_ToolStripMenuItem_Click);
            // 
            // CreateChartFromFile_toolStripMenuItem
            // 
            this.CreateChartFromFile_toolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CreateChartFromFile_toolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateChartFromFile_toolStripMenuItem.Name = "CreateChartFromFile_toolStripMenuItem";
            this.CreateChartFromFile_toolStripMenuItem.Size = new System.Drawing.Size(183, 21);
            this.CreateChartFromFile_toolStripMenuItem.Text = "График по данным из файла";
            this.CreateChartFromFile_toolStripMenuItem.Click += new System.EventHandler(this.CreateChartFromFile_toolStripMenuItem_Click);
            // 
            // ProcessData_ToolStripMenuItem
            // 
            this.ProcessData_ToolStripMenuItem.BackColor = System.Drawing.Color.LightCyan;
            this.ProcessData_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcessData_ToolStripMenuItem.Name = "ProcessData_ToolStripMenuItem";
            this.ProcessData_ToolStripMenuItem.Size = new System.Drawing.Size(183, 21);
            this.ProcessData_ToolStripMenuItem.Text = "Обработать данные";
            this.ProcessData_ToolStripMenuItem.Click += new System.EventHandler(this.ProcessData_ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateChartFromDB_ToolStripMenuItem,
            this.CreateChartFromFile_toolStripMenuItem,
            this.ProcessData_ToolStripMenuItem,
            this.MapOfHydroposts_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(196, 693);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "Построить график";
            // 
            // MapOfHydroposts_ToolStripMenuItem
            // 
            this.MapOfHydroposts_ToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.MapOfHydroposts_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MapOfHydroposts_ToolStripMenuItem.Name = "MapOfHydroposts_ToolStripMenuItem";
            this.MapOfHydroposts_ToolStripMenuItem.Size = new System.Drawing.Size(183, 21);
            this.MapOfHydroposts_ToolStripMenuItem.Text = "Карта гидроузлов";
            this.MapOfHydroposts_ToolStripMenuItem.Click += new System.EventHandler(this.MapOfHydroposts_ToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxAxesInterval);
            this.groupBox2.Controls.Add(this.numericUpDownMinY);
            this.groupBox2.Controls.Add(this.numericUpDownY);
            this.groupBox2.Controls.Add(this.numericUpDownMaxY);
            this.groupBox2.Controls.Add(this.checkBoxMinMaxX);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numericUpDownX);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBoxMinMaxY);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numericUpDownMaxX);
            this.groupBox2.Controls.Add(this.numericUpDownMinX);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(7, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 259);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки графика";
            // 
            // checkBoxAxesInterval
            // 
            this.checkBoxAxesInterval.AutoSize = true;
            this.checkBoxAxesInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAxesInterval.Location = new System.Drawing.Point(4, 22);
            this.checkBoxAxesInterval.Name = "checkBoxAxesInterval";
            this.checkBoxAxesInterval.Size = new System.Drawing.Size(99, 20);
            this.checkBoxAxesInterval.TabIndex = 64;
            this.checkBoxAxesInterval.Text = "Интервал";
            this.checkBoxAxesInterval.UseVisualStyleBackColor = true;
            this.checkBoxAxesInterval.CheckedChanged += new System.EventHandler(this.checkBoxAxesInterval_CheckedChanged);
            // 
            // numericUpDownMinY
            // 
            this.numericUpDownMinY.DecimalPlaces = 3;
            this.numericUpDownMinY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMinY.Location = new System.Drawing.Point(69, 119);
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
            this.numericUpDownMinY.TabIndex = 54;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.DecimalPlaces = 3;
            this.numericUpDownY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownY.Location = new System.Drawing.Point(70, 71);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(108, 22);
            this.numericUpDownY.TabIndex = 51;
            // 
            // numericUpDownMaxY
            // 
            this.numericUpDownMaxY.DecimalPlaces = 3;
            this.numericUpDownMaxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMaxY.Location = new System.Drawing.Point(69, 147);
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
            this.numericUpDownMaxY.TabIndex = 55;
            // 
            // checkBoxMinMaxX
            // 
            this.checkBoxMinMaxX.AutoSize = true;
            this.checkBoxMinMaxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMinMaxX.Location = new System.Drawing.Point(4, 176);
            this.checkBoxMinMaxX.Name = "checkBoxMinMaxX";
            this.checkBoxMinMaxX.Size = new System.Drawing.Size(66, 20);
            this.checkBoxMinMaxX.TabIndex = 63;
            this.checkBoxMinMaxX.Text = "Ось X";
            this.checkBoxMinMaxX.UseVisualStyleBackColor = true;
            this.checkBoxMinMaxX.CheckedChanged += new System.EventHandler(this.checkBoxMinMaxX_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Мин.";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.DecimalPlaces = 3;
            this.numericUpDownX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownX.Location = new System.Drawing.Point(70, 43);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(108, 22);
            this.numericUpDownX.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(2, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ось Y";
            // 
            // checkBoxMinMaxY
            // 
            this.checkBoxMinMaxY.AutoSize = true;
            this.checkBoxMinMaxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMinMaxY.Location = new System.Drawing.Point(4, 98);
            this.checkBoxMinMaxY.Name = "checkBoxMinMaxY";
            this.checkBoxMinMaxY.Size = new System.Drawing.Size(67, 20);
            this.checkBoxMinMaxY.TabIndex = 62;
            this.checkBoxMinMaxY.Text = "Ось Y";
            this.checkBoxMinMaxY.UseVisualStyleBackColor = true;
            this.checkBoxMinMaxY.CheckedChanged += new System.EventHandler(this.checkBoxMinMaxY_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Макс.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "Макс.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(2, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Ось X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 60;
            this.label10.Text = "Мин.";
            // 
            // numericUpDownMaxX
            // 
            this.numericUpDownMaxX.DecimalPlaces = 3;
            this.numericUpDownMaxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMaxX.Location = new System.Drawing.Point(69, 229);
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
            this.numericUpDownMaxX.TabIndex = 59;
            // 
            // numericUpDownMinX
            // 
            this.numericUpDownMinX.DecimalPlaces = 3;
            this.numericUpDownMinX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMinX.Location = new System.Drawing.Point(69, 201);
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
            this.numericUpDownMinX.TabIndex = 58;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonChartColor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBoxChartSeries);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxChartSeriesName);
            this.groupBox3.Controls.Add(this.buttonClearSelectedSeries);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(1008, 460);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 74);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Переименовать / удалить";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Номер";
            // 
            // textBoxChartSeriesName
            // 
            this.textBoxChartSeriesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChartSeriesName.Location = new System.Drawing.Point(52, 45);
            this.textBoxChartSeriesName.Name = "textBoxChartSeriesName";
            this.textBoxChartSeriesName.Size = new System.Drawing.Size(240, 22);
            this.textBoxChartSeriesName.TabIndex = 31;
            this.textBoxChartSeriesName.TextChanged += new System.EventHandler(this.textBoxChartSeriesName_TextChanged);
            // 
            // buttonClearSelectedSeries
            // 
            this.buttonClearSelectedSeries.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonClearSelectedSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearSelectedSeries.Location = new System.Drawing.Point(298, 44);
            this.buttonClearSelectedSeries.Name = "buttonClearSelectedSeries";
            this.buttonClearSelectedSeries.Size = new System.Drawing.Size(24, 24);
            this.buttonClearSelectedSeries.TabIndex = 32;
            this.buttonClearSelectedSeries.Text = "X";
            this.buttonClearSelectedSeries.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClearSelectedSeries.UseVisualStyleBackColor = false;
            this.buttonClearSelectedSeries.Click += new System.EventHandler(this.buttonClearSelectedSeries_Click);
            // 
            // buttonChartColor
            // 
            this.buttonChartColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChartColor.Location = new System.Drawing.Point(327, 44);
            this.buttonChartColor.Name = "buttonChartColor";
            this.buttonChartColor.Size = new System.Drawing.Size(24, 24);
            this.buttonChartColor.TabIndex = 36;
            this.buttonChartColor.UseVisualStyleBackColor = true;
            this.buttonChartColor.Click += new System.EventHandler(this.buttonChartColor_Click);
            // 
            // FormReliefVisualisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1369, 693);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxTypeOfGraphic);
            this.Controls.Add(this.panelHydrograph);
            this.Controls.Add(this.buttonAddWaterLayer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxHigh);
            this.Controls.Add(this.pictureBoxRelief);
            this.Controls.Add(this.buttonAddControlPoints);
            this.Controls.Add(this.buttonControlPointsPath);
            this.Controls.Add(this.textBoxControlPointsPath);
            this.Controls.Add(this.buttonVisualizeRelief);
            this.Controls.Add(this.textBoxReliefPath);
            this.Controls.Add(this.buttonReliefPath);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelControlPoint);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReliefVisualisation";
            this.Text = "Визуализация рельефа";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormReliefVisualisation_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRelief)).EndInit();
            this.groupBoxHigh.ResumeLayout(false);
            this.groupBoxHigh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighMin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartForControlPoint)).EndInit();
            this.panelHydrograph.ResumeLayout(false);
            this.panelHydrograph.PerformLayout();
            this.groupBoxTypeOfGraphic.ResumeLayout(false);
            this.groupBoxTypeOfGraphic.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVisualizeRelief;
        private System.Windows.Forms.TextBox textBoxReliefPath;
        private System.Windows.Forms.Button buttonReliefPath;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button buttonAddControlPoints;
        private System.Windows.Forms.Button buttonControlPointsPath;
        private System.Windows.Forms.TextBox textBoxControlPointsPath;
        private System.Windows.Forms.PictureBox pictureBoxRelief;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.GroupBox groupBoxHigh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_multicolor;
        private System.Windows.Forms.RadioButton radioButton_gray;
        private System.Windows.Forms.Button buttonAddWaterLayer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartForControlPoint;
        private System.Windows.Forms.Button buttonCreateHydrograph;
        private System.Windows.Forms.Button buttonHydrographPath;
        private System.Windows.Forms.TextBox textBoxHydrographPath;
        private System.Windows.Forms.NumericUpDown numericUpDownHighMin;
        private System.Windows.Forms.NumericUpDown numericUpDownHighMax;
        private System.Windows.Forms.Panel panelHydrograph;
        private System.Windows.Forms.Label labelControlPoint;
        private System.Windows.Forms.Button buttonHydrographClear;
        private System.Windows.Forms.GroupBox groupBoxTypeOfGraphic;
        private System.Windows.Forms.RadioButton radioButtonHysteresis;
        private System.Windows.Forms.RadioButton radioButtonEtat;
        private System.Windows.Forms.RadioButton radioButtonQt;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateChartFromDB_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateChartFromFile_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProcessData_ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxAxesInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownMinY;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxY;
        private System.Windows.Forms.CheckBox checkBoxMinMaxX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxMinMaxY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxX;
        private System.Windows.Forms.NumericUpDown numericUpDownMinX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxChartSeries;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxChartSeriesName;
        private System.Windows.Forms.Button buttonClearSelectedSeries;
        private System.Windows.Forms.ToolStripMenuItem MapOfHydroposts_ToolStripMenuItem;
        private System.Windows.Forms.Button buttonChartColor;
    }
}

