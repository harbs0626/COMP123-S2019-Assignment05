using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Program.Forms[FormName.ProductInfoForm.ToString()].Show();
            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void DollarComputerHardwareListGridView_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            this.SelectAllRow(e.RowIndex);
        }

        private void SelectAllRow(int _rowIndex)
        {
            try
            {
                this.DollarComputerHardwareListGridView.Rows[_rowIndex].Selected = true;

                DollarComputersFields.Manufacturer = string.Empty;
                DollarComputersFields.Model = string.Empty;
                DollarComputersFields.Cost = string.Empty;

                DollarComputersFields.Manufacturer = 
                    Convert.ToString(this.DollarComputerHardwareListGridView.Rows[_rowIndex].Cells[2].Value).Trim();
                DollarComputersFields.Model = 
                    Convert.ToString(this.DollarComputerHardwareListGridView.Rows[_rowIndex].Cells[3].Value).Trim();
                DollarComputersFields.Cost = 
                    Convert.ToDouble(this.DollarComputerHardwareListGridView.Rows[_rowIndex].Cells[1].Value).ToString("C2").Trim();

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
