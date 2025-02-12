using System;
using System.Windows.Forms;
namespace زياد_عبده_احمد_محمد_ابوراس_1
{
    public class CustomBtn : Button
    {
        public CustomBtn(int w, int h, EventHandler ev, int t = 0, int l = 0)
        {
            Text = "custom btn";
            Width = w;
            Height = h;
            Click += ev;
            Top = t;
            Left = l;
        }
    }
}
