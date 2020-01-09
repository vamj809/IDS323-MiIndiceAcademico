using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiIndiceAcademico_F1.Objetos;
using System.IO;
using System.Windows.Forms;

namespace MiIndiceAcademico_F1.Consulta
{
    public class MetodosConsulta
    {
        public List<Calificacion> ReadAndLoadScores(DataGridView myDataGrid = null) {
            List<Calificacion> Notas = new List<Calificacion>();
            FileInfo file = new FileInfo("NotasV2.txt");
            if (!File.Exists("NotasV2.txt"))
                File.WriteAllText("NotasV2.txt", "");
            //string fileText = File.ReadAllText(file.FullName);
            foreach (string _ in File.ReadLines(file.FullName)) {
                string[] cell = _.Split(new char[] { ',', '\n' }, StringSplitOptions.None);

                Calificacion score = new Calificacion {
                    ID_Estudiante = int.Parse(cell[0]),
                    ID_Profesor = int.Parse(cell[1]),
                    Clave_Materia = cell[2].Trim(),
                    Nota = int.Parse(cell[3])
                };
                Notas.Add(score);
                if (myDataGrid != null)
                    myDataGrid.Rows.Add(cell[0], cell[1], cell[2], cell[3]);
            }
            if (myDataGrid != null)
                myDataGrid.Refresh();
            return Notas;
        }
        public List<Estudiante> ReadAndLoadStudents(DataGridView myDataGrid = null)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            if (!File.Exists("Estudiantes.txt"))
                File.WriteAllText("Estudiantes.txt", "");
            foreach (string _ in File.ReadLines("Estudiantes.txt")) {
                string[] cell = _.Split(new char[] { ',', '\n' }, StringSplitOptions.None);
                Estudiante student = new Estudiante {
                    ID_Estudiante = int.Parse(cell[0]),
                    Nombre_Estudiante = cell[1].Trim(),
                    Carrera = cell[2].Trim()
                };
                estudiantes.Add(student);
                if (myDataGrid != null) 
                    myDataGrid.Rows.Add(cell[0], cell[1], cell[2]);
            }
            if (myDataGrid != null) 
                myDataGrid.Refresh();
            return estudiantes;
        }

        public List<Asignatura> ReadAndLoadSubjects(DataGridView myDataGrid = null)
        {
            List<Asignatura> asignaturas = new List<Asignatura>();
            if (!File.Exists("Asignaturas.txt"))
                File.WriteAllText("Asignaturas.txt", "");
            foreach (string _ in File.ReadLines("Asignaturas.txt")) {
                string[] cell = _.Split(new char[] { ',', '\n' }, StringSplitOptions.None);
                Asignatura subject = new Asignatura {
                    Clave_Materia = cell[0].Trim(),
                    Nombre_Asignatura = cell[1].Trim(),
                    Credito = int.Parse(cell[2])
                };
                asignaturas.Add(subject);
                if (myDataGrid != null) 
                    myDataGrid.Rows.Add(cell[0], cell[1], cell[2]);
            }
            //A_dataGrid.DataSource = asignaturas;
            if (myDataGrid != null) 
                myDataGrid.Refresh();
            return asignaturas;
        }
        public List<Profesor> ReadAndLoadTeachers(DataGridView myDataGrid = null)
        {
            List<Profesor> profesores = new List<Profesor>();
            if (!File.Exists("Profesores.txt"))
                File.WriteAllText("Profesores.txt", "");
            foreach (string _ in File.ReadLines("Profesores.txt")) {
                string[] cell = _.Split(new char[] { ',', '\n' }, StringSplitOptions.None);
                Profesor teacher = new Profesor {
                    ID_Profesor = int.Parse(cell[0]),
                    Nombre_Profesor = cell[1].Trim()
                };
                profesores.Add(teacher);
                if (myDataGrid != null) 
                    myDataGrid.Rows.Add(cell[0], cell[1]);
            }
            if (myDataGrid != null) 
                myDataGrid.Refresh();
            return profesores;
        }
    }
}
