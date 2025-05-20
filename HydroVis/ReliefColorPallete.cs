using System.Drawing;

namespace ReliefVisualisation
{
    internal class ReliefColorPallete
    {
        const int countColorAreas = 15;
        Color[] colorPallete = new Color[countColorAreas];

        public Color[] Multicolor()
        {
            colorPallete[0] = Color.FromArgb(130, 130, 130);
            colorPallete[1] = Color.FromArgb(168, 168, 168);
            colorPallete[2] = Color.FromArgb(201, 201, 201);
            colorPallete[3] = Color.FromArgb(127, 235, 163);
            colorPallete[4] = Color.FromArgb(77, 240, 112);
            colorPallete[5] = Color.FromArgb(4, 219, 105);
            colorPallete[6] = Color.FromArgb(159, 232, 2);
            colorPallete[7] = Color.FromArgb(255, 228, 94);
            colorPallete[8] = Color.FromArgb(250, 217, 55);
            colorPallete[9] = Color.FromArgb(250, 195, 55);
            colorPallete[10] = Color.FromArgb(232, 176, 35);
            colorPallete[11] = Color.FromArgb(240, 156, 31);
            colorPallete[12] = Color.FromArgb(240, 142, 31);
            colorPallete[13] = Color.FromArgb(222, 127, 18);
            colorPallete[14] = Color.FromArgb(179, 95, 0);

            return colorPallete;
        }

        public Color[] Gray()
        {
            colorPallete[0] = Color.FromArgb(245, 245, 245);
            colorPallete[1] = Color.FromArgb(225, 225, 225);
            colorPallete[2] = Color.FromArgb(205, 205, 205);
            colorPallete[3] = Color.FromArgb(185, 185, 185);
            colorPallete[4] = Color.FromArgb(165, 165, 165);
            colorPallete[5] = Color.FromArgb(145, 145, 145);
            colorPallete[6] = Color.FromArgb(125, 125, 125);
            colorPallete[7] = Color.FromArgb(115, 115, 115);
            colorPallete[8] = Color.FromArgb(105, 105, 105);
            colorPallete[9] = Color.FromArgb(95, 95, 95);
            colorPallete[10] = Color.FromArgb(85, 85, 85);
            colorPallete[11] = Color.FromArgb(75, 75, 75);
            colorPallete[12] = Color.FromArgb(65, 65, 65);
            colorPallete[13] = Color.FromArgb(55, 55, 55);
            colorPallete[14] = Color.FromArgb(45, 45, 45);

            return colorPallete;
        }

        public Color[] Water()
        {
            colorPallete[0] = Color.FromArgb(30, 222, 247);
            colorPallete[1] = Color.FromArgb(41, 182, 242);
            colorPallete[2] = Color.FromArgb(14, 172, 240);
            colorPallete[3] = Color.FromArgb(7, 165, 232);
            colorPallete[4] = Color.FromArgb(19, 150, 207);
            colorPallete[5] = Color.FromArgb(8, 127, 196);
            colorPallete[6] = Color.FromArgb(7, 112, 186);
            colorPallete[7] = Color.FromArgb(9, 105, 173);
            colorPallete[8] = Color.FromArgb(9, 86, 173);
            colorPallete[9] = Color.FromArgb(14, 60, 176);
            colorPallete[10] = Color.FromArgb(16, 58, 163);
            colorPallete[11] = Color.FromArgb(15, 53, 150);
            colorPallete[12] = Color.FromArgb(13, 47, 133);
            colorPallete[13] = Color.FromArgb(11, 41, 117);
            colorPallete[14] = Color.FromArgb(8, 33, 94);

            return colorPallete;
        }
    }
}
