using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asso.Launcher.Classes
{
    public static class ImageUtilities
    {
        public static Image GetRandomImage(int w, int h)
        {
            Color randomColor = GetRandomColor();
            Image img = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(img))
                g.FillRectangle(new SolidBrush(randomColor), new Rectangle(0, 0, img.Width, img.Height));
            return img;
        }

        public static Color GetRandomColor()
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
        }
    }
}
