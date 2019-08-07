using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// This method manages the Product Info Form 
        /// either opening the data from the database or 
        /// from a saved file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            switch (Program.BeginTag)
            {
                case "StartNewOrder":
                case "SelectOrder":
                    this.LoadSelectedRow();
                    break;
                case "OpenProductInfoForm":
                    DialogResult _dResult =
                        MessageBox.Show("Do you want to open previously saved file?", "Dollar Computers",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (_dResult)
                    {
                        case DialogResult.Yes:
                            this.OpenOrderFromFile();
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// This method loads the item that were stored 
        /// temporarily from the DollarComputersFields class
        /// </summary>
        private void LoadSelectedRow()
        {
            this.ProductIDTextBox.Text = DollarComputersFields.ProductID;
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
        }

        /// <summary>
        /// This method stores temporarily to the 
        /// DollarComputersFields class going to Order Form
        /// </summary>
        private void LoadNextRow()
        {
            DollarComputersFields.ProductID = this.ProductIDTextBox.Text;
            DollarComputersFields.Condition = this.ConditionTextBox.Text;
            DollarComputersFields.Cost = this.CostTextBox.Text;
            DollarComputersFields.Platform = this.PlatformTextBox.Text;
            DollarComputersFields.Manufacturer = this.ManufacturerTextBox.Text;
            DollarComputersFields.OS = this.OSTextBox.Text;
            DollarComputersFields.Model = this.ModelTextBox.Text;
            DollarComputersFields.Memory = this.MemoryTextBox.Text;
            DollarComputersFields.LCDSize = this.LCDSizeTextBox.Text;
            DollarComputersFields.HDD = this.HDDTextBox.Text;
            DollarComputersFields.CPUBrand = this.CPUBrandTextBox.Text;
            DollarComputersFields.CPUType = this.CPUTypeTextBox.Text;
            DollarComputersFields.CPUNumber = this.CPUNumberTextBox.Text;
            DollarComputersFields.CPUSpeed = this.CPUSpeedTextBox.Text;
            DollarComputersFields.GPUType = this.GPUTypeTextBox.Text;
            DollarComputersFields.WebCam = this.WebCamTextBox.Text;
        }

        /// <summary>
        /// This method manages the file being opened from the 
        /// OpenOrderFromFile method and load into the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoFormOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenOrderFromFile();
        }

        /// <summary>
        /// This method stores the data from the file to a List then passed
        /// to PopulateDollarComputerFields method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenOrderFromFile()
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();
            _openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            _openFileDialog.Filter = "Text Files (*.txt) |*.txt| All Files (*.*) |*.*";

            var result = _openFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                using (StreamReader _rdData = new StreamReader(_openFileDialog.FileName))
                {
                    DollarComputersFields.dollarComputersArray = new List<string>();

                    string rdLine = string.Empty;
                    while ((rdLine = _rdData.ReadLine()) != null){
                        DollarComputersFields.dollarComputersArray.Add(rdLine.Remove(0, 3));
                    }
                    this.PopulateDollarComputerFields(DollarComputersFields.dollarComputersArray);
                    this.LoadSelectedRow();

                    _rdData.Close();
                    _rdData.Dispose();

                    this.ApplicationMessage("Successfully read file!", "Dollar Computers",
                        "ReadOrderFromFile");
                }
            }
            else
            {
                this.ApplicationMessage("File was not read!", "Dollar Computers",
                    "ReadOrderFromFileError");
            }
        }

        /// <summary>
        /// This method manages the List from the file to the Dollar Computer Fields class
        /// </summary>
        /// <param name="dollarComputerArray"></param>
        private void PopulateDollarComputerFields(List<string> dollarComputerArray)
        {
            DollarComputersFields.ProductID = dollarComputerArray[0].Trim();
            DollarComputersFields.Condition = dollarComputerArray[1].Trim();
            DollarComputersFields.Cost = dollarComputerArray[2].Trim();
            DollarComputersFields.Platform = dollarComputerArray[3].Trim();
            DollarComputersFields.Manufacturer = dollarComputerArray[4].Trim();
            DollarComputersFields.OS = dollarComputerArray[5].Trim();
            DollarComputersFields.Model = dollarComputerArray[6].Trim();
            DollarComputersFields.Memory = dollarComputerArray[7].Trim();
            DollarComputersFields.LCDSize = dollarComputerArray[8].Trim();
            DollarComputersFields.HDD = dollarComputerArray[9].Trim();
            DollarComputersFields.CPUBrand = dollarComputerArray[10].Trim();
            DollarComputersFields.CPUNumber = dollarComputerArray[11].Trim();
            DollarComputersFields.CPUType = dollarComputerArray[11].Trim();
            DollarComputersFields.CPUSpeed = dollarComputerArray[13].Trim();
            DollarComputersFields.GPUType = dollarComputerArray[14].Trim();
            DollarComputersFields.WebCam = dollarComputerArray[15].Trim();
        }

        /// <summary>
        /// This method calls the SaveOrderToFile method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoFormSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveOrderToFile();
        }

        /// <summary>
        /// This method saves the data to a text file
        /// </summary>
        private void SaveOrderToFile()
        {
            try
            {
                SaveFileDialog _saveFileDialog = new SaveFileDialog();
                _saveFileDialog.Filter = "Text Files (*.txt) |*.txt| All Files (*.*) |*.*";
                _saveFileDialog.Title = "Dollar Computers";
                _saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                _saveFileDialog.FileName = "Product.txt";

                var result = _saveFileDialog.ShowDialog();
                if (result != DialogResult.Cancel)
                {
                    using (StreamWriter _wrData = new StreamWriter(_saveFileDialog.FileName))
                    {
                        _wrData.WriteLine("00|" + this.ProductIDTextBox.Text);
                        _wrData.WriteLine("01|" + this.ConditionTextBox.Text);
                        _wrData.WriteLine("02|" + this.CostTextBox.Text);
                        _wrData.WriteLine("03|" + this.PlatformTextBox.Text);
                        _wrData.WriteLine("04|" + this.ManufacturerTextBox.Text);
                        _wrData.WriteLine("05|" + this.OSTextBox.Text);
                        _wrData.WriteLine("06|" + this.ModelTextBox.Text);
                        _wrData.WriteLine("07|" + this.MemoryTextBox.Text);
                        _wrData.WriteLine("08|" + this.LCDSizeTextBox.Text);
                        _wrData.WriteLine("09|" + this.HDDTextBox.Text);
                        _wrData.WriteLine("10|" + this.CPUBrandTextBox.Text);
                        _wrData.WriteLine("11|" + this.CPUTypeTextBox.Text);
                        _wrData.WriteLine("12|" + this.CPUNumberTextBox.Text);
                        _wrData.WriteLine("13|" + this.CPUSpeedTextBox.Text);
                        _wrData.WriteLine("14|" + this.GPUTypeTextBox.Text);
                        _wrData.WriteLine("15|" + this.WebCamTextBox.Text);
                        
                        _wrData.Close();
                        _wrData.Dispose();

                        this.ApplicationMessage("Successfully save file!", "Dollar Computers",
                            "SaveOrderToFile");
                    }
                }
                else
                {
                    this.ApplicationMessage("File was not saved!", "Dollar Computers",
                        "SaveOrderToFileError");
                }
            }
            catch (Exception ex)
            {
                this.ApplicationMessage($"Unable to save file due to error: {ex.Message}", "Dollar Computers",
                    "ExceptionError");
                return;
            }
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
                case "ReadOrderFromFileError":
                case "SaveOrderToFileError":
                    MessageBox.Show(message, title,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "OpenSavedOrder":
                case "ReadOrderFromFile":
                case "SaveOrderToFile":
                    MessageBox.Show(message, title, 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        /// <summary>
        /// This method opens the Select Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProduct_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
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
        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method opens the Order Form and pass the list 
        /// collection to the Order Form for further processing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.NextTag = Program.BeginTag;

            switch (Program.BeginTag)
            {
                case "StartNewOrder":
                case "SelectOrder":
                    break;
                case "OpenProductInfoForm":
                    if (DollarComputersFields.dollarComputersArray != null)
                    {
                        DollarComputersFields.dollarComputersOrder =
                            DollarComputersFields.dollarComputersArray.ToList();
                    }
                    else
                    {
                        this.LoadNextRow();
                    }
                    break;
            }

            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Hide();
        }
    }
}
