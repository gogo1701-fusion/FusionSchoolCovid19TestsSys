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

        private TestInfo ti;

        public Testing()
        {
            InitializeComponent();
        }

        public void showWindow(TestInfo ti)
        {
            this.ti = ti;

            this.m_TestInfo = ti;

            this.nameLabel.Text = "Име на ученик: " + ti.Name;

            this.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startTest_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Тестът за " + ti.Name + " започна. Моля изчакайте да свърши.");
            TestConditionDialog tcd = new TestConditionDialog(ti, this);
            tcd.Show();
        }

        private void пращанеНаТестовеПрезЕмайлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
