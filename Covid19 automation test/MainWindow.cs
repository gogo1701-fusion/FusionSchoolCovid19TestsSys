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


		//GradeInfo giWindow = new GradeInfo(Grades.gisPK);
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
					GradeInfo.ShowWindow(Grades.gisPK, castedSender);
				
				} else if (castedSender.Text == "1А")
				{
					GradeInfo.ShowWindow(Grades.gis1A, castedSender);

				} else if (castedSender.Text == "1Б")
				{
					GradeInfo.ShowWindow(Grades.gis1B, castedSender);

				} else if (castedSender.Text == "1В")
				{
					GradeInfo.ShowWindow(Grades.gis1V, castedSender);

				} else if (castedSender.Text == "2А")
				{
					GradeInfo.ShowWindow(Grades.gis2A, castedSender);

				} else if (castedSender.Text == "3А")
				{
					GradeInfo.ShowWindow(Grades.gis3A, castedSender);

				} else if (castedSender.Text == "3Б")
				{
					GradeInfo.ShowWindow(Grades.gis3B, castedSender);

				} else if (castedSender.Text == "4А")
				{
					GradeInfo.ShowWindow(Grades.gis4A, castedSender);

				} else if (castedSender.Text == "4Б")
				{
					GradeInfo.ShowWindow(Grades.gis4B, castedSender);

				} else if (castedSender.Text == "5А")
				{
					GradeInfo.ShowWindow(Grades.gis5A, castedSender);

				} else if (castedSender.Text == "6А")
				{
					GradeInfo.ShowWindow(Grades.gis6A, castedSender);

				} else if (castedSender.Text == "6Б")
				{
					GradeInfo.ShowWindow(Grades.gis6B, castedSender);

				} else if (castedSender.Text == "7А")
				{
					GradeInfo.ShowWindow(Grades.gis7A, castedSender);

				}

				Grades.gisPK.Name = castedSender.Text;
			}

		}
	}
	[Serializable]
	public class TestInfo
	{
		public string Name { get; set; }
		public GradeInfoStruct Grade { get; set; }
		public ETestCondition TestCondition { get; set; }
		public bool hasTakenTest { get; set; }
	}

	public class GradeInfoStruct
	{
		public string Name { get; set; }
		public TestInfo[] Students { get; set; }
	}

	public class StudentDisplayCard
    {
		public TestInfo ti { get; set; }
		public string cardName { get; set; }
    }
	
	public enum ETestCondition
	{
		Positive,
		Negative,
		Undefined
	}
}
