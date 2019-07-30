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
                    this.OpenSavedOrder();
                    break;
                default:
                    //Do nothing
                    break;
            }
        }

        private void OpenSavedOrder()
        {
            OpenFileDialog _opDiag = new OpenFileDialog();
            _opDiag.InitialDirectory = Directory.GetCurrentDirectory();
            _opDiag.Filter = "Text Files (*.txt)|(*.txt)| All Files (*.*)|(*.*)";
            _opDiag.ShowDialog();

            string _fileName = string.Empty;
            _fileName = _opDiag.FileName;

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
    }
}
