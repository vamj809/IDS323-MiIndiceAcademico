using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiIndiceAcademico_F1
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(userTXT.Text == pwdTXT.Text && userTXT.Text == "admin") {
                this.Hide();
                new MainMenu().ShowDialog(this);
                this.Close();
            } else {
                MessageBox.Show("Usuario y/o contraseña inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
