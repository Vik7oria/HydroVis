using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using HydroVis;
using MySql.Data.MySqlClient;

namespace ReliefVisualisation
{
    public partial class FormChartFromDB : Form
    {
        SetChartWithInterface setChart = new SetChartWithInterface();
        MySqlConnection connection = null;
        Color treeViewColor = Color.White;
        double minX = 1000000, minY = 1000000, maxX = -1000000, maxY = -1000000;
        double intervalX, intervalY;
        WorkWithDataBase dataBase = new WorkWithDataBase();
        public FormChartFromDB()
        {
            InitializeComponent();
            dateTimePicker2.MaxDate = DateTime.Now;
            if (dataBase.ConnectToDB(ref connection) == 0)
            {
                dataBase.MakeHydropostsList(connection, treeViewHydroposts);
                buttonMakeCraphic.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ошибка подключения к базе данных.");
            }
        }

        private void ButtonMakeChart_Click(object sender, EventArgs e)
        {
            dataBase.MakeChartFromDB(chartFromDataBase, comboBoxChartSeries, connection, treeViewHydroposts,
                                     dateTimePicker, dateTimePicker2, radioButtonHydrograph, radioButtonWaterLevel,
                                     radioButtonHysteresis, textBoxChartSeriesName);

            minX = chartFromDataBase.ChartAreas[0].AxisX.Minimum;
            maxX = chartFromDataBase.ChartAreas[0].AxisX.Maximum;
            minY = chartFromDataBase.ChartAreas[0].AxisY.Minimum;
            maxY = chartFromDataBase.ChartAreas[0].AxisY.Maximum;
            intervalX = chartFromDataBase.ChartAreas[0].AxisX.Interval;
            intervalY = chartFromDataBase.ChartAreas[0].AxisY.Interval;
        }

        private void checkBoxMinMaxY_CheckedChanged(object sender, EventArgs e)
        {
            setChart.SetAxisYMinMax(chartFromDataBase, numericUpDownMaxY, numericUpDownMinY, minY, maxY, checkBoxMinMaxY);
        }

        private void checkBoxMinMaxX_CheckedChanged(object sender, EventArgs e)
        {
            setChart.SetAxisXMinMax(chartFromDataBase, numericUpDownMaxX, numericUpDownMinX, minX, maxX, checkBoxMinMaxX);
        }

        private void checkBoxAxesInterval_CheckedChanged(object sender, EventArgs e)
        {
            setChart.SetInterval(chartFromDataBase, numericUpDownX, numericUpDownY, intervalX, intervalY, checkBoxAxesInterval);
        }

        private void buttonSeriesColor_Click(object sender, EventArgs e)
        {
            setChart.ChangeSeriesColor(chartFromDataBase, comboBoxChartSeries, buttonChartColor);
        }

        private void ButtonSaveChart_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveAsDocument = new SaveFileDialog();
            saveAsDocument.Title = "Сохранить документ как...";
            saveAsDocument.FileName = "График";
            saveAsDocument.Filter = "Файл png (*.png) |*.png| Все файлы (*.*)|*.*";

            if (saveAsDocument.ShowDialog() == DialogResult.OK)
            {
                chartFromDataBase.SaveImage(saveAsDocument.FileName, ChartImageFormat.Png);
            }
            else
            {
                return;
            }
        }

        private void textBoxChartSeriesName_TextChanged(object sender, EventArgs e)
        {
            setChart.RenameSeries(chartFromDataBase, comboBoxChartSeries, textBoxChartSeriesName);   
        }

        private void comboBoxChartSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seriesNumber = Convert.ToInt32(comboBoxChartSeries.Text);
            textBoxChartSeriesName.Text = chartFromDataBase.Series[seriesNumber - 1].LegendText;
            buttonChartColor.BackColor = chartFromDataBase.Series[seriesNumber - 1].Color;
        }

        private void ButtonClearSelectedSeries_Click(object sender, EventArgs e)
        {
            setChart.DeleteSeries(chartFromDataBase, comboBoxChartSeries, textBoxChartSeriesName, buttonChartColor, ref minX, ref maxX, ref minY, ref maxY);
        }

        private void ButtonClearChart_Click(object sender, EventArgs e)
        {
            dataBase.ClearChartFromDB(chartFromDataBase, comboBoxChartSeries, textBoxChartSeriesName, buttonChartColor);
        }

        private void TreeViewHydroposts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            labelTreePath.Text = treeViewHydroposts.SelectedNode.Parent != null ?
                                 treeViewHydroposts.SelectedNode.Parent.Text + "    >    " + treeViewHydroposts.SelectedNode.Text :
                                 treeViewHydroposts.SelectedNode.Text;
            treeViewHydroposts.SelectedNode.BackColor = Color.PaleTurquoise;
        }

        private void TreeViewHydroposts_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (treeViewHydroposts.SelectedNode != null && treeViewHydroposts.SelectedNode.BackColor != treeViewColor)
                treeViewHydroposts.SelectedNode.BackColor = treeViewColor;
        }
    }
}
