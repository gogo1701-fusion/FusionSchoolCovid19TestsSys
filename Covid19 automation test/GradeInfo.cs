using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19_automation_test
{
	public partial class GradeInfo : Form
	{
		public GradeInfo(GradeInfoStruct gis)
		{
			InitializeComponent();
			
			this.gradeNameLabel.Text = "Име на клас: " + gis.Name;
			this.Text = "Инфо за клас: " + gis.Name;
		}

		public void showWindow(GradeInfoStruct gis)
		{
			this.gradeNameLabel.Text = "Име на клас: " + gis.Name;
			this.Text = "Инфо за клас: " + gis.Name;

			this.studentsListBox.Items.Clear();
			foreach (string student in gis.Students)
			{
				int addedItem = this.studentsListBox.Items.Add(student);
			}

			this.Show();
		}

		private void GradeInfo_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}
}
