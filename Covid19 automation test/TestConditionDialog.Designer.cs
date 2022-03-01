namespace Covid19_automation_test
{
    partial class TestConditionDialog
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
            this.posButton = new System.Windows.Forms.Button();
            this.negButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Изберете резултата от теста на";
            // 
            // posButton
            // 
            this.posButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.posButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.posButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.posButton.Location = new System.Drawing.Point(12, 68);
            this.posButton.Name = "posButton";
            this.posButton.Size = new System.Drawing.Size(185, 153);
            this.posButton.TabIndex = 3;
            this.posButton.Text = "Позитивен";
            this.posButton.UseVisualStyleBackColor = true;
            this.posButton.Click += new System.EventHandler(this.posButton_Click);
            // 
            // negButton
            // 
            this.negButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.negButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.negButton.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.negButton.Location = new System.Drawing.Point(219, 68);
            this.negButton.Name = "negButton";
            this.negButton.Size = new System.Drawing.Size(185, 153);
            this.negButton.TabIndex = 4;
            this.negButton.Text = "Отрицателен";
            this.negButton.UseVisualStyleBackColor = true;
            this.negButton.Click += new System.EventHandler(this.negButton_Click);
            // 
            // TestConditionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 245);
            this.Controls.Add(this.negButton);
            this.Controls.Add(this.posButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(445, 284);
            this.MinimumSize = new System.Drawing.Size(445, 284);
            this.Name = "TestConditionDialog";
            this.Text = "Информация за Тест";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button posButton;
        private Button negButton;
    }
}