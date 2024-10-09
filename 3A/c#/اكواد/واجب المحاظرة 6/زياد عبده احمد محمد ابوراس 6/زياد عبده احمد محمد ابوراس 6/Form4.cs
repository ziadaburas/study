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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void onBtnDrowClick(object sender, EventArgs e)
        {
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;
            Bitmap img = new Bitmap(w,h);
            for(int i = 0; i < w; i++)
            {
                img.SetPixel(i, 1, Color.Red);
                img.SetPixel(i, h-1, Color.Red);
            }
            for (int i = 0; i < h; i++)
            {
                img.SetPixel(1, i, Color.Red);
                img.SetPixel(w-1, i, Color.Red);
            }
            pictureBox1.Image = img;
        }

        private void onBtnClearClick(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
