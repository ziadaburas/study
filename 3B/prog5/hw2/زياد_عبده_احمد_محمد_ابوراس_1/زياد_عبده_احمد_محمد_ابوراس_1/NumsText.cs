using System;
using System.Windows.Forms;
namespace زياد_عبده_احمد_محمد_ابوراس_1
{
    public class NumsText : TextBox
    {
        public NumsText(int t = 0, int l = 0, string tx = "")
        {
            Top = t;
            Left = l;
            Width = 30;
            Height = 30;
            Multiline = true;
            Text = tx;
            if (tx.Length != 0) return;
            Random r = new Random();
            Text = r.Next(0, 20).ToString();
        }
    }
}
