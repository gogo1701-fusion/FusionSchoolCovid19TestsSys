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

		Testing test = new Testing(ti);
		public MainWindow()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			test.Show();
		}
	}

	public class TestInfo
	{
		public string Name { get; set; }
	}
}
