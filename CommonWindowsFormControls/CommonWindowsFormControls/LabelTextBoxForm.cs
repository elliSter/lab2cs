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
    public partial class LabelTextBoxForm : Form
    {
        public LabelTextBoxForm()
        {
            InitializeComponent();
        }

        private string helpLabelText = "";

        private void LabelTextBoxForm_Load(object sender, EventArgs e)
        {
            currentDateLabel.Text = String.Format("Today is {0}", DateTime.Today.ToString("D"));
        }

        private void PhoneTextBox_Enter(object sender, EventArgs e)
        {

            if (CountryTextBox.Text == "USA")
            {
                helpLabel.Text = "Enter phone numbers in the " + "(999) 999-999 format.";
            }
            else
            {
                helpLabel.Text = "Please use the correct phone format " + "for this country.";
            }
        }

        private void PhoneTextBox_Leave(object sender, EventArgs e)
        {
            helpLabel.Text = "";
        }

        private void RegionLabel_Click(object sender, EventArgs e)
        {
            helpLabel.Text = "Region means State in the US and " + "Province in Canada.";
        }

        private void PostalCodeLabel_MouseEnter(object sender, EventArgs e)
        {
            helpLabelText = helpLabel.Text;
        }

        private void PostalCodeLabel_MouseHover(object sender, EventArgs e)
        {
            helpLabel.Text = "Postal Code means Zip Code in the US.";
        }

        private void PostalCodeLabel_MouseLeave(object sender, EventArgs e)
        {
            helpLabel.Text = helpLabelText;
        }

        private void CountryTextBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void NotesTextBox_Leave(object sender, EventArgs e)
        {
            if (NotesTextBox.TextLength > 100)
                MessageBox.Show(String.Format("This is {0} characters. Please keep it under 100.", NotesTextBox.TextLength));
        }

        private void ContactNameTextBox_Enter(object sender, EventArgs e)
        {
            ContactNameTextBox.Tag = ContactNameTextBox.BackColor;
            ContactNameTextBox.BackColor = Color.Yellow;
        }

        private void ContactNameTextBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void CityTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (CityTextBox.TextLength > 15)
            {
                MessageBox.Show("The city field can only be 15 characters.");
                e.Cancel = true;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompanyNameTextBox_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CompanyNameTextBox.Text))
            {
                CompanyNameTextBox.BackColor = Color.White;
                label2.Visible = false;
            }
            else
            {
                CompanyNameTextBox.BackColor = Color.Red;
                label2.Visible = true;
            }
        }

        private void CompanyNameTextBox_Enter(object sender, EventArgs e)
        {
            CompanyNameTextBox.BackColor = Color.Yellow;
            
        }

        private void CountryTextBox_Enter(object sender, EventArgs e)
        {

        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            CountryTextBox.Text = CountryTextBox.Text.ToUpper();
        }
    }
}
