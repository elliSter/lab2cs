namespace CommonWindowsFormControls
{
    partial class ComboBoxListBoxCheckedListBoxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultsButton2 = new System.Windows.Forms.Button();
            this.controlsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.selectedControlsListBox = new System.Windows.Forms.ListBox();
            this.resultsButton1 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.statesListBox = new System.Windows.Forms.ListBox();
            this.controlsListBox3 = new System.Windows.Forms.ListBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.statesComboBox = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.controlsComboBox3 = new System.Windows.Forms.ComboBox();
            this.controlsComboBox2 = new System.Windows.Forms.ComboBox();
            this.controlsComboBox1 = new System.Windows.Forms.ComboBox();
            this.controlsListBox2 = new System.Windows.Forms.ListBox();
            this.controlsListBox1 = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultsButton2
            // 
            this.resultsButton2.Location = new System.Drawing.Point(533, 346);
            this.resultsButton2.Name = "resultsButton2";
            this.resultsButton2.Size = new System.Drawing.Size(75, 35);
            this.resultsButton2.TabIndex = 109;
            this.resultsButton2.Text = "Results";
            this.resultsButton2.UseVisualStyleBackColor = true;
            this.resultsButton2.Click += new System.EventHandler(this.resultsButton2_Click);
            // 
            // controlsCheckedListBox
            // 
            this.controlsCheckedListBox.CheckOnClick = true;
            this.controlsCheckedListBox.FormattingEnabled = true;
            this.controlsCheckedListBox.Items.AddRange(new object[] {
            "Label",
            "TextBox",
            "Button",
            "CheckBox ",
            "RadioButton ",
            "ComboBox ",
            "ListBox ",
            "CheckedListBox ",
            "LinkLabel ",
            "NumericUpDown ",
            "PictureBox ",
            "ProgressBar "});
            this.controlsCheckedListBox.Location = new System.Drawing.Point(534, 166);
            this.controlsCheckedListBox.Name = "controlsCheckedListBox";
            this.controlsCheckedListBox.Size = new System.Drawing.Size(147, 154);
            this.controlsCheckedListBox.TabIndex = 108;
            this.controlsCheckedListBox.ThreeDCheckBoxes = true;
            this.controlsCheckedListBox.UseCompatibleTextRendering = true;
            this.controlsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.controlsCheckedListBox_ItemCheck);
            // 
            // selectedControlsListBox
            // 
            this.selectedControlsListBox.FormattingEnabled = true;
            this.selectedControlsListBox.Location = new System.Drawing.Point(335, 346);
            this.selectedControlsListBox.Name = "selectedControlsListBox";
            this.selectedControlsListBox.Size = new System.Drawing.Size(134, 121);
            this.selectedControlsListBox.TabIndex = 107;
            // 
            // resultsButton1
            // 
            this.resultsButton1.Location = new System.Drawing.Point(250, 346);
            this.resultsButton1.Name = "resultsButton1";
            this.resultsButton1.Size = new System.Drawing.Size(75, 35);
            this.resultsButton1.TabIndex = 106;
            this.resultsButton1.Text = "Results";
            this.resultsButton1.UseVisualStyleBackColor = true;
            this.resultsButton1.Click += new System.EventHandler(this.resultsButton1_Click);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(15, 346);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(123, 35);
            this.Label4.TabIndex = 105;
            this.Label4.Text = "What state do you want to visit? ";
            // 
            // statesListBox
            // 
            this.statesListBox.FormattingEnabled = true;
            this.statesListBox.Location = new System.Drawing.Point(18, 384);
            this.statesListBox.Name = "statesListBox";
            this.statesListBox.Size = new System.Drawing.Size(120, 82);
            this.statesListBox.TabIndex = 104;
            this.statesListBox.SelectedIndexChanged += new System.EventHandler(this.statesListBox_SelectedIndexChanged);
            // 
            // controlsListBox3
            // 
            this.controlsListBox3.FormattingEnabled = true;
            this.controlsListBox3.Location = new System.Drawing.Point(336, 181);
            this.controlsListBox3.Name = "controlsListBox3";
            this.controlsListBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.controlsListBox3.Size = new System.Drawing.Size(134, 121);
            this.controlsListBox3.TabIndex = 103;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(18, 150);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(226, 13);
            this.Label3.TabIndex = 102;
            this.Label3.Text = "What control do you want to learn about next?";
            // 
            // statesComboBox
            // 
            this.statesComboBox.FormattingEnabled = true;
            this.statesComboBox.Location = new System.Drawing.Point(236, 100);
            this.statesComboBox.Name = "statesComboBox";
            this.statesComboBox.Size = new System.Drawing.Size(156, 21);
            this.statesComboBox.TabIndex = 101;
            this.statesComboBox.SelectedIndexChanged += new System.EventHandler(this.statesComboBox_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(18, 103);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(162, 13);
            this.Label2.TabIndex = 100;
            this.Label2.Text = "What state do you want to visit? ";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(631, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 36);
            this.closeButton.TabIndex = 99;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // controlsComboBox3
            // 
            this.controlsComboBox3.FormattingEnabled = true;
            this.controlsComboBox3.Location = new System.Drawing.Point(398, 48);
            this.controlsComboBox3.Name = "controlsComboBox3";
            this.controlsComboBox3.Size = new System.Drawing.Size(184, 21);
            this.controlsComboBox3.TabIndex = 98;
            // 
            // controlsComboBox2
            // 
            this.controlsComboBox2.FormattingEnabled = true;
            this.controlsComboBox2.Location = new System.Drawing.Point(208, 48);
            this.controlsComboBox2.Name = "controlsComboBox2";
            this.controlsComboBox2.Size = new System.Drawing.Size(184, 21);
            this.controlsComboBox2.TabIndex = 97;
            this.controlsComboBox2.SelectedIndexChanged += new System.EventHandler(this.controlsComboBox2_SelectedIndexChanged);
            // 
            // controlsComboBox1
            // 
            this.controlsComboBox1.FormattingEnabled = true;
            this.controlsComboBox1.Items.AddRange(new object[] {
            "Label",
            "TextBox",
            "Button",
            "CheckBox ",
            "RadioButton ",
            "ComboBox ",
            "ListBox ",
            "CheckedListBox ",
            "LinkLabel ",
            "NumericUpDown ",
            "PictureBox ",
            "ProgressBar "});
            this.controlsComboBox1.Location = new System.Drawing.Point(18, 48);
            this.controlsComboBox1.Name = "controlsComboBox1";
            this.controlsComboBox1.Size = new System.Drawing.Size(184, 21);
            this.controlsComboBox1.TabIndex = 96;
            this.controlsComboBox1.SelectedIndexChanged += new System.EventHandler(this.controlsComboBox1_SelectedIndexChanged);
            // 
            // controlsListBox2
            // 
            this.controlsListBox2.FormattingEnabled = true;
            this.controlsListBox2.Location = new System.Drawing.Point(177, 181);
            this.controlsListBox2.Name = "controlsListBox2";
            this.controlsListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.controlsListBox2.Size = new System.Drawing.Size(134, 121);
            this.controlsListBox2.TabIndex = 95;
            // 
            // controlsListBox1
            // 
            this.controlsListBox1.FormattingEnabled = true;
            this.controlsListBox1.Items.AddRange(new object[] {
            "Label",
            "TextBox",
            "Button",
            "CheckBox ",
            "RadioButton ",
            "ComboBox ",
            "ListBox ",
            "CheckedListBox ",
            "LinkLabel ",
            "NumericUpDown ",
            "PictureBox ",
            "ProgressBar "});
            this.controlsListBox1.Location = new System.Drawing.Point(18, 181);
            this.controlsListBox1.Name = "controlsListBox1";
            this.controlsListBox1.Size = new System.Drawing.Size(134, 121);
            this.controlsListBox1.TabIndex = 94;
            this.controlsListBox1.SelectedIndexChanged += new System.EventHandler(this.controlsListBox1_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(226, 13);
            this.Label1.TabIndex = 93;
            this.Label1.Text = "What control do you want to learn about next?";
            // 
            // ComboBoxListBoxCheckedListBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 566);
            this.Controls.Add(this.resultsButton2);
            this.Controls.Add(this.controlsCheckedListBox);
            this.Controls.Add(this.selectedControlsListBox);
            this.Controls.Add(this.resultsButton1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.statesListBox);
            this.Controls.Add(this.controlsListBox3);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.statesComboBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.controlsComboBox3);
            this.Controls.Add(this.controlsComboBox2);
            this.Controls.Add(this.controlsComboBox1);
            this.Controls.Add(this.controlsListBox2);
            this.Controls.Add(this.controlsListBox1);
            this.Controls.Add(this.Label1);
            this.Name = "ComboBoxListBoxCheckedListBoxForm";
            this.Text = "ComboBoxListBoxCheckedListBoxForm";
            this.Load += new System.EventHandler(this.ComboBoxListBoxCheckedListBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button resultsButton2;
        internal System.Windows.Forms.CheckedListBox controlsCheckedListBox;
        internal System.Windows.Forms.ListBox selectedControlsListBox;
        internal System.Windows.Forms.Button resultsButton1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ListBox statesListBox;
        internal System.Windows.Forms.ListBox controlsListBox3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox statesComboBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button closeButton;
        internal System.Windows.Forms.ComboBox controlsComboBox3;
        internal System.Windows.Forms.ComboBox controlsComboBox2;
        internal System.Windows.Forms.ComboBox controlsComboBox1;
        internal System.Windows.Forms.ListBox controlsListBox2;
        internal System.Windows.Forms.ListBox controlsListBox1;
        internal System.Windows.Forms.Label Label1;
    }
}