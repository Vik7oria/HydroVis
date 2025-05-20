using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReliefVisualisation
{
    public class ReliefVisualisation
    {
        FileStream fstream;
        Bitmap bmpRelief, bmpReliefNewSize, bmpWater, bmpControlPoints;
        GradientLine gradientLineRelief, gradientLineWater;
        ReliefAxes reliefAxes;
        ChartFromFile chartForControlPoint = new ChartFromFile();
        double xmin, xmax, ymin, ymax, delta_x, delta_y;
        double reliefWidth, reliefHeight;
        string last_filename, contrP_path;
        Color[] reliefColor;
        int pointSizeX = 5, pointSizeY = 5;

        double controlP_ForBmp_y, controlP_ForBmp_x; 
        Int64 control_count;
        double[] controlP_x, controlP_y;
        int selectedPointId = -1;

        byte[] firstBytes = new byte[4];
        byte[] NxNy_bytes = new byte[2];
        byte[] minmax_bytes = new byte[8];
        byte[] Zb_bytes = new byte[4];
        char[] sgrd = new char[4];
        Int16 Nx, Ny;
        double zmin, zmax, Nz, delta_z;
        float[] Z_heights;
        int N, i_z;
        double[] zForColorAreasL, zForColorAreasR;

        public ReliefVisualisation()
        {
            gradientLineRelief = new GradientLine();
            gradientLineWater = new GradientLine();
            reliefAxes = new ReliefAxes();
        }

        private void ReadGRDFile(string filename)
        {
            try
            {
                fstream = File.OpenRead(filename);
            }
            catch
            {
                return;
            }

            //Чтение идентификационной строки
            fstream.Read(firstBytes, 0, 4);
            sgrd[0] = Convert.ToChar(firstBytes[0]);
            sgrd[1] = Convert.ToChar(firstBytes[1]);
            sgrd[2] = Convert.ToChar(firstBytes[2]);
            sgrd[3] = Convert.ToChar(firstBytes[3]);

            //Чтение количества ячеек по осям Ox, Oy и рассчёт их общего количества
            fstream.Read(NxNy_bytes, 0, 2);
            Nx = BitConverter.ToInt16(NxNy_bytes, 0);
            fstream.Read(NxNy_bytes, 0, 2);
            Ny = BitConverter.ToInt16(NxNy_bytes, 0);

            N = Nx * Ny;

            //Чтение мин. и макс. значений по осям Ox, Oy, Oz
            fstream.Read(minmax_bytes, 0, 8);
            xmin = BitConverter.ToDouble(minmax_bytes, 0);
            fstream.Read(minmax_bytes, 0, 8);
            xmax = BitConverter.ToDouble(minmax_bytes, 0);

            fstream.Read(minmax_bytes, 0, 8);
            ymin = BitConverter.ToDouble(minmax_bytes, 0);
            fstream.Read(minmax_bytes, 0, 8);
            ymax = BitConverter.ToDouble(minmax_bytes, 0);

            fstream.Read(minmax_bytes, 0, 8);
            zmin = BitConverter.ToDouble(minmax_bytes, 0);
            fstream.Read(minmax_bytes, 0, 8);
            zmax = BitConverter.ToDouble(minmax_bytes, 0);

            //Чтение высот для каждой из N ячеек
            Z_heights = new float[N];
            for (int i = 0; i < N; i++)
            {
                fstream.Read(Zb_bytes, 0, 4);
                Z_heights[i] = BitConverter.ToSingle(Zb_bytes, 0);
            }

            fstream.Close();
        }

        private void CreateReliefImage(Bitmap bmpRelief, Color[] color_pallete, PictureBox pictureBoxRelief)
        {
            reliefColor = color_pallete;
            int count_color_areas = color_pallete.Count();
            zForColorAreasL = new double[count_color_areas];
            zForColorAreasR = new double[count_color_areas];

            //Рассчёт шага для высот в зависимости от количества цветов в палитре
            Nz = Math.Abs(zmax - zmin);
            delta_z = Convert.ToDouble(Nz) / (count_color_areas);

            //Рассчет значений для каждого из промежутков высот
            for (int i = 0; i < count_color_areas; i++)
            {
                zForColorAreasL[i] = zmin;
                zForColorAreasR[i] = zmin + delta_z;
                zmin += delta_z;
            }

            //Рассчёт шага по осям Ox, Oy
            delta_x = (xmax - xmin) / Convert.ToDouble(Nx - 1);
            delta_y = (ymax - ymin) / Convert.ToDouble(Ny - 1);

            i_z = 0;
            for (int j = Ny - 1; j >= 0; j--)
            {
                for (int i = 0; i < Nx; i++)
                {
                    for (int k = 0; k < count_color_areas; k++)
                    {
                        if ((Z_heights[i_z] > zForColorAreasL[k]) && (Z_heights[i_z] <= zForColorAreasR[k]))
                        {
                            bmpRelief.SetPixel((int)i, (int)j, reliefColor[k]);
                        }
                    }
                    i_z++;
                }
            }

            //рассчеты для задания размера изображения рельефа
            //с учетом размеров монитора
            double nx_to_ny = (double)Nx / Ny;

            if (Nx > Ny)
            {
                reliefWidth = SystemInformation.PrimaryMonitorSize.Width - 830;
                reliefHeight = reliefWidth / nx_to_ny * 3.5;
                pointSizeX = 14;
                pointSizeY = 4;
            }
            else
            {
                reliefHeight = SystemInformation.PrimaryMonitorSize.Height - 200;
                reliefWidth = reliefHeight * nx_to_ny;
                pointSizeX = 5;
                pointSizeY = 5;
            }

            bmpReliefNewSize = new Bitmap(bmpRelief, new Size((int)reliefWidth, (int)reliefHeight));
            pictureBoxRelief.Image = bmpReliefNewSize;
        }

        public void VisualizeRelief(PictureBox pictureBox, string filename, Form form, Color[] color_pallete, NumericUpDown numericUpDownHighMin = null, NumericUpDown numericUpDownHighMax = null)
        {
            if (filename != last_filename)
            {
                numericUpDownHighMin.Text = "";
                numericUpDownHighMax.Text = "";
            }
            last_filename = filename;
            bmpWater = null;
            selectedPointId = -1;

            if (form.Controls.Contains(gradientLineRelief))
            {
                form.Controls.Remove(gradientLineRelief);
            }

            if (form.Controls.Contains(gradientLineWater))
            {
                form.Controls.Remove(gradientLineWater);
            }

            if (form.Controls.Contains(reliefAxes))
            {
                form.Controls.Remove(reliefAxes);
            }

            ReadGRDFile(filename);

            try
            {
                bmpRelief = new Bitmap(Nx, Ny);
            }
            catch
            {
                MessageBox.Show("Не удаётся отобразить данные рельефа.");
                return;
            }

            numericUpDownHighMin.Minimum = Convert.ToDecimal(Math.Round(zmin, 3));
            numericUpDownHighMin.Maximum = Convert.ToDecimal(Math.Round(zmax, 3));
            numericUpDownHighMax.Minimum = Convert.ToDecimal(Math.Round(zmin, 3));
            numericUpDownHighMax.Maximum = Convert.ToDecimal(Math.Round(zmax, 3));

            //Изменение макс и мин высот на введённые
            if (numericUpDownHighMin.Text != "")
            {
                zmin = Convert.ToDouble(numericUpDownHighMin.Value);
            }
            else
            {
                numericUpDownHighMin.Text = Convert.ToString(Math.Round(zmin, 3));
            }

            if (numericUpDownHighMax.Text != "")
            {
                zmax = Convert.ToDouble(numericUpDownHighMax.Value);
            }
            else
            {
                numericUpDownHighMax.Text = Convert.ToString(Math.Round(zmax, 3));
            }

            CreateReliefImage(bmpRelief, color_pallete, pictureBox);

            reliefAxes.ReliefWidth = pictureBox.Width;
            reliefAxes.ReliefHeight = pictureBox.Height;
            reliefAxes.Xmin = xmin; reliefAxes.Xmax = xmax;
            reliefAxes.Ymin = ymin; reliefAxes.Ymax = ymax;
            reliefAxes.Location = new Point(pictureBox.Location.X - 2 - 65, pictureBox.Location.Y - 5);
            form.Controls.Add(reliefAxes);

            gradientLineRelief.ColorPallete = reliefColor;
            gradientLineRelief.ZForColorAreas_L = zForColorAreasL;
            gradientLineRelief.ZForColorAreas_R = zForColorAreasR;
            gradientLineRelief.Location = new Point(pictureBox.Width + pictureBox.Location.X + 33, pictureBox.Location.Y);
            form.Controls.Add(gradientLineRelief);
        }

        public void AddWaterLayer(PictureBox pictureBox, string filename, Form form, Color[] color_pallete)
        {
            if (form.Controls.Contains(gradientLineWater))
            {
                form.Controls.Remove(gradientLineWater);
            }

            ReadGRDFile(filename);

            if (bmpRelief != null)
            {
                bmpWater = new Bitmap(bmpRelief);
            }
            else
            {
                bmpWater = new Bitmap(Nx, Ny);
            }

            CreateReliefImage(bmpWater, color_pallete, pictureBox);

            gradientLineWater.ColorPallete = reliefColor;
            gradientLineWater.ZForColorAreas_L = zForColorAreasL;
            gradientLineWater.ZForColorAreas_R = zForColorAreasR;
            gradientLineWater.Location = new Point(pictureBox.Width + pictureBox.Location.X + 95, pictureBox.Location.Y);
            form.Controls.Add(gradientLineWater);
        }

        public void AddControlPoints(PictureBox pictureBox, string filename)
        {
            StreamReader sr;
            String readLine;
            string[] readLine_coordinates;
            contrP_path = "";
            for (int i = 0; i < filename.Split('\\').Length - 1; i++)
            {
                contrP_path += filename.Split('\\')[i] + "\\";
            }
            
            if (bmpWater != null)
            {
                bmpControlPoints = new Bitmap(bmpWater);
            }
            else if (bmpRelief != null)
            {
                bmpControlPoints = new Bitmap(bmpRelief);
            }
            else
            {
                MessageBox.Show("Не удаётся отобразить данные контрольных точек.");
                return;
            }

            try
            {
                sr = new StreamReader(filename);
            }
            catch
            {
                MessageBox.Show("Не удаётся отобразить данные контрольных точек.");
                return;
            }

            //чтение количества точек и создание массивов для их координат
            readLine = sr.ReadLine();
            try
            {
                control_count = Convert.ToInt64(readLine);
            }
            catch
            {
                MessageBox.Show("Не удаётся отобразить данные контрольных точек.");
                return;
            }
            controlP_x = new double[control_count];
            controlP_y = new double[control_count];

            //чтение координат
            for (int i_coordinate = 0; i_coordinate < control_count; i_coordinate++)
            {
                Console.WriteLine(readLine);
                readLine = sr.ReadLine();//номер точки
                readLine = sr.ReadLine();//координаты точки
                readLine_coordinates = readLine.Split(' ');
                controlP_x[i_coordinate] = double.Parse(readLine_coordinates[0].Replace('.', ','));
                controlP_y[i_coordinate] = double.Parse(readLine_coordinates[1].Replace('.', ','));
            }

            sr.Close();

            //отрисовка точек
            for (int i = 0; i < control_count; i++)
            {
                //циклы, чтобы увеличить размер точек
                //сама точка при l == m == 0
                for (int l = -pointSizeX; l <= pointSizeX; l++)
                {
                    for (int m = -pointSizeY; m <= pointSizeY; m++)
                    {
                        //помимо перевода координаты для соответствия с размером grd также выполняется инверсия для учёта нумерации пикселей в bmp с левого верхнего угла
                        controlP_ForBmp_x = (controlP_x[i] - xmin) / delta_x - l;
                        controlP_ForBmp_y = (ymax - ymin) / delta_y - ((controlP_y[i] - ymin) / delta_y) - m;
                        if (controlP_ForBmp_x <= bmpControlPoints.Width - 1 && controlP_ForBmp_x >= 0 &&
                            controlP_ForBmp_y <= bmpControlPoints.Height - 1 && controlP_ForBmp_y >= 0)
                        {
                            bmpControlPoints.SetPixel((int)controlP_ForBmp_x, (int)controlP_ForBmp_y, Color.Black);
                        }
                    }
                }
            }
            bmpReliefNewSize = new Bitmap(bmpControlPoints, new Size((int)reliefWidth, (int)reliefHeight));
            pictureBox.Image = bmpReliefNewSize;
        }

        public void SelectControlPoint(PictureBox pictureBox, int mouseX, int mouseY, Label labelControlPoint, Chart chart, string chartType)
        {
            if(bmpControlPoints == null)
            {
                return;
            }

            int x_CoordinateInBmp = mouseX, y_CoordinateInBmp = mouseY;
            bool MouseOnPoint = false;

            x_CoordinateInBmp = (int)(x_CoordinateInBmp * bmpRelief.Width / bmpReliefNewSize.Width);
            y_CoordinateInBmp = (int)(y_CoordinateInBmp * bmpRelief.Height / bmpReliefNewSize.Height);

            for (int i = 0; i < control_count; i++)
            {
                for (int l = -(pointSizeX + 5); l <= (pointSizeX + 5); l++)
                {
                    for (int m = -(pointSizeY + 5); m <= (pointSizeY + 5); m++)
                    {
                        controlP_ForBmp_x = (controlP_x[i] - xmin) / delta_x - l;
                        controlP_ForBmp_y = (ymax - ymin) / delta_y - ((controlP_y[i] - ymin) / delta_y) - m;
                        if (x_CoordinateInBmp == (int)controlP_ForBmp_x && y_CoordinateInBmp == (int)controlP_ForBmp_y)
                        {
                            MouseOnPoint = true;
                        }
                    }
                }

                if (MouseOnPoint)
                {
                    if (i == selectedPointId)
                    {
                        for (int l = -pointSizeX; l <= pointSizeX; l++)
                        {
                            for (int m = -pointSizeY; m <= pointSizeY; m++)
                            {
                                controlP_ForBmp_x = (controlP_x[i] - xmin) / delta_x - l;
                                controlP_ForBmp_y = (ymax - ymin) / delta_y - ((controlP_y[i] - ymin) / delta_y) - m;
                                if (controlP_ForBmp_x <= bmpControlPoints.Width - 1 && controlP_ForBmp_x >= 0 &&
                                    controlP_ForBmp_y <= bmpControlPoints.Height - 1 && controlP_ForBmp_y >= 0)
                                {
                                    bmpControlPoints.SetPixel((int)controlP_ForBmp_x, (int)controlP_ForBmp_y, Color.Black);
                                }
                            }
                        }
                        labelControlPoint.Visible = false;
                        bmpReliefNewSize = new Bitmap(bmpControlPoints, new Size((int)reliefWidth, (int)reliefHeight));
                        pictureBox.Image = bmpReliefNewSize;
                        selectedPointId = -1;
                        return;
                    }

                    for (int l = -pointSizeX; l <= pointSizeX; l++)
                    {
                        for (int m = -pointSizeY; m <= pointSizeY; m++)
                        {
                            controlP_ForBmp_x = (controlP_x[i] - xmin) / delta_x - l;
                            controlP_ForBmp_y = (ymax - ymin) / delta_y - ((controlP_y[i] - ymin) / delta_y) - m;
                            if (controlP_ForBmp_x <= bmpControlPoints.Width - 1 && controlP_ForBmp_x >= 0 &&
                                controlP_ForBmp_y <= bmpControlPoints.Height - 1 && controlP_ForBmp_y >= 0)
                            {
                                bmpControlPoints.SetPixel((int)controlP_ForBmp_x, (int)controlP_ForBmp_y, Color.Red);
                            }

                            if (selectedPointId >= 0)
                            {
                                controlP_ForBmp_x = (controlP_x[selectedPointId] - xmin) / delta_x - l;
                                controlP_ForBmp_y = (ymax - ymin) / delta_y - ((controlP_y[selectedPointId] - ymin) / delta_y) - m;
                                if (controlP_ForBmp_x <= bmpControlPoints.Width - 1 && controlP_ForBmp_x >= 0 &&
                                    controlP_ForBmp_y <= bmpControlPoints.Height - 1 && controlP_ForBmp_y >= 0)
                                {
                                    bmpControlPoints.SetPixel((int)controlP_ForBmp_x, (int)controlP_ForBmp_y, Color.Black);
                                }
                            }
                        }
                    }
                    bmpReliefNewSize = new Bitmap(bmpControlPoints, new Size((int)reliefWidth, (int)reliefHeight));
                    pictureBox.Image = bmpReliefNewSize;

                    labelControlPoint.Text = "Координаты выбранной\nконтрольной точки " + (i + 1).ToString() +
                                             ":\n\n(" + controlP_x[i].ToString() + "; "  + controlP_y[i].ToString() + ")";
                    labelControlPoint.Visible = true;
                    selectedPointId = i;

                    if (chartType == "Qt")
                    {
                        chartForControlPoint.MakeModelingQtChart(chart, contrP_path + "dat\\" + "Qtr" + i.ToString() + ".dat", i+1);
                    }
                    else if (chartType == "Etat")
                    {
                        chartForControlPoint.MakeModelingEtatChart(chart, contrP_path + "ContrP_ " + i.ToString() + ".dat", i+1);
                    }
                    else
                    {
                        chartForControlPoint.MakeModelingHysteresisChart(chart, contrP_path + "dat\\" + "Qtr" + i.ToString() + ".dat", contrP_path + "ContrP_ " + i.ToString() + ".dat", i+1);
                    }
                    return;
                }
            }
        }

        public void ClearChartForControlPoint()
        {
            chartForControlPoint.ClearChart();
        }
    }
}
