using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MIA_2020.Objetos;

namespace MIA_2020.Menus
{
    public partial class StudentsMenu : Form
    {
        private ColeccionCompleta datosBin;
        private Estudiante EstudianteActual;
        public StudentsMenu(ColeccionCompleta _datos = null, Estudiante _estudiante = null)
        {
            InitializeComponent();
            //Esta seccion hace que las pestañas se oculten.
            TabControl.Appearance = TabAppearance.FlatButtons;
            TabControl.ItemSize = new Size(0, 1);
            TabControl.SizeMode = TabSizeMode.Fixed;

            //Aqui se cargan los datos:
            if (_datos == null)
                _datos = new ColeccionCompleta();
            datosBin = _datos;

            //Aqui se carga la información del estudiante para mostrarla:
            if (_estudiante != null) {
                InfoLabel.Text = "ID:\n" +
                    $"{_estudiante.ID_Estudiante}\n\n" +
                    $"Nombre:\n" +
                    $"{_estudiante.Nombre_Estudiante}\n\n" +
                    $"Carrera:\n" +
                    $"{_estudiante.Carrera_Estudiante}";
                
                EstudianteActual = _estudiante;
            }
            else {
                InfoLabel.Text = "";
            }

            //Aqui se cargan las asignaturas disponibles:
            ListBoxDisponibles.DataSource = datosBin.Asignaturas;
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginForm = new Login();
            LoginForm.Show();
        }

        private void CloseSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MiCuentaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MiCuentaButton.Checked) {
                TabControl.SelectedTab = MiCuenta;
            }
        }

        private void SeleccionButton_CheckedChanged(object sender, EventArgs e)
        {
            if(SeleccionButton.Checked) {
                TabControl.SelectedTab = Seleccion;
            }
        }

        private void MisCalificacionesButton_CheckedChanged(object sender, EventArgs e)
        {
            if(MisCalificacionesButton.Checked) {
                TabControl.SelectedTab = MisCalificaciones;
            }
        }

        private void RankingButton_CheckedChanged(object sender, EventArgs e)
        {
            if(RankingButton.Checked) {
                TabControl.SelectedTab = Ranking;
            }
        }
    }
}
