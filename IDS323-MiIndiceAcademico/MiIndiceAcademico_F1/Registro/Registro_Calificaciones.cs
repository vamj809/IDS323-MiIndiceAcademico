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
    public partial class Registro_Calificaciones : Form
    {
        public Registro_Calificaciones()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader Lector;
            String[] longitud = new String[99];
            String Cadenas;
            try
            {
                Lector = File.OpenText("Estudiantes.txt");

                string id = textBox1.Text;
                string idP = textBox3.Text;
                string clave = textBox4.Text;
                Cadenas = Lector.ReadLine();

                StreamWriter guardarNota = null;
                if (File.Exists("Calificaciones.txt")) {
                    guardarNota = File.AppendText("Calificaciones.txt");
                    string contenido = textBox1.Text + ",";
                    string contenido2 = textBox3.Text + ",";
                    string contenido3 = textBox4.Text + ",";
                    string contenido4 = textBox2.Text + ",\n";
                    guardarNota.Write(contenido);
                    guardarNota.Write(contenido2);
                    guardarNota.Write(contenido3);
                    guardarNota.Write(contenido4);
                    guardarNota.Flush();
                    guardarNota.Close();
                    MessageBox.Show("El registro se completo exitosamente!", "Message", MessageBoxButtons.OK);
                    this.Close();
                }
                else {
                    guardarNota = File.CreateText("Calificaciones.txt");
                    string contenido = textBox1.Text + ",";
                    string contenido2 = textBox3.Text + ",";
                    string contenido3 = textBox4.Text + ",";
                    string contenido4 = textBox2.Text + ",\n";
                    guardarNota.Write(contenido);
                    guardarNota.Write(contenido2);
                    guardarNota.Write(contenido3);
                    guardarNota.Write(contenido4);
                    guardarNota.Flush();
                    guardarNota.Close();
                    MessageBox.Show("El registro se completo exitosamente!", "Message", MessageBoxButtons.OK);
                    this.Close();

                }
                /*
                longitud = Cadenas.Split(',');
                if (longitud[0].Trim().Equals(id))
                {
                    Lector = File.OpenText("Profesores.txt");
                    if (longitud[0].Trim().Equals(idP))
                    {
                        Lector = File.OpenText("Asignaturas.txt");
                        if (longitud[0].Trim().Equals(clave))
                        {
                            StreamWriter guardarNota = null;
                            if (File.Exists("Calificaciones.txt"))
                            {
                                guardarNota = File.AppendText("Calificaciones.txt");
                                string contenido = textBox1.Text + ",";
                                string contenido2 = textBox3.Text + ",";
                                string contenido3 = textBox4.Text + ",";
                                string contenido4 = textBox2.Text + ",\n";
                                guardarNota.Write(contenido);
                                guardarNota.Write(contenido2);
                                guardarNota.Write(contenido3);
                                guardarNota.Write(contenido4);
                                guardarNota.Flush();
                                guardarNota.Close();
                                MessageBox.Show("El registro se completo exitosamente!", "Message", MessageBoxButtons.OK);
                                this.Close();
                            }
                            else
                            {
                                guardarNota = File.CreateText("Calificaciones.txt");
                                string contenido = textBox1.Text + ",";
                                string contenido2 = textBox3.Text + ",";
                                string contenido3 = textBox4.Text + ",";
                                string contenido4 = textBox2.Text + ",\n";
                                guardarNota.Write(contenido);
                                guardarNota.Write(contenido2);
                                guardarNota.Write(contenido3);
                                guardarNota.Write(contenido4);
                                guardarNota.Flush();
                                guardarNota.Close();
                                MessageBox.Show("El registro se completo exitosamente!", "Message", MessageBoxButtons.OK);
                                this.Close();

                            }


                        }
                        else
                        {
                            MessageBox.Show("El valor digitado no se encuentra registrado favor intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();

                        }

                    }
                    else
                    {
                        MessageBox.Show("El valor digitado no se encuentra registrado favor intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();

                    }

                }
                else
                {
                    MessageBox.Show("El valor digitado no se encuentra registrado favor intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();

                }*/
            }
            catch
            {
                MessageBox.Show("Error masivo en el sistema favor cerrar la aplicacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
