﻿using System;
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

        private void ReadScores()
        {
            FileInfo file = new FileInfo("NotasV2.txt");
            string fileText = File.ReadAllText(file.FullName);
            foreach (string line in File.ReadLines(file.FullName)) {
                string[] cell = fileText.Split(new char[] { ',', '\n' });
                score = new Calificacion();
                score.ID_Estudiante = int.Parse(cell[0]);
                score.ID_Profesor = int.Parse(cell[1]);
                score.Clave_Materia = cell[2];
                score.Nota = int.Parse(cell[3]);
                Notas.Add(score);
            }
        }

        private void C_ID_comboBox_TextChanged(object sender, EventArgs e)
        {
            C_dataGrid.Refresh();
        }
    }
}
