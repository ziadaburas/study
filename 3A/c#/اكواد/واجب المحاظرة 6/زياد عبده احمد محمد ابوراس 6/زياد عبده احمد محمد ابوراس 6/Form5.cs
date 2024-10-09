using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace زياد_عبده_احمد_محمد_ابوراس_6
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void onStartTimer(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(seconds.Text)+1;
            checkSeconeds(s);

        }
        private void checkSeconeds(int s)
        {
            if (s == 60)
            {
                int m = Convert.ToInt32(minutes.Text)+1;
                checkMinutes(m);
                seconds.Text = "00";
            }
            else
            {
                if(s<10) seconds.Text = "0"+s.ToString();
                else seconds.Text =  s.ToString();

            }
        }
        private void checkMinutes(int m)
        {
            if (m == 60)
            {
                minutes.Text = "00";
                int h = Convert.ToInt32(minutes.Text) + 1;
                checkHours(h);

            }
            else
            {
                if (m < 10) minutes.Text = "0" + m.ToString();
                else minutes.Text = m.ToString();
            }
               
        }
        private void checkHours(int h)
        {
            if (h == 24)
            {
                int d = Convert.ToInt32(days.Text) + 1;
                days.Text = d.ToString();
                hours.Text = "00";

            }
            else
            {
                if (h < 10) hours.Text = "0" + h.ToString();
                else hours.Text = h.ToString();
            }
               
            
        }

        
        private void onBtnClick(object sender, EventArgs e)
        {
            timer1.Enabled = (sender==startBtn);
        }
    }
}
