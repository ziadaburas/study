using System;
using System.Windows.Forms;
namespace زياذ_عبده_احمد_محمد_ابوراس_2
{
    public class FormText:Form
    {

        const int size = 6;
        NumericText[,] nums = new NumericText[size, size];
        NumericText summation = new NumericText();
        RadioButton resulting = new RadioButton();
        Button[] btns = new Button[7];
        Random random = new Random();
        string[] options = { "القطر الرئيسي", "القطر الثانوي", "فوق الرئيسي", "ثجث الرئيسي", "فوق الثانوي", "ثجث الثانوي", "مسح الكل" };
        delegate bool condition(int i, int j, int length);
        delegate void manageText(int i, int j);
        condition[] conditions;
        public FormText()
        {
            conditions = new condition[] {
            mainDiameter,
            secondaryDiameter,
            aboveMainDiameter,
            underMainDiameter ,
            aboveSecondaryDiameter,
            underSecondaryDiameter,
            clearAll
            };
            summation.Enabled = false;
            summation.Left = resulting.Left = 500;
            summation.Top = 50;
            resulting.Text = "المجموع";
            resulting.CheckedChanged += summ;
            Controls.Add(summation);
            Controls.Add(resulting);

            Width = 750;
            initBtns();
        }
        void initBtns()
        {
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i] = new Button();
                btns[i].Text = options[i];
                btns[i].Width = 100;
                btns[i].Top = 200;
                btns[i].Left = i * 100;
                btns[i].Click += btnOptionClick;

            }
            Controls.AddRange(btns);
        }
        void addItems(condition cond)
        {
            clearItems();
            loopItems((i, j) => {
                if (cond(i, j, size))
                {
                    nums[i, j] = new NumericText($"{random.Next(0, 10)}", i, j);
                    Controls.Add(nums[i, j]);
                }
            }, false);



        }
        void clearItems()
        {
            loopItems((i, j) => nums[i, j].Dispose(), true);
        }
        void loopItems(manageText fun, bool isNull = true)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (isNull)
                    {
                        if (nums[i, j] == null) continue;

                    }

                    fun(i, j);
                }


            }
        }
        bool mainDiameter(int i, int j, int length) => (i == j);
        bool secondaryDiameter(int i, int j, int length) => (i + j == length - 1);
        bool aboveMainDiameter(int i, int j, int length) => (i < j);
        bool underMainDiameter(int i, int j, int length) => (i > j);
        bool aboveSecondaryDiameter(int i, int j, int length) => (i + j < length - 1);
        bool underSecondaryDiameter(int i, int j, int length) => (i + j > length - 1);
        bool clearAll(int i, int j, int length) => false;


        void btnOptionClick(object s, EventArgs e)
        {
            resulting.Checked = false;
            summation.Text = "";
            int width = ((Button)s).Width;
            int index = ((Button)s).Left / width;
            addItems(conditions[index]);

        }
        void summ(object s, EventArgs e)
        {
            int r = 0;
            loopItems((i, j) => r += Convert.ToInt32(nums[i, j].Text), true);
            summation.Text = $"{r}";
        }
    }
}
