using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiIndiceAcademico_F1.Registro;

namespace MiIndiceAcademico_F1
{
    public partial class MainMenu : Form
    {
        public MainMenu(string userName = null)
        {
            InitializeComponent();

            if (userName != null) {
                currentUserLabel.Text = $"Bienvenido/a {userName}";
            }
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Estudiantes _Estudiantes = new Registro_Estudiantes();
            _Estudiantes.MdiParent = this;
            _Estudiantes.Show();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Calificaciones _Calificaciones = new Registro_Calificaciones();
            _Calificaciones.MdiParent = this;
            _Calificaciones.Show();
        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Asignaturas _Asignaturas = new Registro_Asignaturas();
            _Asignaturas.MdiParent = this;
            _Asignaturas.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Profesores _Profesores = new Registro_Profesores();
            _Profesores.MdiParent = this;
            _Profesores.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas _consultas = new Consultas();
            _consultas.MdiParent = this;
            _consultas.Show();
        }

        private void estudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Eliminar_Estudiantes _Estudiantes = new Eliminar_Estudiantes();
            _Estudiantes.MdiParent = this;
            _Estudiantes.Show();
        }
    }
}
