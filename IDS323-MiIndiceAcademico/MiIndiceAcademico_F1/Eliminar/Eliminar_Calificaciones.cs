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
    public partial class Eliminar_Calificaciones : Form
    {
        public Eliminar_Calificaciones()
        {
            InitializeComponent();
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
                Lector = File.OpenText("Calificaciones.txt");

                string Nota = textBox1.Text;
                string IDE = textBox2.Text;
                string IDP = textBox3.Text;
                string Clave = textBox4.Text;
                Cadenas = Lector.ReadLine();
                while (Cadenas != null)
                {

                    longitud = Cadenas.Split(',');
                    if (longitud[0].Trim().Equals(IDE))
                    {
                        if (longitud[1].Trim().Equals(IDP))
                        {
                            if (longitud[2].Trim().Equals(Clave))
                            {
                                if (longitud[3].Trim().Equals(Nota))
                                {

                                    encontrar = true;

                                }
                                else
                                {
                                    escribir.WriteLine(Cadenas);

                                }
                                

                            }
                            

                        }
                        

                    }
                   
                    Cadenas = Lector.ReadLine();

                }
                if (encontrar == false)
                {
                    MessageBox.Show("La calificacion no es correcta o no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("La Eliminacion se completo exitosamente!", "Message", MessageBoxButtons.OK);
                    Lector.Close();
                    escribir.Close();

                    File.Delete("Calificaciones.txt");
                    File.Move("copia.txt", "Calificaciones.txt");
                }
               
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
