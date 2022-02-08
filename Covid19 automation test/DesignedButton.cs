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
    public partial class DesignedButton : UserControl
    {
        public DesignedButton()
        {
            InitializeComponent();
        }

        [Description("Main Text"), Category("Custom Data")]
        public string MainText
        {
            get => label1.Text;
            set => label1.Text = value;
        }
    }
}
