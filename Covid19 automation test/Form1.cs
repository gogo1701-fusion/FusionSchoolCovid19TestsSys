using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Covid19_automation_test
{
    public partial class Form1 : Form
    {
        public string username = "Fusion";
        public string password = "FusionTests1488!#";


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
            if (checkPasswordAndUsername())
			{

			}

            MainWindow mw = new MainWindow(this);
            mw.Show();

            this.Hide();
        }

        ///<summary>
        ///Checks is the password is correct or not. Retruns true if everything is OK, false if not.
        ///</summary>
        public bool checkPasswordAndUsername()
		{
            if (username == "Fusion")
			{
                if (password == "FusionTests1488!#")
                {
                    return true;
                }
                else
				{
                    MessageBox.Show("Incorrect Username!", "Incorrect Username!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				    return false;
                }
			}
            else
			{
                MessageBox.Show("Incorrect Password!", "Incorrect Password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
            }
		}
    }
}