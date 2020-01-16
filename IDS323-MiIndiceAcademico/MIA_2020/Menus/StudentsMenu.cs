﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MIA_2020.Objetos;

namespace MIA_2020.Menus
{
    public partial class StudentsMenu : Form
    {
        List<Estudiante> ListaEstudiantes;
        GestorDeObjetos GDO;
        public StudentsMenu()
        {
            InitializeComponent();
            TabControl.Appearance = TabAppearance.FlatButtons;
            TabControl.ItemSize = new Size(0, 1);
            TabControl.SizeMode = TabSizeMode.Fixed;

            GDO = new GestorDeObjetos();
            ListaEstudiantes = GDO.CargarEstudiantes();
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
                TabControl.SelectedTab = Seleccion;
            }
        }

        private void MisCalificacionesButton_CheckedChanged(object sender, EventArgs e)
        {
            if(MisCalificacionesButton.Checked) {
                TabControl.SelectedTab = MisCalificaciones;
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
