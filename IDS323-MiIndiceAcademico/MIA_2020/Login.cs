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
using MIA_2020.Objetos;

namespace MIA_2020
{
    public partial class Login : Form
    {
        ColeccionCompleta datosBin;
        public Login(string ID = "")
        {
            InitializeComponent();
            datosBin = new ColeccionCompleta();
            if(ID != "") {
                UserTextBox.Text = ID;
            }
            //Debug Options:
            //this.Hide();
            //new Menus.StudentsMenu().Show(this);
        }

        private void UserNotFound()
        {
            MessageBox.Show("Usuario(ID) no encontrado.", "Credenciales Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            UserTextBox.Focus();
        }
        private void WrongPassword()
        {
            MessageBox.Show("Usuario(ID) encontrado.\nContraseña incorrecta.", "Credenciales Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PasswordTextBox.Focus();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Form Menu;
            if (StudentsButton.Checked) { //Estudiantes
                var estudiantes = datosBin.Estudiantes.Where(x => x.ID_Estudiante.ToString() == UserTextBox.Text);
                if (estudiantes.Count() < 1) {
                    UserNotFound();
                    return;
                } else if(estudiantes.Where(x => x.Clave_Estudiante.ToString() == PasswordTextBox.Text).Count() < 1) {
                    WrongPassword();
                    return;
                }
                //Contraseña correcta
                Menu = new Menus.StudentsMenu();
            }
            else if (TeachersButton.Checked) { //Profesores
                var profesores = datosBin.Profesores.Where(x => x.ID_Profesor.ToString() == UserTextBox.Text);
                if (profesores.Count() < 1) {
                    UserNotFound();
                    return;
                }
                else if (profesores.Where(x => x.Clave_Profesor.ToString() == PasswordTextBox.Text).Count() < 1) {
                    WrongPassword();
                    return;
                }
                //Contraseña correcta
                Menu = new Menus.TeachersMenu();
            }
            else if (AdminsButton.Checked) { //Administradores
                /*var administradores = datosBin.Administradores.Where(x => x.ID_Profesor.ToString() == UserTextBox.Text);
                if (.Count() < 1) {
                    UserNotFound();
                    return;
                }
                else if (profesores.Where(x => x.Clave_Profesor.ToString() == PasswordTextBox.Text).Count() < 1) {
                    WrongPassword();
                    return;
                }*/
                //Contraseña correcta
                Menu = new Menus.AdminsMenu();
            }
            else { //Invitados
                //Menu Invitados.
                Menu = new Menus.GuestsMenu();
            }

            this.Hide();
            Menu.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GuestsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GuestsButton.Checked) {
                GuestsAccessPanel.Size = new Size() { Width = 458,  Height = 193 };
            }
            else {
                GuestsAccessPanel.Size = new Size() { Width = 1, Height = 1 };
            }
        }

        private void NewStudent_Click(object sender, EventArgs e)
        {
            NewStudent AddStudentForm = new NewStudent(datosBin);
            this.Hide();
            AddStudentForm.Show();
            datosBin.RecargarEstudiantes();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                OkButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape) {
                CancelButton.PerformClick();
            }
        }
    }
}
