namespace MIA_2020
{
    partial class NewScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.textAsignatura = new System.Windows.Forms.ComboBox();
            this.textEstudiante = new System.Windows.Forms.ComboBox();
            this.textNota = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.textNota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Asignatura:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(193, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nota:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(39, 23);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(258, 31);
            this.TitleLabel.TabIndex = 32;
            this.TitleLabel.Text = "Nueva Calificación";
            // 
            // textAsignatura
            // 
            this.textAsignatura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textAsignatura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.textAsignatura.FormattingEnabled = true;
            this.textAsignatura.Location = new System.Drawing.Point(112, 150);
            this.textAsignatura.Name = "textAsignatura";
            this.textAsignatura.Size = new System.Drawing.Size(200, 24);
            this.textAsignatura.TabIndex = 3;
            // 
            // textEstudiante
            // 
            this.textEstudiante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textEstudiante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.textEstudiante.FormattingEnabled = true;
            this.textEstudiante.Location = new System.Drawing.Point(112, 82);
            this.textEstudiante.Name = "textEstudiante";
            this.textEstudiante.Size = new System.Drawing.Size(200, 24);
            this.textEstudiante.TabIndex = 33;
            // 
            // textNota
            // 
            this.textNota.Location = new System.Drawing.Point(112, 214);
            this.textNota.Name = "textNota";
            this.textNota.Size = new System.Drawing.Size(200, 22);
            this.textNota.TabIndex = 4;
            // 
            // NewScore
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(348, 343);
            this.Controls.Add(this.textEstudiante);
            this.Controls.Add(this.textAsignatura);
            this.Controls.Add(this.textNota);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewScore";
            this.Text = "NewStudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewScore_FormClosing);
            this.Load += new System.EventHandler(this.NewScore_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewScore_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.textNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox textAsignatura;
        private System.Windows.Forms.ComboBox textEstudiante;
        private System.Windows.Forms.NumericUpDown textNota;
    }
}