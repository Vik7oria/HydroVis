using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace HydroVis
{
    internal class WorkWithDataBase
    {
        string connectionString = "datasource=127.0.0.1; port=3306;username=root;password=;database=гидродинамические_данные;";
        int child_id = 0, parent_id = 0, uniqueSeriesNumber = 0;
        Dictionary<string, int> currentNodeId = new Dictionary<string, int>();
        MySqlCommand command = new MySqlCommand();
        double minX = 1000000, minY = 1000000, maxX = -1000000, maxY = -1000000;
        double intervalX, intervalY;

        public int ConnectToDB(ref MySqlConnection connection)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open(); ;
            }
            catch
            {
                return -1;
            }

            return 0;
        }

        public void MakeHydropostsList(MySqlConnection connection, TreeView treeViewHydroposts)
        {
            command.Connection = connection;
            command.CommandText = "SELECT id_гидроузла, Источник FROM Гидроузел WHERE Уровень = 0;";

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var hydropost_id = reader.GetValue(0);
                        var source = reader.GetValue(1);
                        treeViewHydroposts.Nodes.Add(source.ToString());
                        currentNodeId.Add(parent_id.ToString() + "p", Convert.ToInt32(reader.GetValue(0)));
                        parent_id++;
                    }
                }
            }

            foreach (TreeNode node in treeViewHydroposts.Nodes)
            {
                string hydropost_id = currentNodeId[node.Index.ToString() + "p"].ToString();

                MySqlDataReader reader_nodes;
                command.CommandText = $"SELECT Гидроузел.id_гидроузла, Гидроузел.Источник, Гидроузел.населённый_пункт" +
                                      $" FROM Гидроузел, Связь_гидроузлов" +
                                      $" WHERE Гидроузел.id_гидроузла = Связь_гидроузлов.id_промежуточного_гидроузла and" +
                                      $" Связь_гидроузлов.id_гидроузла = {hydropost_id};";
                reader_nodes = command.ExecuteReader();
                if (reader_nodes.HasRows)
                {
                    while (reader_nodes.Read())
                    {
                        var cur_hydropost_id = reader_nodes.GetValue(0);
                        var source = reader_nodes.GetValue(1);
                        var locality = reader_nodes.GetValue(2);
                        node.Nodes.Add(source.ToString() + " " + locality.ToString());

                        currentNodeId.Add(node.Index.ToString() + child_id.ToString(), Convert.ToInt32(reader_nodes.GetValue(0)));
                        child_id++;
                    }
                }
                reader_nodes.Close();
                child_id = 0;
            }
        }

        public void MakeChartFromDB(Chart chartFromDataBase, ComboBox comboBoxChartSeries, MySqlConnection connection, TreeView treeViewHydroposts,
                                    DateTimePicker dateTimePicker, DateTimePicker dateTimePicker2, RadioButton radioButtonHydrograph,
                                    RadioButton radioButtonWaterLevel, RadioButton radioButtonHysteresis, TextBox textBoxChartSeriesName)
        {
            chartFromDataBase.Series.Add($"Series{uniqueSeriesNumber += 1}");
            int series_count = chartFromDataBase.Series.Count();
            chartFromDataBase.Series[series_count - 1].ChartType = SeriesChartType.Line;
            comboBoxChartSeries.Items.Add(series_count);
            comboBoxChartSeries.Text = series_count.ToString();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;

            string hydropost = treeViewHydroposts.SelectedNode.Text;
            string hydropost_id;
            string message = "Нет данных";
            string month, day;

            if (treeViewHydroposts.SelectedNode.Parent != null)
            {
                string id_parent = treeViewHydroposts.SelectedNode.Parent.Index.ToString();
                string id_child = treeViewHydroposts.SelectedNode.Index.ToString();
                hydropost_id = currentNodeId[id_parent + id_child].ToString();
            }
            else
            {
                string id_parent = treeViewHydroposts.SelectedNode.Index.ToString();
                hydropost_id = currentNodeId[id_parent + "p"].ToString();
            }

            if (dateTimePicker.Value.Month < 10)
                month = "0" + dateTimePicker.Value.Month.ToString();
            else
                month = dateTimePicker.Value.Month.ToString();

            if (dateTimePicker.Value.Day < 10)
                day = "0" + dateTimePicker.Value.Day.ToString();
            else
                day = dateTimePicker.Value.Day.ToString();

            string date_start = dateTimePicker.Value.Year.ToString() + "-" +
                          month + "-" + day;

            if (dateTimePicker2.Value.Month < 10)
                month = "0" + dateTimePicker2.Value.Month.ToString();
            else
                month = dateTimePicker2.Value.Month.ToString();

            if (dateTimePicker2.Value.Day < 10)
                day = "0" + dateTimePicker2.Value.Day.ToString();
            else
                day = dateTimePicker2.Value.Day.ToString();

            string date_end = dateTimePicker2.Value.Year.ToString() + "-" +
                          month + "-" + day;

            if (radioButtonHydrograph.Checked)
            {
                chartFromDataBase.ChartAreas[0].AxisX.Title = "Время, t, дни";
                chartFromDataBase.ChartAreas[0].AxisY.Title = "Расходы воды, Q, м³/с";
                command.CommandText = $"SELECT Q FROM Вода WHERE id_гидроузла = {hydropost_id} and" +
                                      $" DATE_FORMAT(Дата,'%Y-%m-%d') >= \"{date_start}\" and" +
                                      $" DATE_FORMAT(Дата,'%Y-%m-%d') <= \"{date_end}\";";
                message = "Нет данных о расходе воды за указанный период времени для выбранного гидроузла";
            }
            else if (radioButtonWaterLevel.Checked)
            {
                chartFromDataBase.ChartAreas[0].AxisX.Title = "Время, t, дни";
                chartFromDataBase.ChartAreas[0].AxisY.Title = "Уровень воды, \u03B7, м";
                command.CommandText = $"SELECT Eta_NB FROM Вода WHERE id_гидроузла = {hydropost_id} and" +
                                      $" DATE_FORMAT(Дата,'%Y-%m-%d') >= \"{date_start}\" and" +
                                      $" DATE_FORMAT(Дата,'%Y-%m-%d') <= \"{date_end}\";";
                message = "Нет данных об уровне воды за указанный период времени для выбранного гидроузла";
            }
            else if (radioButtonHysteresis.Checked)
            {
                chartFromDataBase.ChartAreas[0].AxisX.Title = "Расход воды, Q, м³/c";
                chartFromDataBase.ChartAreas[0].AxisY.Title = "Уровень воды, \u03B7, м";
                command.CommandText = $"SELECT Q, Eta_NB FROM Вода WHERE id_гидроузла = {hydropost_id} and" +
                                      $" DATE_FORMAT(Дата, '%Y-%m-%d') >= \"{date_start}\" and" +
                                      $" DATE_FORMAT(Дата, '%Y-%m-%d') <= \"{date_end}\";";
                message = "Нет данных о расходе и/или уровне воды за указанный период времени для выбранного гидроузла";
            }

            MySqlDataReader reader = command.ExecuteReader();
            int i = 0, null_count = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var parameter_value = reader.GetValue(0);
                    if (reader.FieldCount > 1)
                    {
                        var parameter2_value = reader.GetValue(1);
                        if (parameter_value.ToString() != "" && parameter2_value.ToString() != "")
                        {
                            chartFromDataBase.Series[series_count - 1].Points.AddXY(Convert.ToDouble(parameter_value.ToString()), Convert.ToDouble(parameter2_value.ToString()));
                            if (Convert.ToDouble(parameter2_value.ToString()) < minY)
                            {
                                minY = Convert.ToDouble(parameter2_value.ToString());
                            }

                            if (Convert.ToDouble(parameter_value.ToString()) < minX)
                            {
                                minX = Convert.ToDouble(parameter_value.ToString());
                            }

                            if (Convert.ToDouble(parameter2_value.ToString()) > maxY)
                            {
                                maxY = Convert.ToDouble(parameter2_value.ToString());
                            }

                            if (Convert.ToDouble(parameter_value.ToString()) > maxX)
                            {
                                maxX = Convert.ToDouble(parameter_value.ToString());
                            }
                        }
                        else
                        {
                            null_count++;
                        }
                    }
                    else
                    {
                        if (parameter_value.ToString() != "")
                        {
                            chartFromDataBase.Series[series_count - 1].Points.AddXY(i, Convert.ToDouble(parameter_value.ToString()));
                            if (Convert.ToDouble(parameter_value.ToString()) < minY)
                            {
                                minY = Convert.ToDouble(parameter_value.ToString());
                            }

                            if (Convert.ToDouble(parameter_value.ToString()) > maxY)
                            {
                                maxY = Convert.ToDouble(parameter_value.ToString());
                            }

                            minX = 0;
                            if ((dateTimePicker2.Value - dateTimePicker.Value).TotalDays > maxX)
                            {
                                maxX = (dateTimePicker2.Value - dateTimePicker.Value).TotalDays;
                            }
                        }
                        else
                        {
                            null_count++;
                        }
                    }

                    i++;
                }
            }
            else
            {
                MessageBox.Show(message);
            }

            if (null_count == i)
            {
                MessageBox.Show(message);
                chartFromDataBase.Series.Remove(chartFromDataBase.Series[series_count - 1]);
                comboBoxChartSeries.Items.Remove(series_count);
                comboBoxChartSeries.Text = chartFromDataBase.Series.Count().ToString();
                series_count -= 1;
            }
            else
            {
                chartFromDataBase.ChartAreas[0].AxisY.Minimum = minY;
                chartFromDataBase.ChartAreas[0].AxisY.Maximum = maxY;

                chartFromDataBase.ChartAreas[0].AxisX.Minimum = minX;
                chartFromDataBase.ChartAreas[0].AxisX.Maximum = maxX;

                intervalX = Math.Round((maxX - minX) / 12, 0);
                intervalY = Math.Round((maxY - minY) / 12, 0);

                if (intervalX == 0)
                    intervalX = 1;
                if (intervalY == 0)
                    intervalY = 1;

                chartFromDataBase.ChartAreas[0].AxisX.Interval = intervalX;
                chartFromDataBase.ChartAreas[0].AxisY.Interval = intervalY;

                string Year;
                if (dateTimePicker.Value.Year == dateTimePicker2.Value.Year)
                    Year = dateTimePicker.Value.Year.ToString();
                else
                    Year = dateTimePicker.Value.Year.ToString() + "-" + dateTimePicker2.Value.Year.ToString();

                chartFromDataBase.Series[series_count - 1].LegendText = hydropost + " " + Year;
                chartFromDataBase.Series[series_count - 1].BorderWidth = 2;
            }
            reader.Close();

            if (series_count != 0)
            {
                textBoxChartSeriesName.Text = chartFromDataBase.Series[series_count - 1].LegendText;
            }
        }

        public void ClearChartFromDB(Chart chartFromDataBase, ComboBox comboBoxChartSeries, TextBox textBoxChartSeriesName, Button buttonChartColor)
        {
            chartFromDataBase.Series.Clear();
            comboBoxChartSeries.Items.Clear();
            textBoxChartSeriesName.Text = "";
            buttonChartColor.BackColor = Color.White;
            minY = 1000000;
            minX = 1000000;
            maxX = -1000000;
            maxY = -1000000;
        }
    }
}
