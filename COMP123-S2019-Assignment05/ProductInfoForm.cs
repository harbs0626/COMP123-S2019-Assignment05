﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace COMP123_S2019_Assignment05
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            DialogResult _dResult =
                MessageBox.Show("Do you want to open previously saved file?", "Dollar Computers",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (_dResult)
            {
                case DialogResult.Yes:
                    this.OpenOrderFromFile();
                    break;
                default:
                    this.LoadSelectedRow();
                    break;
            }
        }

        private void LoadSelectedRow()
        {
            this.ProductIDTextBox.Text = DollarComputersFields.ProductID;
            this.ConditionTextBox.Text = DollarComputersFields.Condition;
            this.CostTextBox.Text = DollarComputersFields.Cost;
        }

        private void ProductInfoFormOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenOrderFromFile();
        }

        private void OpenOrderFromFile()
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();
            _openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            _openFileDialog.Filter = "Text Files (*.txt)|(*.txt)| All Files (*.*)|(*.*)";
            _openFileDialog.ShowDialog();

            string _fileName = string.Empty;
            _fileName = _openFileDialog.FileName;

            if ((_fileName == null) || (_fileName == ""))
            {
                this.ApplicationMessage("No file selected!", "Dollar Computers", 
                    "OpenFileDialog");
                return;
            }
            else
            {
                Program.FileName = _fileName;
                this.ApplicationMessage("Previously saved file has been loaded!", "Dollar Computers",
                    "OpenSavedOrder");
            }
        }

        private void ProductInfoFormSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveOrderToFile();
        }

        private void SaveOrderToFile()
        {
            try
            {
                SaveFileDialog _saveFileDialog = new SaveFileDialog();
                _saveFileDialog.Filter = "Text Files (*.txt)|(*.txt)| All Files (*.*)|(*.*)";
                _saveFileDialog.Title = "Dollar Computers";
                _saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                _saveFileDialog.FileName = "Product.txt";
                _saveFileDialog.ShowDialog();

                using (StreamWriter _wrData = new StreamWriter(_saveFileDialog.FileName))
                {
                    _wrData.WriteLine(this.ProductIDTextBox.Text);
                    _wrData.Close();
                    _wrData.Dispose();

                    MessageBox.Show($"Successfully save file!", "Dollar Computers",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to save file due to error: {ex.Message}", "Dollar Computers",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ApplicationMessage(string message, string title, string mode)
        {
            switch (mode)
            {
                case "OpenFileDialog":
                    MessageBox.Show(message, title,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "OpenSavedOrder":
                    MessageBox.Show(message, title, 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.StartForm.ToString()].Show();
            this.Close();
        }

        private void SelectAnotherProduct_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SelectForm.ToString()].Show();
            this.Hide();

        }
    }
}
