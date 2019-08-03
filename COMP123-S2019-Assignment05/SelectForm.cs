using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.BeginTag = "SelectOrder";

            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.Show();
            //Program.productInfoForm.Show();
            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 
            // 'dollarComputersDataSet.products' table. You can move, 
            // or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
        }

        private void SelectFormGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectAllRow(e.RowIndex);
        }
       
        private int _colCount;
        private int _colIndex;

        private void SelectAllRow(int rowIndex)
        {
            try
            {
                this.SelectFormGridView.Rows[rowIndex].Selected = true;

                _colCount = 0;
                _colIndex = 0;

                _colCount = this.SelectFormGridView.Columns.Count;
                DollarComputersFields.dollarComputersArray = new List<string>();

                this.ClearDollarComputerFields();
                while (_colIndex < _colCount)
                {
                    var rowValue = this.SelectFormGridView.Rows[rowIndex].Cells[_colIndex].Value;
                    DollarComputersFields.dollarComputersArray.Add(Convert.ToString(rowValue).Trim());

                    _colIndex += 1;
                }
                this.PopulateDollarComputerFields(DollarComputersFields.dollarComputersArray);
 
                this.YourSelectionTextBox.Text = 
                    DollarComputersFields.Manufacturer + " " +
                    DollarComputersFields.Model + " " +
                    DollarComputersFields.Cost;

                this.NextButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dollar Computers",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.NextButton.Enabled = false;
            }
        }

        private void ClearDollarComputerFields()
        {
            DollarComputersFields.ProductID = string.Empty;
            DollarComputersFields.Condition = string.Empty;
            DollarComputersFields.Cost = string.Empty;
            DollarComputersFields.Platform = string.Empty;
            DollarComputersFields.Manufacturer = string.Empty;
            DollarComputersFields.OS = string.Empty;
            DollarComputersFields.Model = string.Empty;
            DollarComputersFields.Memory = string.Empty;
            DollarComputersFields.LCDSize = string.Empty;
            DollarComputersFields.HDD = string.Empty;
            DollarComputersFields.CPUBrand = string.Empty;
            DollarComputersFields.CPUNumber = string.Empty;
            DollarComputersFields.CPUType = string.Empty;
            DollarComputersFields.CPUSpeed = string.Empty;
            DollarComputersFields.GPUType = string.Empty;
            DollarComputersFields.WebCam = string.Empty;
        }

        private void PopulateDollarComputerFields(List<string> dollarComputerArray)
        {
            DollarComputersFields.ProductID = dollarComputerArray[0];
            DollarComputersFields.Condition = dollarComputerArray[14];
            DollarComputersFields.Cost = Convert.ToDouble(dollarComputerArray[1]).ToString("C2").Trim();
            DollarComputersFields.Platform = dollarComputerArray[16];
            DollarComputersFields.Manufacturer = dollarComputerArray[2];
            DollarComputersFields.OS = dollarComputerArray[15];
            DollarComputersFields.Model = dollarComputerArray[3];
            DollarComputersFields.Memory = dollarComputerArray[5];
            DollarComputersFields.LCDSize = dollarComputerArray[7];
            DollarComputersFields.HDD = dollarComputerArray[17];
            DollarComputersFields.CPUBrand = dollarComputerArray[10];
            DollarComputersFields.CPUNumber = dollarComputerArray[13];
            DollarComputersFields.CPUType = dollarComputerArray[11];
            DollarComputersFields.CPUSpeed = dollarComputerArray[12];
            DollarComputersFields.GPUType = dollarComputerArray[19];
            DollarComputersFields.WebCam = dollarComputerArray[30];
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult _dResult =
                MessageBox.Show("Do you want to exit the program?", "Dollar Computers",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_dResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
