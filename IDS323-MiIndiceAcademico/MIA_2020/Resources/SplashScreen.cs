using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIA_2020.Resources
{
    public partial class SplashScreen : Form
    {
        int CounterIndex = 0, LimitInMiliseconds = 2000;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void loadAndCloseTimer_Tick(object sender, EventArgs e)
        {
            CounterIndex++;
            if(CounterIndex >= LimitInMiliseconds/100) {
                this.Hide();
                loadAndCloseTimer.Stop();
                loadAndCloseTimer.Enabled = false;
                this.Close();
            }
        }

        private void SplashScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.ShowDialog(this);
        }

        private void SplashScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) {
                CounterIndex = LimitInMiliseconds;
            }
        }
    }
}
