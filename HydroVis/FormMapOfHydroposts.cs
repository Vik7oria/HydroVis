using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace HydroVis
{
    public partial class FormMapOfHydroposts : Form
    {
        Bitmap bmpMap = new Bitmap("Карта_гидроузлов.png");
        MySqlConnection connection = null;
        const int numHydroposts = 7;
        Point[] hydropostPoint = new Point[numHydroposts];
        Color[] hydropostColor = new Color[numHydroposts];
        string hydropost_name = "";
        int pointSize = 4;
        int series_count = 0;
        double minXEta = 1000000, minYEta = 1000000, maxXEta = -1000000, maxYEta = -1000000;
        double minXQ = 1000000, minYQ = 1000000, maxXQ = -1000000, maxYQ = -1000000;
        double intervalX, intervalY;
        WorkWithDataBase dataBase = new WorkWithDataBase();

        public FormMapOfHydroposts()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            pictureBoxMap.SizeMode = PictureBoxSizeMode.AutoSize;
            dateTimePicker2.MaxDate = DateTime.Now;
            MakeHydropostsPoints();

            if (dataBase.ConnectToDB(ref connection) == 0)
            {
               pictureBoxMap.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ошибка подключения к базе данных.");
            }
        }

        private void MakeHydropostsPoints()
        {
            hydropostPoint[0] = new Point(179, 172);
            hydropostPoint[1] = new Point(224, 108);
            hydropostPoint[2] = new Point(344, 177);
            hydropostPoint[3] = new Point(451, 201);
            hydropostPoint[4] = new Point(505, 324);
            hydropostPoint[5] = new Point(459, 384);
            hydropostPoint[6] = new Point(378, 518);

            hydropostColor[0] = Color.DarkBlue;
            hydropostColor[1] = Color.Brown;
            hydropostColor[2] = Color.DarkOrange;
            hydropostColor[3] = Color.Purple;
            hydropostColor[4] = Color.Red;
            hydropostColor[5] = Color.Black;
            hydropostColor[6] = Color.Green;

            for (int l = -pointSize - 1; l <= pointSize + 1; l++)
            {
                for (int m = -pointSize - 1; m <= pointSize + 1; m++)
                {
                    for (int i = 0; i < numHydroposts; i++)
                    {
                        bmpMap.SetPixel(hydropostPoint[i].X - l, hydropostPoint[i].Y - m, Color.White);
                    }
                }
            }

            for (int l = -pointSize; l <= pointSize; l++)
            {
                for (int m = -pointSize; m <= pointSize; m++)
                {
                    for (int i = 0; i < numHydroposts; i++)
                    {
                        bmpMap.SetPixel(hydropostPoint[i].X - l, hydropostPoint[i].Y - m, hydropostColor[i]);
                    }
                }
            }

            pictureBoxMap.Image = bmpMap;
        }

        private int GetSelectedPointIndex(MouseEventArgs e)
        {
            for (int l = -pointSize; l <= pointSize; l++)
            {
                for (int m = -pointSize; m <= pointSize; m++)
                {
                    for (int i = 0; i < numHydroposts; i++)
                    {
                        if (e.X == hydropostPoint[i].X - l && e.Y == hydropostPoint[i].Y - m)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }

        private void PictureBoxMap_MouseClick(object sender, MouseEventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            string month, day;
            int hydropost = GetSelectedPointIndex(e), i_day = 0, null_count_Eta = 0, null_count_Q = 0;
            string message = "Нет данных для выбранного гидроузла за указанный период";
            chartQt.ChartAreas[0].AxisX.Title = "Время, t, дни";
            chartQt.ChartAreas[0].AxisY.Title = "Расходы воды, Q, м³/с";
            chartEtat.ChartAreas[0].AxisX.Title = "Время, t, дни";
            chartEtat.ChartAreas[0].AxisY.Title = "Уровень воды, \u03B7, м";

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

            if (hydropost != -1)
            {
                switch (hydropost)
                {
                    case 0:
                        hydropost = 9;
                        hydropost_name = "вдхр. Иваньковское, г. Дубна";
                        break;
                    case 1:
                        hydropost = 28;
                        hydropost_name = "вдхр. Рыбинское, г. Рыбинск";
                        break;
                    case 2:
                        hydropost = 73;
                        hydropost_name = "вдхр. Горьковское, р-н Городецкий";
                        break;
                    case 3:
                        hydropost = 115;
                        hydropost_name = "вдхр. Чебоксарское, г. Новочебоксарск";
                        break;
                    case 4:
                        hydropost = 129;
                        hydropost_name = "вдхр. Куйбышевское, г. Жигулёвск";
                        break;
                    case 5:
                        hydropost = 142;
                        hydropost_name = "вдхр. Саратовское, г. Балаково";
                        break;
                    case 6:
                        hydropost = 152;
                        hydropost_name = "вдхр. Волгоградское, Волгоградская обл.";
                        break;
                }

                command.CommandText = $"SELECT Eta_NB, Q FROM Вода WHERE id_гидроузла = {hydropost} and" +
                                      $" DATE_FORMAT(Дата,'%Y-%m-%d') >= \"{date_start}\" and" +
                                      $" DATE_FORMAT(Дата,'%Y-%m-%d') <= \"{date_end}\";";

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    series_count = chartEtat.Series.Count();
                    series_count += 1;
                    chartEtat.Series.Add($"Series{series_count}");
                    chartEtat.Series[series_count - 1].ChartType = SeriesChartType.Line;
                    chartEtat.Series[series_count - 1].BorderWidth = 2;
                    chartEtat.Series[series_count - 1].Color = hydropostColor[GetSelectedPointIndex(e)];

                    chartQt.Series.Add($"Series{series_count}");
                    chartQt.Series[series_count - 1].ChartType = SeriesChartType.Line;
                    chartQt.Series[series_count - 1].BorderWidth = 2;
                    chartQt.Series[series_count - 1].Color = hydropostColor[GetSelectedPointIndex(e)];

                    while (reader.Read())
                    {
                        var Eta = reader.GetValue(0);
                        var Q = reader.GetValue(1);
                        if (Eta.ToString() != "")
                        {
                            chartEtat.Series[series_count - 1].Points.AddXY(i_day, Convert.ToDouble(Eta.ToString()));
                            
                            if (Convert.ToDouble(Eta.ToString()) < minYEta)
                            {
                                minYEta = Convert.ToDouble(Eta.ToString());
                            }

                            if (Convert.ToDouble(Eta.ToString()) > maxYEta)
                            {
                                maxYEta = Convert.ToDouble(Eta.ToString());
                            }

                            minXEta = 0;
                            if ((dateTimePicker2.Value - dateTimePicker.Value).TotalDays > maxXEta)
                            {
                                maxXEta = (dateTimePicker2.Value - dateTimePicker.Value).TotalDays;
                            }
                        }
                        else
                        {
                            null_count_Eta++;
                        }

                        if (Q.ToString() != "")
                        {
                            chartQt.Series[series_count - 1].Points.AddXY(i_day, Convert.ToDouble(Q.ToString()));
                            if (Convert.ToDouble(Q.ToString()) < minYQ)
                            {
                                minYQ = Convert.ToDouble(Q.ToString());
                            }

                            if (Convert.ToDouble(Q.ToString()) > maxYQ)
                            {
                                maxYQ = Convert.ToDouble(Q.ToString());
                            }

                            minXQ = 0;
                            if ((dateTimePicker2.Value - dateTimePicker.Value).TotalDays > maxXQ)
                            {
                                maxXQ = (dateTimePicker2.Value - dateTimePicker.Value).TotalDays;
                            }
                        }
                        else
                        {
                            null_count_Q++;
                        }

                        i_day++;
                    }
                }
                else
                {
                    MessageBox.Show(message);
                    reader.Close();
                    return;
                }

                if (null_count_Eta == i_day)
                {
                    MessageBox.Show("Нет данных уровня воды для выбранного гидроузла за указанный период");
                    chartEtat.Series.Remove(chartEtat.Series[series_count - 1]);
                    series_count -= 1;
                }
                else
                {
                    chartEtat.ChartAreas[0].AxisY.Minimum = minYEta;
                    chartEtat.ChartAreas[0].AxisY.Maximum = maxYEta;

                    chartEtat.ChartAreas[0].AxisX.Minimum = minXEta;
                    chartEtat.ChartAreas[0].AxisX.Maximum = maxXEta;

                    intervalX = Math.Round((maxXEta - minXEta) / 12, 0);
                    intervalY = Math.Round((maxYEta - minYEta) / 10, 2);

                    if (intervalX == 0)
                        intervalX = 1;
                    if (intervalY == 0)
                        intervalY = 1;

                    chartEtat.ChartAreas[0].AxisX.Interval = intervalX;
                    chartEtat.ChartAreas[0].AxisY.Interval = intervalY;

                    string Year;
                    if (dateTimePicker.Value.Year == dateTimePicker2.Value.Year)
                        Year = dateTimePicker.Value.Year.ToString();
                    else
                        Year = dateTimePicker.Value.Year.ToString() + "-" + dateTimePicker2.Value.Year.ToString();

                    //chartEtat.Series[series_count - 1].LegendText = hydropost_name + " " + Year;
                }

                if (null_count_Q == i_day)
                {
                    MessageBox.Show("Нет данных уровня вод для выбранного гидроузла за указанный период");
                    chartEtat.Series.Remove(chartEtat.Series[series_count - 1]);
                    series_count -= 1;
                }
                else
                {
                    chartQt.ChartAreas[0].AxisY.Minimum = minYQ;
                    chartQt.ChartAreas[0].AxisY.Maximum = maxYQ;

                    chartQt.ChartAreas[0].AxisX.Minimum = minXQ;
                    chartQt.ChartAreas[0].AxisX.Maximum = maxXQ;

                    intervalX = Math.Round((maxXQ - minXQ) / 12, 0);
                    intervalY = Math.Round((maxYQ - minYQ) / 10, 2);

                    if (intervalX == 0)
                        intervalX = 1;
                    if (intervalY == 0)
                        intervalY = 1;

                    chartQt.ChartAreas[0].AxisX.Interval = intervalX;
                    chartQt.ChartAreas[0].AxisY.Interval = intervalY;

                    string Year;
                    if (dateTimePicker.Value.Year == dateTimePicker2.Value.Year)
                        Year = dateTimePicker.Value.Year.ToString();
                    else
                        Year = dateTimePicker.Value.Year.ToString() + "-" + dateTimePicker2.Value.Year.ToString();
                }

                reader.Close();
                CreateMarkersLegend(GetSelectedPointIndex(e));
            }
        }

        public void CreateMarkersLegend(int HydropostID)
        {
            Label label = new Label();
            label.Font = new Font("Microsoft Sinse Serif", 11);
            label.Text = hydropost_name;
            label.Location = new Point(12,20*(series_count-1));
            label.Size = new Size(panelHydropostsLegend.Width-12, 20);

            PictureBox markerBox = new PictureBox();
            Bitmap marker = new Bitmap(10, 10);

            for (int i = 0; i < marker.Width; i++)
            {
                for(int j = 0; j < marker.Height; j++)
                {
                    marker.SetPixel(i, j, hydropostColor[HydropostID]);
                }
            }
            markerBox.SizeMode = PictureBoxSizeMode.AutoSize;
            markerBox.Image = marker;
            markerBox.Location = new Point(0,20*(series_count - 1) + 5);

            panelHydropostsLegend.Controls.Add(markerBox);
            panelHydropostsLegend.Controls.Add(label);
        }

        private void buttonChartClear_Click(object sender, EventArgs e)
        {
            chartEtat.Series.Clear();
            chartQt.Series.Clear();
            minYEta = 1000000;
            minXEta = 1000000;
            maxXEta = -1000000;
            maxYEta = -1000000;

            minYQ = 1000000;
            minXQ = 1000000;
            maxXQ = -1000000;
            maxYQ = -1000000;

            panelHydropostsLegend.Controls.Clear();
        }
    }
}
