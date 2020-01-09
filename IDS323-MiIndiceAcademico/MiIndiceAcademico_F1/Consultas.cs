using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiIndiceAcademico_F1.Objetos;
using MiIndiceAcademico_F1.Consulta;

namespace MiIndiceAcademico_F1
{
    public partial class Consultas : Form
    {
        List<Calificacion> notas = new List<Calificacion>();
        List<Estudiante> estudiantes = new List<Estudiante>();
        List<Asignatura> asignaturas = new List<Asignatura>();
        public Consultas()
        {
            InitializeComponent();
            MetodosConsulta MC = new MetodosConsulta();
            notas = MC.ReadAndLoadScores();
            estudiantes = MC.ReadAndLoadStudents(E_dataGrid);
            asignaturas = MC.ReadAndLoadSubjects(A_dataGrid);
            MC.ReadAndLoadTeachers(T_dataGrid);
            loadFinalScores();
            loadStudents();
        }
        private object[] NotaALetra(int credito, int nota)
        {
            if(nota >= 90) {
                return new object[] { 'A', 4, credito + " * 4 = ", credito*4};
            } else if(nota >= 80) {
                return new object[] { 'B', 3, credito + " * 3 = ", credito*3};
            } else if(nota >= 70) {
                return new object[] { 'C', 2, credito + " * 2 = ", credito*2};
            } else if(nota >= 60) {
                return new object[] { 'D', 1, credito + " * 1 = ", credito*1};
            } else if(nota >= 0) {
                return new object[] { 'F', 0, credito + " * 0 = ", credito*0};
            }
            return new object[] { 'R', '-', '-'};
        }
        private string getHonor(double value)
        {
            if(value >= 3.8 & value <= 4.0) {
                return $"{value} - Summa Cum Laude";
            } else if(value >= 3.5) {
                return $"{value} - Magna Cum Laude";
            } else if(value >= 3.2) {
                return $"{value} - Cum Laude";
            }
            return $"{value} - Sin Honor";
        }
        private void loadStudents()
        {
            ID_comboBox.Items.Clear();
            foreach (Estudiante _estudiante in estudiantes) {
                ID_comboBox.Items.Add(_estudiante.ID_Estudiante);
            }
            ID_comboBox.Refresh();
        }
        private void loadFinalScores()
        {
            C_dataGrid.Rows.Clear();
            int total_credito = 0, total_honor = 0;
            foreach (Calificacion item in notas) {
                if (item.ID_Estudiante.ToString() == ID_comboBox.Text) {
                    foreach (Asignatura materia in asignaturas) {
                        if(item.Clave_Materia == materia.Clave_Materia) {
                            object[] calculos = NotaALetra(materia.Credito,item.Nota);
                            if(calculos[0].ToString() != "R") {
                                total_credito += materia.Credito;
                            }
                            total_honor += int.Parse(calculos[3].ToString());
                            C_dataGrid.Rows.Add(
                                materia.Clave_Materia,
                                materia.Nombre_Asignatura,
                                materia.Credito,
                                calculos[0],
                                calculos[1],
                                calculos[2],
                                calculos[3]
                                );
                            break;
                        }
                    }
                }
            }
            if (total_credito != 0) {
                C_GPA_Value.Text = getHonor(Math.Round(total_honor*1.0 / total_credito,2));
            } else {
                C_GPA_Value.Text = "-";
            }
        }
        private void ID_comboBox_TextChanged(object sender, EventArgs e)
        {
            loadFinalScores();
            C_dataGrid.Refresh();
        }
    }
}
