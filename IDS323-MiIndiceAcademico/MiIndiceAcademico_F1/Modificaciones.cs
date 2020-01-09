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
    public partial class Modificaciones : Form
    {
        public Modificaciones()
        {
            InitializeComponent();
        }

        private void btn_C_SaveChanges_Click(object sender, EventArgs e)
        {
            if (File.Exists("NotasV2.txt")) {
                string[] text = File.ReadAllLines("NotasV2.txt");
                //for each line in text.
                for (int i = 0; i < text.Length; i++) {
                    string[] tmp = text[i].Split(',');
                    tmp[3] = C_dataGrid.Rows[i].Cells[3].Value.ToString();
                    text[i] = String.Join(",", tmp);
                }
                File.WriteAllLines("NotasV2.txt", text);
            } else {
                MessageBox.Show("No hay registros de calificaciones.", "Necesito datos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_C_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_E_SaveChanges_Click(object sender, EventArgs e)
        {
            if (File.Exists("Estudiantes.txt")) {
                string[] text = File.ReadAllLines("Estudiantes.txt");
                //for each line in text.
                for (int i = 0; i < text.Length; i++) {
                    string[] tmp = text[i].Split(',');
                    tmp[1] = C_dataGrid.Rows[i].Cells[1].Value.ToString();
                    tmp[2] = C_dataGrid.Rows[i].Cells[2].Value.ToString();
                    text[i] = String.Join(",", tmp);
                }
                File.WriteAllLines("Estudiantes.txt", text);
            }
            else {
                MessageBox.Show("No hay registros de estudiantes.", "Necesito datos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_E_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_A_SaveChanges_Click(object sender, EventArgs e)
        {
            if (File.Exists("Asignaturas.txt")) {
                string[] text = File.ReadAllLines("Asignaturas.txt");
                //for each line in text.
                for (int i = 0; i < text.Length; i++) {
                    string[] tmp = text[i].Split(',');
                    tmp[1] = C_dataGrid.Rows[i].Cells[1].Value.ToString();
                    tmp[2] = C_dataGrid.Rows[i].Cells[2].Value.ToString();
                    text[i] = String.Join(",", tmp);
                }
                File.WriteAllLines("Asignaturas.txt", text);
            }
            else {
                MessageBox.Show("No hay registros de asignaturas.", "Necesito datos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_A_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_P_SaveChanges_Click(object sender, EventArgs e)
        {
            if (File.Exists("Profesores.txt")) {
                string[] text = File.ReadAllLines("Profesores.txt");
                //for each line in text.
                for (int i = 0; i < text.Length; i++) {
                    string[] tmp = text[i].Split(',');
                    tmp[1] = C_dataGrid.Rows[i].Cells[1].Value.ToString();
                    text[i] = String.Join(",", tmp);
                }
                File.WriteAllLines("Profesores.txt", text);
            }
            else {
                MessageBox.Show("No hay registros de profesores.", "Necesito datos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_P_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro desea cerrar sin guardar los cambios?", "¿Está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dr == DialogResult.No) {
                e.Cancel = true;
            }
        }
    }
}
