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
	public partial class MainWindow : Form
	{
		static TestInfo ti = new TestInfo() { Name = "Nqkoj nqkojsi" };

		GradeInfo giWindow = new GradeInfo(Grades.gisPK);
		public MainWindow()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Here we set all students in all classes.
		/// </summary>
		private void gradeButtonsClick(object sender, EventArgs e)
		{
			var castedSender = (Button)sender;

			if (castedSender != null)
			{
				if (castedSender.Text == "ПК")
				{
					giWindow.showWindow(Grades.gisPK);
				
				} else if (castedSender.Text == "1А")
				{
					giWindow.showWindow(Grades.gis1A);

				} else if (castedSender.Text == "1Б")
				{
					giWindow.showWindow(Grades.gis1B);

				} else if (castedSender.Text == "1В")
				{
					giWindow.showWindow(Grades.gis1V);

				} else if (castedSender.Text == "2А")
				{
					giWindow.showWindow(Grades.gis2A);

				} else if (castedSender.Text == "3А")
				{
					giWindow.showWindow(Grades.gis3A);

				} else if (castedSender.Text == "3Б")
				{
					giWindow.showWindow(Grades.gis3B);

				} else if (castedSender.Text == "3В")
				{
					giWindow.showWindow(Grades.gis3V);

				} else if (castedSender.Text == "4А")
				{
					giWindow.showWindow(Grades.gis4A);

				} else if (castedSender.Text == "4Б")
				{
					giWindow.showWindow(Grades.gis4B);

				} else if (castedSender.Text == "5А")
				{
					giWindow.showWindow(Grades.gis5A);

				} else if (castedSender.Text == "6А")
				{
					giWindow.showWindow(Grades.gis6A);

				} else if (castedSender.Text == "6Б")
				{
					giWindow.showWindow(Grades.gis6B);

				} else if (castedSender.Text == "7А")
				{
					giWindow.showWindow(Grades.gis7A);

				}

				Grades.gisPK.Name = castedSender.Text;
			}

		}
	}

	public class TestInfo
	{
		public string Name { get; set; }
	}

	public class GradeInfoStruct
	{
		public string Name { get; set; }
		public string[] Students { get; set; }
	}
}
