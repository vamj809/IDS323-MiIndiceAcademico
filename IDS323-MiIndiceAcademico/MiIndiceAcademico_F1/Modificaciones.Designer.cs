namespace MiIndiceAcademico_F1
{
    partial class Modificaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabsModificaciones = new System.Windows.Forms.TabControl();
            this.tabCalificaciones = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_C_Cancel = new System.Windows.Forms.Button();
            this.btn_C_SaveChanges = new System.Windows.Forms.Button();
            this.C_dataGrid = new System.Windows.Forms.DataGridView();
            this.tabEstudiantes = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_E_Cancel = new System.Windows.Forms.Button();
            this.btn_E_SaveChanges = new System.Windows.Forms.Button();
            this.E_dataGrid = new System.Windows.Forms.DataGridView();
            this.tabAsignaturas = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_A_Cancel = new System.Windows.Forms.Button();
            this.btn_A_SaveChanges = new System.Windows.Forms.Button();
            this.A_dataGrid = new System.Windows.Forms.DataGridView();
            this.tabProfesores = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_P_Cancel = new System.Windows.Forms.Button();
            this.btn_P_SaveChanges = new System.Windows.Forms.Button();
            this.T_dataGrid = new System.Windows.Forms.DataGridView();
            this.Nota_ID_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota_ID_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabsModificaciones.SuspendLayout();
            this.tabCalificaciones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C_dataGrid)).BeginInit();
            this.tabEstudiantes.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.E_dataGrid)).BeginInit();
            this.tabAsignaturas.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A_dataGrid)).BeginInit();
            this.tabProfesores.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsModificaciones
            // 
            this.tabsModificaciones.Controls.Add(this.tabCalificaciones);
            this.tabsModificaciones.Controls.Add(this.tabEstudiantes);
            this.tabsModificaciones.Controls.Add(this.tabAsignaturas);
            this.tabsModificaciones.Controls.Add(this.tabProfesores);
            this.tabsModificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsModificaciones.Location = new System.Drawing.Point(0, 0);
            this.tabsModificaciones.Name = "tabsModificaciones";
            this.tabsModificaciones.SelectedIndex = 0;
            this.tabsModificaciones.Size = new System.Drawing.Size(800, 450);
            this.tabsModificaciones.TabIndex = 1;
            // 
            // tabCalificaciones
            // 
            this.tabCalificaciones.Controls.Add(this.panel1);
            this.tabCalificaciones.Controls.Add(this.C_dataGrid);
            this.tabCalificaciones.Location = new System.Drawing.Point(4, 25);
            this.tabCalificaciones.Name = "tabCalificaciones";
            this.tabCalificaciones.Size = new System.Drawing.Size(792, 421);
            this.tabCalificaciones.TabIndex = 0;
            this.tabCalificaciones.Text = "Calificaciones";
            this.tabCalificaciones.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_C_Cancel);
            this.panel1.Controls.Add(this.btn_C_SaveChanges);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 44);
            this.panel1.TabIndex = 2;
            // 
            // btn_C_Cancel
            // 
            this.btn_C_Cancel.Location = new System.Drawing.Point(695, 9);
            this.btn_C_Cancel.Name = "btn_C_Cancel";
            this.btn_C_Cancel.Size = new System.Drawing.Size(86, 23);
            this.btn_C_Cancel.TabIndex = 1;
            this.btn_C_Cancel.Text = "Cancelar";
            this.btn_C_Cancel.UseVisualStyleBackColor = true;
            this.btn_C_Cancel.Click += new System.EventHandler(this.btn_C_Cancel_Click);
            // 
            // btn_C_SaveChanges
            // 
            this.btn_C_SaveChanges.Location = new System.Drawing.Point(5, 9);
            this.btn_C_SaveChanges.Name = "btn_C_SaveChanges";
            this.btn_C_SaveChanges.Size = new System.Drawing.Size(154, 23);
            this.btn_C_SaveChanges.TabIndex = 0;
            this.btn_C_SaveChanges.Text = "Guardar Cambios";
            this.btn_C_SaveChanges.UseVisualStyleBackColor = true;
            this.btn_C_SaveChanges.Click += new System.EventHandler(this.btn_C_SaveChanges_Click);
            // 
            // C_dataGrid
            // 
            this.C_dataGrid.AllowUserToAddRows = false;
            this.C_dataGrid.AllowUserToDeleteRows = false;
            this.C_dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.C_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.C_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nota_ID_Estudiante,
            this.Nota_ID_Profesor,
            this.Materia,
            this.Nota});
            this.C_dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C_dataGrid.Location = new System.Drawing.Point(0, 0);
            this.C_dataGrid.Name = "C_dataGrid";
            this.C_dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.C_dataGrid.RowHeadersWidth = 20;
            this.C_dataGrid.RowTemplate.Height = 24;
            this.C_dataGrid.Size = new System.Drawing.Size(792, 421);
            this.C_dataGrid.TabIndex = 2;
            this.C_dataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataChanged);
            // 
            // tabEstudiantes
            // 
            this.tabEstudiantes.Controls.Add(this.panel2);
            this.tabEstudiantes.Controls.Add(this.E_dataGrid);
            this.tabEstudiantes.Location = new System.Drawing.Point(4, 25);
            this.tabEstudiantes.Name = "tabEstudiantes";
            this.tabEstudiantes.Size = new System.Drawing.Size(792, 421);
            this.tabEstudiantes.TabIndex = 1;
            this.tabEstudiantes.Text = "Estudiantes";
            this.tabEstudiantes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_E_Cancel);
            this.panel2.Controls.Add(this.btn_E_SaveChanges);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 44);
            this.panel2.TabIndex = 3;
            // 
            // btn_E_Cancel
            // 
            this.btn_E_Cancel.Location = new System.Drawing.Point(695, 9);
            this.btn_E_Cancel.Name = "btn_E_Cancel";
            this.btn_E_Cancel.Size = new System.Drawing.Size(86, 23);
            this.btn_E_Cancel.TabIndex = 1;
            this.btn_E_Cancel.Text = "Cancelar";
            this.btn_E_Cancel.UseVisualStyleBackColor = true;
            this.btn_E_Cancel.Click += new System.EventHandler(this.btn_E_Cancel_Click);
            // 
            // btn_E_SaveChanges
            // 
            this.btn_E_SaveChanges.Location = new System.Drawing.Point(5, 9);
            this.btn_E_SaveChanges.Name = "btn_E_SaveChanges";
            this.btn_E_SaveChanges.Size = new System.Drawing.Size(154, 23);
            this.btn_E_SaveChanges.TabIndex = 0;
            this.btn_E_SaveChanges.Text = "Guardar Cambios";
            this.btn_E_SaveChanges.UseVisualStyleBackColor = true;
            this.btn_E_SaveChanges.Click += new System.EventHandler(this.btn_E_SaveChanges_Click);
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
            this.E_dataGrid.RowHeadersWidth = 51;
            this.E_dataGrid.RowTemplate.Height = 24;
            this.E_dataGrid.Size = new System.Drawing.Size(792, 421);
            this.E_dataGrid.TabIndex = 0;
            this.E_dataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataChanged);
            // 
            // tabAsignaturas
            // 
            this.tabAsignaturas.Controls.Add(this.panel3);
            this.tabAsignaturas.Controls.Add(this.A_dataGrid);
            this.tabAsignaturas.Location = new System.Drawing.Point(4, 25);
            this.tabAsignaturas.Name = "tabAsignaturas";
            this.tabAsignaturas.Size = new System.Drawing.Size(792, 421);
            this.tabAsignaturas.TabIndex = 2;
            this.tabAsignaturas.Text = "Asignaturas";
            this.tabAsignaturas.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_A_Cancel);
            this.panel3.Controls.Add(this.btn_A_SaveChanges);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 44);
            this.panel3.TabIndex = 4;
            // 
            // btn_A_Cancel
            // 
            this.btn_A_Cancel.Location = new System.Drawing.Point(695, 9);
            this.btn_A_Cancel.Name = "btn_A_Cancel";
            this.btn_A_Cancel.Size = new System.Drawing.Size(86, 23);
            this.btn_A_Cancel.TabIndex = 1;
            this.btn_A_Cancel.Text = "Cancelar";
            this.btn_A_Cancel.UseVisualStyleBackColor = true;
            this.btn_A_Cancel.Click += new System.EventHandler(this.btn_A_Cancel_Click);
            // 
            // btn_A_SaveChanges
            // 
            this.btn_A_SaveChanges.Location = new System.Drawing.Point(5, 9);
            this.btn_A_SaveChanges.Name = "btn_A_SaveChanges";
            this.btn_A_SaveChanges.Size = new System.Drawing.Size(154, 23);
            this.btn_A_SaveChanges.TabIndex = 0;
            this.btn_A_SaveChanges.Text = "Guardar Cambios";
            this.btn_A_SaveChanges.UseVisualStyleBackColor = true;
            this.btn_A_SaveChanges.Click += new System.EventHandler(this.btn_A_SaveChanges_Click);
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
            this.A_dataGrid.RowHeadersWidth = 51;
            this.A_dataGrid.RowTemplate.Height = 24;
            this.A_dataGrid.Size = new System.Drawing.Size(792, 421);
            this.A_dataGrid.TabIndex = 3;
            this.A_dataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataChanged);
            // 
            // tabProfesores
            // 
            this.tabProfesores.Controls.Add(this.panel4);
            this.tabProfesores.Controls.Add(this.T_dataGrid);
            this.tabProfesores.Location = new System.Drawing.Point(4, 25);
            this.tabProfesores.Name = "tabProfesores";
            this.tabProfesores.Size = new System.Drawing.Size(792, 421);
            this.tabProfesores.TabIndex = 3;
            this.tabProfesores.Text = "Profesores";
            this.tabProfesores.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_P_Cancel);
            this.panel4.Controls.Add(this.btn_P_SaveChanges);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 377);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(792, 44);
            this.panel4.TabIndex = 4;
            // 
            // btn_P_Cancel
            // 
            this.btn_P_Cancel.Location = new System.Drawing.Point(695, 9);
            this.btn_P_Cancel.Name = "btn_P_Cancel";
            this.btn_P_Cancel.Size = new System.Drawing.Size(86, 23);
            this.btn_P_Cancel.TabIndex = 1;
            this.btn_P_Cancel.Text = "Cancelar";
            this.btn_P_Cancel.UseVisualStyleBackColor = true;
            this.btn_P_Cancel.Click += new System.EventHandler(this.btn_P_Cancel_Click);
            // 
            // btn_P_SaveChanges
            // 
            this.btn_P_SaveChanges.Location = new System.Drawing.Point(5, 9);
            this.btn_P_SaveChanges.Name = "btn_P_SaveChanges";
            this.btn_P_SaveChanges.Size = new System.Drawing.Size(154, 23);
            this.btn_P_SaveChanges.TabIndex = 0;
            this.btn_P_SaveChanges.Text = "Guardar Cambios";
            this.btn_P_SaveChanges.UseVisualStyleBackColor = true;
            this.btn_P_SaveChanges.Click += new System.EventHandler(this.btn_P_SaveChanges_Click);
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
            this.T_dataGrid.RowHeadersWidth = 51;
            this.T_dataGrid.RowTemplate.Height = 24;
            this.T_dataGrid.Size = new System.Drawing.Size(792, 421);
            this.T_dataGrid.TabIndex = 2;
            this.T_dataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataChanged);
            // 
            // Nota_ID_Estudiante
            // 
            this.Nota_ID_Estudiante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nota_ID_Estudiante.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nota_ID_Estudiante.HeaderText = "Matricula Estudiante";
            this.Nota_ID_Estudiante.MinimumWidth = 6;
            this.Nota_ID_Estudiante.Name = "Nota_ID_Estudiante";
            this.Nota_ID_Estudiante.ReadOnly = true;
            // 
            // Nota_ID_Profesor
            // 
            this.Nota_ID_Profesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nota_ID_Profesor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nota_ID_Profesor.HeaderText = "Profesor";
            this.Nota_ID_Profesor.MinimumWidth = 6;
            this.Nota_ID_Profesor.Name = "Nota_ID_Profesor";
            this.Nota_ID_Profesor.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Materia.DefaultCellStyle = dataGridViewCellStyle3;
            this.Materia.HeaderText = "Materia";
            this.Materia.MinimumWidth = 6;
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nota.HeaderText = "Nota";
            this.Nota.MinimumWidth = 6;
            this.Nota.Name = "Nota";
            // 
            // ID_Estudiante
            // 
            this.ID_Estudiante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ID_Estudiante.DefaultCellStyle = dataGridViewCellStyle4;
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
            // 
            // Carrera
            // 
            this.Carrera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.MinimumWidth = 6;
            this.Carrera.Name = "Carrera";
            this.Carrera.Width = 85;
            // 
            // Clave_Materia
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Clave_Materia.DefaultCellStyle = dataGridViewCellStyle5;
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
            // 
            // Credito
            // 
            this.Credito.HeaderText = "Credito";
            this.Credito.MinimumWidth = 6;
            this.Credito.Name = "Credito";
            this.Credito.Width = 125;
            // 
            // ID_Profesor
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ID_Profesor.DefaultCellStyle = dataGridViewCellStyle6;
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
            // 
            // Modificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabsModificaciones);
            this.Name = "Modificaciones";
            this.Text = "Modificaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modificaciones_FormClosing);
            this.tabsModificaciones.ResumeLayout(false);
            this.tabCalificaciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.C_dataGrid)).EndInit();
            this.tabEstudiantes.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.E_dataGrid)).EndInit();
            this.tabAsignaturas.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A_dataGrid)).EndInit();
            this.tabProfesores.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.T_dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsModificaciones;
        private System.Windows.Forms.TabPage tabCalificaciones;
        private System.Windows.Forms.DataGridView C_dataGrid;
        private System.Windows.Forms.TabPage tabEstudiantes;
        private System.Windows.Forms.DataGridView E_dataGrid;
        private System.Windows.Forms.TabPage tabAsignaturas;
        private System.Windows.Forms.DataGridView A_dataGrid;
        private System.Windows.Forms.TabPage tabProfesores;
        private System.Windows.Forms.DataGridView T_dataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_C_Cancel;
        private System.Windows.Forms.Button btn_C_SaveChanges;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_E_Cancel;
        private System.Windows.Forms.Button btn_E_SaveChanges;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_A_Cancel;
        private System.Windows.Forms.Button btn_A_SaveChanges;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_P_Cancel;
        private System.Windows.Forms.Button btn_P_SaveChanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota_ID_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota_ID_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Profesor;
    }
}