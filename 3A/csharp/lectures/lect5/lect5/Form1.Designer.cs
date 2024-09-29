namespace lect5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myPanel1 = new System.Windows.Forms.Panel();
            this.green1 = new System.Windows.Forms.RadioButton();
            this.blue1 = new System.Windows.Forms.RadioButton();
            this.red1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.green2 = new System.Windows.Forms.RadioButton();
            this.blue2 = new System.Windows.Forms.RadioButton();
            this.red2 = new System.Windows.Forms.RadioButton();
            this.myText = new System.Windows.Forms.Label();
            this.myGroup = new System.Windows.Forms.GroupBox();
            this.num1 = new System.Windows.Forms.CheckBox();
            this.num2 = new System.Windows.Forms.CheckBox();
            this.num3 = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.result = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnVisable = new System.Windows.Forms.Button();
            this.btnUnvisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.myPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.myGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // myPanel1
            // 
            this.myPanel1.Controls.Add(this.green1);
            this.myPanel1.Controls.Add(this.blue1);
            this.myPanel1.Controls.Add(this.red1);
            this.myPanel1.Location = new System.Drawing.Point(12, 12);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(125, 136);
            this.myPanel1.TabIndex = 0;
            // 
            // green1
            // 
            this.green1.AutoSize = true;
            this.green1.Location = new System.Drawing.Point(29, 93);
            this.green1.Name = "green1";
            this.green1.Size = new System.Drawing.Size(49, 17);
            this.green1.TabIndex = 2;
            this.green1.TabStop = true;
            this.green1.Text = "اخضر";
            this.green1.UseVisualStyleBackColor = true;
            this.green1.CheckedChanged += new System.EventHandler(this.onCheckedColor);
            // 
            // blue1
            // 
            this.blue1.AutoSize = true;
            this.blue1.Location = new System.Drawing.Point(29, 57);
            this.blue1.Name = "blue1";
            this.blue1.Size = new System.Drawing.Size(46, 17);
            this.blue1.TabIndex = 1;
            this.blue1.TabStop = true;
            this.blue1.Text = "ازرق";
            this.blue1.UseVisualStyleBackColor = true;
            this.blue1.CheckedChanged += new System.EventHandler(this.onCheckedColor);
            // 
            // red1
            // 
            this.red1.AutoSize = true;
            this.red1.Location = new System.Drawing.Point(29, 21);
            this.red1.Name = "red1";
            this.red1.Size = new System.Drawing.Size(47, 17);
            this.red1.TabIndex = 0;
            this.red1.TabStop = true;
            this.red1.Text = "احمر";
            this.red1.UseVisualStyleBackColor = true;
            this.red1.CheckedChanged += new System.EventHandler(this.onCheckedColor);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.green2);
            this.panel1.Controls.Add(this.blue2);
            this.panel1.Controls.Add(this.red2);
            this.panel1.Location = new System.Drawing.Point(162, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 136);
            this.panel1.TabIndex = 3;
            // 
            // green2
            // 
            this.green2.AutoSize = true;
            this.green2.Location = new System.Drawing.Point(29, 93);
            this.green2.Name = "green2";
            this.green2.Size = new System.Drawing.Size(49, 17);
            this.green2.TabIndex = 2;
            this.green2.TabStop = true;
            this.green2.Text = "اخضر";
            this.green2.UseVisualStyleBackColor = true;
            this.green2.CheckedChanged += new System.EventHandler(this.onCheckedBgColor);
            // 
            // blue2
            // 
            this.blue2.AutoSize = true;
            this.blue2.Location = new System.Drawing.Point(29, 57);
            this.blue2.Name = "blue2";
            this.blue2.Size = new System.Drawing.Size(46, 17);
            this.blue2.TabIndex = 1;
            this.blue2.TabStop = true;
            this.blue2.Text = "ازرق";
            this.blue2.UseVisualStyleBackColor = true;
            this.blue2.CheckedChanged += new System.EventHandler(this.onCheckedBgColor);
            // 
            // red2
            // 
            this.red2.AutoSize = true;
            this.red2.Location = new System.Drawing.Point(29, 21);
            this.red2.Name = "red2";
            this.red2.Size = new System.Drawing.Size(47, 17);
            this.red2.TabIndex = 0;
            this.red2.TabStop = true;
            this.red2.Text = "احمر";
            this.red2.UseVisualStyleBackColor = true;
            this.red2.CheckedChanged += new System.EventHandler(this.onCheckedBgColor);
            // 
            // myText
            // 
            this.myText.AutoSize = true;
            this.myText.Location = new System.Drawing.Point(100, 174);
            this.myText.Name = "myText";
            this.myText.Size = new System.Drawing.Size(71, 13);
            this.myText.TabIndex = 4;
            this.myText.Text = "مثال على نص";
            // 
            // myGroup
            // 
            this.myGroup.Controls.Add(this.result);
            this.myGroup.Controls.Add(this.btnResult);
            this.myGroup.Controls.Add(this.num3);
            this.myGroup.Controls.Add(this.num2);
            this.myGroup.Controls.Add(this.num1);
            this.myGroup.Location = new System.Drawing.Point(325, 12);
            this.myGroup.Name = "myGroup";
            this.myGroup.Size = new System.Drawing.Size(122, 180);
            this.myGroup.TabIndex = 5;
            this.myGroup.TabStop = false;
            this.myGroup.Text = "اختر الارقام";
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(23, 19);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(44, 17);
            this.num1.TabIndex = 0;
            this.num1.Text = "100";
            this.num1.UseVisualStyleBackColor = true;
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(23, 57);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(44, 17);
            this.num2.TabIndex = 1;
            this.num2.Text = "200";
            this.num2.UseVisualStyleBackColor = true;
            // 
            // num3
            // 
            this.num3.AutoSize = true;
            this.num3.Location = new System.Drawing.Point(23, 93);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(44, 17);
            this.num3.TabIndex = 2;
            this.num3.Text = "300";
            this.num3.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(32, 151);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 6;
            this.result.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(23, 113);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "حساب";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.onClickResult);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(27, 200);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(75, 23);
            this.btnDisable.TabIndex = 6;
            this.btnDisable.Text = "معطل";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.onDisable);
            // 
            // btnVisable
            // 
            this.btnVisable.Location = new System.Drawing.Point(137, 229);
            this.btnVisable.Name = "btnVisable";
            this.btnVisable.Size = new System.Drawing.Size(75, 23);
            this.btnVisable.TabIndex = 7;
            this.btnVisable.Text = "مرئي";
            this.btnVisable.UseVisualStyleBackColor = true;
            this.btnVisable.Click += new System.EventHandler(this.onVisable);
            // 
            // btnUnvisable
            // 
            this.btnUnvisable.Location = new System.Drawing.Point(27, 229);
            this.btnUnvisable.Name = "btnUnvisable";
            this.btnUnvisable.Size = new System.Drawing.Size(75, 23);
            this.btnUnvisable.TabIndex = 8;
            this.btnUnvisable.Text = "مخفي";
            this.btnUnvisable.UseVisualStyleBackColor = true;
            this.btnUnvisable.Click += new System.EventHandler(this.onUnvisable);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(137, 200);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(75, 23);
            this.btnEnable.TabIndex = 9;
            this.btnEnable.Text = "مفعل";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.onEnable);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 277);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnUnvisable);
            this.Controls.Add(this.btnVisable);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.myGroup);
            this.Controls.Add(this.myText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.myPanel1);
            this.Name = "Form1";
            this.Text = "lect5";
            this.myPanel1.ResumeLayout(false);
            this.myPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.myGroup.ResumeLayout(false);
            this.myGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel myPanel1;
        private System.Windows.Forms.RadioButton green1;
        private System.Windows.Forms.RadioButton blue1;
        private System.Windows.Forms.RadioButton red1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton green2;
        private System.Windows.Forms.RadioButton blue2;
        private System.Windows.Forms.RadioButton red2;
        private System.Windows.Forms.Label myText;
        private System.Windows.Forms.GroupBox myGroup;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.CheckBox num3;
        private System.Windows.Forms.CheckBox num2;
        private System.Windows.Forms.CheckBox num1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnVisable;
        private System.Windows.Forms.Button btnUnvisable;
        private System.Windows.Forms.Button btnEnable;
    }
}

