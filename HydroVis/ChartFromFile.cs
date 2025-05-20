using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Globalization;

namespace ReliefVisualisation
{
    public class ChartFromFile
    {
        double minX = 1000000, maxX = -1000000, minY = 1000000, maxY = -1000000;
        double eta, Q;
        int series_count, uniqueSeriesNumber = 0;
        Chart currentChart;
        StreamReader streamReader;
        string xtitle, ytitle, seriesName, dataLine;

        private void SetChart()
        {
            currentChart.Series[series_count - 1].LegendText = seriesName;

            currentChart.ChartAreas[0].AxisX.Title = xtitle;
            currentChart.ChartAreas[0].AxisY.Title = ytitle;

            currentChart.Series[series_count - 1].ChartType = SeriesChartType.Line;
            currentChart.Series[series_count - 1].BorderWidth = 2;

            currentChart.ChartAreas[0].AxisX.Minimum = Math.Round(minX, 2);
            currentChart.ChartAreas[0].AxisX.Maximum = Math.Round(maxX, 2);
            currentChart.ChartAreas[0].AxisX.Interval = Math.Round((maxX - minX) / 10, 0);

            currentChart.ChartAreas[0].AxisY.Minimum = Math.Round(minY, 2);
            currentChart.ChartAreas[0].AxisY.Maximum = Math.Round(maxY, 2);
            currentChart.ChartAreas[0].AxisY.Interval = Math.Round((maxY - minY) / 10, 0);
        }

