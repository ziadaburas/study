using System;
using System.Windows.Forms;

namespace زياد_عبده_احمد_محمد_ابوراس_1
{ 
public class CloseBtn : Button
    {
        public CloseBtn()
        {
            ParentChanged += (s, e) =>
            {
                Form f = (Form)Parent;
                Text = "close";
                Left = 0;
                Top = f.Height - Height * 3;
                this.Click += (ss, ee) => f.Close();
            };

        }

    }
}
