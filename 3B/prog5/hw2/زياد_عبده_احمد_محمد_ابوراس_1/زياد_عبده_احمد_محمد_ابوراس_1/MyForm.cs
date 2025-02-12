using System;
using System.Windows.Forms;
namespace زياد_عبده_احمد_محمد_ابوراس_1
{
    public class MyForm:Form
    {

            CloseBtn btn1 = new CloseBtn();
            ColorBtn colorBtn = new ColorBtn();
            UpperText upperText = new UpperText(30, 0);
            ComboColors comboColors = new ComboColors(0, 80);
            CleanTextBtn cleanTextBtn = new CleanTextBtn(30, 120);
            SpacingText spacingText = new SpacingText(120);
            MangeSpaceText mangeSpaceText = new MangeSpaceText(150);
            CustomBtn customBtn;
            Panel p = new Panel();

            public MyForm()
            {
                Width = 400;
                customBtn = new CustomBtn(120, 30, (sender, e) => MessageBox.Show("click custom btn"), 60);
                Controls.Add(btn1);
                Controls.Add(colorBtn);
                Controls.Add(upperText);
                Controls.Add(comboColors);
                Controls.Add(customBtn);
                Controls.Add(cleanTextBtn);
                Controls.Add(spacingText);
                Controls.Add(mangeSpaceText);
                initPnel();
            }
            void initPnel()
            {
                p.Width = 100;
                p.Height = 100;
                p.Left = 250;
                p.Controls.Add(new NumsText());
                p.Controls.Add(new NumsText(35));
                p.Controls.Add(new NumsText(70));

                p.Controls.Add(new NumsText(0, 35));
                p.Controls.Add(new NumsText(35, 35));
                p.Controls.Add(new NumsText(70, 35));
                p.Controls.Add(new NumsText(0, 70, "text1"));
                p.Controls.Add(new NumsText(35, 70, "text2"));
                p.Controls.Add(new NumsText(70, 70, "text3"));
                Controls.Add(p);
            }


    }
}
