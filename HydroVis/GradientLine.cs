using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReliefVisualisation
{
    public partial class GradientLine : UserControl
    {
        private Color[] colorPallete;
        private double[] zForColorAreasL, zForColorAreasR;
        private Brush gradientPart; 

        public GradientLine()
        {
            InitializeComponent();
        }

        public Color[] ColorPallete
        {
            set { colorPallete = value; }
        }

        public double[] ZForColorAreas_L
        {
            set { zForColorAreasL = value; }
        }

        public double[] ZForColorAreas_R
        {
            set { zForColorAreasR = value; }
        }

        private void DrawGradientLine(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            int initX = 5, initY = 5;
            int gradWidth = 15, gradHeight = 37;
            this.Width = gradWidth + 30;
            this.Height = gradHeight * colorPallete.Length + 20;
            Font font = new Font("Arial", 9);

            if (colorPallete != null && zForColorAreasL != null && zForColorAreasR != null)
            {
                for (int i = 0; i < colorPallete.Length; i++)
                {
                    gradientPart = new SolidBrush(colorPallete[i]);
                    g.FillRectangle(gradientPart, initX, initY, gradWidth, gradHeight);
                    g.DrawString(Convert.ToString(Math.Round(zForColorAreasL[i], 0)), font, new SolidBrush(Color.Black), initX + gradWidth, initY - 8);
                    g.DrawString(Convert.ToString(Math.Round(zForColorAreasR[i], 0)), font, new SolidBrush(Color.Black), initX + gradWidth, initY - 8 + gradHeight);
                    initY += gradHeight;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e) 
        {
            DrawGradientLine(e);     
        }
    }
}
