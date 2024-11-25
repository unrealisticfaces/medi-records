namespace medi_records
{
    partial class forgotpassword
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 65);
            label1.Name = "label1";
            label1.Size = new Size(365, 23);
            label1.TabIndex = 0;
            label1.Text = "Please enter your username to search for your account.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(55, 175, 225);
            label2.Location = new Point(22, 31);
            label2.Name = "label2";
            label2.Size = new Size(191, 34);
            label2.TabIndex = 1;
            label2.Text = "Find your account";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(183, 183, 183);
            textBox1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Location = new Point(22, 133);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 29);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 107);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 3;
            label3.Text = "Search username";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 182);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 4;
            label4.Text = "New password";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(183, 183, 183);
            textBox2.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ControlText;
            textBox2.Location = new Point(22, 208);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 29);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 255);
            label5.Name = "label5";
            label5.Size = new Size(129, 23);
            label5.TabIndex = 6;
            label5.Text = "Confirm password";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(183, 183, 183);
            textBox3.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.ControlText;
            textBox3.Location = new Point(22, 281);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 29);
            textBox3.TabIndex = 7;
            // 
            // forgotpassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(418, 409);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Name = "forgotpassword";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
    }
}