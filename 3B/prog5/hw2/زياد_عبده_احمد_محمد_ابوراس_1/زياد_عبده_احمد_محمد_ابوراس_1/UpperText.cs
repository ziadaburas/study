using System;
using System.Windows.Forms;

namespace زياد_عبده_احمد_محمد_ابوراس_1
{
    public class UpperText : TextBox
    {
        public UpperText(int t = 0, int l = 0)
        {
            Top = t;
            Left = l;
            TextChanged += (s, e) =>
            {
                int cur = SelectionStart;
                Text = Text.ToUpper();
                SelectionStart = cur;

            };
        }
    }
}
