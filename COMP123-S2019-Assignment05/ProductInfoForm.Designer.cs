namespace COMP123_S2019_Assignment05
{
    partial class ProductInfoForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Location = new System.Drawing.Point(57, 52);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(58, 13);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Location = new System.Drawing.Point(121, 49);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductIDTextBox.TabIndex = 2;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(379, 49);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConditionTextBox.TabIndex = 4;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(322, 52);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(51, 13);
            this.ConditionLabel.TabIndex = 3;
            this.ConditionLabel.Text = "Condition";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(625, 49);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 6;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(591, 52);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(28, 13);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(172, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(172, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}