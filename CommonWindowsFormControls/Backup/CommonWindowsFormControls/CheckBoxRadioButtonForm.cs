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
    public partial class CheckBoxRadioButtonForm : Form
    {
        public CheckBoxRadioButtonForm()
        {
            InitializeComponent();
        }

        private void salaryTextBox_Leave(object sender, EventArgs e)
        {
            if ((salaryTextBox.Text != String.Empty))
            {
                if (decimal.Parse(salaryTextBox.Text) > 3000)
                {
                    vpApprovalCheckBox.Checked = true;
                }

            }
        }

        private void vpApprovalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (vpApprovalCheckBox.Checked)
            {
                MessageBox.Show("Ask your VP for approval.");
            }

        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder("");
            if (vbRadioButton1.Checked)
            {
                results.Append(("You like VB" + "\r\n"));
            }
            else if (csRadioButton1.Checked)
            {
                results.Append(("You like C#" + "\r\n"));
            }
            else if (vbCSRadioButton1.Checked)
            {
                results.Append(("You like both VB and C#" + "\r\n"));
            }

            if (beginnerRadioButton.Checked)
            {
                results.Append(("You are a beginner developer" + "\r\n"));
            }
            else if (intermediateRadioButton.Checked)
            {
                results.Append(("You are an intermediate developer" + "\r\n"));
            }
            else if (advancedRadioButton.Checked)
            {
                results.Append(("You are an advanced developer" + "\r\n"));
            }

            MessageBox.Show(results.ToString());
        }

        private void beginnerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (beginnerRadioButton.Checked)
            {
                MessageBox.Show("You clicked the Beginner radio button");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
