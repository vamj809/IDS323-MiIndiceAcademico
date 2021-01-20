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
        private ModuloConsulta moduloConsulta = new ModuloConsulta();
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
            Hide();
            new Login().Show();
        }

        private void CloseSystem_Click(object sender, EventArgs e)
        {
            Dispose();
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

            //TablaRanking {ID,Estudiante,GPA,Honor)
            int total_credito = 0, total_honor = 0;
            string gpa = "", honor = "";
            foreach (Estudiante estudiante in datosBin.Estudiantes) {
                total_credito = 0; total_honor = 0;
                gpa = ""; honor = "";
                foreach (Calificacion calificacion in datosBin.Calificaciones.FindAll(cal => cal.ID_Estudiante == estudiante.ID_Estudiante)) {
                    foreach (Asignatura materia in datosBin.Asignaturas.FindAll(mat => mat.Clave_Materia == calificacion.Clave_Materia)) {
                        object[] calculos = moduloConsulta.NotaALetra(materia.Credito, calificacion.Nota);
                        if (calculos[0].ToString() != "R") {
                            total_credito += materia.Credito;
                        }
                        total_honor += int.Parse(calculos[3].ToString()); // <- puntos de honor
                    }
                }

                if (total_credito != 0) {
                    honor = moduloConsulta.getHonor(Math.Round(total_honor * 1.0 / total_credito, 2));
                    gpa = Math.Round(total_honor * 1.0 / total_credito, 2).ToString();
                }
                else {
                    honor = "-";
                    gpa = "-";
                }
                TablaRanking.Rows.Add(
                            estudiante.ID_Estudiante,
                            estudiante.Nombre_Estudiante,
                            gpa,
                            honor);
            }

            TablaRanking.Sort(TablaRanking.Columns[2], System.ComponentModel.ListSortDirection.Descending);
        }

        private void NuevaCalificacion_Click(object sender, EventArgs e)
        {
            NewScore AddScoreForm = new NewScore(datosBin);
            AddScoreForm.ShowDialog();
            datosBin.RecargarProfesores();
            TablaCalificaciones.DataSource = datosBin.Profesores;
            TablaCalificaciones.Refresh();
        }

        private void TeachersMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogOffButton.PerformClick();
        }
    }
}
