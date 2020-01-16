using MIA_2020.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MIA_2020
{
    public partial class NewScore : Form
    {
        private int progressState = 0; //{0, no changes; -1, unsaved changes; 1, saved changes}
        private ColeccionCompleta CC;
        public NewScore(ColeccionCompleta _CC)
        {
            if (_CC == null) {
                _CC = new ColeccionCompleta();
            }
            CC = _CC;
            InitializeComponent();
            progressState = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Registrar
            if(textClave.Text == "") {
                textClave.Focus();
            } else if (textNombre.Text == "") {
                textNombre.Focus();
            }
            else if (textProfesor.SelectedIndex == -1) {
                MessageBox.Show("Debe seleccionar un profesor de la lista", "Selección incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textProfesor.Focus();
            }
            else if (textCreditos.Value == 0) {
                textCreditos.Focus();
            }
            else {
                CC.Asignaturas.Add(new Asignatura() {
                    Clave_Materia = textClave.Text,
                    Nombre_Asignatura = textNombre.Text,
                    ID_Profesor = textProfesor.SelectedIndex,
                    Credito = int.Parse(textCreditos.Value.ToString())
                });
                CC.GuardarAsignaturas();
                MessageBox.Show($"Asignatura creada correctamente.\nRecuerde que su Clave es {textClave.Text}",
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

        private void NewScore_Load(object sender, EventArgs e)
        {

        }

        private void NewScore_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void NewScore_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
