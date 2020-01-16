using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIA_2020
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            /*this.BackgroundImage = Properties.Resources.OurLogo;
            this.TransparencyKey = Color.White;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            */

            //this.Hide();
            Resources.SplashScreen x = new Resources.SplashScreen();
            x.ShowDialog();
        }
    }
}
