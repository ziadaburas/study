using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assign3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void onLoadForm(object sender, EventArgs e)
        {
            summ.Click += onBtnClick;
            fact.Click += onBtnClick;
            sqrtt.Click += onBtnClick;
        }
        private void onBtnClick(object sender, EventArgs e)
        {
            if (isEmpty(number)) return;
            int a = Convert.ToInt32(number.Text);
            if (sender == summ)
                sumLabel.Text = ((a * (a + 1)) / 2).ToString();
            else if (sender == fact)
                factLabel.Text = (factorial(a)).ToString();
            else
                sqrtLabel.Text = (Math.Sqrt(a)).ToString();
            

        }
        private int factorial(int n)
        {
            if (n <= 1)
                return 1;
            return n * factorial(n - 1);
        }
        private bool isEmpty(TextBox t)
        {
            try
            {
                Convert.ToInt32(t.Text);
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("please enter number");
                t.Focus();
                return true;
            }
           
        }
    }
}
