using System;
using System.Windows.Forms;
using System.Drawing;
namespace زياد_عبده_احمد_محمد_ابوراس_1
{
    public class ComboColors : ComboBox
    {
        Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Black };
        public ComboColors(int t = 0, int l = 0)
        {
            Top = t;
            Left = l;
            DropDownStyle = ComboBoxStyle.DropDownList;
            Items.AddRange(new string[] { "red", "green", "blue", "black" });
            SelectedIndexChanged += (s, e) => this.FindForm().BackColor = colors[SelectedIndex];
        }
    }
}

