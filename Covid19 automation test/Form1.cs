using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Covid19_automation_test
{
    public partial class Form1 : Form
    {
        public string username = "Fusion";
        public string password = "FusionTests1488!#";

        public bool isInDebugMode = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = checkPasswordAndUsername();

            if (!isInDebugMode)
            {
                if (result)
                {
                    LoadingScreen ls = new LoadingScreen(this);
                    ls.Show();
                }
                else if (!result)
                {
                    MessageBox.Show("Incorrect Password or Username! If you don`t know the Password or Username, Contact us.", "Incorrect Password or Username!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                LoadingScreen ls = new LoadingScreen(this);
                ls.Show();
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
            if (passwordInput.PasswordChar == '*')
			{
                passwordInput.PasswordChar = '\0';
			    
            } else if (passwordInput.PasswordChar == '\0')
			{
                passwordInput.PasswordChar = '*';
			}

		}

        private void button2_Click(object sender, EventArgs e)
        {
            ReportWindow rw = new ReportWindow();
            rw.Show();
        }
    }
}