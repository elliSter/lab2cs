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
    public partial class NumericUpDownProgressBarForm : Form
    {
        public NumericUpDownProgressBarForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateRandomNumbersButton_Click(object sender, EventArgs e)
        {
            randomNumbersProgressBar.Value = 0;
            randomNumbersProgressBar.Maximum = 10000;
            randomNumbersProgressBar.Step = 100;

            Random randomNumber = new Random();
            for (int i = 1; i <= 10000; i++)
            {
                randomNumber.Next();
                if (i % 100 == 0)
                {
                    randomNumbersProgressBar.PerformStep();
                }
            }
        }
    }
}
