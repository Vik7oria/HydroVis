using HydroVis;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReliefVisualisation
{
    public partial class FormChartFromFile : Form
    {
        ChartFromFile chartFromFile = new ChartFromFile();
        SetChartWithInterface setChart = new SetChartWithInterface();
        double minX, maxX, minY, maxY;
        double xInterval, yInterval;
        public FormChartFromFile()
        {
            InitializeComponent();
        }
        private void ButtonFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD1 = new OpenFileDialog();
            OD1.Title = "Выбор файла данных";
            OD1.Filter = "Файлы (*.dat) |*.dat| Все файлы (*.*)|*.*";
            OD1.FileName = "";
            if (OD1.ShowDialog() == DialogResult.OK)
            {
                textBoxFileQ.Text = OD1.FileName;
            }
        }

        private void ButtonMakeChart_Click(object sender, EventArgs e)
        {
            if (radioButtonHydrograph.Checked)
            {
                chartFromFile.MakeQtChart(chartFile, textBoxFileQ.Text);
            }
            else if(radioButtonWaterLevel.Checked)
            {
                if (radioButton_VB.Checked)
                    chartFromFile.MakeEtatChart(chartFile, textBoxFileQ.Text, true);
                else
                    chartFromFile.MakeEtatChart(chartFile, textBoxFileQ.Text, false);
            }
            else
            {
                if (radioButton_VB.Checked)
                    chartFromFile.MakeHysteresisChart(chartFile, textBoxFileQ.Text, true);
                else
                    chartFromFile.MakeHysteresisChart(chartFile, textBoxFileQ.Text, false);
            }
            
            minX = chartFile.ChartAreas[0].AxisX.Minimum;
            maxX = chartFile.ChartAreas[0].AxisX.Maximum;
            minY = chartFile.ChartAreas[0].AxisY.Minimum;
            maxY = chartFile.ChartAreas[0].AxisY.Maximum;
            xInterval = chartFile.ChartAreas[0].AxisX.Interval;
            yInterval = chartFile.ChartAreas[0].AxisY.Interval;

            comboBoxChartSeries.Items.Add(chartFile.Series.Count);
            comboBoxChartSeries.Text = chartFile.Series.Count.ToString();
            textBoxChartSeriesName.Text = chartFile.Series[chartFile.Series.Count-1].LegendText;
        }

        private void ButtonClearChart_Click(object sender, EventArgs e)
        {
            chartFromFile.ClearChart();
            comboBoxChartSeries.Items.Clear();
            textBoxChartSeriesName.Text = "";
            buttonChartColor.BackColor = Color.White;
        }

        private void ButtonSaveChart_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveAsDocument = new SaveFileDialog();
            saveAsDocument.Title = "Сохранить график как...";
            saveAsDocument.FileName = "График";
            saveAsDocument.Filter = "Файл png (*.png) |*.png| Все файлы (*.*)|*.*";

            if (saveAsDocument.ShowDialog() == DialogResult.OK)
            {
                chartFile.SaveImage(saveAsDocument.FileName, ChartImageFormat.Png);
            }
            else
            {
                return;
            }
        }

        private void textBoxChartSeriesName_TextChanged(object sender, EventArgs e)
        {
            setChart.RenameSeries(chartFile, comboBoxChartSeries, textBoxChartSeriesName);
        }

        private void comboBoxChartSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seriesNumber = Convert.ToInt32(comboBoxChartSeries.Text);
            textBoxChartSeriesName.Text = chartFile.Series[seriesNumber - 1].LegendText;
            buttonChartColor.BackColor = chartFile.Series[seriesNumber - 1].Color;
        }

        private void buttonClearSelectedSeries_Click(object sender, EventArgs e)
        {
            setChart.DeleteSeries(chartFile, comboBoxChartSeries, textBoxChartSeriesName, buttonChartColor, ref minX, ref maxX, ref minY, ref maxY);
        }

        private void buttonChartColor_Click(object sender, EventArgs e)
        {
            setChart.ChangeSeriesColor(chartFile, comboBoxChartSeries, buttonChartColor);
        }

        private void checkBoxMinMaxY_CheckedChanged(object sender, EventArgs e)
        {
            setChart.SetAxisYMinMax(chartFile, numericUpDownMaxY, numericUpDownMinY, minY, maxY, checkBoxMinMaxY);
        }

        private void checkBoxMinMaxX_CheckedChanged(object sender, EventArgs e)
        {
            setChart.SetAxisXMinMax(chartFile, numericUpDownMaxX, numericUpDownMinX, minX, maxX, checkBoxMinMaxX);
        }

        private void checkBoxAxesInterval_CheckedChanged(object sender, EventArgs e)
        {
            setChart.SetInterval(chartFile, numericUpDownX, numericUpDownY, xInterval, yInterval, checkBoxAxesInterval);
        }

        private void radioButtonHydrograph_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonHydrograph.Checked)
            {
                radioButton_VB.Enabled = false;
                radioButton_NB.Enabled = false;
            }
            else
            {
                radioButton_VB.Enabled = true;
                radioButton_NB.Enabled = true;
            }
        }
    }
}
