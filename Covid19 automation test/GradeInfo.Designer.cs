namespace Covid19_automation_test
{
	partial class GradeInfo
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
            this.gradeNameLabel = new System.Windows.Forms.Label();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.опцийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradeNameLabel
            // 
            this.gradeNameLabel.AutoSize = true;
            this.gradeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gradeNameLabel.Location = new System.Drawing.Point(14, 24);
            this.gradeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gradeNameLabel.Name = "gradeNameLabel";
            this.gradeNameLabel.Size = new System.Drawing.Size(64, 25);
            this.gradeNameLabel.TabIndex = 0;
            this.gradeNameLabel.Text = "label1";
            // 
            // studentsListBox
            // 
            this.studentsListBox.BackColor = System.Drawing.Color.Silver;
            this.studentsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentsListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.ItemHeight = 25;
            this.studentsListBox.Items.AddRange(new object[] {
            "dsff",
            "ddsf",
            "sdf",
            "sdf",
            "dsf",
            "ds",
            "fds",
            "f",
            "",
            "f",
            "s",
            "f",
            "s",
            "f",
            "s"});
            this.studentsListBox.Location = new System.Drawing.Point(14, 57);
            this.studentsListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(905, 450);
            this.studentsListBox.TabIndex = 1;
            this.studentsListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.studentsListBox_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опцийToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // опцийToolStripMenuItem
            // 
            this.опцийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendEmail});
            this.опцийToolStripMenuItem.Name = "опцийToolStripMenuItem";
            this.опцийToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.опцийToolStripMenuItem.Text = "Опций";
            // 
            // sendEmail
            // 
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(199, 22);
            this.sendEmail.Text = "Пращане на резултати";
            this.sendEmail.Click += new System.EventHandler(this.sendEmail_Click);
            // 
            // GradeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.gradeNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "GradeInfo";
            this.Text = "Ученици в класовете";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GradeInfo_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Label gradeNameLabel;
		private ListBox studentsListBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem опцийToolStripMenuItem;
        private ToolStripMenuItem sendEmail;
    }
}