using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Covid19_automation_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\files\\" + "test.txt");
            sw.WriteLine("This text is written by our app.");
            sw.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}