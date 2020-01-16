using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MIA_2020.Objetos;

namespace MIA_2020.Menus
{
    public partial class TeachersMenu : Form
    {
        private ColeccionCompleta datosBin;
        private Profesor ProfesorActual;
        private List<Asignatura> misMaterias;
        private List<Calificacion> misCalificaciones;
        public TeachersMenu(ColeccionCompleta _datos = null, Profesor _profesor = null)
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

            //Aqui se carga la información del maestro para mostrarla:
            if (_profesor != null) {
                ProfesorActual = _profesor;
            }
            else {
                ProfesorActual = new Profesor();
            }

            misMaterias = datosBin.Asignaturas.FindAll(x => x.ID_Profesor == ProfesorActual.ID_Profesor);
            misCalificaciones = new List<Calificacion>();
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
            
        }

        private void MisCalificacionesButton_CheckedChanged(object sender, EventArgs e)
        {
            if(CalificacionesButton.Checked) {
                TabControl.SelectedTab = MisCalificaciones;
                TablaCalificaciones.Refresh();
            }
        }

        private void RankingButton_CheckedChanged(object sender, EventArgs e)
        {
            if(RankingButton.Checked) {
                TabControl.SelectedTab = Ranking;
            }
        }

        private void TeachersMenu_Load(object sender, EventArgs e)
        {
            //Aqui se carga la información del estudiante para mostrarla:
            if (ProfesorActual != null) {
                InfoLabel.Text = "ID:\n" +
                    $"{ProfesorActual.ID_Profesor}\n\n" +
                    $"Nombre:\n" +
                    $"{ProfesorActual.Nombre_Profesor}";
            }
            else {
                InfoLabel.Text = "";
            }

            //Carga calificaciones
            foreach (var item in datosBin.Calificaciones) {
                foreach (var materia in misMaterias) {
                    if (item.Clave_Materia == materia.Clave_Materia) {
                        misCalificaciones.Add(item);
                        break;
                    }
                }
            }
            TablaCalificaciones.DataSource = misCalificaciones;
        }

        private void NuevaCalificacion_Click(object sender, EventArgs e)
        {
            NewScore AddScoreForm = new NewScore(datosBin);
            AddScoreForm.ShowDialog();
            datosBin.RecargarProfesores();
            TablaCalificaciones.DataSource = datosBin.Profesores;
            TablaCalificaciones.Refresh();
        }
    }
}
