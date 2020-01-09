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

namespace MiIndiceAcademico_F1
{
    public partial class Consultas : Form
    {
        List<Calificacion> Notas = new List<Calificacion>();
        Calificacion score = new Calificacion();

        List<Estudiante> estudiantes = new List<Estudiante>();
        Estudiante student = new Estudiante();

        List<Profesor> profesores = new List<Profesor>();
        Profesor teacher = new Profesor();

        List<Asignatura> asignaturas = new List<Asignatura>();
        Asignatura subject = new Asignatura();
        public Consultas()
        {
            InitializeComponent();
            ReadScores();
            ReadStudents();
            ReadSubjects();
            ReadTeachers();
            loadFinalScores();
        }
        private void loadFinalScores()
        {
            foreach (Calificacion item in Notas) {
                if(item.ID_Estudiante.ToString() == ID_comboBox.Text) {

                }
            }
            object Detalles_Calificacion = new { mike = "", ok = "" };
            C_dataGrid.DataSource = Notas;
            C_dataGrid.Refresh();
        }
        private void ReadScores()
        {
            if (Notas.Count < 1) {
                FileInfo file = new FileInfo("NotasV2.txt");
                if (!File.Exists("NotasV2.txt"))
                    File.WriteAllText("NotasV2.txt", "");
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
                        Nombre = cell[1].Trim(),
                        Carrera = cell[2].Trim()
                    };
                    estudiantes.Add(student);
                }
                E_dataGrid.DataSource = estudiantes;
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
                        Nombre = cell[1].Trim(),
                        Credito = int.Parse(cell[2])
                    };
                    asignaturas.Add(subject);
                }
                A_dataGrid.DataSource = asignaturas;
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
                        Nombre = cell[1].Trim()
                    };
                    profesores.Add(teacher);
                }
                T_dataGrid.DataSource = profesores;
                T_dataGrid.Refresh();
            }
        }

        private void ID_comboBox_TextChanged(object sender, EventArgs e)
        {
            C_dataGrid.Refresh();
        }
    }
}
