using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onCheckedBgColor(object sender, EventArgs e)
        {
            if (sender == red2)
                myText.BackColor = Color.Red;
            else if (sender == green2)
                myText.BackColor = Color.Green;
            else 
                myText.BackColor = Color.Blue;
        }

        private void onCheckedColor(object sender, EventArgs e)
        {
            if (sender == red1)
                myText.ForeColor = Color.Red;
            else if (sender == green1)
                myText.ForeColor = Color.Green;
            else
                myText.ForeColor = Color.Blue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void onClickResult(object sender, EventArgs e)
        {
            int z = 0;
            z += isChecked(num1);
            z += isChecked(num2);
            z += isChecked(num3);
            if (z != 0)
                result.Text = z.ToString();
            else
                result.Text = "لم يتم اختيار اي قيمة";



        }
        private int isChecked(CheckBox c)
        {
            if (c.Checked)
                return Convert.ToInt32(c.Text);
            return 0;
        }
        private void onEnable(object sender, EventArgs e)
        {
            myGroup.Enabled = true;
        }
        private void onDisable(object sender, EventArgs e)
        {
            myGroup.Enabled = false;
        }
        private void onVisable(object sender, EventArgs e)
        {
            myGroup.Visible = true;
        }
        private void onUnvisable(object sender, EventArgs e)
        {
            myGroup.Visible = false;
        }
    }
}
