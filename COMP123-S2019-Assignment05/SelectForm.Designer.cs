namespace COMP123_S2019_Assignment05
{
    partial class SelectForm
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
            this.DollarComputerHardwareListButton = new System.Windows.Forms.Button();
            this.DollarComputerHardwareListGridView = new System.Windows.Forms.DataGridView();
            this.YourSelectionLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DollarComputerHardwareListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DollarComputerHardwareListButton
            // 
            this.DollarComputerHardwareListButton.Location = new System.Drawing.Point(12, 12);
            this.DollarComputerHardwareListButton.Name = "DollarComputerHardwareListButton";
            this.DollarComputerHardwareListButton.Size = new System.Drawing.Size(200, 23);
            this.DollarComputerHardwareListButton.TabIndex = 0;
            this.DollarComputerHardwareListButton.Text = "DollarComputer Hardware List";
            this.DollarComputerHardwareListButton.UseVisualStyleBackColor = true;
            // 
            // DollarComputerHardwareListGridView
            // 
            this.DollarComputerHardwareListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DollarComputerHardwareListGridView.Location = new System.Drawing.Point(12, 41);
            this.DollarComputerHardwareListGridView.Name = "DollarComputerHardwareListGridView";
            this.DollarComputerHardwareListGridView.Size = new System.Drawing.Size(776, 368);
            this.DollarComputerHardwareListGridView.TabIndex = 1;
            // 
            // YourSelectionLabel
            // 
            this.YourSelectionLabel.AutoSize = true;
            this.YourSelectionLabel.Location = new System.Drawing.Point(9, 420);
            this.YourSelectionLabel.Name = "YourSelectionLabel";
            this.YourSelectionLabel.Size = new System.Drawing.Size(76, 13);
            this.YourSelectionLabel.TabIndex = 2;
            this.YourSelectionLabel.Text = "Your Selection";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(713, 415);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(632, 415);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 417);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(535, 20);
            this.textBox1.TabIndex = 5;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.YourSelectionLabel);
            this.Controls.Add(this.DollarComputerHardwareListGridView);
            this.Controls.Add(this.DollarComputerHardwareListButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            ((System.ComponentModel.ISupportInitialize)(this.DollarComputerHardwareListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DollarComputerHardwareListButton;
        private System.Windows.Forms.DataGridView DollarComputerHardwareListGridView;
        private System.Windows.Forms.Label YourSelectionLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

