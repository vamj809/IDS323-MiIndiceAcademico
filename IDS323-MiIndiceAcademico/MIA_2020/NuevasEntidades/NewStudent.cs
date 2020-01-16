using MIA_2020.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIA_2020
{
    public partial class NewStudent : Form
    {
        private int progressState = 0; //{0, no changes; -1, unsaved changes; 1, saved changes}
        private ColeccionCompleta CC;
        public NewStudent(ColeccionCompleta _CC)
        {
            if (_CC == null) {
                _CC = new ColeccionCompleta();
            }
            CC = _CC;
            InitializeComponent();
            progressState = 0;
            if(CC.Estudiantes.Count() < 1) {
                textID.Text = 1201001.ToString();
            } else {
                textID.Text = (CC.Estudiantes.Max(x => x.ID_Estudiante) + 1).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Registrar
            if(textNombre.Text == "") {
                textNombre.Focus();
            } else if (textCarrera.Text == "") {
                textCarrera.Focus();
            }
            else if (textClave.Text == "") {
                textClave.Focus();
            }
            else if (textClave_2.Text == "") {
                textClave_2.Focus();
            }
            else if (textClave.Text != textClave_2.Text) {
                MessageBox.Show("Ambas contraseñas deben ser iguales. Verifique su contraseña.",
                "Error de autenticación.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textClave.Focus();
            } else {
                if(textID.Text == "") {
                    textID.Text = "0";
                }
                CC.Estudiantes.Add(new Estudiante() {
                    ID_Estudiante = int.Parse(textID.Text),
                    Nombre_Estudiante = textNombre.Text,
                    Carrera_Estudiante = textCarrera.Text,
                    Clave_Estudiante = textClave.Text
                });
                CC.GuardarEstudiantes();
                MessageBox.Show($"Estudiante creado correctamente.\nRecuerde que su ID es {textID.Text}",
                    "Proceso completado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressState = 1;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Cancelar
            this.Close();
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            progressState = -1;
        }

        private void NewStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login Menu = new Login();
            //Verifica que si han habido cambios, preguntará para confirmar que quiere salir sin guardar.
            if (progressState == -1) {
                DialogResult dr = MessageBox.Show("¿Seguro desea cerrar sin guardar los cambios?", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) {
                    e.Cancel = true;
                    return;
                }
            }
            else if (progressState == 1) {
                Menu = new Login(textID.Text);
            }
            this.Hide();
            Menu.Show();
        }

        private void NewStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                button1.PerformClick();
            } else if(e.KeyCode == Keys.Escape) {
                button2.PerformClick();
            }
        }
    }
}
