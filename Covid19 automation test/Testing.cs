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
    public partial class Testing : Form
    {
        public TestInfo m_TestInfo;

        public Testing(TestInfo ti)
        {
            InitializeComponent();
            this.m_TestInfo = ti;

            this.nameLabel.Text = ti.Name;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
