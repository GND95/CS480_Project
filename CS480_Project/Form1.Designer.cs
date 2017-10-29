namespace CS480_Project
{
    partial class mainMenuForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.mailButton = new System.Windows.Forms.Button();
            this.emailBody = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(283, 46);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Internet-Related Issue";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radioButton1.Location = new System.Drawing.Point(303, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 30);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Select";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox2.Location = new System.Drawing.Point(3, 55);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(283, 46);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Printer/Scanner Issue";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radioButton2.Location = new System.Drawing.Point(303, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 30);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Select";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox3.Location = new System.Drawing.Point(3, 107);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(283, 46);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "SMART Board Issue";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radioButton3.Location = new System.Drawing.Point(303, 113);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 30);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Select";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox4.Location = new System.Drawing.Point(3, 159);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(283, 46);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Sound Issue";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radioButton4.Location = new System.Drawing.Point(303, 169);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(91, 30);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Select";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox5.Location = new System.Drawing.Point(3, 211);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(421, 73);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Other (Write in below and select your name from the drop-down dialog box)";
            // 
            // mailButton
            // 
            this.mailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.mailButton.Location = new System.Drawing.Point(303, 506);
            this.mailButton.Name = "mailButton";
            this.mailButton.Size = new System.Drawing.Size(121, 68);
            this.mailButton.TabIndex = 10;
            this.mailButton.Text = "Send";
            this.mailButton.UseVisualStyleBackColor = true;
            this.mailButton.Click += new System.EventHandler(this.mailButton_Click);
            // 
            // emailBody
            // 
            this.emailBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailBody.Location = new System.Drawing.Point(3, 290);
            this.emailBody.Name = "emailBody";
            this.emailBody.Size = new System.Drawing.Size(294, 284);
            this.emailBody.TabIndex = 11;
            this.emailBody.Text = "Describe your issue";
            this.emailBody.Click += new System.EventHandler(this.emailBody_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(303, 336);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(303, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select Name:";
            // 
            // mainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.emailBody);
            this.Controls.Add(this.mailButton);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Name = "mainMenuForm";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button mailButton;
        private System.Windows.Forms.RichTextBox emailBody;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

