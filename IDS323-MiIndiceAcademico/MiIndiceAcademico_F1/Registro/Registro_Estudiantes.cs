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
    public partial class Registro_Estudiantes : Form
    {
        public Registro_Estudiantes()
        {
            InitializeComponent();
        }

        private void Registro_Estudiantes_Load(object sender, EventArgs e)
        {

        }    
         
        private void textname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if(contraseña.Text != cContraseña.Text)
            {
                MessageBox.Show("La contraseña no coincide con la confirmacion favor intentar de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else {


            }*/

            StreamWriter guardar = null;
                if (File.Exists("Registro.txt"))
                {
                    guardar = File.AppendText("Registro.txt");
                    string contenido = textBox1.Text + ",";
                    string contenido2 = textname.Text + ",";
                    string contenido3 = textBox2.Text + ",\n";
                    guardar.Write(contenido);
                    guardar.Write(contenido2);
                    guardar.Write(contenido3);
                    guardar.Flush();
                    guardar.Close();
                    MessageBox.Show("El registro se completo exitosamente!", "Message", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    guardar = File.CreateText("Registro.txt");
                    string contenido = textBox1.Text + ",";
                    string contenido2 = textname.Text + ",";
                    string contenido3 = textBox2.Text + ",\n";
                    guardar.Write(contenido);
                    guardar.Write(contenido2);
                    guardar.Write(contenido3);
                    guardar.Flush();
                    guardar.Close();
                    MessageBox.Show("El registro se completo exitosamente!", "Message", MessageBoxButtons.OK);
                    this.Close();

                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void textapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
