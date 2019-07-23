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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SelectForm.ToString()].Show();
            this.Hide();
        }
    }
}
