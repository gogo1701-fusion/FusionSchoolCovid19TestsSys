﻿namespace Covid19_automation_test
{
    partial class Testing
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Testing));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.пращанеНаТестовеПрезЕмайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nameLabel = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(686, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пращанеНаТестовеПрезЕмайлToolStripMenuItem,
            this.изходToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(52, 22);
			this.toolStripDropDownButton1.Text = "Опций";
			// 
			// пращанеНаТестовеПрезЕмайлToolStripMenuItem
			// 
			this.пращанеНаТестовеПрезЕмайлToolStripMenuItem.Name = "пращанеНаТестовеПрезЕмайлToolStripMenuItem";
			this.пращанеНаТестовеПрезЕмайлToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
			this.пращанеНаТестовеПрезЕмайлToolStripMenuItem.Text = "Пращане на тестове през емайл";
			// 
			// изходToolStripMenuItem
			// 
			this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
			this.изходToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
			this.изходToolStripMenuItem.Text = "Изход";
			this.изходToolStripMenuItem.Click += new System.EventHandler(this.изходToolStripMenuItem_Click);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nameLabel.Location = new System.Drawing.Point(42, 74);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(109, 25);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "nameLabel";
			// 
			// Testing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 390);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Testing";
			this.Text = "Testing";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.MaximizeBox = false;
			this.PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem пращанеНаТестовеПрезЕмайлToolStripMenuItem;
        private ToolStripMenuItem изходToolStripMenuItem;
		private Label nameLabel;
	}
}