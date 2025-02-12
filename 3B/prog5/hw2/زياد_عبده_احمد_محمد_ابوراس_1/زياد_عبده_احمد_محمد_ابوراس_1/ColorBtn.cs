using System;
using System.Windows.Forms;
using System.Drawing;
namespace زياد_عبده_احمد_محمد_ابوراس_1
{
    public class ColorBtn : Button
    {
        Random random = new Random();
        public ColorBtn(int t = 0, int l = 0)
        {
            Top = t;
            Left = l;
            Text = "change color";
            Click += (s, e) => BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        }
    }
}
