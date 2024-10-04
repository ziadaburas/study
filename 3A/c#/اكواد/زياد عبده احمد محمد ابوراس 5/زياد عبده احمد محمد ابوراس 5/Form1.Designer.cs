namespace زياد_عبده_احمد_محمد_ابوراس_5
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
            this.myPanel = new System.Windows.Forms.Panel();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.num1Label = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.resLabel = new System.Windows.Forms.Label();
            this.operLabel = new System.Windows.Forms.Label();
            this.resultOperLabel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.myPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // myPanel
            // 
            this.myPanel.Controls.Add(this.btnRes);
            this.myPanel.Controls.Add(this.btnClose);
            this.myPanel.Controls.Add(this.resultOperLabel);
            this.myPanel.Controls.Add(this.operLabel);
            this.myPanel.Controls.Add(this.resLabel);
            this.myPanel.Controls.Add(this.num2Label);
            this.myPanel.Controls.Add(this.num1Label);
            this.myPanel.Controls.Add(this.result);
            this.myPanel.Controls.Add(this.num2);
            this.myPanel.Controls.Add(this.num1);
            this.myPanel.Location = new System.Drawing.Point(10, 50);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(380, 100);
            this.myPanel.TabIndex = 0;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(280, 20);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 20);
            this.num1.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(140, 20);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 20);
            this.num2.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(0, 20);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 2;
            // 
            // num1Label
            // 
            this.num1Label.AutoSize = true;
            this.num1Label.Location = new System.Drawing.Point(280, 0);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(100, 15);
            this.num1Label.TabIndex = 3;
            this.num1Label.Text = "الرقم الاول";
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.Location = new System.Drawing.Point(140, 0);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(100, 15);
            this.num2Label.TabIndex = 4;
            this.num2Label.Text = "الرقم الثاني";
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Location = new System.Drawing.Point(0, 0);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(100, 15);
            this.resLabel.TabIndex = 5;
            this.resLabel.Text = "الناتج";
            // 
            // operLabel
            // 
            this.operLabel.AutoSize = true;
            this.operLabel.Location = new System.Drawing.Point(260, 20);
            this.operLabel.Name = "operLabel";
            this.operLabel.Size = new System.Drawing.Size(20, 15);
            this.operLabel.TabIndex = 6;
            this.operLabel.Text = "/";
            // 
            // resultOperLabel
            // 
            this.resultOperLabel.AutoSize = true;
            this.resultOperLabel.Location = new System.Drawing.Point(110, 20);
            this.resultOperLabel.Name = "resultOperLabel";
            this.resultOperLabel.Size = new System.Drawing.Size(35, 13);
            this.resultOperLabel.TabIndex = 7;
            this.resultOperLabel.Text = "=";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 25);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "جمع";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(100, 0);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 25);
            this.btnSub.TabIndex = 9;
            this.btnSub.Text = "طرح";
            this.btnSub.UseVisualStyleBackColor = true;
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(200, 0);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 25);
            this.btnMul.TabIndex = 1;
            this.btnMul.Text = "ضرب";
            this.btnMul.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(300, 0);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 25);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "قسمة";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(280, 60);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(100, 25);
            this.btnRes.TabIndex = 3;
            this.btnRes.Text = "حساب";
            this.btnRes.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(0, 60);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.myPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.myPanel.ResumeLayout(false);
            this.myPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel myPanel;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label resultOperLabel;
        private System.Windows.Forms.Label operLabel;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.Label num1Label;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnClose;
    }
}

