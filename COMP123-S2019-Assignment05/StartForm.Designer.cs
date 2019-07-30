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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartNewOrderButton = new System.Windows.Forms.Button();
            this.ExitForm = new System.Windows.Forms.Button();
            this.OpenSavedOrderButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StartNewOrderButton);
            this.groupBox1.Controls.Add(this.ExitForm);
            this.groupBox1.Controls.Add(this.OpenSavedOrderButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 449);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Image = global::COMP123_S2019_Assignment05.Properties.Resources.gold_coin;
            this.pictureBox1.Location = new System.Drawing.Point(175, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Your Computer Today!";
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.Image = global::COMP123_S2019_Assignment05.Properties.Resources.cart;
            this.StartNewOrderButton.Location = new System.Drawing.Point(7, 123);
            this.StartNewOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(160, 200);
            this.StartNewOrderButton.TabIndex = 0;
            this.StartNewOrderButton.Text = "Start a New Order";
            this.StartNewOrderButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StartNewOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StartNewOrderButton.UseVisualStyleBackColor = true;
            this.StartNewOrderButton.Click += new System.EventHandler(this.StartNewOrderButton_Click);
            // 
            // ExitForm
            // 
            this.ExitForm.Image = global::COMP123_S2019_Assignment05.Properties.Resources.exit;
            this.ExitForm.Location = new System.Drawing.Point(344, 123);
            this.ExitForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitForm.Name = "ExitForm";
            this.ExitForm.Size = new System.Drawing.Size(160, 200);
            this.ExitForm.TabIndex = 2;
            this.ExitForm.Text = "Exit";
            this.ExitForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitForm.UseVisualStyleBackColor = true;
            this.ExitForm.Click += new System.EventHandler(this.ExitForm_Click);
            // 
            // OpenSavedOrderButton
            // 
            this.OpenSavedOrderButton.Image = global::COMP123_S2019_Assignment05.Properties.Resources.order;
            this.OpenSavedOrderButton.Location = new System.Drawing.Point(176, 228);
            this.OpenSavedOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpenSavedOrderButton.Name = "OpenSavedOrderButton";
            this.OpenSavedOrderButton.Size = new System.Drawing.Size(160, 200);
            this.OpenSavedOrderButton.TabIndex = 1;
            this.OpenSavedOrderButton.Text = "Open a Saved Order";
            this.OpenSavedOrderButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OpenSavedOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenSavedOrderButton.UseVisualStyleBackColor = true;
            this.OpenSavedOrderButton.Click += new System.EventHandler(this.OpenSavedOrderButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 461);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computers!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Button OpenSavedOrderButton;
        private System.Windows.Forms.Button ExitForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}