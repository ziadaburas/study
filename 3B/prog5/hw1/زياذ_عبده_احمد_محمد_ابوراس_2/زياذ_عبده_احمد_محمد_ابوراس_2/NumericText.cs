using System;
using System.Windows.Forms;
namespace زياذ_عبده_احمد_محمد_ابوراس_2
{
    public class NumericText : TextBox
    {
        public NumericText(string text = "", int i = 0, int j = 0)
        {
            Text = text;
            Multiline = true;
            Width = 30;
            Height = 30;
            Left = Width * j;
            Top = Height * i;
            KeyPress += new KeyPressEventHandler(onKeyPress);

        }
        void onKeyPress(object s, KeyPressEventArgs e)
        {
            int key = e.KeyChar;
            if (!((key >= 48 && key <= 57) || key == 8))
            {
                e.Handled = true;
            }
        }
    }
}
