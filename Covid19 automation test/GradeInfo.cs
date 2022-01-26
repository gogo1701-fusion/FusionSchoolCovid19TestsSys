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
		public GradeInfoStruct gis;

		//Testing testWindow = new Testing();
		public GradeInfo ()
		{
			InitializeComponent();			
		}

		StudentDisplayCard sdc;
		Button castedSender;

		public static GradeInfo ShowWindow(GradeInfoStruct gis, Button castedSender)
        {
			var gi = new GradeInfo();
			gi.PopulateWindow(gis, castedSender);
			return gi;
		}

		private void PopulateWindow(GradeInfoStruct gis, Button castedSender)
		{
			this.gis = gis;

			this.gradeNameLabel.Text = "Име на клас: " + gis.Name;
			this.Text = "Информация за клас: " + gis.Name;

			this.gradeNameLabel.Text = "Име на клас: " + gis.Name;
			this.Text = "Инфо за клас: " + gis.Name;

			this.castedSender = castedSender;

			this.studentsListBox.Items.Clear();
			foreach (TestInfo student in gis.Students)
			{
				sdc = new StudentDisplayCard() { ti = student, cardName = student.Name };

				int addedItem = this.studentsListBox.Items.Add(sdc.cardName);
			}

			this.Show();
		}

		private void GradeInfo_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

        private void studentsListBox_MouseClick(object sender, MouseEventArgs e)
        {
			new Testing().showWindow(gis.Students[this.studentsListBox.SelectedIndex]); // index your mom 
        }
    }
}
