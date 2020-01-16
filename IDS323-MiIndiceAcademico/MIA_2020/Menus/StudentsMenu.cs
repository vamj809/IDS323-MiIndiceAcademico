using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MIA_2020.Objetos;

namespace MIA_2020.Menus
{
    public partial class StudentsMenu : Form
    {
        private ModuloConsulta moduloConsulta;
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

            moduloConsulta = new ModuloConsulta();

            //Aqui se carga la información del estudiante para mostrarla:
            if (_estudiante != null) {
                EstudianteActual = _estudiante;
            }
            else {
                EstudianteActual = new Estudiante();
            }
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

        private void StudentsMenu_Load(object sender, EventArgs e)
        {
            //Aqui se carga la información del estudiante para mostrarla:
            if (EstudianteActual != null) {
                InfoLabel.Text = "ID:\n" +
                    $"{EstudianteActual.ID_Estudiante}\n\n" +
                    $"Nombre:\n" +
                    $"{EstudianteActual.Nombre_Estudiante}\n\n" +
                    $"Carrera:\n" +
                    $"{EstudianteActual.Carrera_Estudiante}";
            }
            else {
                InfoLabel.Text = "";
            }

            //Aqui se cargan las calificaciones disponibles:
            //TablaCalificaciones.DataSource = datosBin.Calificaciones.FindAll(x => x.ID_Estudiante == EstudianteActual.ID_Estudiante);

            int total_credito = 0, total_honor = 0;
            foreach (Calificacion item in datosBin.Calificaciones) {
                if (item.ID_Estudiante == EstudianteActual.ID_Estudiante) {
                    foreach (Asignatura materia in datosBin.Asignaturas) {
                        if (item.Clave_Materia == materia.Clave_Materia) {
                            object[] calculos = moduloConsulta.NotaALetra(materia.Credito, item.Nota);
                            if (calculos[0].ToString() != "R") {
                                total_credito += materia.Credito;
                            }
                            total_honor += int.Parse(calculos[3].ToString());
                            TablaCalificaciones.Rows.Add(
                                materia.Clave_Materia,
                                materia.Nombre_Asignatura,
                                materia.Credito,
                                calculos[0],
                                item.Nota,
                                calculos[2],
                                calculos[3]
                                );
                            break;
                        }
                    }
                }
            }
            if (total_credito != 0) {
                C_GPA_Value.Text = moduloConsulta.getHonor(Math.Round(total_honor * 1.0 / total_credito, 2));
            }
            else {
                C_GPA_Value.Text = "-";
            }

            //TablaRanking {ID,Estudiante,GPA,Honor)
            total_credito = 0;
            total_honor = 0;
            string gpa = "", honor = "";
            foreach (Estudiante estudiante in datosBin.Estudiantes) {
                total_credito = 0; total_honor = 0;
                gpa = "";  honor = "";
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
        }
    }
}
