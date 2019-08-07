namespace COMP123_S2019_Assignment05
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.OrderFormFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderFormPrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OrderFormExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderFormEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderFormBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderFormHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderFormAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeed = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.FinishButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.YourPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.OrderFormImage = new System.Windows.Forms.PictureBox();
            this.OrderFormPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.OrderFormMenuStrip.SuspendLayout();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.YourPriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFormImage)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.OrderFormMenuStrip, "OrderFormMenuStrip");
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderFormFileToolStripMenuItem,
            this.OrderFormEditToolStripMenuItem,
            this.OrderFormHelpToolStripMenuItem});
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            // 
            // OrderFormFileToolStripMenuItem
            // 
            this.OrderFormFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderFormPrintToolStripMenuItem,
            this.toolStripSeparator1,
            this.OrderFormExitToolStripMenuItem});
            this.OrderFormFileToolStripMenuItem.Name = "OrderFormFileToolStripMenuItem";
            resources.ApplyResources(this.OrderFormFileToolStripMenuItem, "OrderFormFileToolStripMenuItem");
            // 
            // OrderFormPrintToolStripMenuItem
            // 
            this.OrderFormPrintToolStripMenuItem.Name = "OrderFormPrintToolStripMenuItem";
            resources.ApplyResources(this.OrderFormPrintToolStripMenuItem, "OrderFormPrintToolStripMenuItem");
            this.OrderFormPrintToolStripMenuItem.Click += new System.EventHandler(this.OrderFormPrintToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // OrderFormExitToolStripMenuItem
            // 
            this.OrderFormExitToolStripMenuItem.Name = "OrderFormExitToolStripMenuItem";
            resources.ApplyResources(this.OrderFormExitToolStripMenuItem, "OrderFormExitToolStripMenuItem");
            this.OrderFormExitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OrderFormEditToolStripMenuItem
            // 
            this.OrderFormEditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderFormBackToolStripMenuItem});
            this.OrderFormEditToolStripMenuItem.Name = "OrderFormEditToolStripMenuItem";
            resources.ApplyResources(this.OrderFormEditToolStripMenuItem, "OrderFormEditToolStripMenuItem");
            // 
            // OrderFormBackToolStripMenuItem
            // 
            this.OrderFormBackToolStripMenuItem.Name = "OrderFormBackToolStripMenuItem";
            resources.ApplyResources(this.OrderFormBackToolStripMenuItem, "OrderFormBackToolStripMenuItem");
            this.OrderFormBackToolStripMenuItem.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderFormHelpToolStripMenuItem
            // 
            this.OrderFormHelpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.OrderFormHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderFormAboutToolStripMenuItem});
            this.OrderFormHelpToolStripMenuItem.Name = "OrderFormHelpToolStripMenuItem";
            resources.ApplyResources(this.OrderFormHelpToolStripMenuItem, "OrderFormHelpToolStripMenuItem");
            // 
            // OrderFormAboutToolStripMenuItem
            // 
            this.OrderFormAboutToolStripMenuItem.Name = "OrderFormAboutToolStripMenuItem";
            resources.ApplyResources(this.OrderFormAboutToolStripMenuItem, "OrderFormAboutToolStripMenuItem");
            this.OrderFormAboutToolStripMenuItem.Click += new System.EventHandler(this.OrderFormAboutToolStripMenuItem_Click);
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.Controls.Add(this.OSTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.WebCamTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.GPUTypeTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUSpeedTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUNumberTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.LCDSizeTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUBrandTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.MemoryTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.panel1);
            this.SystemComponentsGroupBox.Controls.Add(this.WebCamLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.MemoryLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUSpeed);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OSLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.shapeContainer1);
            resources.ApplyResources(this.SystemComponentsGroupBox, "SystemComponentsGroupBox");
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.TabStop = false;
            // 
            // OSTextBox
            // 
            this.OSTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.OSTextBox, "OSTextBox");
            this.OSTextBox.Name = "OSTextBox";
            // 
            // ConditionTextBox
            // 
            resources.ApplyResources(this.ConditionTextBox, "ConditionTextBox");
            this.ConditionTextBox.Name = "ConditionTextBox";
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.WebCamTextBox, "WebCamTextBox");
            this.WebCamTextBox.Name = "WebCamTextBox";
            // 
            // PlatformTextBox
            // 
            resources.ApplyResources(this.PlatformTextBox, "PlatformTextBox");
            this.PlatformTextBox.Name = "PlatformTextBox";
            // 
            // ManufacturerTextBox
            // 
            resources.ApplyResources(this.ManufacturerTextBox, "ManufacturerTextBox");
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.GPUTypeTextBox, "GPUTypeTextBox");
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            // 
            // ConditionLabel
            // 
            resources.ApplyResources(this.ConditionLabel, "ConditionLabel");
            this.ConditionLabel.Name = "ConditionLabel";
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.HDDTextBox, "HDDTextBox");
            this.HDDTextBox.Name = "HDDTextBox";
            // 
            // ModelTextBox
            // 
            resources.ApplyResources(this.ModelTextBox, "ModelTextBox");
            this.ModelTextBox.Name = "ModelTextBox";
            // 
            // PlatformLabel
            // 
            resources.ApplyResources(this.PlatformLabel, "PlatformLabel");
            this.PlatformLabel.Name = "PlatformLabel";
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.CPUSpeedTextBox, "CPUSpeedTextBox");
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            // 
            // ModelLabel
            // 
            resources.ApplyResources(this.ModelLabel, "ModelLabel");
            this.ModelLabel.Name = "ModelLabel";
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.CPUNumberTextBox, "CPUNumberTextBox");
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            // 
            // ManufacturerLabel
            // 
            resources.ApplyResources(this.ManufacturerLabel, "ManufacturerLabel");
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.CPUTypeTextBox, "CPUTypeTextBox");
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.LCDSizeTextBox, "LCDSizeTextBox");
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.CPUBrandTextBox, "CPUBrandTextBox");
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.MemoryTextBox, "MemoryTextBox");
            this.MemoryTextBox.Name = "MemoryTextBox";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // WebCamLabel
            // 
            resources.ApplyResources(this.WebCamLabel, "WebCamLabel");
            this.WebCamLabel.BackColor = System.Drawing.Color.Transparent;
            this.WebCamLabel.Name = "WebCamLabel";
            // 
            // LCDSizeLabel
            // 
            resources.ApplyResources(this.LCDSizeLabel, "LCDSizeLabel");
            this.LCDSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            // 
            // MemoryLabel
            // 
            resources.ApplyResources(this.MemoryLabel, "MemoryLabel");
            this.MemoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.MemoryLabel.Name = "MemoryLabel";
            // 
            // GPUTypeLabel
            // 
            resources.ApplyResources(this.GPUTypeLabel, "GPUTypeLabel");
            this.GPUTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            // 
            // HDDLabel
            // 
            resources.ApplyResources(this.HDDLabel, "HDDLabel");
            this.HDDLabel.BackColor = System.Drawing.Color.Transparent;
            this.HDDLabel.Name = "HDDLabel";
            // 
            // CPUSpeed
            // 
            resources.ApplyResources(this.CPUSpeed, "CPUSpeed");
            this.CPUSpeed.BackColor = System.Drawing.Color.Transparent;
            this.CPUSpeed.Name = "CPUSpeed";
            // 
            // CPUNumberLabel
            // 
            resources.ApplyResources(this.CPUNumberLabel, "CPUNumberLabel");
            this.CPUNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            // 
            // CPUTypeLabel
            // 
            resources.ApplyResources(this.CPUTypeLabel, "CPUTypeLabel");
            this.CPUTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            // 
            // CPUBrandLabel
            // 
            resources.ApplyResources(this.CPUBrandLabel, "CPUBrandLabel");
            this.CPUBrandLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            // 
            // OSLabel
            // 
            resources.ApplyResources(this.OSLabel, "OSLabel");
            this.OSLabel.BackColor = System.Drawing.Color.Transparent;
            this.OSLabel.Name = "OSLabel";
            // 
            // shapeContainer1
            // 
            resources.ApplyResources(this.shapeContainer1, "shapeContainer1");
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            resources.ApplyResources(this.lineShape1, "lineShape1");
            // 
            // FinishButton
            // 
            resources.ApplyResources(this.FinishButton, "FinishButton");
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // CancelButton
            // 
            resources.ApplyResources(this.CancelButton, "CancelButton");
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BackButton
            // 
            resources.ApplyResources(this.BackButton, "BackButton");
            this.BackButton.Name = "BackButton";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // YourPriceGroupBox
            // 
            this.YourPriceGroupBox.Controls.Add(this.TotalTextBox);
            this.YourPriceGroupBox.Controls.Add(this.TotalLabel);
            this.YourPriceGroupBox.Controls.Add(this.CostTextBox);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourPriceGroupBox.Controls.Add(this.PriceLabel);
            this.YourPriceGroupBox.Controls.Add(this.shapeContainer3);
            resources.ApplyResources(this.YourPriceGroupBox, "YourPriceGroupBox");
            this.YourPriceGroupBox.Name = "YourPriceGroupBox";
            this.YourPriceGroupBox.TabStop = false;
            // 
            // TotalTextBox
            // 
            resources.ApplyResources(this.TotalTextBox, "TotalTextBox");
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            // 
            // TotalLabel
            // 
            resources.ApplyResources(this.TotalLabel, "TotalLabel");
            this.TotalLabel.Name = "TotalLabel";
            // 
            // CostTextBox
            // 
            resources.ApplyResources(this.CostTextBox, "CostTextBox");
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            // 
            // SalesTaxTextBox
            // 
            resources.ApplyResources(this.SalesTaxTextBox, "SalesTaxTextBox");
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            // 
            // SalesTaxLabel
            // 
            resources.ApplyResources(this.SalesTaxLabel, "SalesTaxLabel");
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            // 
            // PriceLabel
            // 
            resources.ApplyResources(this.PriceLabel, "PriceLabel");
            this.PriceLabel.Name = "PriceLabel";
            // 
            // shapeContainer3
            // 
            resources.ApplyResources(this.shapeContainer3, "shapeContainer3");
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            resources.ApplyResources(this.lineShape2, "lineShape2");
            // 
            // OrderFormImage
            // 
            this.OrderFormImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderFormImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.OrderFormImage, "OrderFormImage");
            this.OrderFormImage.Name = "OrderFormImage";
            this.OrderFormImage.TabStop = false;
            // 
            // OrderFormPrintForm
            // 
            this.OrderFormPrintForm.DocumentName = "document";
            this.OrderFormPrintForm.Form = this;
            this.OrderFormPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.OrderFormPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("OrderFormPrintForm.PrinterSettings")));
            this.OrderFormPrintForm.PrintFileName = null;
            // 
            // OrderForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.OrderFormImage);
            this.Controls.Add(this.YourPriceGroupBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Name = "OrderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.SystemComponentsGroupBox.PerformLayout();
            this.YourPriceGroupBox.ResumeLayout(false);
            this.YourPriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFormImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OrderFormFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderFormEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderFormHelpToolStripMenuItem;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.ToolStripMenuItem OrderFormPrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem OrderFormExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderFormBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderFormAboutToolStripMenuItem;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeed;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox YourPriceGroupBox;
        private System.Windows.Forms.PictureBox OrderFormImage;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm OrderFormPrintForm;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label TotalLabel;
    }
}