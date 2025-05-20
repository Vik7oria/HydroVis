using HydroVis;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReliefVisualisation
{
    public partial class FormReliefVisualisation : Form
    {
        ReliefVisualisation reliefVisualisation = new ReliefVisualisation();
        ReliefColorPallete reliefColorPallete = new ReliefColorPallete();
        ReliefColorPallete waterColorPallete = new ReliefColorPallete();
        bool resizeHydrograph = false;
        double minX = 1000000, maxX = -1000000, minY = 1000000, maxY = - 1000000, intervalX, intervalY;
        SetChartWithInterface setChart = new SetChartWithInterface();
        ChartFromFile hydroChart = new ChartFromFile();
        int previousSeriesCount = 0;

        public FormReliefVisualisation()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ButtonReliefPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.Title = "Выбор файла для рельефа";
            OD.Filter = "Файлы (*.grd) |*.grd| Все файлы (*.*)|*.*";
            OD.FileName = "";
            if (OD.ShowDialog() == DialogResult.OK)
            {
                textBoxReliefPath.Text = OD.FileName;
            }
        }

        private void ButtonVisualizeRelief_Click(object sender, EventArgs e)
        {          
            if (radioButton_gray.Checked)
            {
                reliefVisualisation.VisualizeRelief(pictureBoxRelief, textBoxReliefPath.Text, this, reliefColorPallete.Gray(), numericUpDownHighMin, numericUpDownHighMax);
            }
            else
            {
                reliefVisualisation.VisualizeRelief(pictureBoxRelief, textBoxReliefPath.Text, this, reliefColorPallete.Multicolor(), numericUpDownHighMin, numericUpDownHighMax);
            }
        }

        private void ButtonControlPointsPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD1 = new OpenFileDialog();
            OD1.Title = "Выбор файла для контрольных точек";
            OD1.Filter = "Файлы (*.dat) |*.dat| Все файлы (*.*)|*.*";
            OD1.FileName = "";
            if (OD1.ShowDialog() == DialogResult.OK)
            {
                textBoxControlPointsPath.Text = OD1.FileName;
            }
        }

        private void ButtonAddControlPoints_Click(object sender, EventArgs e)
        {
            reliefVisualisation.AddControlPoints(pictureBoxRelief, textBoxControlPointsPath.Text);
        }

        private void PictureBoxRelief_MouseClick(object sender, MouseEventArgs e)
        {
            string chartType;
            if (radioButtonEtat.Checked)
            {
                chartType = "Etat";
            }
            else if (radioButtonQt.Checked)
            {
                chartType = "Qt";
            }
            else
            {
                chartType = "Hysteresis";
            }
            reliefVisualisation.SelectControlPoint(pictureBoxRelief, e.X, e.Y, labelControlPoint, chartForControlPoint, chartType);

            minX = chartForControlPoint.ChartAreas[0].AxisX.Minimum;
            maxX = chartForControlPoint.ChartAreas[0].AxisX.Maximum;
            minY = chartForControlPoint.ChartAreas[0].AxisY.Minimum;
            maxY = chartForControlPoint.ChartAreas[0].AxisY.Maximum;
            intervalX = chartForControlPoint.ChartAreas[0].AxisX.Interval;
            intervalY = chartForControlPoint.ChartAreas[0].AxisY.Interval;

            if (previousSeriesCount != chartForControlPoint.Series.Count)
            {
                comboBoxChartSeries.Items.Add(chartForControlPoint.Series.Count);
                comboBoxChartSeries.Text = chartForControlPoint.Series.Count.ToString();
                textBoxChartSeriesName.Text = chartForControlPoint.Series[chartForControlPoint.Series.Count - 1].LegendText;
            }
            previousSeriesCount = chartForControlPoint.Series.Count;
        }

        private void CreateChartFromDB_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChartFromDB chartFromDB = new FormChartFromDB();
            chartFromDB.Show();
        }

        private void CreateChartFromFile_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChartFromFile chartFromFile = new FormChartFromFile();
            chartFromFile.Show();
        }

        private void ProcessData_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcessData formProcessData = new FormProcessData();
            formProcessData.Show();
        }

        private void MapOfHydroposts_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMapOfHydroposts formMap = new FormMapOfHydroposts();
            formMap.Show();
        }

        private void ButtonAddWaterLayer_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.Title = "Выбор файла для слоя воды";
            OD.Filter = "Файлы (*.grd) |*.grd| Все файлы (*.*)|*.*";
            OD.FileName = "";

            try 
            {
                if (OD.ShowDialog() == DialogResult.OK)
                {
                    reliefVisualisation.AddWaterLayer(pictureBoxRelief, OD.FileName, this, waterColorPallete.Water());
                }
            }
            catch
            {
                MessageBox.Show("Не удаётся добавить указанный слой воды.");
                return;
            }
        }

        private void ButtonHydrographPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.Title = "Выбор файла для гидрографа";
            OD.Filter = "Файлы (*.dat) |*.dat| Все файлы (*.*)|*.*";
            OD.FileName = "";
            if (OD.ShowDialog() == DialogResult.OK)
            {
                textBoxHydrographPath.Text = OD.FileName;
            }
        }

        private void ButtonCreateHydrograph_Click(object sender, EventArgs e)
        {
            hydroChart.MakeModelingHydrographChart(chartForControlPoint, textBoxHydrographPath.Text);
            comboBoxChartSeries.Items.Add(chartForControlPoint.Series.Count);
            comboBoxChartSeries.Text = chartForControlPoint.Series.Count.ToString();
            textBoxChartSeriesName.Text = chartForControlPoint.Series[chartForControlPoint.Series.Count - 1].LegendText;
        }

        private void radioButton_gray_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_gray.Checked)
            {
                reliefVisualisation.VisualizeRelief(pictureBoxRelief, textBoxReliefPath.Text, this, reliefColorPallete.Gray(), numericUpDownHighMin, numericUpDownHighMax);
            }
            else
            {
                reliefVisualisation.VisualizeRelief(pictureBoxRelief, textBoxReliefPath.Text, this, reliefColorPallete.Multicolor(), numericUpDownHighMin, numericUpDownHighMax);
            }
        }

        private void buttonHydrographClear_Click(object sender, EventArgs e)
        {
            comboBoxChartSeries.Items.Clear();
            textBoxChartSeriesName.Text = "";
            buttonChartColor.BackColor = Color.White;
            try
            {
                reliefVisualisation.ClearChartForControlPoint();
            }
            catch
            {
                hydroChart.ClearChart();
                return;
            }
        }

        private void panelHydrograph_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X >= 0 && e.X <= 10 && e.Y <= panelHydrograph.Height && e.Y >= panelHydrograph.Height - 10)
            {
                resizeHydrograph = true;
            }
        }

        private void panelHydrograph_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= 0 && e.X <= 10 && e.Y <= panelHydrograph.Height && e.Y >= panelHydrograph.Height - 10)
            {
                this.Cursor = Cursors.SizeNESW;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }

            if (resizeHydrograph)
            {
                panelHydrograph.Left = MousePosition.X;
                panelHydrograph.Width = panelHydrograph.Parent.Width - panelHydrograph.Left - 20;
                panelHydrograph.Height = MousePosition.Y - panelHydrograph.Location.Y;
            }
        }

        private void panelHydrograph_MouseUp(object sender, MouseEventArgs e)
        {
            resizeHydrograph = false;
        }

        private void comboBoxChartSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seriesNumber = Convert.ToInt32(comboBoxChartSeries.Text);
            textBoxChartSeriesName.Text = chartForControlPoint.Series[seriesNumber - 1].LegendText;
            buttonChartColor.BackColor = chartForControlPoint.Series[seriesNumber - 1].Color;
        }

        private void textBoxChartSeriesName_TextChanged(object sender, EventArgs e)
        {
            setChart.RenameSeries(chartForControlPoint, comboBoxChartSeries, textBoxChartSeriesName);
        }

        private void buttonClearSelectedSeries_Click(object sender, EventArgs e)
        {
            setChart.DeleteSeries(chartForControlPoint, comboBoxChartSeries, textBoxChartSeriesName, buttonChartColor, ref minX, ref maxX, ref minY, ref maxY);  
        }

        private void buttonChartColor_Click(object sender, EventArgs e)
        {
            setChart.ChangeSeriesColor(chartForControlPoint, comboBoxChartSeries, buttonChartColor);
        }

        private void FormReliefVisualisation_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveAsDocument = new SaveFileDialog();
            saveAsDocument.Title = "Сохранить график как...";
            saveAsDocument.FileName = "График";
            saveAsDocument.Filter = "Файл png (*.png) |*.png| Все файлы (*.*)|*.*";

            if (saveAsDocument.ShowDialog() == DialogResult.OK)
            {
                chartForControlPoint.SaveImage(saveAsDocument.FileName, ChartImageFormat.Png);
            }
            else
            {
                return;
            }
        }

        private void checkBoxAxesInterval_CheckedChanged(object sender, EventArgs e)
        {
            setChart.SetInterval(chartForControlPoint, numericUpDownX, numericUpDownY, intervalX, intervalY, checkBoxAxesInterval);
        }

        private void checkBoxMinMaxY_CheckedChanged(object sender, EventArgs e)
        {
            setChart.SetAxisYMinMax(chartForControlPoint, numericUpDownMaxY, numericUpDownMinY, minY, maxY, checkBoxMinMaxY);
        }

        private void checkBoxMinMaxX_CheckedChanged(object sender, EventArgs e)
        {
            setChart.SetAxisXMinMax(chartForControlPoint, numericUpDownMaxX, numericUpDownMinX, minX, maxX, checkBoxMinMaxX);
        }
    }
}
