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
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text == PasswordTextBox.Text && UserTextBox.Text == "admin") {
                this.Hide();

                Form Menu;
                if (StudentsButton.Checked)
                    Menu = new Menus.StudentsMenu();
                else if (TeachersButton.Checked)
                    Menu = new Menus.TeachersMenu();
                else if (AdminsButton.Checked)
                    Menu = new Menus.AdminsMenu();
                else
                    Menu = new Menus.GuestsMenu();

                Menu.ShowDialog(this);
                //this.Hide();
                //new MainMenu(UserTextBox.Text).ShowDialog(this);
                this.Close();
            }
            else {
                MessageBox.Show("Usuario y/o contraseña inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
