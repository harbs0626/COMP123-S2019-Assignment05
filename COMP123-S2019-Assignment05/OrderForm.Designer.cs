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
            this.OrderFormMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderFormFileToolStripMenuItem,
            this.OrderFormEditToolStripMenuItem,
            this.OrderFormHelpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(884, 31);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // OrderFormFileToolStripMenuItem
            // 
            this.OrderFormFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderFormPrintToolStripMenuItem,
            this.toolStripSeparator1,
            this.OrderFormExitToolStripMenuItem});
            this.OrderFormFileToolStripMenuItem.Name = "OrderFormFileToolStripMenuItem";
            this.OrderFormFileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.OrderFormFileToolStripMenuItem.Text = "&File";
            // 
            // OrderFormPrintToolStripMenuItem
            // 
            this.OrderFormPrintToolStripMenuItem.Name = "OrderFormPrintToolStripMenuItem";
            this.OrderFormPrintToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.OrderFormPrintToolStripMenuItem.Text = "&Print";
            this.OrderFormPrintToolStripMenuItem.Click += new System.EventHandler(this.OrderFormPrintToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // OrderFormExitToolStripMenuItem
            // 
            this.OrderFormExitToolStripMenuItem.Name = "OrderFormExitToolStripMenuItem";
            this.OrderFormExitToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.OrderFormExitToolStripMenuItem.Text = "E&xit";
            this.OrderFormExitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OrderFormEditToolStripMenuItem
            // 
            this.OrderFormEditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderFormBackToolStripMenuItem});
            this.OrderFormEditToolStripMenuItem.Name = "OrderFormEditToolStripMenuItem";
            this.OrderFormEditToolStripMenuItem.Size = new System.Drawing.Size(48, 25);
            this.OrderFormEditToolStripMenuItem.Text = "&Edit";
            // 
            // OrderFormBackToolStripMenuItem
            // 
            this.OrderFormBackToolStripMenuItem.Name = "OrderFormBackToolStripMenuItem";
            this.OrderFormBackToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.OrderFormBackToolStripMenuItem.Text = "&Back";
            this.OrderFormBackToolStripMenuItem.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderFormHelpToolStripMenuItem
            // 
            this.OrderFormHelpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.OrderFormHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderFormAboutToolStripMenuItem});
            this.OrderFormHelpToolStripMenuItem.Name = "OrderFormHelpToolStripMenuItem";
            this.OrderFormHelpToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.OrderFormHelpToolStripMenuItem.Text = "&Help";
            // 
            // OrderFormAboutToolStripMenuItem
            // 
            this.OrderFormAboutToolStripMenuItem.Name = "OrderFormAboutToolStripMenuItem";
            this.OrderFormAboutToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.OrderFormAboutToolStripMenuItem.Text = "&About";
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
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(13, 45);
            this.SystemComponentsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(537, 500);
            this.SystemComponentsGroupBox.TabIndex = 1;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            // 
            // OSTextBox
            // 
            this.OSTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OSTextBox.Enabled = false;
            this.OSTextBox.Location = new System.Drawing.Point(131, 461);
            this.OSTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(385, 22);
            this.OSTextBox.TabIndex = 9;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Enabled = false;
            this.ConditionTextBox.Location = new System.Drawing.Point(126, 32);
            this.ConditionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(150, 29);
            this.ConditionTextBox.TabIndex = 7;
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WebCamTextBox.Enabled = false;
            this.WebCamTextBox.Location = new System.Drawing.Point(131, 424);
            this.WebCamTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.Size = new System.Drawing.Size(385, 22);
            this.WebCamTextBox.TabIndex = 8;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Enabled = false;
            this.PlatformTextBox.Location = new System.Drawing.Point(371, 32);
            this.PlatformTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(150, 29);
            this.PlatformTextBox.TabIndex = 4;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Enabled = false;
            this.ManufacturerTextBox.Location = new System.Drawing.Point(126, 74);
            this.ManufacturerTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(150, 29);
            this.ManufacturerTextBox.TabIndex = 6;
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPUTypeTextBox.Enabled = false;
            this.GPUTypeTextBox.Location = new System.Drawing.Point(131, 386);
            this.GPUTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.Size = new System.Drawing.Size(385, 22);
            this.GPUTypeTextBox.TabIndex = 7;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(40, 36);
            this.ConditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(92, 21);
            this.ConditionLabel.TabIndex = 0;
            this.ConditionLabel.Text = "Condition - ";
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HDDTextBox.Enabled = false;
            this.HDDTextBox.Location = new System.Drawing.Point(131, 349);
            this.HDDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.Size = new System.Drawing.Size(385, 22);
            this.HDDTextBox.TabIndex = 6;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Enabled = false;
            this.ModelTextBox.Location = new System.Drawing.Point(371, 74);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(150, 29);
            this.ModelTextBox.TabIndex = 5;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(293, 36);
            this.PlatformLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(84, 21);
            this.PlatformLabel.TabIndex = 2;
            this.PlatformLabel.Text = "Platform - ";
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CPUSpeedTextBox.Enabled = false;
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(131, 312);
            this.CPUSpeedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(385, 22);
            this.CPUSpeedTextBox.TabIndex = 5;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(309, 78);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(68, 21);
            this.ModelLabel.TabIndex = 3;
            this.ModelLabel.Text = "Model - ";
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CPUNumberTextBox.Enabled = false;
            this.CPUNumberTextBox.Location = new System.Drawing.Point(131, 273);
            this.CPUNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.Size = new System.Drawing.Size(385, 22);
            this.CPUNumberTextBox.TabIndex = 4;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(14, 78);
            this.ManufacturerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(118, 21);
            this.ManufacturerLabel.TabIndex = 1;
            this.ManufacturerLabel.Text = "Manufacturer - ";
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CPUTypeTextBox.Enabled = false;
            this.CPUTypeTextBox.Location = new System.Drawing.Point(131, 236);
            this.CPUTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.Size = new System.Drawing.Size(385, 22);
            this.CPUTypeTextBox.TabIndex = 3;
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LCDSizeTextBox.Enabled = false;
            this.LCDSizeTextBox.Location = new System.Drawing.Point(131, 126);
            this.LCDSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.Size = new System.Drawing.Size(385, 22);
            this.LCDSizeTextBox.TabIndex = 0;
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CPUBrandTextBox.Enabled = false;
            this.CPUBrandTextBox.Location = new System.Drawing.Point(131, 199);
            this.CPUBrandTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.Size = new System.Drawing.Size(385, 22);
            this.CPUBrandTextBox.TabIndex = 2;
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MemoryTextBox.Enabled = false;
            this.MemoryTextBox.Location = new System.Drawing.Point(131, 163);
            this.MemoryTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.Size = new System.Drawing.Size(385, 22);
            this.MemoryTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(126, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 366);
            this.panel1.TabIndex = 20;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.BackColor = System.Drawing.Color.Transparent;
            this.WebCamLabel.Location = new System.Drawing.Point(41, 425);
            this.WebCamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(91, 21);
            this.WebCamLabel.TabIndex = 18;
            this.WebCamLabel.Text = "Web Cam - ";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.LCDSizeLabel.Location = new System.Drawing.Point(48, 127);
            this.LCDSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(84, 21);
            this.LCDSizeLabel.TabIndex = 10;
            this.LCDSizeLabel.Text = "LCD Size - ";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.MemoryLabel.Location = new System.Drawing.Point(49, 164);
            this.MemoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(83, 21);
            this.MemoryLabel.TabIndex = 11;
            this.MemoryLabel.Text = "Memory - ";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.GPUTypeLabel.Location = new System.Drawing.Point(41, 387);
            this.GPUTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(91, 21);
            this.GPUTypeLabel.TabIndex = 17;
            this.GPUTypeLabel.Text = "GPU Type - ";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.BackColor = System.Drawing.Color.Transparent;
            this.HDDLabel.Location = new System.Drawing.Point(75, 350);
            this.HDDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(57, 21);
            this.HDDLabel.TabIndex = 16;
            this.HDDLabel.Text = "HDD - ";
            // 
            // CPUSpeed
            // 
            this.CPUSpeed.AutoSize = true;
            this.CPUSpeed.BackColor = System.Drawing.Color.Transparent;
            this.CPUSpeed.Location = new System.Drawing.Point(31, 313);
            this.CPUSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPUSpeed.Name = "CPUSpeed";
            this.CPUSpeed.Size = new System.Drawing.Size(101, 21);
            this.CPUSpeed.TabIndex = 15;
            this.CPUSpeed.Text = "CPU Speed - ";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUNumberLabel.Location = new System.Drawing.Point(16, 274);
            this.CPUNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(116, 21);
            this.CPUNumberLabel.TabIndex = 14;
            this.CPUNumberLabel.Text = "CPU Number - ";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUTypeLabel.Location = new System.Drawing.Point(42, 237);
            this.CPUTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(90, 21);
            this.CPUTypeLabel.TabIndex = 13;
            this.CPUTypeLabel.Text = "CPU Type - ";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUBrandLabel.Location = new System.Drawing.Point(33, 200);
            this.CPUBrandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(99, 21);
            this.CPUBrandLabel.TabIndex = 12;
            this.CPUBrandLabel.Text = "CPU Brand - ";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.BackColor = System.Drawing.Color.Transparent;
            this.OSLabel.Location = new System.Drawing.Point(87, 462);
            this.OSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(45, 21);
            this.OSLabel.TabIndex = 19;
            this.OSLabel.Text = "OS - ";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(4, 27);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(529, 468);
            this.shapeContainer1.TabIndex = 21;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 15;
            this.lineShape1.X2 = 517;
            this.lineShape1.Y1 = 86;
            this.lineShape1.Y2 = 86;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(774, 509);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(98, 40);
            this.FinishButton.TabIndex = 2;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(670, 509);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(98, 40);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(566, 509);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(98, 40);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
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
            this.YourPriceGroupBox.Location = new System.Drawing.Point(566, 319);
            this.YourPriceGroupBox.Name = "YourPriceGroupBox";
            this.YourPriceGroupBox.Size = new System.Drawing.Size(306, 184);
            this.YourPriceGroupBox.TabIndex = 5;
            this.YourPriceGroupBox.TabStop = false;
            this.YourPriceGroupBox.Text = "Your Price";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(140, 131);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(150, 29);
            this.TotalTextBox.TabIndex = 28;
            this.TotalTextBox.Text = "0.00";
            this.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(90, 135);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(56, 21);
            this.TotalLabel.TabIndex = 27;
            this.TotalLabel.Text = "Total - ";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(140, 31);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(150, 29);
            this.CostTextBox.TabIndex = 24;
            this.CostTextBox.Text = "$0.00";
            this.CostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(140, 69);
            this.SalesTaxTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(150, 29);
            this.SalesTaxTextBox.TabIndex = 25;
            this.SalesTaxTextBox.Text = "0.13";
            this.SalesTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(15, 73);
            this.SalesTaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(130, 21);
            this.SalesTaxLabel.TabIndex = 23;
            this.SalesTaxLabel.Text = "Sales Tax (13%) - ";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(87, 35);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(58, 21);
            this.PriceLabel.TabIndex = 22;
            this.PriceLabel.Text = "Price - ";
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(3, 25);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer3.Size = new System.Drawing.Size(300, 156);
            this.shapeContainer3.TabIndex = 26;
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 17;
            this.lineShape2.X2 = 286;
            this.lineShape2.Y1 = 81;
            this.lineShape2.Y2 = 81;
            // 
            // OrderFormImage
            // 
            this.OrderFormImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderFormImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderFormImage.Location = new System.Drawing.Point(557, 56);
            this.OrderFormImage.Name = "OrderFormImage";
            this.OrderFormImage.Size = new System.Drawing.Size(150, 150);
            this.OrderFormImage.TabIndex = 6;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.ControlBox = false;
            this.Controls.Add(this.OrderFormImage);
            this.Controls.Add(this.YourPriceGroupBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
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