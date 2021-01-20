﻿namespace MIA_2020.Menus
{
    partial class AdminsMenu
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
            this.SubMenuPanel = new System.Windows.Forms.Panel();
            this.RankingButton = new System.Windows.Forms.RadioButton();
            this.ProfesoresButton = new System.Windows.Forms.RadioButton();
            this.CloseSystem = new System.Windows.Forms.Button();
            this.LogOffButton = new System.Windows.Forms.Button();
            this.MisCalificacionesButton = new System.Windows.Forms.RadioButton();
            this.SeleccionButton = new System.Windows.Forms.RadioButton();
            this.MiCuentaButton = new System.Windows.Forms.RadioButton();
            this.TopFillPanel = new System.Windows.Forms.Panel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MiCuenta = new System.Windows.Forms.TabPage();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.MiCuenta_TitleLabel = new System.Windows.Forms.Label();
            this.Estudiantes = new System.Windows.Forms.TabPage();
            this.NuevoEstudiante = new System.Windows.Forms.Button();
            this.TablaEstudiantes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Asignaturas = new System.Windows.Forms.TabPage();
            this.NuevaAsignatura = new System.Windows.Forms.Button();
            this.TablaAsignaturas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Profesores = new System.Windows.Forms.TabPage();
            this.NuevoProfesor = new System.Windows.Forms.Button();
            this.TablaProfesores = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Ranking = new System.Windows.Forms.TabPage();
            this.TablaRanking = new System.Windows.Forms.DataGridView();
            this.ID_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Honor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.SubMenuPanel.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.MiCuenta.SuspendLayout();
            this.Estudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEstudiantes)).BeginInit();
            this.Asignaturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaAsignaturas)).BeginInit();
            this.Profesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProfesores)).BeginInit();
            this.Ranking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // SubMenuPanel
            // 
            this.SubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SubMenuPanel.Controls.Add(this.RankingButton);
            this.SubMenuPanel.Controls.Add(this.ProfesoresButton);
            this.SubMenuPanel.Controls.Add(this.CloseSystem);
            this.SubMenuPanel.Controls.Add(this.LogOffButton);
            this.SubMenuPanel.Controls.Add(this.MisCalificacionesButton);
            this.SubMenuPanel.Controls.Add(this.SeleccionButton);
            this.SubMenuPanel.Controls.Add(this.MiCuentaButton);
            this.SubMenuPanel.Controls.Add(this.TopFillPanel);
            this.SubMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SubMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SubMenuPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubMenuPanel.Name = "SubMenuPanel";
            this.SubMenuPanel.Size = new System.Drawing.Size(141, 417);
            this.SubMenuPanel.TabIndex = 0;
            // 
            // RankingButton
            // 
            this.RankingButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.RankingButton.AutoEllipsis = true;
            this.RankingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RankingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RankingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RankingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.RankingButton.FlatAppearance.BorderSize = 0;
            this.RankingButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.RankingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RankingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RankingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RankingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.RankingButton.Location = new System.Drawing.Point(0, 280);
            this.RankingButton.Name = "RankingButton";
            this.RankingButton.Size = new System.Drawing.Size(141, 37);
            this.RankingButton.TabIndex = 12;
            this.RankingButton.Text = "Ranking";
            this.RankingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RankingButton.UseVisualStyleBackColor = false;
            this.RankingButton.CheckedChanged += new System.EventHandler(this.RankingButton_CheckedChanged);
            // 
            // ProfesoresButton
            // 
            this.ProfesoresButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ProfesoresButton.AutoEllipsis = true;
            this.ProfesoresButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProfesoresButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProfesoresButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfesoresButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ProfesoresButton.FlatAppearance.BorderSize = 0;
            this.ProfesoresButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ProfesoresButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProfesoresButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProfesoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfesoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.ProfesoresButton.Location = new System.Drawing.Point(0, 243);
            this.ProfesoresButton.Name = "ProfesoresButton";
            this.ProfesoresButton.Size = new System.Drawing.Size(141, 37);
            this.ProfesoresButton.TabIndex = 16;
            this.ProfesoresButton.Text = "Profesores";
            this.ProfesoresButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProfesoresButton.UseVisualStyleBackColor = false;
            this.ProfesoresButton.CheckedChanged += new System.EventHandler(this.ProfesoresButton_CheckedChanged);
            // 
            // CloseSystem
            // 
            this.CloseSystem.Location = new System.Drawing.Point(2, 375);
            this.CloseSystem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseSystem.Name = "CloseSystem";
            this.CloseSystem.Size = new System.Drawing.Size(136, 37);
            this.CloseSystem.TabIndex = 15;
            this.CloseSystem.Text = "Cerrar Sistema";
            this.CloseSystem.UseVisualStyleBackColor = true;
            this.CloseSystem.Click += new System.EventHandler(this.CloseSystem_Click);
            // 
            // LogOffButton
            // 
            this.LogOffButton.Location = new System.Drawing.Point(2, 333);
            this.LogOffButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.Size = new System.Drawing.Size(136, 37);
            this.LogOffButton.TabIndex = 14;
            this.LogOffButton.Text = "Cerrar Sesión";
            this.LogOffButton.UseVisualStyleBackColor = true;
            this.LogOffButton.Click += new System.EventHandler(this.LogOffButton_Click);
            // 
            // MisCalificacionesButton
            // 
            this.MisCalificacionesButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.MisCalificacionesButton.AutoEllipsis = true;
            this.MisCalificacionesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MisCalificacionesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MisCalificacionesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MisCalificacionesButton.FlatAppearance.BorderSize = 0;
            this.MisCalificacionesButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.MisCalificacionesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MisCalificacionesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MisCalificacionesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MisCalificacionesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.MisCalificacionesButton.Location = new System.Drawing.Point(0, 206);
            this.MisCalificacionesButton.Name = "MisCalificacionesButton";
            this.MisCalificacionesButton.Size = new System.Drawing.Size(141, 37);
            this.MisCalificacionesButton.TabIndex = 11;
            this.MisCalificacionesButton.Text = "Asignaturas";
            this.MisCalificacionesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MisCalificacionesButton.UseVisualStyleBackColor = false;
            this.MisCalificacionesButton.CheckedChanged += new System.EventHandler(this.MisCalificacionesButton_CheckedChanged);
            // 
            // SeleccionButton
            // 
            this.SeleccionButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SeleccionButton.AutoEllipsis = true;
            this.SeleccionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SeleccionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeleccionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.SeleccionButton.FlatAppearance.BorderSize = 0;
            this.SeleccionButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.SeleccionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SeleccionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SeleccionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeleccionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.SeleccionButton.Location = new System.Drawing.Point(0, 169);
            this.SeleccionButton.Name = "SeleccionButton";
            this.SeleccionButton.Size = new System.Drawing.Size(141, 37);
            this.SeleccionButton.TabIndex = 10;
            this.SeleccionButton.Text = "Estudiantes";
            this.SeleccionButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SeleccionButton.UseVisualStyleBackColor = false;
            this.SeleccionButton.CheckedChanged += new System.EventHandler(this.SeleccionButton_CheckedChanged);
            // 
            // MiCuentaButton
            // 
            this.MiCuentaButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.MiCuentaButton.AutoEllipsis = true;
            this.MiCuentaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MiCuentaButton.Checked = true;
            this.MiCuentaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MiCuentaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MiCuentaButton.FlatAppearance.BorderSize = 0;
            this.MiCuentaButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.MiCuentaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MiCuentaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MiCuentaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiCuentaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.MiCuentaButton.Location = new System.Drawing.Point(0, 132);
            this.MiCuentaButton.Name = "MiCuentaButton";
            this.MiCuentaButton.Size = new System.Drawing.Size(141, 37);
            this.MiCuentaButton.TabIndex = 9;
            this.MiCuentaButton.TabStop = true;
            this.MiCuentaButton.Text = "Mi Cuenta";
            this.MiCuentaButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MiCuentaButton.UseVisualStyleBackColor = false;
            this.MiCuentaButton.CheckedChanged += new System.EventHandler(this.MiCuentaButton_CheckedChanged);
            // 
            // TopFillPanel
            // 
            this.TopFillPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TopFillPanel.BackgroundImage = global::MIA_2020.Properties.Resources.OurLogo;
            this.TopFillPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TopFillPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopFillPanel.Location = new System.Drawing.Point(0, 0);
            this.TopFillPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopFillPanel.Name = "TopFillPanel";
            this.TopFillPanel.Size = new System.Drawing.Size(141, 132);
            this.TopFillPanel.TabIndex = 13;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.MiCuenta);
            this.TabControl.Controls.Add(this.Estudiantes);
            this.TabControl.Controls.Add(this.Asignaturas);
            this.TabControl.Controls.Add(this.Profesores);
            this.TabControl.Controls.Add(this.Ranking);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ItemSize = new System.Drawing.Size(120, 21);
            this.TabControl.Location = new System.Drawing.Point(141, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabControl.MinimumSize = new System.Drawing.Size(537, 417);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(537, 417);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 3;
            // 
            // MiCuenta
            // 
            this.MiCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MiCuenta.Controls.Add(this.InfoLabel);
            this.MiCuenta.Controls.Add(this.MiCuenta_TitleLabel);
            this.MiCuenta.Location = new System.Drawing.Point(4, 25);
            this.MiCuenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MiCuenta.Name = "MiCuenta";
            this.MiCuenta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MiCuenta.Size = new System.Drawing.Size(529, 388);
            this.MiCuenta.TabIndex = 0;
            this.MiCuenta.Text = "Mi Cuenta";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoEllipsis = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InfoLabel.Location = new System.Drawing.Point(104, 126);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(323, 204);
            this.InfoLabel.TabIndex = 16;
            this.InfoLabel.Text = "ID:\r\nasdf\r\n\r\nNombre:\r\nasdf";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MiCuenta_TitleLabel
            // 
            this.MiCuenta_TitleLabel.AutoSize = true;
            this.MiCuenta_TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.MiCuenta_TitleLabel.Location = new System.Drawing.Point(211, 64);
            this.MiCuenta_TitleLabel.Name = "MiCuenta_TitleLabel";
            this.MiCuenta_TitleLabel.Size = new System.Drawing.Size(120, 26);
            this.MiCuenta_TitleLabel.TabIndex = 15;
            this.MiCuenta_TitleLabel.Text = "Mi Cuenta";
            // 
            // Estudiantes
            // 
            this.Estudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Estudiantes.Controls.Add(this.NuevoEstudiante);
            this.Estudiantes.Controls.Add(this.TablaEstudiantes);
            this.Estudiantes.Controls.Add(this.label1);
            this.Estudiantes.Location = new System.Drawing.Point(4, 25);
            this.Estudiantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Estudiantes.Name = "Estudiantes";
            this.Estudiantes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Estudiantes.Size = new System.Drawing.Size(529, 388);
            this.Estudiantes.TabIndex = 1;
            this.Estudiantes.Text = "Estudiantes";
            // 
            // NuevoEstudiante
            // 
            this.NuevoEstudiante.Location = new System.Drawing.Point(426, 9);
            this.NuevoEstudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NuevoEstudiante.Name = "NuevoEstudiante";
            this.NuevoEstudiante.Size = new System.Drawing.Size(99, 37);
            this.NuevoEstudiante.TabIndex = 18;
            this.NuevoEstudiante.Text = "Crear Nuevo";
            this.NuevoEstudiante.UseVisualStyleBackColor = true;
            this.NuevoEstudiante.Click += new System.EventHandler(this.NuevoEstudiante_Click);
            // 
            // TablaEstudiantes
            // 
            this.TablaEstudiantes.AllowUserToAddRows = false;
            this.TablaEstudiantes.AllowUserToDeleteRows = false;
            this.TablaEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaEstudiantes.Location = new System.Drawing.Point(2, 51);
            this.TablaEstudiantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TablaEstudiantes.Name = "TablaEstudiantes";
            this.TablaEstudiantes.RowHeadersWidth = 51;
            this.TablaEstudiantes.RowTemplate.Height = 24;
            this.TablaEstudiantes.Size = new System.Drawing.Size(526, 336);
            this.TablaEstudiantes.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(194, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Estudiantes";
            // 
            // Asignaturas
            // 
            this.Asignaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Asignaturas.Controls.Add(this.NuevaAsignatura);
            this.Asignaturas.Controls.Add(this.TablaAsignaturas);
            this.Asignaturas.Controls.Add(this.label2);
            this.Asignaturas.Location = new System.Drawing.Point(4, 25);
            this.Asignaturas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Asignaturas.Name = "Asignaturas";
            this.Asignaturas.Size = new System.Drawing.Size(529, 388);
            this.Asignaturas.TabIndex = 2;
            this.Asignaturas.Text = "Asignaturas";
            // 
            // NuevaAsignatura
            // 
            this.NuevaAsignatura.Location = new System.Drawing.Point(433, 11);
            this.NuevaAsignatura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NuevaAsignatura.Name = "NuevaAsignatura";
            this.NuevaAsignatura.Size = new System.Drawing.Size(92, 37);
            this.NuevaAsignatura.TabIndex = 17;
            this.NuevaAsignatura.Text = "Crear Nueva";
            this.NuevaAsignatura.UseVisualStyleBackColor = true;
            this.NuevaAsignatura.Click += new System.EventHandler(this.NuevaAsignatura_Click);
            // 
            // TablaAsignaturas
            // 
            this.TablaAsignaturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaAsignaturas.Location = new System.Drawing.Point(0, 56);
            this.TablaAsignaturas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TablaAsignaturas.Name = "TablaAsignaturas";
            this.TablaAsignaturas.RowHeadersWidth = 51;
            this.TablaAsignaturas.RowTemplate.Height = 24;
            this.TablaAsignaturas.Size = new System.Drawing.Size(531, 337);
            this.TablaAsignaturas.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(196, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Asignaturas";
            // 
            // Profesores
            // 
            this.Profesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Profesores.Controls.Add(this.NuevoProfesor);
            this.Profesores.Controls.Add(this.TablaProfesores);
            this.Profesores.Controls.Add(this.label4);
            this.Profesores.Location = new System.Drawing.Point(4, 25);
            this.Profesores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Profesores.Name = "Profesores";
            this.Profesores.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Profesores.Size = new System.Drawing.Size(529, 388);
            this.Profesores.TabIndex = 4;
            this.Profesores.Text = "Profesores";
            // 
            // NuevoProfesor
            // 
            this.NuevoProfesor.Location = new System.Drawing.Point(424, 6);
            this.NuevoProfesor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NuevoProfesor.Name = "NuevoProfesor";
            this.NuevoProfesor.Size = new System.Drawing.Size(100, 37);
            this.NuevoProfesor.TabIndex = 18;
            this.NuevoProfesor.Text = "Crear Nuevo";
            this.NuevoProfesor.UseVisualStyleBackColor = true;
            this.NuevoProfesor.Click += new System.EventHandler(this.NuevoProfesor_Click);
            // 
            // TablaProfesores
            // 
            this.TablaProfesores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProfesores.Location = new System.Drawing.Point(2, 54);
            this.TablaProfesores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TablaProfesores.Name = "TablaProfesores";
            this.TablaProfesores.RowHeadersWidth = 51;
            this.TablaProfesores.RowTemplate.Height = 24;
            this.TablaProfesores.Size = new System.Drawing.Size(526, 337);
            this.TablaProfesores.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(197, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Profesores";
            // 
            // Ranking
            // 
            this.Ranking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ranking.Controls.Add(this.TablaRanking);
            this.Ranking.Controls.Add(this.label3);
            this.Ranking.Location = new System.Drawing.Point(4, 25);
            this.Ranking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ranking.Name = "Ranking";
            this.Ranking.Size = new System.Drawing.Size(529, 388);
            this.Ranking.TabIndex = 3;
            this.Ranking.Text = "Ranking";
            // 
            // TablaRanking
            // 
            this.TablaRanking.AllowUserToAddRows = false;
            this.TablaRanking.AllowUserToDeleteRows = false;
            this.TablaRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Estudiante,
            this.Estudiante,
            this.GPA,
            this.Honor});
            this.TablaRanking.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TablaRanking.Location = new System.Drawing.Point(0, 49);
            this.TablaRanking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TablaRanking.Name = "TablaRanking";
            this.TablaRanking.ReadOnly = true;
            this.TablaRanking.RowHeadersWidth = 51;
            this.TablaRanking.RowTemplate.Height = 24;
            this.TablaRanking.Size = new System.Drawing.Size(529, 339);
            this.TablaRanking.TabIndex = 20;
            // 
            // ID_Estudiante
            // 
            this.ID_Estudiante.HeaderText = "ID Estudiante";
            this.ID_Estudiante.MinimumWidth = 6;
            this.ID_Estudiante.Name = "ID_Estudiante";
            this.ID_Estudiante.ReadOnly = true;
            this.ID_Estudiante.Width = 125;
            // 
            // Estudiante
            // 
            this.Estudiante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.MinimumWidth = 6;
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.ReadOnly = true;
            // 
            // GPA
            // 
            this.GPA.HeaderText = "Índice Académico";
            this.GPA.MinimumWidth = 6;
            this.GPA.Name = "GPA";
            this.GPA.ReadOnly = true;
            this.GPA.Width = 125;
            // 
            // Honor
            // 
            this.Honor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Honor.HeaderText = "Honorarios";
            this.Honor.MinimumWidth = 6;
            this.Honor.Name = "Honor";
            this.Honor.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(203, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ranking";
            // 
            // AdminsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(678, 417);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.SubMenuPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminsMenu";
            this.Text = "Menu del Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminsMenu_FormClosing);
            this.Load += new System.EventHandler(this.AdminsMenu_Load);
            this.SubMenuPanel.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.MiCuenta.ResumeLayout(false);
            this.MiCuenta.PerformLayout();
            this.Estudiantes.ResumeLayout(false);
            this.Estudiantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEstudiantes)).EndInit();
            this.Asignaturas.ResumeLayout(false);
            this.Asignaturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaAsignaturas)).EndInit();
            this.Profesores.ResumeLayout(false);
            this.Profesores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProfesores)).EndInit();
            this.Ranking.ResumeLayout(false);
            this.Ranking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRanking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SubMenuPanel;
        private System.Windows.Forms.Button LogOffButton;
        private System.Windows.Forms.RadioButton RankingButton;
        private System.Windows.Forms.RadioButton MisCalificacionesButton;
        private System.Windows.Forms.RadioButton SeleccionButton;
        private System.Windows.Forms.RadioButton MiCuentaButton;
        private System.Windows.Forms.Panel TopFillPanel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MiCuenta;
        private System.Windows.Forms.TabPage Estudiantes;
        private System.Windows.Forms.TabPage Asignaturas;
        private System.Windows.Forms.TabPage Ranking;
        private System.Windows.Forms.Button CloseSystem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton ProfesoresButton;
        private System.Windows.Forms.TabPage Profesores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView TablaEstudiantes;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label MiCuenta_TitleLabel;
        private System.Windows.Forms.Button NuevaAsignatura;
        private System.Windows.Forms.DataGridView TablaAsignaturas;
        private System.Windows.Forms.Button NuevoEstudiante;
        private System.Windows.Forms.Button NuevoProfesor;
        private System.Windows.Forms.DataGridView TablaProfesores;
        private System.Windows.Forms.DataGridView TablaRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Honor;
    }
}