﻿namespace MiIndiceAcademico_F1
{
    partial class Consultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabsConsultas = new System.Windows.Forms.TabControl();
            this.tabCalificaciones = new System.Windows.Forms.TabPage();
            this.C_GPA_ = new System.Windows.Forms.Label();
            this.C_dataGrid = new System.Windows.Forms.DataGridView();
            this.Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDeLaNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_por_VN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntosDeHonor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLabel = new System.Windows.Forms.Label();
            this.C_ID_comboBox = new System.Windows.Forms.ComboBox();
            this.tabEstudiantes = new System.Windows.Forms.TabPage();
            this.tabAsignaturas = new System.Windows.Forms.TabPage();
            this.tabProfesores = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.E_dataGrid = new System.Windows.Forms.DataGridView();
            this.T_dataGrid = new System.Windows.Forms.DataGridView();
            this.A_dataGrid = new System.Windows.Forms.DataGridView();
            this.tabsConsultas.SuspendLayout();
            this.tabCalificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C_dataGrid)).BeginInit();
            this.tabEstudiantes.SuspendLayout();
            this.tabAsignaturas.SuspendLayout();
            this.tabProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.E_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsConsultas
            // 
            this.tabsConsultas.Controls.Add(this.tabCalificaciones);
            this.tabsConsultas.Controls.Add(this.tabEstudiantes);
            this.tabsConsultas.Controls.Add(this.tabAsignaturas);
            this.tabsConsultas.Controls.Add(this.tabProfesores);
            this.tabsConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsConsultas.Location = new System.Drawing.Point(0, 0);
            this.tabsConsultas.Name = "tabsConsultas";
            this.tabsConsultas.SelectedIndex = 0;
            this.tabsConsultas.Size = new System.Drawing.Size(914, 484);
            this.tabsConsultas.TabIndex = 0;
            // 
            // tabCalificaciones
            // 
            this.tabCalificaciones.Controls.Add(this.C_GPA_);
            this.tabCalificaciones.Controls.Add(this.C_dataGrid);
            this.tabCalificaciones.Controls.Add(this.IDLabel);
            this.tabCalificaciones.Controls.Add(this.C_ID_comboBox);
            this.tabCalificaciones.Location = new System.Drawing.Point(4, 25);
            this.tabCalificaciones.Name = "tabCalificaciones";
            this.tabCalificaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalificaciones.Size = new System.Drawing.Size(906, 455);
            this.tabCalificaciones.TabIndex = 0;
            this.tabCalificaciones.Text = "Calificaciones";
            this.tabCalificaciones.UseVisualStyleBackColor = true;
            // 
            // C_GPA_
            // 
            this.C_GPA_.AutoSize = true;
            this.C_GPA_.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_GPA_.Location = new System.Drawing.Point(545, 395);
            this.C_GPA_.Name = "C_GPA_";
            this.C_GPA_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C_GPA_.Size = new System.Drawing.Size(202, 17);
            this.C_GPA_.TabIndex = 3;
            this.C_GPA_.Text = "Índice Académico General:";
            // 
            // C_dataGrid
            // 
            this.C_dataGrid.AllowUserToDeleteRows = false;
            this.C_dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.C_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.C_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asignatura,
            this.Creditos,
            this.Nota,
            this.ValorDeLaNota,
            this.C_por_VN,
            this.PuntosDeHonor});
            this.C_dataGrid.Location = new System.Drawing.Point(29, 64);
            this.C_dataGrid.Name = "C_dataGrid";
            this.C_dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.C_dataGrid.RowHeadersWidth = 51;
            this.C_dataGrid.RowTemplate.Height = 24;
            this.C_dataGrid.Size = new System.Drawing.Size(848, 314);
            this.C_dataGrid.TabIndex = 2;
            // 
            // Asignatura
            // 
            this.Asignatura.Frozen = true;
            this.Asignatura.HeaderText = "Asignatura";
            this.Asignatura.MinimumWidth = 6;
            this.Asignatura.Name = "Asignatura";
            this.Asignatura.Width = 125;
            // 
            // Creditos
            // 
            this.Creditos.HeaderText = "Créditos";
            this.Creditos.MinimumWidth = 6;
            this.Creditos.Name = "Creditos";
            this.Creditos.Width = 125;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.MinimumWidth = 6;
            this.Nota.Name = "Nota";
            this.Nota.Width = 125;
            // 
            // ValorDeLaNota
            // 
            this.ValorDeLaNota.HeaderText = "Valor de la Nota";
            this.ValorDeLaNota.MinimumWidth = 6;
            this.ValorDeLaNota.Name = "ValorDeLaNota";
            this.ValorDeLaNota.Width = 125;
            // 
            // C_por_VN
            // 
            this.C_por_VN.HeaderText = "Créditos * Valor de Nota";
            this.C_por_VN.MinimumWidth = 6;
            this.C_por_VN.Name = "C_por_VN";
            this.C_por_VN.Width = 125;
            // 
            // PuntosDeHonor
            // 
            this.PuntosDeHonor.HeaderText = "Puntos de Honor";
            this.PuntosDeHonor.MinimumWidth = 6;
            this.PuntosDeHonor.Name = "PuntosDeHonor";
            this.PuntosDeHonor.Width = 125;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(26, 24);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(111, 17);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID (Matrícula):";
            // 
            // C_ID_comboBox
            // 
            this.C_ID_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.C_ID_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.C_ID_comboBox.FormattingEnabled = true;
            this.C_ID_comboBox.Items.AddRange(new object[] {
            "1067196",
            "1089090",
            "1075050",
            "1043020",
            "1091337"});
            this.C_ID_comboBox.Location = new System.Drawing.Point(143, 21);
            this.C_ID_comboBox.Name = "C_ID_comboBox";
            this.C_ID_comboBox.Size = new System.Drawing.Size(122, 24);
            this.C_ID_comboBox.TabIndex = 0;
            this.C_ID_comboBox.TextChanged += new System.EventHandler(this.C_ID_comboBox_TextChanged);
            // 
            // tabEstudiantes
            // 
            this.tabEstudiantes.Controls.Add(this.E_dataGrid);
            this.tabEstudiantes.Location = new System.Drawing.Point(4, 25);
            this.tabEstudiantes.Name = "tabEstudiantes";
            this.tabEstudiantes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstudiantes.Size = new System.Drawing.Size(906, 455);
            this.tabEstudiantes.TabIndex = 1;
            this.tabEstudiantes.Text = "Estudiantes";
            this.tabEstudiantes.UseVisualStyleBackColor = true;
            // 
            // tabAsignaturas
            // 
            this.tabAsignaturas.Controls.Add(this.A_dataGrid);
            this.tabAsignaturas.Location = new System.Drawing.Point(4, 25);
            this.tabAsignaturas.Name = "tabAsignaturas";
            this.tabAsignaturas.Size = new System.Drawing.Size(906, 455);
            this.tabAsignaturas.TabIndex = 2;
            this.tabAsignaturas.Text = "Asignaturas";
            this.tabAsignaturas.UseVisualStyleBackColor = true;
            // 
            // tabProfesores
            // 
            this.tabProfesores.Controls.Add(this.T_dataGrid);
            this.tabProfesores.Location = new System.Drawing.Point(4, 25);
            this.tabProfesores.Name = "tabProfesores";
            this.tabProfesores.Size = new System.Drawing.Size(906, 455);
            this.tabProfesores.TabIndex = 3;
            this.tabProfesores.Text = "Profesores";
            this.tabProfesores.UseVisualStyleBackColor = true;
            // 
            // E_dataGrid
            // 
            this.E_dataGrid.AllowUserToAddRows = false;
            this.E_dataGrid.AllowUserToDeleteRows = false;
            this.E_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.E_dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.E_dataGrid.Location = new System.Drawing.Point(3, 3);
            this.E_dataGrid.Name = "E_dataGrid";
            this.E_dataGrid.ReadOnly = true;
            this.E_dataGrid.RowHeadersWidth = 51;
            this.E_dataGrid.RowTemplate.Height = 24;
            this.E_dataGrid.Size = new System.Drawing.Size(900, 449);
            this.E_dataGrid.TabIndex = 0;
            // 
            // T_dataGrid
            // 
            this.T_dataGrid.AllowUserToAddRows = false;
            this.T_dataGrid.AllowUserToDeleteRows = false;
            this.T_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.T_dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.T_dataGrid.Location = new System.Drawing.Point(0, 0);
            this.T_dataGrid.Name = "T_dataGrid";
            this.T_dataGrid.ReadOnly = true;
            this.T_dataGrid.RowHeadersWidth = 51;
            this.T_dataGrid.RowTemplate.Height = 24;
            this.T_dataGrid.Size = new System.Drawing.Size(906, 455);
            this.T_dataGrid.TabIndex = 2;
            // 
            // A_dataGrid
            // 
            this.A_dataGrid.AllowUserToAddRows = false;
            this.A_dataGrid.AllowUserToDeleteRows = false;
            this.A_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A_dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A_dataGrid.Location = new System.Drawing.Point(0, 0);
            this.A_dataGrid.Name = "A_dataGrid";
            this.A_dataGrid.ReadOnly = true;
            this.A_dataGrid.RowHeadersWidth = 51;
            this.A_dataGrid.RowTemplate.Height = 24;
            this.A_dataGrid.Size = new System.Drawing.Size(906, 455);
            this.A_dataGrid.TabIndex = 3;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 484);
            this.Controls.Add(this.tabsConsultas);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.tabsConsultas.ResumeLayout(false);
            this.tabCalificaciones.ResumeLayout(false);
            this.tabCalificaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C_dataGrid)).EndInit();
            this.tabEstudiantes.ResumeLayout(false);
            this.tabAsignaturas.ResumeLayout(false);
            this.tabProfesores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.E_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsConsultas;
        private System.Windows.Forms.TabPage tabCalificaciones;
        private System.Windows.Forms.TabPage tabEstudiantes;
        private System.Windows.Forms.ComboBox C_ID_comboBox;
        private System.Windows.Forms.TabPage tabAsignaturas;
        private System.Windows.Forms.TabPage tabProfesores;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.DataGridView C_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDeLaNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_por_VN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntosDeHonor;
        private System.Windows.Forms.Label C_GPA_;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView E_dataGrid;
        private System.Windows.Forms.DataGridView T_dataGrid;
        private System.Windows.Forms.DataGridView A_dataGrid;
    }
}