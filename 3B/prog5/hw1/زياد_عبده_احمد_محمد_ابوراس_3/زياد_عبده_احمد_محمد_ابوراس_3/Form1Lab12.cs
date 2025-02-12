using System;
using System.Windows.Forms;
using System.Drawing;

namespace زياد_عبده_احمد_محمد_ابوراس_3
{
    public class Form1Lab12 : Form
    {
        TextBox[] texts;
        RadioButton row = new RadioButton();
        RadioButton column = new RadioButton();
        TextBox numberOfBoxes = new TextBox();
        Label label = new Label();
        Button btn = new Button();
        Panel panel = new Panel();
        public Form1Lab12()
        {
            Width = 500;
            Height = 300;

            row.Text = "horizontal";
            row.Top = 0;
            row.Left = 0;
            row.Checked = true;

            column.Text = "vertical";
            column.Top = 0;
            column.Left = 100;


            panel.Width = 200;
            panel.Height = 100;
            panel.Top = 250;
            panel.Controls.Add(row);
            panel.Controls.Add(column);

            numberOfBoxes.Top = 250;
            numberOfBoxes.Left = 250;

            label.Text = "length : ";
            label.Top = 250;
            label.Left = 200;

            btn.Text = " generate";
            btn.Top = 250;
            btn.Left = 400;
            btn.Click += onChecked;


            Controls.Add(panel);
            Controls.Add(numberOfBoxes);
            Controls.Add(label);
            Controls.Add(btn);

        }
        void onChecked(object s, EventArgs e)
        {
            clearValuea();
            try
            {
                int num = Convert.ToInt32(numberOfBoxes.Text);
                if (num <= 0 || num > 10) throw new Exception();


                texts = new TextBox[num];
                for (int i = 0; i < num; i++)
                {
                    texts[i] = new TextBox();
                    texts[i].Multiline = true;
                    texts[i].Width = 40;
                    texts[i].Height = 40;
                    texts[i].Top = Convert.ToInt32(column.Checked) * i * 40;
                    texts[i].Left = Convert.ToInt32(row.Checked) * i * 40;
                    Controls.Add(texts[i]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("enter valid value 1-10");

            }
        }
        void clearValuea()
        {
            if (texts == null) return;
            for (int i = 0; i < texts.Length; i++)
            {
                if (texts[i] != null)
                    texts[i].Dispose();
            }
        }
    }
}
