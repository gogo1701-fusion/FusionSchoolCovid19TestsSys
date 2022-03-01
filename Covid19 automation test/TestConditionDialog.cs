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
    public partial class TestConditionDialog : Form
    {
        private ETestCondition testCondition;

        private TestInfo ti;
        private Testing testing;

        public TestConditionDialog(TestInfo ti, Testing testing)
        {
            InitializeComponent();

            label1.Text = "Изберете резултата от теста на " + ti.Name + ":";
            this.ti = ti;
            this.testing = testing;
        }

        private void posButton_Click(object sender, EventArgs e)
        {
            testCondition = ETestCondition.Positive;
            finishTest();
        }

        private void negButton_Click(object sender, EventArgs e)
        {
            testCondition = ETestCondition.Negative;
            finishTest();
        }

        public void finishTest()
        {
            // Executes after the test finishes
            MessageBox.Show("Тестът на " + ti.Name + " Завърши.");
            Utils.WriteFinishedStudent(testCondition, ti);

            testing.Close();
            Close();
        }
    }
}
