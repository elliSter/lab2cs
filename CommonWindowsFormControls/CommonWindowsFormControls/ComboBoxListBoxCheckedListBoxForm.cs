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
    public partial class ComboBoxListBoxCheckedListBoxForm : Form
    {
        public ComboBoxListBoxCheckedListBoxForm()
        {
            InitializeComponent();
        }

        string[] stateAbbreviations = {"WA","OR","CA","ID","NV"};

        private void ComboBoxListBoxCheckedListBoxForm_Load(object sender, EventArgs e)
        {
           
            controlsComboBox2.Items.Add("Label");
            controlsComboBox2.Items.Add("TextBox");
            controlsComboBox2.Items.Add("Button");
            controlsComboBox2.Items.Add("CheckBox");
            controlsComboBox2.Items.Add("RadioButton");
            controlsComboBox2.Items.Add("ComboBox");
            controlsComboBox2.Items.Add("ListBox");
            controlsComboBox2.Items.Add("CheckedListBox");
            controlsComboBox2.Items.Add("LinkLabel");
            controlsComboBox2.Items.Add("NumericUpDown");
            controlsComboBox2.Items.Add("PictureBox");
            controlsComboBox2.Items.Add("ProgressBar");

            string[] controlsArray = {"Label","TextBox","Button","CheckBox","RadioButton","ComboBox","ListBox","CheckedListBox"
                                         ,"LinkLabel","NumericUpDown","PictureBox","ProgressBar"};

            controlsComboBox3.Items.AddRange(controlsArray);

            statesComboBox.Items.Add("Washington");
            statesComboBox.Items.Add("Oregon");
            statesComboBox.Items.Add("California");
            statesComboBox.Items.Add("Idaho");
            statesComboBox.Items.Add("Nevada");

            // Fill the three ListBoxes
          
            controlsListBox2.Items.Add("Label");
            controlsListBox2.Items.Add("TextBox");
            controlsListBox2.Items.Add("Button");
            controlsListBox2.Items.Add("CheckBox");
            controlsListBox2.Items.Add("RadioButton");
            controlsListBox2.Items.Add("ComboBox");
            controlsListBox2.Items.Add("ListBox");
            controlsListBox2.Items.Add("CheckedListBox");
            controlsListBox2.Items.Add("LinkLabel");
            controlsListBox2.Items.Add("NumericUpDown");
            controlsListBox2.Items.Add("PictureBox");
            controlsListBox2.Items.Add("ProgressBar");

            controlsListBox3.Items.AddRange(controlsArray);

            statesListBox.Items.Add("Washington");
            statesListBox.Items.Add("Oregon");
            statesListBox.Items.Add("California");
            statesListBox.Items.Add("Idaho");
            statesListBox.Items.Add("Nevada");



        }

     

        private void controlsComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("You chose item number {0} - {1}", controlsComboBox1.SelectedIndex, controlsComboBox1.SelectedItem));
        }

        private void controlsComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("You selected {0} - {1}", statesComboBox.SelectedIndex.ToString(), statesComboBox.SelectedItem));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controlsListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("You chose item number {0} - {1}", controlsListBox1.SelectedIndex, controlsListBox1.SelectedItem));
        }

        private void statesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show(String.Format("You selected {0} - {1}", statesListBox.SelectedIndex.ToString(), statesListBox.SelectedItem));
        }

        private void resultsButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("You selected {0} items", controlsListBox3.SelectedItems.Count));

            foreach (object obj in controlsListBox3.SelectedItems)
            {
                selectedControlsListBox.Items.Add(obj);
            }
        }

        private void controlsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string checkedItem = controlsCheckedListBox.Items[e.Index].ToString();

            string confirmMessage = null;
            if (e.NewValue == CheckState.Checked)
            {
                confirmMessage = string.Format("Do you really want to check {0}?", checkedItem);
            }
            else
            {
                confirmMessage = string.Format("Do you really want to uncheck {0}?", checkedItem);
            }


            if (MessageBox.Show(confirmMessage, "Double check", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.NewValue = e.CurrentValue;
            }
        }

        private void resultsButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("You checked {0} items", controlsCheckedListBox.CheckedItems.Count));

            foreach (object obj in controlsCheckedListBox.CheckedItems)
            {
                selectedControlsListBox.Items.Add(obj);
            }
        }
    }
}
