using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace زياد_عبده_احمد_محمد_ابوراس_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Load += onLoadForm;
            btnAdd.Click += onBtnClick;
            btnSub.Click += onBtnClick;
            btnMul.Click += onBtnClick;
            btnDiv.Click += onBtnClick;
            btnRes.Click += onBtnClick;
            btnClose.Click += onBtnCloseClick;

        }
        private void onLoadForm(object sender, EventArgs e)
        {
            onBtnCloseClick(null, null);
        }

        private void onBtnCloseClick(object sender, EventArgs e)
        {
            Height = 75;
            myPanel.Visible = false;

        }
        private void onBtnClick(object sender, EventArgs e)
        {
            if (sender == btnAdd)
                changePanel("+", Color.Azure);
            else if (sender == btnSub)
                changePanel("-", Color.Bisque);
            else if (sender == btnMul)
                changePanel("*", Color.BurlyWood);
            else if (sender == btnDiv)
                changePanel("/", Color.LightGoldenrodYellow);
            else if (sender == btnRes)
                getResult();



        }
        private void changePanel(string l, Color c)
        {
            Height = 200;
            myPanel.Visible = true;
            myPanel.BackColor = c;
            operLabel.Text = l;
            num1.Text = num2.Text = result.Text = null;
        }
        private void getResult()
        {
            if (isEmpty(num1) || isEmpty(num2)) return;
            int a = Convert.ToInt32(num1.Text.Trim());
            int b = Convert.ToInt32(num2.Text.Trim());

            char op = operLabel.Text[0];
            double z;


            switch (op)
            {
                case '+':
                    z = a + b;
                    break;
                case '-':
                    z = a - b;
                    break;
                case '*':
                    z = a * b;
                    break;
                case '/':
                    if (b != 0) z = a / b;
                    else z = 0;
                    break;
                default:
                    z = 0;
                    break;
            }
            result.Text = z.ToString();

        }
        private bool isEmpty(TextBox t)
        {
            try
            {
                Convert.ToInt32(t.Text);
                return false;
            }
            catch (Exception exp)
            {
                MessageBox.Show("please enter number");
                t.Focus();
                return true;
            }

        }

    }
}
