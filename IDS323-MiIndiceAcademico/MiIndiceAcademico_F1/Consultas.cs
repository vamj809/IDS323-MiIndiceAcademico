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
        public Consultas()
        {
            InitializeComponent();
            ReadScores();
        }

        private void ReadStudents()
        {
            foreach(string _ in File.ReadLines("Estudiantes.txt")) {
                string[] cell = _.Split(new char[] { ',', '\n' }, StringSplitOptions.None);

            }
        }

        private void ReadScores()
        {
            FileInfo file = new FileInfo("NotasV2.txt");
            string fileText = File.ReadAllText(file.FullName);
            foreach (string _ in File.ReadLines(file.FullName)) {
                string[] cell = _.Split(new char[] { ',', '\n' },StringSplitOptions.None);

                score = new Calificacion {
                    ID_Estudiante = int.Parse(cell[0]),
                    ID_Profesor = int.Parse(cell[1]),
                    Clave_Materia = cell[2].Trim(),
                    Nota = int.Parse(cell[3])
                };
                Notas.Add(score);
            }
            C_dataGrid.DataSource = Notas;
            C_dataGrid.Refresh();
        }

        private void C_ID_comboBox_TextChanged(object sender, EventArgs e)
        {
            C_dataGrid.Refresh();
        }
    }
}
