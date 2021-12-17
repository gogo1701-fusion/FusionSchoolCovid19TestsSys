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
            bool result = checkPasswordAndUsername();

            if (result)
            {
                MainWindow mw = new MainWindow();
                mw.Show();

                this.Hide();
            }
            else if (!result)
            {
                MessageBox.Show("Incorrect Password or Username!", "Incorrect Password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///<summary>
        ///Checks is the password is correct or not. Retruns true if everything is OK, false if not.
        ///</summary>
        public bool checkPasswordAndUsername()
		{
            if (usernameInput.Text == username)
			{
                if (passwordInput.Text == password) 
                {
                    return true;
                }
                else
				{
				    return false;
                }
			}
            else
			{
				return false;
            }
		}

		private void showPasswordButton_Click(object sender, EventArgs e)
		{
            passwordInput.PasswordChar = ' ';
		}
	}
}