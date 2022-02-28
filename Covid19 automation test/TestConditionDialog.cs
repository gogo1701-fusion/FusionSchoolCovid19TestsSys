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

        public TestConditionDialog(TestInfo ti)
        {
            InitializeComponent();

            this.label1.Text = "Изберете резултата от теста на " + ti.Name + ":";
            this.ti = ti;
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
            MessageBox.Show(Utils.TranslateTestEnum(testCondition));
        }
    }
}
