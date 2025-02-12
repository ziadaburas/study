using System;
using System.Windows.Forms;
namespace زياد_عبده_احمد_محمد_ابوراس_1
{
    public class SpacingText : TextBox
    {
        public SpacingText(int t = 0, int l = 0)
        {
            Top = t;
            Left = l;

            KeyPress += (s, e) =>
            {
                int i = SelectionStart;
                int key = e.KeyChar;
                if (key != ' ') return;
                if (Text.Length == 0) return;

                if (i != 0)
                {
                    if (Text[i - 1] == ' ')
                    {
                        e.Handled = true;
                        return;
                    }
                }
                if (i != Text.Length)
                {
                    if (Text[i] == ' ')
                    {
                        e.Handled = true;
                        return;
                    }
                }


            };
        }
    }
}

