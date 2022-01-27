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

        public TestConditionDialog(TestInfo ti)
        {
            InitializeComponent();

            this.label1.Text = "Изберете резултата от теста на " + ti.Name + ":";
        }

        public ETestCondition getTestCondition()
        {
            if (testResultDropdown.Text == "Позитивен")
            {
                return ETestCondition.Positive;

            } else if (testResultDropdown.Text == "Отрицателен")
            {
                return ETestCondition.Negative;
            }

            return ETestCondition.Undefined;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (getTestCondition() != ETestCondition.Undefined)
            {
                // Do after test finished stuff here.
                /* Example That prints the selected test condition: */MessageBox.Show(Utils.TranslateTestEnum(getTestCondition()));

            } else
            {
                MessageBox.Show("Не е избран вида на теста! Изберете дали е положителен или отрицателен и опитайте пак.");
            }

        }
    }
}
