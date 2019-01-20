using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommonWindowsFormControls
{
    public partial class Switchboard : Form
    {
        public Switchboard()
        {
            InitializeComponent();
        }

        private void demo1Button_Click(object sender, EventArgs e)
        {
            LabelTextBoxForm f = new LabelTextBoxForm();
            f.Show();
        }

        private void demo3Button_Click(object sender, EventArgs e)
        {
            CheckBoxRadioButtonForm f = new CheckBoxRadioButtonForm();
            f.Show();
        }

        private void demo4Button_Click(object sender, EventArgs e)
        {
            ComboBoxListBoxCheckedListBoxForm f = new ComboBoxListBoxCheckedListBoxForm();
            f.Show();
        }

        private void demo6Button_Click(object sender, EventArgs e)
        {
            NumericUpDownProgressBarForm f = new NumericUpDownProgressBarForm();
            f.Show();
        }
    }
}
