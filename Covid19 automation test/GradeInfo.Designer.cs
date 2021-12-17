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
			this.SuspendLayout();
			// 
			// gradeNameLabel
			// 
			this.gradeNameLabel.AutoSize = true;
			this.gradeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gradeNameLabel.Location = new System.Drawing.Point(12, 9);
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
			this.studentsListBox.Location = new System.Drawing.Point(12, 37);
			this.studentsListBox.Name = "studentsListBox";
			this.studentsListBox.Size = new System.Drawing.Size(776, 400);
			this.studentsListBox.TabIndex = 1;
			// 
			// GradeInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.studentsListBox);
			this.Controls.Add(this.gradeNameLabel);
			this.Name = "GradeInfo";
			this.Text = "GradeInfo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GradeInfo_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label gradeNameLabel;
		private ListBox studentsListBox;
	}
}