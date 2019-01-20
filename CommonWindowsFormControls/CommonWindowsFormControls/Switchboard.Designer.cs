namespace CommonWindowsFormControls
{
    partial class Switchboard
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
            this.demo6Button = new System.Windows.Forms.Button();
            this.demo4Button = new System.Windows.Forms.Button();
            this.demo3Button = new System.Windows.Forms.Button();
            this.demo1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // demo6Button
            // 
            this.demo6Button.Location = new System.Drawing.Point(12, 135);
            this.demo6Button.Name = "demo6Button";
            this.demo6Button.Size = new System.Drawing.Size(327, 38);
            this.demo6Button.TabIndex = 11;
            this.demo6Button.Text = "NumericUpDown and ProgressBar controls";
            this.demo6Button.UseVisualStyleBackColor = true;
            this.demo6Button.Click += new System.EventHandler(this.demo6Button_Click);
            // 
            // demo4Button
            // 
            this.demo4Button.Location = new System.Drawing.Point(12, 91);
            this.demo4Button.Name = "demo4Button";
            this.demo4Button.Size = new System.Drawing.Size(327, 38);
            this.demo4Button.TabIndex = 10;
            this.demo4Button.Text = "ComboBox, ListBox and CheckedListBox controls";
            this.demo4Button.UseVisualStyleBackColor = true;
            this.demo4Button.Click += new System.EventHandler(this.demo4Button_Click);
            // 
            // demo3Button
            // 
            this.demo3Button.Location = new System.Drawing.Point(12, 47);
            this.demo3Button.Name = "demo3Button";
            this.demo3Button.Size = new System.Drawing.Size(327, 38);
            this.demo3Button.TabIndex = 9;
            this.demo3Button.Text = "CheckBox and RadioButton controls";
            this.demo3Button.UseVisualStyleBackColor = true;
            this.demo3Button.Click += new System.EventHandler(this.demo3Button_Click);
            // 
            // demo1Button
            // 
            this.demo1Button.Location = new System.Drawing.Point(12, 3);
            this.demo1Button.Name = "demo1Button";
            this.demo1Button.Size = new System.Drawing.Size(327, 38);
            this.demo1Button.TabIndex = 8;
            this.demo1Button.Text = "Label and TextBox controls";
            this.demo1Button.UseVisualStyleBackColor = true;
            this.demo1Button.Click += new System.EventHandler(this.demo1Button_Click);
            // 
            // Switchboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 177);
            this.Controls.Add(this.demo6Button);
            this.Controls.Add(this.demo4Button);
            this.Controls.Add(this.demo3Button);
            this.Controls.Add(this.demo1Button);
            this.Name = "Switchboard";
            this.Text = "Switchboard";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button demo6Button;
        internal System.Windows.Forms.Button demo4Button;
        internal System.Windows.Forms.Button demo3Button;
        internal System.Windows.Forms.Button demo1Button;
    }
}