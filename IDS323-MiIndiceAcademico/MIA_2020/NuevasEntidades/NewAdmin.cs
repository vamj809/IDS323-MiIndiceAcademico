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
    public partial class NewAdmin : Form
    {
        private int progressState = 0; //{0, no changes; -1, unsaved changes; 1, saved changes}
        private ColeccionCompleta CC;
        public NewAdmin(ColeccionCompleta _CC)
        {
            if (_CC == null) {
                _CC = new ColeccionCompleta();
            }
            CC = _CC;
            InitializeComponent();
            progressState = 0;
            if(CC.Administradores.Count() < 1) {
                textID.Text = 320001.ToString();
            } else {
                textID.Text = (CC.Administradores.Max(x => x.Usuario) + 1).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Registrar
            if(textNombre.Text == "") {
                textNombre.Focus();
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
                CC.Administradores.Add(new Administrador() {
                    Usuario = int.Parse(textID.Text),
                    Nombre = textNombre.Text,
                    Clave = textClave.Text
                });
                CC.GuardarAdministradores();
                MessageBox.Show($"Administrador creado correctamente.\nRecuerde que su ID es {textID.Text}",
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

        private void NewAdmin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void NewAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape) {
                button2.PerformClick();
            }
        }
    }
}
