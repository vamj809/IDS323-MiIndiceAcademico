namespace MIA_2020.Menus
{
    partial class StudentsMenu
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
            this.CloseSystem = new System.Windows.Forms.Button();
            this.LogOffButton = new System.Windows.Forms.Button();
            this.RankingButton = new System.Windows.Forms.RadioButton();
            this.MisCalificacionesButton = new System.Windows.Forms.RadioButton();
            this.MiCuentaButton = new System.Windows.Forms.RadioButton();
            this.TopFillPanel = new System.Windows.Forms.Panel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MiCuenta = new System.Windows.Forms.TabPage();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.MiCuenta_TitleLabel = new System.Windows.Forms.Label();
            this.MisCalificaciones = new System.Windows.Forms.TabPage();
            this.TablaCalificaciones = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDeLaNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_por_VN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntosDeHonor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.C_GPA_Label = new System.Windows.Forms.Label();
            this.C_GPA_Value = new System.Windows.Forms.Label();
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
            this.MisCalificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCalificaciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.Ranking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // SubMenuPanel
            // 
            this.SubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SubMenuPanel.Controls.Add(this.CloseSystem);
            this.SubMenuPanel.Controls.Add(this.LogOffButton);
            this.SubMenuPanel.Controls.Add(this.RankingButton);
            this.SubMenuPanel.Controls.Add(this.MisCalificacionesButton);
            this.SubMenuPanel.Controls.Add(this.MiCuentaButton);
            this.SubMenuPanel.Controls.Add(this.TopFillPanel);
            this.SubMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SubMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SubMenuPanel.Name = "SubMenuPanel";
            this.SubMenuPanel.Size = new System.Drawing.Size(188, 513);
            this.SubMenuPanel.TabIndex = 0;
            // 
            // CloseSystem
            // 
            this.CloseSystem.Location = new System.Drawing.Point(3, 461);
            this.CloseSystem.Name = "CloseSystem";
            this.CloseSystem.Size = new System.Drawing.Size(182, 46);
            this.CloseSystem.TabIndex = 15;
            this.CloseSystem.Text = "Cerrar Sistema";
            this.CloseSystem.UseVisualStyleBackColor = true;
            this.CloseSystem.Click += new System.EventHandler(this.CloseSystem_Click);
            // 
            // LogOffButton
            // 
            this.LogOffButton.Location = new System.Drawing.Point(3, 410);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.Size = new System.Drawing.Size(182, 46);
            this.LogOffButton.TabIndex = 14;
            this.LogOffButton.Text = "Cerrar Sesión";
            this.LogOffButton.UseVisualStyleBackColor = true;
            this.LogOffButton.Click += new System.EventHandler(this.LogOffButton_Click);
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
            this.RankingButton.Location = new System.Drawing.Point(0, 283);
            this.RankingButton.Margin = new System.Windows.Forms.Padding(4);
            this.RankingButton.Name = "RankingButton";
            this.RankingButton.Size = new System.Drawing.Size(188, 60);
            this.RankingButton.TabIndex = 12;
            this.RankingButton.Text = "Ranking";
            this.RankingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RankingButton.UseVisualStyleBackColor = false;
            this.RankingButton.CheckedChanged += new System.EventHandler(this.RankingButton_CheckedChanged);
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
            this.MisCalificacionesButton.Location = new System.Drawing.Point(0, 223);
            this.MisCalificacionesButton.Margin = new System.Windows.Forms.Padding(4);
            this.MisCalificacionesButton.Name = "MisCalificacionesButton";
            this.MisCalificacionesButton.Size = new System.Drawing.Size(188, 60);
            this.MisCalificacionesButton.TabIndex = 11;
            this.MisCalificacionesButton.Text = "Mis Calificaciones";
            this.MisCalificacionesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MisCalificacionesButton.UseVisualStyleBackColor = false;
            this.MisCalificacionesButton.CheckedChanged += new System.EventHandler(this.MisCalificacionesButton_CheckedChanged);
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
            this.MiCuentaButton.Location = new System.Drawing.Point(0, 163);
            this.MiCuentaButton.Margin = new System.Windows.Forms.Padding(4);
            this.MiCuentaButton.Name = "MiCuentaButton";
            this.MiCuentaButton.Size = new System.Drawing.Size(188, 60);
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
            this.TopFillPanel.Name = "TopFillPanel";
            this.TopFillPanel.Size = new System.Drawing.Size(188, 163);
            this.TopFillPanel.TabIndex = 13;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.MiCuenta);
            this.TabControl.Controls.Add(this.MisCalificaciones);
            this.TabControl.Controls.Add(this.Ranking);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ItemSize = new System.Drawing.Size(120, 21);
            this.TabControl.Location = new System.Drawing.Point(188, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(950, 513);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 3;
            // 
            // MiCuenta
            // 
            this.MiCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MiCuenta.Controls.Add(this.InfoLabel);
            this.MiCuenta.Controls.Add(this.MiCuenta_TitleLabel);
            this.MiCuenta.Location = new System.Drawing.Point(4, 25);
            this.MiCuenta.Name = "MiCuenta";
            this.MiCuenta.Padding = new System.Windows.Forms.Padding(3);
            this.MiCuenta.Size = new System.Drawing.Size(942, 484);
            this.MiCuenta.TabIndex = 0;
            this.MiCuenta.Text = "Mi Cuenta";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoEllipsis = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InfoLabel.Location = new System.Drawing.Point(134, 156);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(431, 251);
            this.InfoLabel.TabIndex = 14;
            this.InfoLabel.Text = "ID:\r\nasdf\r\n\r\nNombre:\r\nasdf\r\n\r\nCarrera:\r\nasda";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MiCuenta_TitleLabel
            // 
            this.MiCuenta_TitleLabel.AutoSize = true;
            this.MiCuenta_TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.MiCuenta_TitleLabel.Location = new System.Drawing.Point(276, 80);
            this.MiCuenta_TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MiCuenta_TitleLabel.Name = "MiCuenta_TitleLabel";
            this.MiCuenta_TitleLabel.Size = new System.Drawing.Size(146, 31);
            this.MiCuenta_TitleLabel.TabIndex = 13;
            this.MiCuenta_TitleLabel.Text = "Mi Cuenta";
            // 
            // MisCalificaciones
            // 
            this.MisCalificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MisCalificaciones.Controls.Add(this.TablaCalificaciones);
            this.MisCalificaciones.Controls.Add(this.label2);
            this.MisCalificaciones.Controls.Add(this.panel1);
            this.MisCalificaciones.Location = new System.Drawing.Point(4, 25);
            this.MisCalificaciones.Name = "MisCalificaciones";
            this.MisCalificaciones.Size = new System.Drawing.Size(942, 484);
            this.MisCalificaciones.TabIndex = 2;
            this.MisCalificaciones.Text = "Calificaciones";
            // 
            // TablaCalificaciones
            // 
            this.TablaCalificaciones.AllowUserToAddRows = false;
            this.TablaCalificaciones.AllowUserToDeleteRows = false;
            this.TablaCalificaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaCalificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Asignatura,
            this.Creditos,
            this.Nota,
            this.ValorDeLaNota,
            this.C_por_VN,
            this.PuntosDeHonor});
            this.TablaCalificaciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TablaCalificaciones.Location = new System.Drawing.Point(0, 73);
            this.TablaCalificaciones.Name = "TablaCalificaciones";
            this.TablaCalificaciones.ReadOnly = true;
            this.TablaCalificaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TablaCalificaciones.RowHeadersWidth = 20;
            this.TablaCalificaciones.RowTemplate.Height = 24;
            this.TablaCalificaciones.Size = new System.Drawing.Size(942, 363);
            this.TablaCalificaciones.TabIndex = 19;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(337, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Calificaciones";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.C_GPA_Label);
            this.panel1.Controls.Add(this.C_GPA_Value);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 48);
            this.panel1.TabIndex = 18;
            // 
            // C_GPA_Label
            // 
            this.C_GPA_Label.AutoSize = true;
            this.C_GPA_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_GPA_Label.Location = new System.Drawing.Point(332, 15);
            this.C_GPA_Label.Name = "C_GPA_Label";
            this.C_GPA_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C_GPA_Label.Size = new System.Drawing.Size(202, 17);
            this.C_GPA_Label.TabIndex = 5;
            this.C_GPA_Label.Text = "Índice Académico General:";
            // 
            // C_GPA_Value
            // 
            this.C_GPA_Value.AutoSize = true;
            this.C_GPA_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_GPA_Value.Location = new System.Drawing.Point(555, 15);
            this.C_GPA_Value.Name = "C_GPA_Value";
            this.C_GPA_Value.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C_GPA_Value.Size = new System.Drawing.Size(13, 17);
            this.C_GPA_Value.TabIndex = 6;
            this.C_GPA_Value.Text = "-";
            // 
            // Ranking
            // 
            this.Ranking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ranking.Controls.Add(this.TablaRanking);
            this.Ranking.Controls.Add(this.label3);
            this.Ranking.Location = new System.Drawing.Point(4, 25);
            this.Ranking.Name = "Ranking";
            this.Ranking.Size = new System.Drawing.Size(942, 484);
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
            this.TablaRanking.Location = new System.Drawing.Point(0, 67);
            this.TablaRanking.Name = "TablaRanking";
            this.TablaRanking.ReadOnly = true;
            this.TablaRanking.RowHeadersWidth = 51;
            this.TablaRanking.RowTemplate.Height = 24;
            this.TablaRanking.Size = new System.Drawing.Size(942, 417);
            this.TablaRanking.TabIndex = 21;
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
            this.label3.Location = new System.Drawing.Point(367, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ranking";
            // 
            // StudentsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1138, 513);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.SubMenuPanel);
            this.Name = "StudentsMenu";
            this.Text = "Menu de los Estudiantes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentsMenu_FormClosing);
            this.Load += new System.EventHandler(this.StudentsMenu_Load);
            this.SubMenuPanel.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.MiCuenta.ResumeLayout(false);
            this.MiCuenta.PerformLayout();
            this.MisCalificaciones.ResumeLayout(false);
            this.MisCalificaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCalificaciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.RadioButton MiCuentaButton;
        private System.Windows.Forms.Panel TopFillPanel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MiCuenta;
        private System.Windows.Forms.TabPage MisCalificaciones;
        private System.Windows.Forms.TabPage Ranking;
        private System.Windows.Forms.Button CloseSystem;
        private System.Windows.Forms.Label MiCuenta_TitleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label C_GPA_Label;
        private System.Windows.Forms.Label C_GPA_Value;
        private System.Windows.Forms.DataGridView TablaCalificaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDeLaNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_por_VN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntosDeHonor;
        private System.Windows.Forms.DataGridView TablaRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Honor;
    }
}