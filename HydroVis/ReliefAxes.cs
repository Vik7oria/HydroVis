using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReliefVisualisation
{
    public partial class ReliefAxes : UserControl
    {
        private double xmax, xmin, ymax, ymin;
        private int reliefImageWidth, reliefImageHeight;
        private int countX = 2, countY = 2;

        public ReliefAxes()
        {
            InitializeComponent();
        }

        public int CountX
        {
            set { countX = value; }
        }

        public int CountY
        {
            set { countY = value; }
        }

        public int ReliefWidth
        {
            set { reliefImageWidth = value; }
        }

        public int ReliefHeight
        {
            set { reliefImageHeight = value; }
        }

        public double Xmax
        {
            set { xmax = value; }
        }

        public double Xmin
        {
            set { xmin = value; }
        }

        public double Ymax
        {
            set { ymax = value; }
        }

        public double Ymin
        {
            set { ymin = value; }
        }

        private void DrawAxes(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Pen pen = new Pen(Color.Black, 2);
            int streak = 6, textSpaceY = 18, textSpaceX = 65;
            int start_draw_Y = 5;
            double intervalX, intervalY, deltaX, deltaY;
            Font font = new Font("Arial", 9);
            String axis_text;

            intervalX = (xmax - xmin) / countX;
            intervalY = (ymax - ymin) / countY;

            deltaX = reliefImageWidth / (double)countX;
            deltaY = reliefImageHeight / (double)countY;

            this.Width = reliefImageWidth + 2 + streak + textSpaceX + textSpaceX / 2;
            this.Height = reliefImageHeight + 2 + streak + textSpaceY + start_draw_Y;

            //Оси X и Y
            g.DrawLine(pen, 0 + textSpaceX, start_draw_Y, 0 + textSpaceX, start_draw_Y + reliefImageHeight + 1);
            g.DrawLine(pen, 0 + textSpaceX, reliefImageHeight + 1 + start_draw_Y, reliefImageWidth + 1 + textSpaceX, reliefImageHeight + 1 + start_draw_Y);

            for (int i = 0; i < countX + 1; i++)
            {
                //отметки по оси X
                g.DrawLine(pen, (int)(textSpaceX + deltaX * i), reliefImageHeight + 1 + start_draw_Y, (int)(0 + textSpaceX + deltaX * i), reliefImageHeight + 1 + streak + start_draw_Y);
                axis_text = Convert.ToString(Math.Round(xmin + intervalX * i, 2));
                g.DrawString(axis_text, font, new SolidBrush(Color.Black), (int)(textSpaceX + deltaX * i - g.MeasureString(axis_text, font).Width / 2), reliefImageHeight + 1 + streak + 3 + start_draw_Y);
            }

            for (int i = 0; i < countY + 1; i++)
            {
                //отметки по оси Y
                g.DrawLine(pen, 0 + textSpaceX, (int)(reliefImageHeight + 1 - deltaY * i + start_draw_Y), 0 + textSpaceX - streak, (int)(reliefImageHeight + 1 - deltaY * i + start_draw_Y));
                axis_text = Convert.ToString(Math.Round(ymin + intervalY * i, 2));
                g.DrawString(axis_text, font, new SolidBrush(Color.Black), 0 + textSpaceX - streak - g.MeasureString(axis_text, font).Width - 5, (int)(reliefImageHeight + 1 - deltaY * i - font.GetHeight() / 2 + start_draw_Y));
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawAxes(e);
        }
    }
}
