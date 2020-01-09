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

namespace MiIndiceAcademico_F1.Eliminar
{
    public partial class Eliminar_Asignaturas : Form
    {
        public Eliminar_Asignaturas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader Lector;
            bool encontrar;
            encontrar = false;
            String[] longitud = new String[99];
            String Cadenas;
            StreamWriter escribir;
            escribir = File.CreateText("copia.txt");
            try
            {
                Lector = File.OpenText("Asignaturas.txt");

                string clave = textBox1.Text;
                Cadenas = Lector.ReadLine();
                while (Cadenas != null)
                {

                    longitud = Cadenas.Split(',');
                    if (longitud[0].Trim().Equals(clave))
                    {
                        Console.WriteLine("Nombre: " + longitud[0].Trim());
                        encontrar = true;

                    }
                    else
                    {
                        escribir.WriteLine(Cadenas);

                    }
                    Cadenas = Lector.ReadLine();

                }
                if (encontrar == false)
                {
                    MessageBox.Show("La clave no es correcta o no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("La Eliminacion se completo exitosamente!", "Message", MessageBoxButtons.OK);

                }
                Lector.Close();
                escribir.Close();

                File.Delete("Asignaturas.txt");
                File.Move("copia.txt", "Asignaturas.txt");
            }
            catch 
            {
                MessageBox.Show("Error masivo en el sistema favor intentar nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
