using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks.Printing;
using System.Resources;
/// <summary>
/// 
/// Course Name:    COMP123
/// Course Section: Section 002
/// Assignment:     #5-Dollar Computers
/// Student Name:   Harbin Ramo
/// Student Number: 301046044
/// 
/// </summary>
namespace COMP123_S2019_Assignment05
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// This method loads the data from the Product Info Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Program.NextTag)
                {
                    case "OpenProductInfoForm":
                        if (DollarComputersFields.dollarComputersOrder != null)
                        {
                            this.PopulateDollarComputerFields(DollarComputersFields.dollarComputersOrder);
                            this.LoadSelectedRow();
                        }
                        else
                        {
                            this.LoadSelectedRow();
                        }
                        break;
                    default:
                        this.LoadSelectedRow();
                        break;
                }
            }
            catch (Exception ex)
            {
                this.ApplicationMessage($"Unable to load data due to error: {ex.Message}", "Dollar Computers",
                    "ExceptionError");
                return;
            }
        }

        /// <summary>
        /// 1. This method loads the item that were stored 
        /// temporarily from the DollarComputersFields class
        /// 
        /// 2. Loads the image from the resource.resx
        /// 
        /// 3. Compute the total cost after tax 
        /// </summary>
        private void LoadSelectedRow()
        {
            this.ConditionTextBox.Text = DollarComputersFields.Condition;
            this.CostTextBox.Text = DollarComputersFields.Cost;
            this.PlatformTextBox.Text = DollarComputersFields.Platform;
            this.ManufacturerTextBox.Text = DollarComputersFields.Manufacturer;
            this.OSTextBox.Text = DollarComputersFields.OS;
            this.ModelTextBox.Text = DollarComputersFields.Model;
            this.MemoryTextBox.Text = DollarComputersFields.Memory;
            this.LCDSizeTextBox.Text = DollarComputersFields.LCDSize;
            this.HDDTextBox.Text = DollarComputersFields.HDD;
            this.CPUBrandTextBox.Text = DollarComputersFields.CPUBrand;
            this.CPUTypeTextBox.Text = DollarComputersFields.CPUType;
            this.CPUNumberTextBox.Text = DollarComputersFields.CPUNumber;
            this.CPUSpeedTextBox.Text = DollarComputersFields.CPUSpeed;
            this.GPUTypeTextBox.Text = DollarComputersFields.GPUType;
            this.WebCamTextBox.Text = DollarComputersFields.WebCam;

            if (DollarComputersFields.Manufacturer != string.Empty)
            {
                this.LoadImage(DollarComputersFields.Manufacturer);
            }
            if (this.CostTextBox.Text != string.Empty)
            {
                this.ComputeTotalCost(this.CostTextBox.Text);
            }
        }

        /// <summary>
        /// This method loads the image depending on the selected manufacturer
        /// </summary>
        /// <param name="manufacturer"></param>
        private void LoadImage(string manufacturer)
        {
            switch (manufacturer.ToLower()) {
                case "acer":
                    this.OrderFormImage.Image = (Image)COMP123_S2019_Assignment05.Properties.Resources.acer;
                    break;
                case "asus":
                    this.OrderFormImage.Image = (Image)COMP123_S2019_Assignment05.Properties.Resources.asus;
                    break;
                case "hp":
                    this.OrderFormImage.Image = (Image)COMP123_S2019_Assignment05.Properties.Resources.hp;
                    break;
                case "imac":
                    this.OrderFormImage.Image = (Image)COMP123_S2019_Assignment05.Properties.Resources.imac;
                    break;
                case "macpro":
                    this.OrderFormImage.Image = (Image)COMP123_S2019_Assignment05.Properties.Resources.macpro;
                    break;
                case "toshiba":
                    this.OrderFormImage.Image = (Image)COMP123_S2019_Assignment05.Properties.Resources.Toshiba;
                    break;
                case "cybertronpc":
                    this.OrderFormImage.Image = (Image)COMP123_S2019_Assignment05.Properties.Resources.cybertronpc;
                    break;
                case "gateway":
                    this.OrderFormImage.Image = (Image)COMP123_S2019_Assignment05.Properties.Resources.gateway;
                    break;
                case "ibuypower":
                    this.OrderFormImage.Image = (Image)COMP123_S2019_Assignment05.Properties.Resources.ibuypower;
                    break;
                case "lenovo":
                    this.OrderFormImage.Image = (Image)COMP123_S2019_Assignment05.Properties.Resources.Lenovo;
                    break;
            }
        }

        /// <summary>
        /// This method manages the file being opened from the 
        /// OpenOrderFromFile method and load into the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopulateDollarComputerFields(List<string> dollarComputerOrder)
        {
            DollarComputersFields.ProductID = dollarComputerOrder[0];
            DollarComputersFields.Condition = dollarComputerOrder[1];
            DollarComputersFields.Cost = dollarComputerOrder[2];
            DollarComputersFields.Platform = dollarComputerOrder[3];
            DollarComputersFields.Manufacturer = dollarComputerOrder[4];
            DollarComputersFields.OS = dollarComputerOrder[5];
            DollarComputersFields.Model = dollarComputerOrder[6];
            DollarComputersFields.Memory = dollarComputerOrder[7];
            DollarComputersFields.LCDSize = dollarComputerOrder[8];
            DollarComputersFields.HDD = dollarComputerOrder[9];
            DollarComputersFields.CPUBrand = dollarComputerOrder[10];
            DollarComputersFields.CPUNumber = dollarComputerOrder[11];
            DollarComputersFields.CPUType = dollarComputerOrder[12];
            DollarComputersFields.CPUSpeed = dollarComputerOrder[13];
            DollarComputersFields.GPUType = dollarComputerOrder[14];
            DollarComputersFields.WebCam = dollarComputerOrder[15];
        }

        /// <summary>
        /// This method computes the total cost after tax
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComputeTotalCost(string cost)
        {
            double currCost = Convert.ToDouble(cost.ToString().Replace('$',' '));
            double currTax = Convert.ToDouble(this.SalesTaxTextBox.Text);
            this.TotalTextBox.Text = Convert.ToDouble((currCost * currTax) + currCost).ToString("C2").Trim();
        }

        /// <summary>
        /// This method manages the messageboxes to be used in the form
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="mode"></param>
        private void ApplicationMessage(string message, string title, string mode)
        {
            switch (mode)
            {
                case "ExceptionError":
                    MessageBox.Show(message, title,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "OpenOrder":
                    MessageBox.Show(message, title,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        /// <summary>
        /// This method opens the About Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderFormAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.Show();
        }

        /// <summary>
        /// This method manages printing of receipts or orders
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="mode"></param>
        private void OrderFormPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult _dResult =
                MessageBox.Show("Do you want to print a receipt?", "Dollar Computers",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_dResult == DialogResult.Yes)
            {
                this.OrderFormPrintForm.PrintFileName = Directory.GetCurrentDirectory() + "\\OrderFormSlip.txt";
                this.OrderFormPrintForm.PrintAction = PrintAction.PrintToPreview;
                this.OrderFormPrintForm.Print(this, PrintForm.PrintOption.ClientAreaOnly);
                this.Refresh();
            }
        }

        /// <summary>
        /// This method calls the Product Info Form
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="mode"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.Show();
            this.Hide();
        }

        /// <summary>
        /// This method cancels or exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult _dResult =
                MessageBox.Show("Do you want to exit the program?", "Dollar Computers",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_dResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// This method completely closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        /// <summary>
        /// This method finalizes the Order Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 
                MessageBox.Show("Thank you for taking your time in our Dollar Computers App!" + "\n\n" +
                "Please be advised that your order will take 7-10 business days.", "Dollar Computers", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
