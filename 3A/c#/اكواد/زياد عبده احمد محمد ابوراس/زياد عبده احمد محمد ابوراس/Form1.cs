using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace زياد_عبده_احمد_محمد_ابوراس
{
    public partial class Form1 : Form
    {
        private string op = "+-*/";
        public Form1()
        {
            InitializeComponent();
        }

        private void onResClick(object sender, EventArgs e)
        {
            if (isEmpty(num1) || isEmpty(op1) || isEmpty(num2) || isEmpty(op2) || isEmpty(num3)) return;
            int a = Convert.ToInt32(num1.Text.Trim());
            int b = Convert.ToInt32(num2.Text.Trim());
            int c = Convert.ToInt32(num3.Text.Trim());


            char o1 = op1.Text.Trim()[0];
            char o2 = op2.Text.Trim()[0];

            double result;
            if (getIndex(op, o2) < getIndex(op, o1))
            {
                result = getResult(a, o1, b);
                result = getResult(result, o2, c);
            }
            else
            {

                result = getResult(b, o2, c);
                result = getResult(a, o1, result);
            }
            res.Text = result.ToString();


        }

        private int getIndex(string s, char key)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == key)
                    return i;
            }

            return -1;
        }



        private void onEditNumber(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if ((k >= 48 && k <= 57) || k == 8) e.Handled = false;
            else e.Handled = true;
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {


        }
        private bool isEmpty(TextBox t)
        {
            if (t.Text.Trim() == "")
            {
                MessageBox.Show("please enter number");
                t.Focus();
                return true;
            }
            return false;
        }
        private void onEditOperator(object sender, KeyPressEventArgs e)
        {

            if ((((TextBox)sender).Text.Length <= 0 && getIndex(op, e.KeyChar) != -1) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;

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

        private void onLoadForm(object sender, EventArgs e)
        {
            this.Text = " زياد ابوراس - الواجب رقم 1";
        }

        private void onCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

