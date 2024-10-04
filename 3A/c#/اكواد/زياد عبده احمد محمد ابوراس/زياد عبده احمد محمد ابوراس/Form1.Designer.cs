namespace زياد_عبده_احمد_محمد_ابوراس
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
                this.label1 = new System.Windows.Forms.Label();
                this.num1 = new System.Windows.Forms.TextBox();
                this.op1 = new System.Windows.Forms.TextBox();
                this.num2 = new System.Windows.Forms.TextBox();
                this.op2 = new System.Windows.Forms.TextBox();
                this.num3 = new System.Windows.Forms.TextBox();
                this.res = new System.Windows.Forms.TextBox();
                this.label2 = new System.Windows.Forms.Label();
                this.label3 = new System.Windows.Forms.Label();
                this.label4 = new System.Windows.Forms.Label();
                this.label5 = new System.Windows.Forms.Label();
                this.label6 = new System.Windows.Forms.Label();
                this.btnRes = new System.Windows.Forms.Button();
                this.btnClose = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(152, 19);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(55, 13);
                this.label1.TabIndex = 0;
                this.label1.Text = "العدد الاول";
                // 
                // num1
                // 
                this.num1.Location = new System.Drawing.Point(16, 16);
                this.num1.Name = "num1";
                this.num1.Size = new System.Drawing.Size(100, 20);
                this.num1.TabIndex = 1;
                this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
                this.num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onEditNumber);
                // 
                // op1
                // 
                this.op1.Location = new System.Drawing.Point(16, 51);
                this.op1.Name = "op1";
                this.op1.Size = new System.Drawing.Size(100, 20);
                this.op1.TabIndex = 2;
                this.op1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onEditOperator);
                // 
                // num2
                // 
                this.num2.Location = new System.Drawing.Point(16, 88);
                this.num2.Name = "num2";
                this.num2.Size = new System.Drawing.Size(100, 20);
                this.num2.TabIndex = 3;
                this.num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onEditNumber);
                // 
                // op2
                // 
                this.op2.Location = new System.Drawing.Point(16, 123);
                this.op2.Name = "op2";
                this.op2.Size = new System.Drawing.Size(100, 20);
                this.op2.TabIndex = 4;
                this.op2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onEditOperator);
                // 
                // num3
                // 
                this.num3.Location = new System.Drawing.Point(16, 156);
                this.num3.Name = "num3";
                this.num3.Size = new System.Drawing.Size(100, 20);
                this.num3.TabIndex = 5;
                this.num3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onEditNumber);
                // 
                // res
                // 
                this.res.Enabled = false;
                this.res.Location = new System.Drawing.Point(16, 186);
                this.res.Name = "res";
                this.res.Size = new System.Drawing.Size(100, 20);
                this.res.TabIndex = 6;
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(152, 54);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(40, 13);
                this.label2.TabIndex = 7;
                this.label2.Text = "العملية";
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(157, 91);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(60, 13);
                this.label3.TabIndex = 8;
                this.label3.Text = "العدد الثاني";
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(157, 130);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(40, 13);
                this.label4.TabIndex = 9;
                this.label4.Text = "العملية";
                // 
                // label5
                // 
                this.label5.AutoSize = true;
                this.label5.Location = new System.Drawing.Point(157, 163);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(59, 13);
                this.label5.TabIndex = 10;
                this.label5.Text = "العدد الثالث";
                // 
                // label6
                // 
                this.label6.AutoSize = true;
                this.label6.Location = new System.Drawing.Point(157, 193);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(31, 13);
                this.label6.TabIndex = 11;
                this.label6.Text = "الناتج";
                // 
                // btnRes
                // 
                this.btnRes.Location = new System.Drawing.Point(155, 226);
                this.btnRes.Name = "btnRes";
                this.btnRes.Size = new System.Drawing.Size(75, 23);
                this.btnRes.TabIndex = 12;
                this.btnRes.Text = "حساب";
                this.btnRes.UseVisualStyleBackColor = true;
                this.btnRes.Click += new System.EventHandler(this.onResClick);
                // 
                // btnClose
                // 
                this.btnClose.Location = new System.Drawing.Point(16, 226);
                this.btnClose.Name = "btnClose";
                this.btnClose.Size = new System.Drawing.Size(100, 23);
                this.btnClose.TabIndex = 13;
                this.btnClose.Text = "اغلاق";
                this.btnClose.UseVisualStyleBackColor = true;
                this.btnClose.Click += new System.EventHandler(this.onCloseClick);
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(284, 261);
                this.Controls.Add(this.btnClose);
                this.Controls.Add(this.btnRes);
                this.Controls.Add(this.label6);
                this.Controls.Add(this.label5);
                this.Controls.Add(this.label4);
                this.Controls.Add(this.label3);
                this.Controls.Add(this.label2);
                this.Controls.Add(this.res);
                this.Controls.Add(this.num3);
                this.Controls.Add(this.op2);
                this.Controls.Add(this.num2);
                this.Controls.Add(this.op1);
                this.Controls.Add(this.num1);
                this.Controls.Add(this.label1);
                this.Name = "Form1";
                this.Text = "Form1";
                this.Load += new System.EventHandler(this.onLoadForm);
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.TextBox num1;
            private System.Windows.Forms.TextBox op1;
            private System.Windows.Forms.TextBox num2;
            private System.Windows.Forms.TextBox op2;
            private System.Windows.Forms.TextBox num3;
            private System.Windows.Forms.TextBox res;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Label label6;
            private System.Windows.Forms.Button btnRes;
            private System.Windows.Forms.Button btnClose;
        }
    


}

