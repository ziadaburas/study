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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void onBtnOpenClick(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.Filter = "Imgs|*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                Bitmap img = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = img;
                imgPathLabel.Text = openFileDialog1.FileName;


            }
        }

        private void onBtnClearClick(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            imgPathLabel.Text = null;
        }
    }
}
