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

namespace MiIndiceAcademico_F1
{
    public partial class Eliminar_Estudiantes : Form
    {
        public Eliminar_Estudiantes()
        {
            InitializeComponent();
        }

        private void eliminar_Click(object sender, EventArgs e)
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
                Lector = File.OpenText("Registro.txt");

                string id = textBox1.Text;
                Cadenas = Lector.ReadLine();
                while (Cadenas != null)
                {

                    longitud = Cadenas.Split(',');
                    if (longitud[0].Trim().Equals(id))
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
                    MessageBox.Show("La ID no es correcta o no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("La Eliminacion se completo exitosamente!", "Message", MessageBoxButtons.OK);

                }
                Lector.Close();
                escribir.Close();

                File.Delete("Registro.txt");
                File.Move("copia.txt", "Registro.txt");
            }
            catch 
            {
                MessageBox.Show("Error masivo en el sistema favor intentar nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            this.Close();
           
        }

        private void cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
