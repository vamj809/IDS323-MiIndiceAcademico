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
            this.tabEstudiantes = new System.Windows.Forms.TabPage();
            this.tabAsignaturas = new System.Windows.Forms.TabPage();
            this.tabProfesores = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabsConsultas.SuspendLayout();
            this.tabCalificaciones.SuspendLayout();
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
            this.tabsConsultas.Size = new System.Drawing.Size(800, 450);
            this.tabsConsultas.TabIndex = 0;
            // 
            // tabCalificaciones
            // 
            this.tabCalificaciones.Controls.Add(this.comboBox1);
            this.tabCalificaciones.Location = new System.Drawing.Point(4, 25);
            this.tabCalificaciones.Name = "tabCalificaciones";
            this.tabCalificaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalificaciones.Size = new System.Drawing.Size(792, 421);
            this.tabCalificaciones.TabIndex = 0;
            this.tabCalificaciones.Text = "Calificaciones";
            this.tabCalificaciones.UseVisualStyleBackColor = true;
            // 
            // tabEstudiantes
            // 
            this.tabEstudiantes.Location = new System.Drawing.Point(4, 25);
            this.tabEstudiantes.Name = "tabEstudiantes";
            this.tabEstudiantes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstudiantes.Size = new System.Drawing.Size(792, 421);
            this.tabEstudiantes.TabIndex = 1;
            this.tabEstudiantes.Text = "Estudiantes";
            this.tabEstudiantes.UseVisualStyleBackColor = true;
            // 
            // tabAsignaturas
            // 
            this.tabAsignaturas.Location = new System.Drawing.Point(4, 25);
            this.tabAsignaturas.Name = "tabAsignaturas";
            this.tabAsignaturas.Size = new System.Drawing.Size(792, 421);
            this.tabAsignaturas.TabIndex = 2;
            this.tabAsignaturas.Text = "Asignaturas";
            this.tabAsignaturas.UseVisualStyleBackColor = true;
            // 
            // tabProfesores
            // 
            this.tabProfesores.Location = new System.Drawing.Point(4, 25);
            this.tabProfesores.Name = "tabProfesores";
            this.tabProfesores.Size = new System.Drawing.Size(792, 421);
            this.tabProfesores.TabIndex = 3;
            this.tabProfesores.Text = "Profesores";
            this.tabProfesores.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(32, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "jhvjhvj";
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabsConsultas);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.tabsConsultas.ResumeLayout(false);
            this.tabCalificaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsConsultas;
        private System.Windows.Forms.TabPage tabCalificaciones;
        private System.Windows.Forms.TabPage tabEstudiantes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabAsignaturas;
        private System.Windows.Forms.TabPage tabProfesores;
    }
}