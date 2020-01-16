using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MIA_2020.Objetos;

namespace MIA_2020.Menus
{
    public partial class AdminsMenu : Form
    {
        ColeccionCompleta datosBin;
        public AdminsMenu(ColeccionCompleta _datos = null)
        {
            InitializeComponent();
            //Esta seccion hace que las pestañas se oculten.
            TabControl.Appearance = TabAppearance.FlatButtons;
            TabControl.ItemSize = new Size(0, 1);
            TabControl.SizeMode = TabSizeMode.Fixed;

            //Aqui se cargan los datos:
            if (_datos == null)
                _datos = new ColeccionCompleta();
            datosBin = _datos;
            E_dataGrid.DataSource = datosBin.Estudiantes;
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginForm = new Login();
            LoginForm.Show();
        }

        private void CloseSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MiCuentaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MiCuentaButton.Checked) {
                TabControl.SelectedTab = MiCuenta;
            }
        }

        private void SeleccionButton_CheckedChanged(object sender, EventArgs e)
        {
            if(SeleccionButton.Checked) {
                TabControl.SelectedTab = Estudiantes;
            }
        }

        private void MisCalificacionesButton_CheckedChanged(object sender, EventArgs e)
        {
            if(MisCalificacionesButton.Checked) {
                TabControl.SelectedTab = Asignaturas;
            }
        }
        private void ProfesoresButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ProfesoresButton.Checked) {
                TabControl.SelectedTab = Profesores;
            }
        }

        private void RankingButton_CheckedChanged(object sender, EventArgs e)
        {
            if(RankingButton.Checked) {
                TabControl.SelectedTab = Ranking;
            }
        }
    }
}
