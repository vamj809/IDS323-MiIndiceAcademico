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
    public partial class Registro_Asignaturas : Form
    {
        public Registro_Asignaturas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter guardarAsig = null;
            if (File.Exists("Asignaturas.txt"))
            {
                guardarAsig = File.AppendText("Asignaturas.txt");
                string contenido = textBox1.Text + ",";
                string contenido2 = textBox2.Text + ",";
                string contenido3 = textBox3.Text + ",\n";
                guardarAsig.Write(contenido);
                guardarAsig.Write(contenido2);
                guardarAsig.Write(contenido3);
                guardarAsig.Flush();
                guardarAsig.Close();
                MessageBox.Show("El registro se completo exitosamente!", "Message", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                guardarAsig = File.CreateText("Asignaturas.txt");
                string contenido = textBox1.Text + ",";
                string contenido2 = textBox2.Text + ",";
                string contenido3 = textBox3.Text + ",\n";
                guardarAsig.Write(contenido);
                guardarAsig.Write(contenido2);
                guardarAsig.Write(contenido3);
                guardarAsig.Flush();
                guardarAsig.Close();
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
