using System;
using System.Linq;
using System.Windows.Forms;
namespace زياد_عبده_احمد_محمد_ابوراس_1
{
    public class CleanTextBtn : Button
    {
        public CleanTextBtn(int t = 0, int l = 0)
        {
            Top = t;
            Left = l;
            Text = "clean nums";
            Click += (s, e) =>
            {
                Form f = FindForm();
                clean(f.Controls);
                foreach (Panel p in f.Controls.OfType<Panel>())
                    clean(p.Controls);
                foreach (GroupBox g in f.Controls.OfType<GroupBox>())
                    clean(g.Controls);
            };
        }

        void clean(ControlCollection controls)
        {
            foreach (TextBox textBox in controls.OfType<TextBox>())
            {
                int a;
                if (int.TryParse(textBox.Text, out a))
                    textBox.Clear();

            }
        }
    }
}
