namespace MiIndiceAcademico_F1
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
            this.C_dataGrid = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDeLaNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_por_VN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntosDeHonor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.C_GPA_Label = new System.Windows.Forms.Label();
            this.C_GPA_Value = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IDLabel = new System.Windows.Forms.Label();
            this.ID_comboBox = new System.Windows.Forms.ComboBox();
            this.tabEstudiantes = new System.Windows.Forms.TabPage();
            this.E_dataGrid = new System.Windows.Forms.DataGridView();
            this.ID_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAsignaturas = new System.Windows.Forms.TabPage();
            this.A_dataGrid = new System.Windows.Forms.DataGridView();
            this.Clave_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProfesores = new System.Windows.Forms.TabPage();
            this.T_dataGrid = new System.Windows.Forms.DataGridView();
            this.ID_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabsConsultas.SuspendLayout();
            this.tabCalificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C_dataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabEstudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.E_dataGrid)).BeginInit();
            this.tabAsignaturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A_dataGrid)).BeginInit();
            this.tabProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_dataGrid)).BeginInit();
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
            this.tabCalificaciones.Controls.Add(this.C_dataGrid);
            this.tabCalificaciones.Controls.Add(this.panel2);
            this.tabCalificaciones.Controls.Add(this.panel1);
            this.tabCalificaciones.Location = new System.Drawing.Point(4, 25);
            this.tabCalificaciones.Name = "tabCalificaciones";
            this.tabCalificaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalificaciones.Size = new System.Drawing.Size(906, 455);
            this.tabCalificaciones.TabIndex = 0;
            this.tabCalificaciones.Text = "Calificaciones";
            this.tabCalificaciones.UseVisualStyleBackColor = true;
            // 
            // C_dataGrid
            // 
            this.C_dataGrid.AllowUserToAddRows = false;
            this.C_dataGrid.AllowUserToDeleteRows = false;
            this.C_dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.C_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.C_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Asignatura,
            this.Creditos,
            this.Nota,
            this.ValorDeLaNota,
            this.C_por_VN,
            this.PuntosDeHonor});
            this.C_dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C_dataGrid.Location = new System.Drawing.Point(3, 53);
            this.C_dataGrid.Name = "C_dataGrid";
            this.C_dataGrid.ReadOnly = true;
            this.C_dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.C_dataGrid.RowHeadersWidth = 20;
            this.C_dataGrid.RowTemplate.Height = 24;
            this.C_dataGrid.Size = new System.Drawing.Size(900, 349);
            this.C_dataGrid.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // Asignatura
            // 
            this.Asignatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Asignatura.HeaderText = "Asignatura";
            this.Asignatura.MinimumWidth = 6;
            this.Asignatura.Name = "Asignatura";
            this.Asignatura.ReadOnly = true;
            // 
            // Creditos
            // 
            this.Creditos.HeaderText = "Créditos";
            this.Creditos.MinimumWidth = 6;
            this.Creditos.Name = "Creditos";
            this.Creditos.ReadOnly = true;
            this.Creditos.Width = 70;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.MinimumWidth = 6;
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            this.Nota.Width = 50;
            // 
            // ValorDeLaNota
            // 
            this.ValorDeLaNota.HeaderText = "Valor de la Nota";
            this.ValorDeLaNota.MinimumWidth = 6;
            this.ValorDeLaNota.Name = "ValorDeLaNota";
            this.ValorDeLaNota.ReadOnly = true;
            this.ValorDeLaNota.Width = 125;
            // 
            // C_por_VN
            // 
            this.C_por_VN.HeaderText = "Créditos * Valor de Nota";
            this.C_por_VN.MinimumWidth = 6;
            this.C_por_VN.Name = "C_por_VN";
            this.C_por_VN.ReadOnly = true;
            this.C_por_VN.Width = 125;
            // 
            // PuntosDeHonor
            // 
            this.PuntosDeHonor.HeaderText = "Puntos de Honor";
            this.PuntosDeHonor.MinimumWidth = 6;
            this.PuntosDeHonor.Name = "PuntosDeHonor";
            this.PuntosDeHonor.ReadOnly = true;
            this.PuntosDeHonor.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.C_GPA_Label);
            this.panel2.Controls.Add(this.C_GPA_Value);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 402);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 50);
            this.panel2.TabIndex = 6;
            // 
            // C_GPA_Label
            // 
            this.C_GPA_Label.AutoSize = true;
            this.C_GPA_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_GPA_Label.Location = new System.Drawing.Point(248, 16);
            this.C_GPA_Label.Name = "C_GPA_Label";
            this.C_GPA_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C_GPA_Label.Size = new System.Drawing.Size(202, 17);
            this.C_GPA_Label.TabIndex = 3;
            this.C_GPA_Label.Text = "Índice Académico General:";
            // 
            // C_GPA_Value
            // 
            this.C_GPA_Value.AutoSize = true;
            this.C_GPA_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_GPA_Value.Location = new System.Drawing.Point(471, 16);
            this.C_GPA_Value.Name = "C_GPA_Value";
            this.C_GPA_Value.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C_GPA_Value.Size = new System.Drawing.Size(13, 17);
            this.C_GPA_Value.TabIndex = 4;
            this.C_GPA_Value.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IDLabel);
            this.panel1.Controls.Add(this.ID_comboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 50);
            this.panel1.TabIndex = 5;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(22, 17);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(111, 17);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID (Matrícula):";
            // 
            // ID_comboBox
            // 
            this.ID_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ID_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ID_comboBox.FormattingEnabled = true;
            this.ID_comboBox.Items.AddRange(new object[] {
            "1067196",
            "1089090",
            "1075050",
            "1043020",
            "1091337"});
            this.ID_comboBox.Location = new System.Drawing.Point(142, 14);
            this.ID_comboBox.Name = "ID_comboBox";
            this.ID_comboBox.Size = new System.Drawing.Size(122, 24);
            this.ID_comboBox.TabIndex = 0;
            this.ID_comboBox.TextChanged += new System.EventHandler(this.ID_comboBox_TextChanged);
            // 
            // tabEstudiantes
            // 
            this.tabEstudiantes.Controls.Add(this.E_dataGrid);
            this.tabEstudiantes.Location = new System.Drawing.Point(4, 25);
            this.tabEstudiantes.Name = "tabEstudiantes";
            this.tabEstudiantes.Size = new System.Drawing.Size(906, 455);
            this.tabEstudiantes.TabIndex = 1;
            this.tabEstudiantes.Text = "Estudiantes";
            this.tabEstudiantes.UseVisualStyleBackColor = true;
            // 
            // E_dataGrid
            // 
            this.E_dataGrid.AllowUserToAddRows = false;
            this.E_dataGrid.AllowUserToDeleteRows = false;
            this.E_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.E_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Estudiante,
            this.Nombre_Estudiante,
            this.Carrera});
            this.E_dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.E_dataGrid.Location = new System.Drawing.Point(0, 0);
            this.E_dataGrid.Name = "E_dataGrid";
            this.E_dataGrid.ReadOnly = true;
            this.E_dataGrid.RowHeadersWidth = 51;
            this.E_dataGrid.RowTemplate.Height = 24;
            this.E_dataGrid.Size = new System.Drawing.Size(906, 455);
            this.E_dataGrid.TabIndex = 0;
            // 
            // ID_Estudiante
            // 
            this.ID_Estudiante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID_Estudiante.HeaderText = "Matricula";
            this.ID_Estudiante.MinimumWidth = 6;
            this.ID_Estudiante.Name = "ID_Estudiante";
            this.ID_Estudiante.ReadOnly = true;
            this.ID_Estudiante.Width = 94;
            // 
            // Nombre_Estudiante
            // 
            this.Nombre_Estudiante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Estudiante.HeaderText = "Nombre Completo";
            this.Nombre_Estudiante.MinimumWidth = 6;
            this.Nombre_Estudiante.Name = "Nombre_Estudiante";
            this.Nombre_Estudiante.ReadOnly = true;
            // 
            // Carrera
            // 
            this.Carrera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.MinimumWidth = 6;
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.Width = 85;
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
            // A_dataGrid
            // 
            this.A_dataGrid.AllowUserToAddRows = false;
            this.A_dataGrid.AllowUserToDeleteRows = false;
            this.A_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave_Materia,
            this.Nombre_Asignatura,
            this.Credito});
            this.A_dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A_dataGrid.Location = new System.Drawing.Point(0, 0);
            this.A_dataGrid.Name = "A_dataGrid";
            this.A_dataGrid.ReadOnly = true;
            this.A_dataGrid.RowHeadersWidth = 51;
            this.A_dataGrid.RowTemplate.Height = 24;
            this.A_dataGrid.Size = new System.Drawing.Size(906, 455);
            this.A_dataGrid.TabIndex = 3;
            // 
            // Clave_Materia
            // 
            this.Clave_Materia.HeaderText = "Codigo";
            this.Clave_Materia.MinimumWidth = 6;
            this.Clave_Materia.Name = "Clave_Materia";
            this.Clave_Materia.ReadOnly = true;
            this.Clave_Materia.Width = 125;
            // 
            // Nombre_Asignatura
            // 
            this.Nombre_Asignatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Asignatura.HeaderText = "Nombre";
            this.Nombre_Asignatura.MinimumWidth = 6;
            this.Nombre_Asignatura.Name = "Nombre_Asignatura";
            this.Nombre_Asignatura.ReadOnly = true;
            // 
            // Credito
            // 
            this.Credito.HeaderText = "Credito";
            this.Credito.MinimumWidth = 6;
            this.Credito.Name = "Credito";
            this.Credito.ReadOnly = true;
            this.Credito.Width = 125;
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
            // T_dataGrid
            // 
            this.T_dataGrid.AllowUserToAddRows = false;
            this.T_dataGrid.AllowUserToDeleteRows = false;
            this.T_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.T_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Profesor,
            this.Nombre_Profesor});
            this.T_dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.T_dataGrid.Location = new System.Drawing.Point(0, 0);
            this.T_dataGrid.Name = "T_dataGrid";
            this.T_dataGrid.ReadOnly = true;
            this.T_dataGrid.RowHeadersWidth = 51;
            this.T_dataGrid.RowTemplate.Height = 24;
            this.T_dataGrid.Size = new System.Drawing.Size(906, 455);
            this.T_dataGrid.TabIndex = 2;
            // 
            // ID_Profesor
            // 
            this.ID_Profesor.HeaderText = "Matricula";
            this.ID_Profesor.MinimumWidth = 6;
            this.ID_Profesor.Name = "ID_Profesor";
            this.ID_Profesor.ReadOnly = true;
            this.ID_Profesor.Width = 125;
            // 
            // Nombre_Profesor
            // 
            this.Nombre_Profesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Profesor.HeaderText = "Nombre Completo";
            this.Nombre_Profesor.MinimumWidth = 6;
            this.Nombre_Profesor.Name = "Nombre_Profesor";
            this.Nombre_Profesor.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.C_dataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabEstudiantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.E_dataGrid)).EndInit();
            this.tabAsignaturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A_dataGrid)).EndInit();
            this.tabProfesores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.T_dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsConsultas;
        private System.Windows.Forms.TabPage tabCalificaciones;
        private System.Windows.Forms.TabPage tabEstudiantes;
        private System.Windows.Forms.ComboBox ID_comboBox;
        private System.Windows.Forms.TabPage tabAsignaturas;
        private System.Windows.Forms.TabPage tabProfesores;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label C_GPA_Label;
        private System.Windows.Forms.DataGridView E_dataGrid;
        private System.Windows.Forms.DataGridView T_dataGrid;
        private System.Windows.Forms.DataGridView A_dataGrid;
        private System.Windows.Forms.Label C_GPA_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Profesor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView C_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDeLaNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_por_VN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntosDeHonor;
    }
}