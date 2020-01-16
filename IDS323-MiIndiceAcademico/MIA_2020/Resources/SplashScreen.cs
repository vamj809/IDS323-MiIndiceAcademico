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
        int i = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void loadAndCloseTimer_Tick(object sender, EventArgs e)
        {
            i++;
            if(i >= 20) {
                this.Close();
            }
        }
    }
}
