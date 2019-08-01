using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment05
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            Program.BeginTag = "StartNewOrder";

            //SelectForm selectForm = new SelectForm();
            //selectForm.Show();
            Program.selectForm.Show();
            this.Hide();
        }

        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
            this.OpenProductInfoForm();
        }

        private void OpenProductInfoForm()
        {
            Program.BeginTag = "OpenProductInfoForm";

            //ProductInfoForm productInfoForm = new ProductInfoForm();
            //productInfoForm.Show();
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void ExitForm_Click(object sender, EventArgs e)
        {
            DialogResult _dResult =
                MessageBox.Show("Do you want to exit the program?", "Dollar Computers",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_dResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
