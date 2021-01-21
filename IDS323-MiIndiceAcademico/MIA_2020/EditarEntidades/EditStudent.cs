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
    public partial class EditStudent : Form
    {
        private int progressState = 0; //{0, no changes; -1, unsaved changes; 1, saved changes}
        private ColeccionCompleta CC;
        public EditStudent(ColeccionCompleta _CC, Estudiante Usuario, bool isAdmin = false)
        {
            if (_CC == null) {
                _CC = new ColeccionCompleta();
            }
            CC = _CC;
            InitializeComponent();
            progressState = 0;
            //CargarDatos
            textID.Text = Usuario.ID_Estudiante.ToString();
            textNombre.Text = Usuario.Nombre_Estudiante;
            textCarrera.Text = Usuario.Carrera_Estudiante;
            textClave.Text = Usuario.Clave_Estudiante;
            if (isAdmin) {
                textClave_2.Text = Usuario.Clave_Estudiante;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Editar
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
                CC.Estudiantes[CC.Estudiantes.FindIndex(x => x.ID_Estudiante == int.Parse(textID.Text))] = (
                    new Estudiante() {
                    ID_Estudiante = int.Parse(textID.Text),
                    Nombre_Estudiante = textNombre.Text,
                    Carrera_Estudiante = textCarrera.Text,
                    Clave_Estudiante = textClave.Text
                });
                CC.GuardarEstudiantes();
                MessageBox.Show($"Estudiante editado correctamente.",
                    "Proceso completado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressState = 1;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Cancelar
            Close();
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            progressState = -1;
        }

        private void EditStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Verifica que si han habido cambios, preguntará para confirmar que quiere salir sin guardar.
            if (progressState == -1) {
                DialogResult dr = MessageBox.Show("¿Seguro desea cerrar sin guardar los cambios?", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void EditStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                button1.PerformClick();
            } else if(e.KeyCode == Keys.Escape) {
                button2.PerformClick();
            }
        }
    }
}
