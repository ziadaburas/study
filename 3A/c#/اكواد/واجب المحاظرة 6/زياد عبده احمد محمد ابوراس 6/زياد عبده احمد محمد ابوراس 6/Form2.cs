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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void onBtnClearClick(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void onBtnShowClick(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(@pathText.Text.Trim());
            }catch(Exception ex)
            {
                MessageBox.Show("please enter valid path");
                pathText.Focus();
            }
        }
    }
}
