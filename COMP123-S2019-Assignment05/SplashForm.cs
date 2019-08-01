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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.SplashScreenTimer.Enabled = true;
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            this.SplashScreenTimer.Enabled = false;
            Program.startForm.Show();
            this.Hide();
        }
    }
}
