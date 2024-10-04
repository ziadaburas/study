namespace زياد_عبده_احمد_محمد_ابوراس_4
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
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRightControl = new System.Windows.Forms.Button();
            this.btnUpControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(0, 0);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 25);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(0, 30);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 25);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnRightControl
            // 
            this.btnRightControl.Location = new System.Drawing.Point(320, 220);
            this.btnRightControl.Name = "btnRightControl";
            this.btnRightControl.Size = new System.Drawing.Size(75, 25);
            this.btnRightControl.TabIndex = 0;
            this.btnRightControl.Text = "start";
            this.btnRightControl.UseVisualStyleBackColor = true;
            // 
            // btnUpControl
            // 
            this.btnUpControl.Location = new System.Drawing.Point(240, 220);
            this.btnUpControl.Name = "btnUpControl";
            this.btnUpControl.Size = new System.Drawing.Size(75, 25);
            this.btnUpControl.TabIndex = 0;
            this.btnUpControl.Text = "start";
            this.btnUpControl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRightControl);
            this.Controls.Add(this.btnUpControl);
            this.Name = "Form1";
            this.Text = " زياد_عبده_احمد_محمد_ابوراس_4";
            this.Load += new System.EventHandler(this.onLoadForm);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRightControl;
        private System.Windows.Forms.Button btnUpControl;


    }
}

