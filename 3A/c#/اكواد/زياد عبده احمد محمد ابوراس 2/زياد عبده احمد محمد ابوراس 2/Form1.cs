using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace زياد_عبده_احمد_محمد_ابوراس_2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void onLOadForm(object sender, EventArgs e)
        {
            opers.Items.Add("+");
            opers.Items.Add("-");
            opers.Items.Add("*");
            opers.Items.Add("/");
            opers.SelectedValueChanged += onSelectOper;
            btnRes.Click += onSelectOper;
            btnClear.Click += onBtnClearClick;
            btnClose.Click += onBtnCloseClick;
        }
        private void onBtnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void onBtnClearClick(object sender, EventArgs e)
        {
            num1.Text = num2.Text = result.Text = null;
        }
        private void onSelectOper(object sender, EventArgs e)
        {
            if (isEmpty(num1) || opers.SelectedIndex == -1 || isEmpty(num2))
                return;
            int a = Convert.ToInt32(num1.Text.Trim());
            int b = Convert.ToInt32(num2.Text.Trim());

            char op = opers.SelectedItem.ToString()[0];
            double z = getResult(a, op, b);

            result.Text = z.ToString();

        }
        private bool isEmpty(TextBox t)
        {
            try
            {
                Convert.ToInt32(t.Text);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("please enter number");
                t.Focus();
                return true;
            }

        }
        private double getResult(double a, char oper, double b)
        {
            switch (oper)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b != 0)
                        return a / b;
                    return 0;
                default:
                    return 0;
            }
        }
    }
}
