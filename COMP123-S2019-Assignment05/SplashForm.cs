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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method enables the splash screen timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.SplashScreenTimer.Enabled = true;
        }

        /// <summary>
        /// This method disables the splash screen timer and opens StartForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            this.SplashScreenTimer.Enabled = false;
            Program.startForm.Show();
            this.Hide();
        }
    }
}
