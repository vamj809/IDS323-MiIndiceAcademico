using MIA_2020.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIA_2020.Menus
{
    public partial class GuestsMenu : Form
    {
        private ModuloConsulta moduloConsulta;
        private ColeccionCompleta datosBin;
        public GuestsMenu(ColeccionCompleta _datos = null)
        {
            InitializeComponent();
            moduloConsulta = new ModuloConsulta();
            datosBin = _datos;
            if (datosBin == null)
                datosBin = new ColeccionCompleta();
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

        private void GuestsMenu_Load(object sender, EventArgs e)
        {
            //TablaRanking {ID,Estudiante,GPA,Honor)
            int total_credito = 0, total_honor = 0;
            string gpa = "", honor = "";
            foreach(Estudiante estudiante in datosBin.Estudiantes) {
                foreach(Calificacion calificacion in datosBin.Calificaciones.FindAll(cal => cal.ID_Estudiante == estudiante.ID_Estudiante)){
                    foreach(Asignatura materia in datosBin.Asignaturas.FindAll(mat => mat.Clave_Materia == calificacion.Clave_Materia)){
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
