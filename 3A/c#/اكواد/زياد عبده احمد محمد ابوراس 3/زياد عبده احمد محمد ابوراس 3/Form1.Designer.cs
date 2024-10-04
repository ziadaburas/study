namespace زياد_عبده_احمد_محمد_ابوراس_3
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
            this.number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.summ = new System.Windows.Forms.Button();
            this.fact = new System.Windows.Forms.Button();
            this.sqrtt = new System.Windows.Forms.Button();
            this.sumLabel = new System.Windows.Forms.Label();
            this.factLabel = new System.Windows.Forms.Label();
            this.sqrtLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(37, 28);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 20);
            this.number.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ادخل العدد";
            // 
            // summ
            // 
            this.summ.Location = new System.Drawing.Point(104, 84);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(75, 23);
            this.summ.TabIndex = 2;
            this.summ.Text = "المجموع";
            this.summ.UseVisualStyleBackColor = true;
            // 
            // fact
            // 
            this.fact.Location = new System.Drawing.Point(104, 142);
            this.fact.Name = "fact";
            this.fact.Size = new System.Drawing.Size(75, 23);
            this.fact.TabIndex = 3;
            this.fact.Text = "المضروب";
            this.fact.UseVisualStyleBackColor = true;
            // 
            // sqrtt
            // 
            this.sqrtt.Location = new System.Drawing.Point(104, 200);
            this.sqrtt.Name = "sqrtt";
            this.sqrtt.Size = new System.Drawing.Size(75, 23);
            this.sqrtt.TabIndex = 4;
            this.sqrtt.Text = "الجذر";
            this.sqrtt.UseVisualStyleBackColor = true;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(44, 84);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(35, 13);
            this.sumLabel.TabIndex = 5;
            this.sumLabel.Text = "label2";
            // 
            // factLabel
            // 
            this.factLabel.AutoSize = true;
            this.factLabel.Location = new System.Drawing.Point(44, 147);
            this.factLabel.Name = "factLabel";
            this.factLabel.Size = new System.Drawing.Size(35, 13);
            this.factLabel.TabIndex = 6;
            this.factLabel.Text = "label3";
            // 
            // sqrtLabel
            // 
            this.sqrtLabel.AutoSize = true;
            this.sqrtLabel.Location = new System.Drawing.Point(44, 205);
            this.sqrtLabel.Name = "sqrtLabel";
            this.sqrtLabel.Size = new System.Drawing.Size(35, 13);
            this.sqrtLabel.TabIndex = 7;
            this.sqrtLabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 261);
            this.Controls.Add(this.sqrtLabel);
            this.Controls.Add(this.factLabel);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.sqrtt);
            this.Controls.Add(this.fact);
            this.Controls.Add(this.summ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.onLoadForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button summ;
        private System.Windows.Forms.Button fact;
        private System.Windows.Forms.Button sqrtt;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label factLabel;
        private System.Windows.Forms.Label sqrtLabel;
    }
}


