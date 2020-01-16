using MIA_2020.Objetos;
using System;
using System.Windows.Forms;

namespace MIA_2020
{
    public partial class NewScore : Form
    {
        private int progressState; //{0, no changes; -1, unsaved changes; 1, saved changes}
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
            if(textEstudiante.SelectedIndex == -1) {
                MessageBox.Show("Debe seleccionar un estudiante de la lista", "Selección incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textEstudiante.Focus();
            } 
            else if (textAsignatura.SelectedIndex == -1) {
                MessageBox.Show("Debe seleccionar una asignatura de la lista", "Selección incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textAsignatura.Focus();
            }
            else {
                if (textNota.Value == 0) {
                    DialogResult dr = MessageBox.Show("¿Seguro desea calificarlo/a con un cero?", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.No) {
                        textNota.Focus();
                        return;
                    }
                }
                CC.Calificaciones.Add(new Calificacion() {
                    ID_Estudiante = int.Parse((textEstudiante.SelectedItem as ItemDeLista).Value.ToString()),
                    Clave_Materia = (textAsignatura.SelectedItem as ItemDeLista).Value.ToString(),
                    Nota = int.Parse(textNota.Value.ToString())
                });
                CC.GuardarCalificaciones();
                MessageBox.Show($"Calificación asignada correctamente.",
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
            foreach (Estudiante item in CC.Estudiantes) {
                //new ListItem(Name, Value);
                textEstudiante.Items.Add(new ItemDeLista(item.Nombre_Estudiante, item.ID_Estudiante.ToString()));
            }
            foreach (Asignatura item in CC.Asignaturas) {
                //new ListItem(Name, Value);
                textAsignatura.Items.Add(new ItemDeLista(item.Nombre_Asignatura, item.Clave_Materia.ToString()));
            }
        }

        private void NewScore_FormClosing(object sender, FormClosingEventArgs e)
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

        private void NewScore_KeyDown(object sender, KeyEventArgs e)
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
