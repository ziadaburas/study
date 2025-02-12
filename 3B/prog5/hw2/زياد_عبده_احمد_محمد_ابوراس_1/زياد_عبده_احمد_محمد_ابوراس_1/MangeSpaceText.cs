using System;
using System.Windows.Forms;
namespace زياد_عبده_احمد_محمد_ابوراس_1
{
    public class MangeSpaceText : TextBox
    {
        public MangeSpaceText(int t = 0, int l = 0)
        {
            Top = t;
            Left = l;
            KeyPress += (s, e) =>
            {
                if (e.KeyChar != 100) return;
                string[] txt = Text.Trim().Split();
                string temp = "";
                for (int i = 0; i < txt.Length; i++)
                {
                    if (txt[i].Length > 0)
                        temp += txt[i] + ' ';
                }

                Text = temp;
                SelectionStart = temp.Length;

            };
        }
    }
}
