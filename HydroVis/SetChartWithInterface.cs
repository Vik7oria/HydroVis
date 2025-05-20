using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HydroVis
{
    internal class SetChartWithInterface
    {
        public void SetInterval(Chart chart, NumericUpDown numericUpDownIntervalX, NumericUpDown numericUpDownIntervalY, double defaultIntervalX, double defaultIntervalY, CheckBox checkBoxAxesInterval)
        {
            if (!checkBoxAxesInterval.Checked)
            {
                chart.ChartAreas[0].AxisX.Interval = defaultIntervalX;
                chart.ChartAreas[0].AxisY.Interval = defaultIntervalY;
                return;
            }

            if (numericUpDownIntervalX.Value != 0)
            {
                chart.ChartAreas[0].AxisX.Interval = Convert.ToDouble(numericUpDownIntervalX.Value);
            }

            if (numericUpDownIntervalY.Value != 0)
            {
                chart.ChartAreas[0].AxisY.Interval = Convert.ToDouble(numericUpDownIntervalY.Value);
            }
        }

        public void SetAxisXMinMax(Chart chart, NumericUpDown numericUpDownMaxX, NumericUpDown numericUpDownMinX, double defaultMinX, double defaultMaxX, CheckBox checkBoxAxisXMinMax)
        {
            if (!checkBoxAxisXMinMax.Checked)
            {
                chart.ChartAreas[0].AxisX.Minimum = defaultMinX;
                chart.ChartAreas[0].AxisX.Maximum = defaultMaxX;
                return;
            }

            if (numericUpDownMaxX.Value > numericUpDownMinX.Value)
            {
                chart.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(numericUpDownMinX.Value);
                chart.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(numericUpDownMaxX.Value);
            }
        }

        public void SetAxisYMinMax(Chart chart, NumericUpDown numericUpDownMaxY, NumericUpDown numericUpDownMinY, double defaultMinY, double defaultMaxY, CheckBox checkBoxAxisYMinMax)
        {
            if (!checkBoxAxisYMinMax.Checked)
            {
                chart.ChartAreas[0].AxisY.Minimum = defaultMinY;
                chart.ChartAreas[0].AxisY.Maximum = defaultMaxY;
                return;
            }

            if (numericUpDownMaxY.Value > numericUpDownMinY.Value)
            {
                chart.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(numericUpDownMinY.Value);
                chart.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(numericUpDownMaxY.Value);
            }
        }

        public void DeleteSeries(Chart chartFromDataBase, ComboBox comboBoxChartSeries, TextBox textBoxChartSeriesName, Button buttonChartColor, ref double minX, ref double maxX, ref double minY, ref double maxY)
        {
            if (comboBoxChartSeries.Text != "")
            {
                int selectedSeries = comboBoxChartSeries.SelectedIndex;
                chartFromDataBase.Series.Remove(chartFromDataBase.Series[Convert.ToInt32(comboBoxChartSeries.Text) - 1]);
                comboBoxChartSeries.Items.Remove(comboBoxChartSeries.SelectedItem);

                for (int i = selectedSeries; i < comboBoxChartSeries.Items.Count; i++)
                {
                    comboBoxChartSeries.Items[i] = Convert.ToInt32(comboBoxChartSeries.Items[i]) - 1;
                }

                if (chartFromDataBase.Series.Count() != 0)
                {
                    comboBoxChartSeries.Text = chartFromDataBase.Series.Count().ToString();
                    textBoxChartSeriesName.Text = chartFromDataBase.Series[Convert.ToInt32(comboBoxChartSeries.Text) - 1].LegendText;
                }
                else
                {
                    minY = 1000000;
                    minX = 1000000;
                    maxX = -1000000;
                    maxY = -1000000;
                    textBoxChartSeriesName.Text = "";
                    buttonChartColor.BackColor = Color.White;
                }
            }
        }

        public void ChangeSeriesColor(Chart chartFromDataBase, ComboBox comboBoxChartSeries, Button buttonChartColor)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            if (comboBoxChartSeries.Text != "")
            {
                chartFromDataBase.Series[Convert.ToInt32(comboBoxChartSeries.Text) - 1].Color = colorDialog.Color;
                buttonChartColor.BackColor = colorDialog.Color;
            }
        }

        public void RenameSeries(Chart chart, ComboBox comboBoxChartSeries, TextBox textBoxChartSeriesName)
        {
            if (comboBoxChartSeries.Text != "")
            {
                int seriesNumber = Convert.ToInt32(comboBoxChartSeries.Text);
                chart.Series[seriesNumber - 1].LegendText = textBoxChartSeriesName.Text;
            }
        }

    }
}
