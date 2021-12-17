namespace Covid19_automation_test
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
			this.usernameInput = new System.Windows.Forms.TextBox();
			this.passwordInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.showPasswordButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// usernameInput
			// 
			this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.usernameInput.ForeColor = System.Drawing.Color.Black;
			this.usernameInput.Location = new System.Drawing.Point(185, 111);
			this.usernameInput.Name = "usernameInput";
			this.usernameInput.Size = new System.Drawing.Size(397, 20);
			this.usernameInput.TabIndex = 0;
			// 
			// passwordInput
			// 
			this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.passwordInput.ForeColor = System.Drawing.Color.Black;
			this.passwordInput.Location = new System.Drawing.Point(201, 136);
			this.passwordInput.Name = "passwordInput";
			this.passwordInput.PasswordChar = '*';
			this.passwordInput.Size = new System.Drawing.Size(219, 20);
			this.passwordInput.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(147, 114);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Име:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(147, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Парола:";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(254, 185);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 60);
			this.button1.TabIndex = 4;
			this.button1.Text = "Влезни";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(66, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(553, 31);
			this.label3.TabIndex = 5;
			this.label3.Text = "Добре Дошли в COVID-19 Тест Системата";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(-14, 340);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(920, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "=================================================================================" +
    "=================================\r\n";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(-86, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(920, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "=================================================================================" +
    "=================================\r\n";
			// 
			// showPasswordButton
			// 
			this.showPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.showPasswordButton.Location = new System.Drawing.Point(426, 134);
			this.showPasswordButton.Name = "showPasswordButton";
			this.showPasswordButton.Size = new System.Drawing.Size(156, 23);
			this.showPasswordButton.TabIndex = 8;
			this.showPasswordButton.Text = "Покажи\\Скрии Паролата";
			this.showPasswordButton.UseVisualStyleBackColor = true;
			this.showPasswordButton.Click += new System.EventHandler(this.showPasswordButton_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 327);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(135, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Made by Alex and Georgi©";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(686, 390);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.showPasswordButton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passwordInput);
			this.Controls.Add(this.usernameInput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Covid19 automation test";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private TextBox usernameInput;
        private TextBox passwordInput;
        private Label label1;
        private Label label2;
        private Button button1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Button showPasswordButton;
		private Label label6;
	}
}