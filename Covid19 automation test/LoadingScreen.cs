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
    public partial class LoadingScreen : Form
    {
        Form1 f1;

        public LoadingScreen(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            //f1.Close();
            
            //Thread.Sleep(5000);

            MainWindow mw = new MainWindow();
            mw.Show();
            
            //this.Close();
        }
    }
}
