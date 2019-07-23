namespace COMP123_S2019_Assignment05
{
    partial class StartForm
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
            this.StartNewOrderButton = new System.Windows.Forms.Button();
            this.OpenSavedOrderButton = new System.Windows.Forms.Button();
            this.ExitForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.Location = new System.Drawing.Point(0, 0);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(150, 23);
            this.StartNewOrderButton.TabIndex = 0;
            this.StartNewOrderButton.Text = "Start a New Order";
            this.StartNewOrderButton.UseVisualStyleBackColor = true;
            this.StartNewOrderButton.Click += new System.EventHandler(this.StartNewOrderButton_Click);
            // 
            // OpenSavedOrderButton
            // 
            this.OpenSavedOrderButton.Location = new System.Drawing.Point(0, 29);
            this.OpenSavedOrderButton.Name = "OpenSavedOrderButton";
            this.OpenSavedOrderButton.Size = new System.Drawing.Size(150, 23);
            this.OpenSavedOrderButton.TabIndex = 1;
            this.OpenSavedOrderButton.Text = "Open a Saved Order";
            this.OpenSavedOrderButton.UseVisualStyleBackColor = true;
            // 
            // ExitForm
            // 
            this.ExitForm.Location = new System.Drawing.Point(0, 58);
            this.ExitForm.Name = "ExitForm";
            this.ExitForm.Size = new System.Drawing.Size(150, 23);
            this.ExitForm.TabIndex = 2;
            this.ExitForm.Text = "Exit";
            this.ExitForm.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ExitForm);
            this.Controls.Add(this.OpenSavedOrderButton);
            this.Controls.Add(this.StartNewOrderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computer!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Button OpenSavedOrderButton;
        private System.Windows.Forms.Button ExitForm;
    }
}