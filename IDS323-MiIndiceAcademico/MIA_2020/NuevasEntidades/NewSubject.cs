using MIA_2020.Objetos;
using System;
using System.Windows.Forms;

namespace MIA_2020
{
    public partial class NewSubject : Form
    {
        private int progressState = 0; //{0, no changes; -1, unsaved changes; 1, saved changes}
        private ColeccionCompleta CC;
        public NewSubject(ColeccionCompleta _CC)
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
            } else if(CC.Asignaturas.FindAll(x => x.Clave_Materia == textClave.Text).Count > 0) {
                MessageBox.Show("Clave de asignatura ya existe.", "Selección incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textClave.Focus();
            }
            else {
                CC.Asignaturas.Add(new Asignatura() {
                    Clave_Materia = textClave.Text,
                    Nombre_Asignatura = textNombre.Text,
                    ID_Profesor = int.Parse((textProfesor.SelectedItem as ItemDeLista).Value.ToString()),
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

        private void NewSubject_FormClosing(object sender, FormClosingEventArgs e)
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

        private void NewSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape) {
                button2.PerformClick();
            }
        }

        private void NewSubject_Load(object sender, EventArgs e)
        {
            foreach (Profesor item in CC.Profesores) {
                //new ListItem(Name, Value);
                textProfesor.Items.Add(new ItemDeLista(item.Nombre_Profesor, item.ID_Profesor.ToString()));
            }
        }

        private void textProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
