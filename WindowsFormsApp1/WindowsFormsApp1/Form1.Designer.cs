
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textusername = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texthour = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textminute = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.texthour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textminute)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(307, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(374, 142);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(125, 27);
            this.textusername.TabIndex = 2;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(374, 208);
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '*';
            this.textpassword.Size = new System.Drawing.Size(125, 27);
            this.textpassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(281, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(281, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(307, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "JLU本科生每日自动打卡";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Time";
            // 
            // texthour
            // 
            this.texthour.Location = new System.Drawing.Point(374, 265);
            this.texthour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.texthour.Name = "texthour";
            this.texthour.Size = new System.Drawing.Size(44, 27);
            this.texthour.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = ":";
            // 
            // textminute
            // 
            this.textminute.Location = new System.Drawing.Point(443, 265);
            this.textminute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.textminute.Name = "textminute";
            this.textminute.Size = new System.Drawing.Size(41, 27);
            this.textminute.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.textminute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.texthour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.texthour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textminute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown texthour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown minute;
        private System.Windows.Forms.NumericUpDown textminute;
    }
}

