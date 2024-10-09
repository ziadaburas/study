using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace زياد_عبده_احمد_محمد_ابوراس_5
{
    public partial class Form1 : Form
    {
        Thread threadRight;
        bool rightMoving, rightState;

        Thread threadUp;
        bool upMoving, upState;
        public Form1()
        {
            InitializeComponent();
            btnRightControl.Click += onBtnControlClick;
            btnUpControl.Click += onBtnControlClick;
            FormClosing += onFormClosing;
        }




        private void onFormClosing(object sender, EventArgs e)
        {
            stopMoving(ref threadRight, ref rightState);
            stopMoving(ref threadUp, ref upState);

        }

        private void onBtnControlClick(object sender, EventArgs e)
        {

            if (sender == btnRightControl)
            {
                if (((Button)sender).Text == "start")
                {
                    rightState = true;
                    threadRight = new Thread(startMovingRight);
                    threadRight.Start();
                    ((Button)sender).Text = "stop";

                }
                else
                {
                    ((Button)sender).Text = "start";
                    stopMoving(ref threadRight, ref rightState);
                }

            }
            else
            {
                if (((Button)sender).Text == "start")
                {
                    upState = true;
                    threadUp = new Thread(startMovingUp);
                    threadUp.Start();
                    ((Button)sender).Text = "stop";
                }
                else
                {
                    ((Button)sender).Text = "start";
                    stopMoving(ref threadUp, ref upState);
                }
            }

        }




        private void onLoadForm(object sender, EventArgs e)
        {
            onBtnControlClick(btnRightControl, null);
            onBtnControlClick(btnUpControl, null);

        }
        private void startMovingRight()
        {

            while (rightState)
            {
                Invoke((Action)(() =>
                {
                    btnRight.Left = moving(btnRight.Left, this.Width - btnRight.Width, ref rightMoving);

                }));
                Thread.Sleep(100);
            }

        }
        private void startMovingUp()
        {

            while (upState)
            {
                Invoke((Action)(() =>
                {
                    btnUp.Top = moving(btnUp.Top, this.Height - btnUp.Height * 2, ref upMoving);

                }));
                Thread.Sleep(100);
            }

        }
        private int moving(int value, int max, ref bool state)
        {
            if (value > max || value < 0) state = !state;
            if (state) return value += 10;
            else return value -= 10;

        }
        private void stopMoving(ref Thread thread, ref bool state)
        {
            if (state)
            {
                state = false;
                thread.Abort();
            }
        }
    }
}
