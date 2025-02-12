using System;
using System.Windows.Forms;
using System.Drawing;

namespace زياد_عبده_احمد_محمد_ابوراس_3
{
    public class Form2Lab12 : Form
    {
        TextBox[,] texts;

        TextBox rows = new TextBox();
        TextBox columns = new TextBox();
        Label labelRows = new Label();
        Label labelColumns = new Label();
        Button btn = new Button();
        public Form2Lab12()
        {
            Width = 500;
            Height = 300;

            labelRows.Text = "rows : ";
            labelRows.Top = 250;
            labelRows.Left = 0;

            rows.Top = 250;
            rows.Left = 50;


            labelColumns.Text = "columns : ";
            labelColumns.Top = 250;
            labelColumns.Left = 180;



            columns.Top = 250;
            columns.Left = 250;


            btn.Text = " generate";
            btn.Top = 250;
            btn.Left = 400;
            btn.Click += onChecked;


            Controls.Add(rows);
            Controls.Add(columns);
            Controls.Add(labelRows);
            Controls.Add(labelColumns);

            Controls.Add(btn);

        }
        void onChecked(object s, EventArgs e)
        {
            clearValuea();
            try
            {
                int x = Convert.ToInt32(rows.Text);
                int y = Convert.ToInt32(columns.Text);
                if (x <= 0 || x > 10 || y <= 0 || y > 10) throw new Exception();


                texts = new TextBox[x, y];
                for (int i = 0; i < x; i++)

                {
                    for (int j = 0; j < y; j++)
                    {
                        texts[i, j] = new TextBox();
                        texts[i, j].Multiline = true;
                        texts[i, j].Width = 40;
                        texts[i, j].Height = 40;
                        texts[i, j].Top = i * 40;
                        texts[i, j].Left = j * 40;
                        Controls.Add(texts[i, j]);
                    }
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
            for (int i = 0; i < texts.GetLength(0); i++)
            {
                for (int j = 0; j < texts.GetLength(1); j++)
                    if (texts[i, j] != null)
                        texts[i, j].Dispose();
            }
        }
    }
}
