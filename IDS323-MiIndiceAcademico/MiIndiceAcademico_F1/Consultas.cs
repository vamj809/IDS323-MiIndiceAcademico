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
        //Calificacion score = new Calificacion();

        List<Estudiante> estudiantes = new List<Estudiante>();
        //Estudiante student = new Estudiante();

        List<Profesor> profesores = new List<Profesor>();
        //Profesor teacher = new Profesor();

        List<Asignatura> asignaturas = new List<Asignatura>();
        //Asignatura subject = new Asignatura();
        public Consultas()
        {
            InitializeComponent();
            MetodosConsulta MC = new MetodosConsulta();
            notas = MC.ReadAndLoadScores();
            estudiantes = MC.ReadAndLoadStudents(E_dataGrid);
            asignaturas = MC.ReadAndLoadSubjects(A_dataGrid);
            //ReadScores();
            //ReadStudents();
            //ReadSubjects();
            //ReadTeachers();
            MC.ReadAndLoadTeachers(T_dataGrid);
            loadFinalScores();
            loadStudents();
        }
        private object[] NotaALetra(int credito, int nota)
        {
            if (nota >= 90) {
                return new object[] { 'A', 4, credito + " * 4 = ", credito * 4 };
            }
            else if (nota >= 80) {
                return new object[] { 'B', 3, credito + " * 3 = ", credito * 3 };
            }
            else if (nota >= 70) {
                return new object[] { 'C', 2, credito + " * 2 = ", credito * 2 };
            }
            else if (nota >= 60) {
                return new object[] { 'D', 1, credito + " * 1 = ", credito * 1 };
            }
            else if (nota >= 0) {
                return new object[] { 'F', 0, credito + " * 0 = ", credito * 0 };
            }
            return new object[] { 'R', '-', '-' };
        }
        private string getHonor(double value)
        {
            if (value >= 3.8 & value <= 4.0) {
                return $"{value} - Summa Cum Laude";
            }
            else if (value >= 3.5) {
                return $"{value} - Magna Cum Laude";
            }
            else if (value >= 3.2) {
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
                        if (item.Clave_Materia == materia.Clave_Materia) {
                            object[] calculos = NotaALetra(materia.Credito, item.Nota);
                            if (calculos[0].ToString() != "R") {
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
                C_GPA_Value.Text = getHonor(Math.Round(total_honor * 1.0 / total_credito, 2));
            }
            else {
                C_GPA_Value.Text = "-";
            }
            //C_dataGrid.Refresh();
        }

        /*
        private void ReadScores()
        {
            if (Notas.Count < 1) {
                FileInfo file = new FileInfo("Calificaciones.txt");
                if (!File.Exists("Calificaciones.txt"))
                    File.WriteAllText("Calificaciones.txt", "");
                //string fileText = File.ReadAllText(file.FullName);
                foreach (string _ in File.ReadLines(file.FullName)) {
                    string[] cell = _.Split(new char[] { ',', '\n' }, StringSplitOptions.None);
                    score = new Calificacion {
                        ID_Estudiante = int.Parse(cell[0]),
                        ID_Profesor = int.Parse(cell[1]),
                        Clave_Materia = cell[2].Trim(),
                        Nota = int.Parse(cell[3])
                    };
                    Notas.Add(score);
                }
            }
        }
        private void ReadStudents()
        {
            if(estudiantes.Count < 1) {
                if (!File.Exists("Estudiantes.txt"))
                    File.WriteAllText("Estudiantes.txt", "");
                foreach (string _ in File.ReadLines("Estudiantes.txt")) {
                    string[] cell = _.Split(new char[] { ',', '\n' }, StringSplitOptions.None);
                    student = new Estudiante {
                        ID_Estudiante = int.Parse(cell[0]),
                        Nombre_Estudiante = cell[1].Trim(),
                        Carrera = cell[2].Trim()
                    };
                    estudiantes.Add(student);
                    E_dataGrid.Rows.Add(cell[0], cell[1], cell[2]);
                }
                E_dataGrid.Refresh();
            }
        }
        private void ReadSubjects()
        {
            if (asignaturas.Count < 1) {
                if (!File.Exists("Asignaturas.txt"))
                    File.WriteAllText("Asignaturas.txt", "");
                foreach (string _ in File.ReadLines("Asignaturas.txt")) {
                    string[] cell = _.Split(new char[] { ',', '\n' }, StringSplitOptions.None);
                    subject = new Asignatura {
                        Clave_Materia = cell[0].Trim(),
                        Nombre_Asignatura = cell[1].Trim(),
                        Credito = int.Parse(cell[2])
                    };
                    asignaturas.Add(subject);
                    A_dataGrid.Rows.Add(cell[0], cell[1], cell[2]);
                }
                //A_dataGrid.DataSource = asignaturas;
                A_dataGrid.Refresh();
            }
        }
        private void ReadTeachers()
        {
            if (profesores.Count < 1) {
                if (!File.Exists("Profesores.txt"))
                    File.WriteAllText("Profesores.txt", "");
                foreach (string _ in File.ReadLines("Profesores.txt")) {
                    string[] cell = _.Split(new char[] { ',', '\n' }, StringSplitOptions.None);
                    teacher = new Profesor {
                        ID_Profesor = int.Parse(cell[0]),
                        Nombre_Profesor = cell[1].Trim()
                    };
                    profesores.Add(teacher);
                    T_dataGrid.Rows.Add(cell[0],cell[1]);
                }
                T_dataGrid.Refresh();
            }
        }
        */
        private void ID_comboBox_TextChanged(object sender, EventArgs e)
        {
            loadFinalScores();
            C_dataGrid.Refresh();
        }
    }
}