        public void MakeQtChart (Chart chart, string filename)
        {
            currentChart = chart;
            string[] line_columns = new string[5];
            int i = 0;

            try
            {
                streamReader = new StreamReader(filename);

                currentChart.Series.Add($"Series{uniqueSeriesNumber += 1}");
                series_count = currentChart.Series.Count();
                seriesName = filename.Substring(filename.Length - 8, 4);

                xtitle = "Время, t, дни";
                ytitle = "Расход воды, Q, м³/c";

                dataLine = streamReader.ReadLine();//считывание названий столбцов
                dataLine = streamReader.ReadLine();//самих данных
                while (dataLine != null)
                {                   
                    line_columns = dataLine.Split(' ');
                    if (line_columns[4] != "#")
                    {
                        Q = double.Parse(line_columns[4]);

                        currentChart.Series[series_count - 1].Points.AddXY(i, Q);

                        if (Q < minY) 
                            minY = Q;
                        if (Q > maxY)
                            maxY = Q;
                    }
                    
                    i++;
                    dataLine = streamReader.ReadLine();
                }
                streamReader.Close();

                minX = 0;
                maxX = i;

                SetChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void MakeEtatChart(Chart chart, string filename, bool bief)
        {
            currentChart = chart;
            string[] line_columns = new string[5];
            int i = 0, b;

            if (bief) b = 2;
            else b = 3;

            try
            {
                streamReader = new StreamReader(filename);

                currentChart.Series.Add($"Series{uniqueSeriesNumber += 1}");
                series_count = currentChart.Series.Count();
                seriesName = filename.Substring(filename.Length - 8, 4);

                xtitle = "Время, t, дни";
                ytitle = "Уровень воды, η, м";

                dataLine = streamReader.ReadLine();//считывание названий столбцов
                dataLine = streamReader.ReadLine();//самих данных

                while (dataLine != null)
                {
                    line_columns = dataLine.Split(' ');

                    if (line_columns[b] != "#")
                    {
                        eta = double.Parse(line_columns[b]);

                        if (eta < minY) { minY = eta; }
                        if (eta > maxY) { maxY = eta; }

                        currentChart.Series[series_count - 1].Points.AddXY(i, eta);
                    }

                    i++;
                    dataLine = streamReader.ReadLine();
                }
                streamReader.Close();

                minX = 0;
                maxX = i;

                SetChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void MakeHysteresisChart(Chart chart, string filename, bool bief)
        {
            currentChart = chart;
            string[] line_columns = new string[5];
            int b;

            if (bief) b = 2;
            else b = 3;

            try
            {
                streamReader = new StreamReader(filename);
                currentChart.Series.Add($"Series{uniqueSeriesNumber += 1}");
                series_count = currentChart.Series.Count();
                seriesName = filename.Substring(filename.Length - 8, 4);
                xtitle = "Расход воды, Q, м³/c";
                ytitle = "Уровень воды, η, м";

                dataLine = streamReader.ReadLine();
                dataLine = streamReader.ReadLine();

                while (dataLine != null)
                {
                    line_columns = dataLine.Split(' ');

                    if (line_columns[b] != "#" && line_columns[4] != "#")
                    {
                        eta = double.Parse(line_columns[b]);
                        Q = double.Parse(line_columns[4]);

                        if(eta < minY) { minY = eta; }
                        if (Q < minX) { minX = Q; }
                        if (Q > maxX) { maxX = Q; }
                        if (eta > maxY) { maxY = eta; }

                        currentChart.Series[series_count - 1].Points.AddXY(Q, eta);
                    }

                    dataLine = streamReader.ReadLine();
                }
                streamReader.Close();
                SetChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MakeModelingEtatChart(Chart chart, string filename, int controlPointNumber)
        {
            currentChart = chart;
            string[] line_coordinates = new string[6];
            int i = 0;

            try
            {
                streamReader = new StreamReader(filename);
                currentChart.Series.Add($"Series{uniqueSeriesNumber += 1}");
                series_count = currentChart.Series.Count();
                seriesName = $"В точке {controlPointNumber}";
                xtitle = "Время, t, дни";
                ytitle = "Уровень воды, \u03B7, м";

                dataLine = streamReader.ReadLine();
                while (dataLine != null)
                {
                    line_coordinates = dataLine.Split(' ');
                    eta = double.Parse(line_coordinates[2].Replace('.', ','), NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign);

                    if (eta < minY)
                        minY = eta;
                    if (eta > maxY)
                        maxY = eta;

                    currentChart.Series[series_count - 1].Points.AddXY(i, eta);
                    i++;
                    dataLine = streamReader.ReadLine();
                }
                streamReader.Close();

                minX = 0;
                maxX = i;
                SetChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MakeModelingQtChart(Chart chart, string filename, int controlPointNumber)
        {
            currentChart = chart;
            string[] line_coordinates = new string[11];
            int i = 0;

            try
            {
                streamReader = new StreamReader(filename);

                dataLine = streamReader.ReadLine();
                currentChart.Series.Add($"Series{uniqueSeriesNumber += 1}");
                series_count = currentChart.Series.Count();
                seriesName = $"В точке {controlPointNumber}";
                xtitle = "Время, t, дни";
                ytitle = "Расход воды, Q, м³/c";

                dataLine = streamReader.ReadLine();
                while (dataLine != null)
                {
                    line_coordinates = dataLine.Split(' ');
                    Q = double.Parse(line_coordinates[1].Replace('.', ','), NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);

                    if (Q < minY)
                        minY = Q;
                    if (Q > maxY)
                        maxY = Q;

                    currentChart.Series[series_count - 1].Points.AddXY(i, Q);
                    i++;
                    dataLine = streamReader.ReadLine();
                }
                streamReader.Close();

                minX = 0;
                maxX = i;
                SetChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MakeModelingHysteresisChart(Chart chart, string filenameQ, string filenameEta, int controlPointNumber)
        {
            currentChart = chart;
            StreamReader srQ, srEta;
            String lineQ, lineEta;
            string[] column = new string[11];
            int i = 0;

            try
            {
                srQ = new StreamReader(filenameQ);
                srEta = new StreamReader(filenameEta);

                lineQ = srQ.ReadLine();
                lineEta = srEta.ReadLine();
                currentChart.Series.Add($"Series{uniqueSeriesNumber += 1}");
                series_count = chart.Series.Count();

                lineQ = srQ.ReadLine();
                lineEta = srEta.ReadLine();

                seriesName = $"В точке {controlPointNumber}";
                xtitle = "Расход, Q, м³/с";
                ytitle = "Уровень воды, \u03B7, м";

                while (lineEta != null)
                {
                    column = lineQ.Split(' ');
                    Q = double.Parse(column[1].Replace('.', ','), NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);

                    if (Q < minX)
                        minX = Q;
                    if (Q > maxX)
                        maxX = Q;

                    column = lineEta.Split(' ');
                    eta = double.Parse(column[2].Replace('.', ','), NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign);

                    if (eta < minY)
                        minY = eta;
                    if (eta > maxY)
                        maxY = eta;

                    currentChart.Series[series_count - 1].Points.AddXY(Q, eta);

                    lineQ = srQ.ReadLine();
                    lineEta = srEta.ReadLine();
                }
                srQ.Close();
                srEta.Close();

                SetChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MakeModelingHydrographChart(Chart chart, string filename)
        {
            currentChart = chart;

            try
            {
                streamReader = new StreamReader(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            int i, count = Convert.ToInt32(streamReader.ReadLine());
            currentChart.Series.Add($"Series{uniqueSeriesNumber += 1}");
            series_count = chart.Series.Count();
            seriesName = "Гидрограф";
            xtitle = "Время, t, дни";
            ytitle = "Расход воды, Q, м³/с";

            for (i = 1; i <= count; i++)
            {
                Q = Convert.ToDouble(streamReader.ReadLine());
                currentChart.Series[series_count - 1].Points.AddXY(i, Q);
                if (Q > maxY)
                    maxY = Q;
                if (Q < minY)
                    minY = Q;
            }
            streamReader.Close();

            if (0 < minX)
                minX = 0;
            if (i > maxX)
                maxX = i;

            SetChart();
        }

        public void ClearChart()
        {
            currentChart.Series.Clear();
            minX = 1000000;
            maxX = -1000000;
            minY = 1000000;
            maxY = -1000000;
        }
    }
}
