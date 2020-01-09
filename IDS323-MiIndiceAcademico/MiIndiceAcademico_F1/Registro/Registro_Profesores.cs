using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiIndiceAcademico_F1.Registro
{
    public partial class Registro_Profesores : Form
    {
        public Registro_Profesores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter guardarProf = null;
            if (File.Exists("Profesores.txt"))
            {
                guardarProf = File.AppendText("Profesores.txt");
                string contenido = textBox1.Text + ",";
                string contenido2 = textBox2.Text + ",\n";
                guardarProf.Write(contenido);
                guardarProf.Write(contenido2);
                guardarProf.Flush();
                guardarProf.Close();
                MessageBox.Show("El registro se completo exitosamente!", "Message", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                guardarProf = File.CreateText("Profesores.txt");
                string contenido = textBox1.Text + ",";
                string contenido2 = textBox2.Text + ",\n";
                guardarProf.Write(contenido);
                guardarProf.Write(contenido2);
                guardarProf.Flush();
                guardarProf.Close();
                MessageBox.Show("El registro se completo exitosamente!", "Message", MessageBoxButtons.OK);
                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
