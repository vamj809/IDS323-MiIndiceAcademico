﻿using System;
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
        Form Menu;
        int intentos = 0;
        ColeccionCompleta datosBin;
        public Login(string ID = "")
        {
            InitializeComponent();
            datosBin = new ColeccionCompleta();
            if (ID != "")
            {
                UserTextBox.Text = ID;
            }
            //Debug Options:
            //UserTextBox.Text = 1201001.ToString();
            //PasswordTextBox.Text = "1234";
            //OkButton.PerformClick();
            //this.Hide();
            //new Menus.StudentsMenu().Show(this);
        }

        private void UserNotFound()
        {


            intentos++;
            if (intentos <= 3)
            {
                MessageBox.Show("Usuario(ID) o Contraseña incorrectos.", "Credenciales Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserTextBox.Focus();

            }
            else
            {
                if (intentos > 3)
                {
                    MessageBox.Show("Ha excedido el limites de intentos para acceder al sistema", "Sistema Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
        }
        private void WrongPassword()
        {


            if (intentos <= 3)
            {
                MessageBox.Show("Usuario(ID) o Contraseña incorrectos.", "Credenciales Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Focus();

            }
            else
            {
                if (intentos > 3)
                {
                    MessageBox.Show("Ha excedido el limites de intentos para acceder al sistema", "Sistema Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }



        }


        private void OkButton_Click(object sender, EventArgs e)
        {

            if (StudentsButton.Checked)
            { //Estudiantes
                var estudiantes = datosBin.Estudiantes.Where(x => x.ID_Estudiante.ToString() == UserTextBox.Text);
                if (estudiantes.Count() < 1)
                {
                    UserNotFound();
                    intentos++;
                    return;
                }
                estudiantes = estudiantes.Where(x => x.Clave_Estudiante.ToString() == PasswordTextBox.Text);
                if (estudiantes.Count() < 1)
                {
                    WrongPassword();
                    intentos++;
                    return;
                }
                //Contraseña correcta
                Menu = new Menus.StudentsMenu(datosBin, estudiantes.First());
            }
            else if (TeachersButton.Checked)
            { //Profesores
                var profesores = datosBin.Profesores.Where(x => x.ID_Profesor.ToString() == UserTextBox.Text);
                if (profesores.Count() < 1)
                {
                    UserNotFound();
                    intentos++;
                    return;
                }
                profesores = profesores.Where(x => x.Clave_Profesor.ToString() == PasswordTextBox.Text);
                if (profesores.Count() < 1)
                {
                    WrongPassword();
                    intentos++;
                    return;
                }
                //Contraseña correcta
                Menu = new Menus.TeachersMenu(datosBin, profesores.First());
            }
            else if (AdminsButton.Checked)
            {//Administradores
                /*if (UserTextBox.Text != PasswordTextBox.Text &&
                    PasswordTextBox.Text != "admin") {
                    WrongPassword();
                    return;
                }
                */


                var administradores = datosBin.Administradores.Where(x => x.Usuario.ToString() == UserTextBox.Text);
                if (administradores.Count() < 1)
                {
                    UserNotFound();
                    intentos++;
                    return;

                }

                administradores = administradores.Where(x => x.Clave.ToString() == PasswordTextBox.Text);
                if (administradores.Count() < 1)
                {
                    WrongPassword();
                    intentos++;
                    return;

                }


                //Contraseña correcta
                Menu = new Menus.AdminsMenu(datosBin, administradores.First());

            }


            else
            { //Invitados
                //Menu Invitados.
                Menu = new Menus.GuestsMenu();
            }

            this.Hide();
            Menu.Show();


        }
        

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
            Environment.Exit(0);
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
            NewStudent AddStudentForm = new NewStudent(datosBin,true);
            AddStudentForm.ShowDialog();
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

        private void StudentsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StudentsButton.Checked) {
                NewStudent.Visible = true;
            }
            else {
                NewStudent.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewTeacher AddTeacherForm = new NewTeacher(datosBin);
            AddTeacherForm.ShowDialog();
            datosBin.RecargarProfesores();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewAdmin AddAdminForm = new NewAdmin(datosBin);
            AddAdminForm.ShowDialog();
            datosBin.RecargarAdministradores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
            Environment.Exit(0);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
