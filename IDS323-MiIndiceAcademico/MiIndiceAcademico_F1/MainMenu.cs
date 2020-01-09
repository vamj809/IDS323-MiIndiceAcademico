using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
