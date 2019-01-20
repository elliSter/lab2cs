namespace CommonWindowsFormControls
{
    partial class NumericUpDownProgressBarForm
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
            this.Label3 = new System.Windows.Forms.Label();
            this.ValNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.MaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Label1 = new System.Windows.Forms.Label();
            this.MinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TestProgressBar = new System.Windows.Forms.ProgressBar();
            this.closeButton = new System.Windows.Forms.Button();
            this.randomNumbersProgressBar = new System.Windows.Forms.ProgressBar();
            this.generateRandomNumbersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ValNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(306, 85);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(34, 13);
            this.Label3.TabIndex = 103;
            this.Label3.Text = "Value";
            // 
            // ValNumericUpDown
            // 
            this.ValNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ValNumericUpDown.Location = new System.Drawing.Point(372, 83);
            this.ValNumericUpDown.Name = "ValNumericUpDown";
            this.ValNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.ValNumericUpDown.TabIndex = 102;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(159, 85);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 13);
            this.Label2.TabIndex = 101;
            this.Label2.Text = "Maximum";
            // 
            // MaxNumericUpDown
            // 
            this.MaxNumericUpDown.Location = new System.Drawing.Point(225, 83);
            this.MaxNumericUpDown.Name = "MaxNumericUpDown";
            this.MaxNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.MaxNumericUpDown.TabIndex = 100;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 85);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 99;
            this.Label1.Text = "Minimun";
            // 
            // MinNumericUpDown
            // 
            this.MinNumericUpDown.Location = new System.Drawing.Point(81, 83);
            this.MinNumericUpDown.Name = "MinNumericUpDown";
            this.MinNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.MinNumericUpDown.TabIndex = 98;
            // 
            // TestProgressBar
            // 
            this.TestProgressBar.Location = new System.Drawing.Point(18, 112);
            this.TestProgressBar.Name = "TestProgressBar";
            this.TestProgressBar.Size = new System.Drawing.Size(426, 23);
            this.TestProgressBar.TabIndex = 97;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(369, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 36);
            this.closeButton.TabIndex = 96;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // randomNumbersProgressBar
            // 
            this.randomNumbersProgressBar.Location = new System.Drawing.Point(14, 54);
            this.randomNumbersProgressBar.Name = "randomNumbersProgressBar";
            this.randomNumbersProgressBar.Size = new System.Drawing.Size(212, 23);
            this.randomNumbersProgressBar.TabIndex = 95;
            // 
            // generateRandomNumbersButton
            // 
            this.generateRandomNumbersButton.Location = new System.Drawing.Point(14, 12);
            this.generateRandomNumbersButton.Name = "generateRandomNumbersButton";
            this.generateRandomNumbersButton.Size = new System.Drawing.Size(212, 36);
            this.generateRandomNumbersButton.TabIndex = 94;
            this.generateRandomNumbersButton.Text = "Generate random numbers";
            this.generateRandomNumbersButton.UseVisualStyleBackColor = true;
            this.generateRandomNumbersButton.Click += new System.EventHandler(this.generateRandomNumbersButton_Click);
            // 
            // NumericUpDownProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 145);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ValNumericUpDown);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.MaxNumericUpDown);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.MinNumericUpDown);
            this.Controls.Add(this.TestProgressBar);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.randomNumbersProgressBar);
            this.Controls.Add(this.generateRandomNumbersButton);
            this.Name = "NumericUpDownProgressBarForm";
            this.Text = "NumericUpDownProgressBarForm";
            ((System.ComponentModel.ISupportInitialize)(this.ValNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.NumericUpDown ValNumericUpDown;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.NumericUpDown MaxNumericUpDown;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.NumericUpDown MinNumericUpDown;
        internal System.Windows.Forms.ProgressBar TestProgressBar;
        internal System.Windows.Forms.Button closeButton;
        internal System.Windows.Forms.ProgressBar randomNumbersProgressBar;
        internal System.Windows.Forms.Button generateRandomNumbersButton;
    }
}