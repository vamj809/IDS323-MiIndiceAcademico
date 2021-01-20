namespace MIA_2020
{
    partial class NewSubject
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
            this.textClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.textCreditos = new System.Windows.Forms.NumericUpDown();
            this.textProfesor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.textCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave:";
            // 
            // textClave
            // 
            this.textClave.Location = new System.Drawing.Point(84, 58);
            this.textClave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textClave.Name = "textClave";
            this.textClave.Size = new System.Drawing.Size(151, 20);
            this.textClave.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(145, 232);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(84, 99);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(151, 20);
            this.textNombre.TabIndex = 2;
            this.textNombre.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Creditos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Profesor:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(38, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(126, 26);
            this.TitleLabel.TabIndex = 32;
            this.TitleLabel.Text = "Asignatura";
            // 
            // textCreditos
            // 
            this.textCreditos.Location = new System.Drawing.Point(84, 181);
            this.textCreditos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCreditos.Name = "textCreditos";
            this.textCreditos.Size = new System.Drawing.Size(150, 20);
            this.textCreditos.TabIndex = 4;
            // 
            // textProfesor
            // 
            this.textProfesor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textProfesor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.textProfesor.FormattingEnabled = true;
            this.textProfesor.Location = new System.Drawing.Point(84, 142);
            this.textProfesor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textProfesor.Name = "textProfesor";
            this.textProfesor.Size = new System.Drawing.Size(151, 21);
            this.textProfesor.TabIndex = 3;
            this.textProfesor.SelectedIndexChanged += new System.EventHandler(this.textProfesor_SelectedIndexChanged);
            // 
            // NewSubject
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(261, 279);
            this.ControlBox = false;
            this.Controls.Add(this.textProfesor);
            this.Controls.Add(this.textCreditos);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textClave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewSubject";
            this.Text = "Nueva Asignatura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewSubject_FormClosing);
            this.Load += new System.EventHandler(this.NewSubject_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewSubject_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.textCreditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.NumericUpDown textCreditos;
        private System.Windows.Forms.ComboBox textProfesor;
    }
}