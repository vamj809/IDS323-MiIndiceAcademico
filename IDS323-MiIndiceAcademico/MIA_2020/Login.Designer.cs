namespace MIA_2020
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.StudentsButton = new System.Windows.Forms.RadioButton();
            this.TeachersButton = new System.Windows.Forms.RadioButton();
            this.AdminsButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GuestsButton = new System.Windows.Forms.RadioButton();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.LabelClave = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.GuestsAccessPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NewStudent = new System.Windows.Forms.Button();
            this.LogoMIA = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.GuestsAccessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMIA)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsButton
            // 
            this.StudentsButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.StudentsButton.AutoSize = true;
            this.StudentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StudentsButton.Checked = true;
            this.StudentsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.StudentsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.StudentsButton.FlatAppearance.BorderSize = 0;
            this.StudentsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.StudentsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StudentsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StudentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.StudentsButton.Location = new System.Drawing.Point(493, 0);
            this.StudentsButton.Margin = new System.Windows.Forms.Padding(4);
            this.StudentsButton.Name = "StudentsButton";
            this.StudentsButton.Size = new System.Drawing.Size(118, 80);
            this.StudentsButton.TabIndex = 5;
            this.StudentsButton.TabStop = true;
            this.StudentsButton.Text = "Estudiantes";
            this.toolTip.SetToolTip(this.StudentsButton, "Acceso para Estudiantes");
            this.StudentsButton.UseVisualStyleBackColor = false;
            this.StudentsButton.CheckedChanged += new System.EventHandler(this.StudentsButton_CheckedChanged);
            // 
            // TeachersButton
            // 
            this.TeachersButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.TeachersButton.AutoSize = true;
            this.TeachersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TeachersButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.TeachersButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TeachersButton.FlatAppearance.BorderSize = 0;
            this.TeachersButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.TeachersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TeachersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TeachersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeachersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.TeachersButton.Location = new System.Drawing.Point(611, 0);
            this.TeachersButton.Margin = new System.Windows.Forms.Padding(4);
            this.TeachersButton.Name = "TeachersButton";
            this.TeachersButton.Size = new System.Drawing.Size(121, 80);
            this.TeachersButton.TabIndex = 6;
            this.TeachersButton.Text = "Profesorado";
            this.toolTip.SetToolTip(this.TeachersButton, "Acceso para Profesores");
            this.TeachersButton.UseVisualStyleBackColor = false;
            // 
            // AdminsButton
            // 
            this.AdminsButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.AdminsButton.AutoSize = true;
            this.AdminsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdminsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AdminsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.AdminsButton.FlatAppearance.BorderSize = 0;
            this.AdminsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.AdminsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdminsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdminsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.AdminsButton.Location = new System.Drawing.Point(732, 0);
            this.AdminsButton.Margin = new System.Windows.Forms.Padding(4);
            this.AdminsButton.Name = "AdminsButton";
            this.AdminsButton.Size = new System.Drawing.Size(144, 80);
            this.AdminsButton.TabIndex = 7;
            this.AdminsButton.Text = "Administración";
            this.toolTip.SetToolTip(this.AdminsButton, "Administración");
            this.AdminsButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.GuestsButton);
            this.panel1.Controls.Add(this.StudentsButton);
            this.panel1.Controls.Add(this.TeachersButton);
            this.panel1.Controls.Add(this.AdminsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 80);
            this.panel1.TabIndex = 4;
            // 
            // GuestsButton
            // 
            this.GuestsButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.GuestsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GuestsButton.BackgroundImage = global::MIA_2020.Properties.Resources.User;
            this.GuestsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GuestsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.GuestsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.GuestsButton.FlatAppearance.BorderSize = 0;
            this.GuestsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.GuestsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GuestsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GuestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuestsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.GuestsButton.Location = new System.Drawing.Point(413, 0);
            this.GuestsButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuestsButton.Name = "GuestsButton";
            this.GuestsButton.Size = new System.Drawing.Size(80, 80);
            this.GuestsButton.TabIndex = 8;
            this.toolTip.SetToolTip(this.GuestsButton, "Invitados");
            this.GuestsButton.UseVisualStyleBackColor = false;
            this.GuestsButton.CheckedChanged += new System.EventHandler(this.GuestsButton_CheckedChanged);
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LabelUsuario.Location = new System.Drawing.Point(413, 191);
            this.LabelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(119, 20);
            this.LabelUsuario.TabIndex = 6;
            this.LabelUsuario.Text = "Usuario (ID):";
            // 
            // LabelClave
            // 
            this.LabelClave.AutoSize = true;
            this.LabelClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LabelClave.Location = new System.Drawing.Point(413, 246);
            this.LabelClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelClave.Name = "LabelClave";
            this.LabelClave.Size = new System.Drawing.Size(111, 20);
            this.LabelClave.TabIndex = 7;
            this.LabelClave.Text = "Contraseña:";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(557, 188);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(224, 26);
            this.UserTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(557, 243);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(224, 26);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ShowAlways = true;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(526, 130);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(181, 31);
            this.TitleLabel.TabIndex = 12;
            this.TitleLabel.Text = "Inicie Sesión";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(372, 328);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(204, 42);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "Ingresar (Enter)";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(626, 328);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(204, 42);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancelar (Esc)";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // GuestsAccessPanel
            // 
            this.GuestsAccessPanel.Controls.Add(this.label1);
            this.GuestsAccessPanel.Location = new System.Drawing.Point(372, 115);
            this.GuestsAccessPanel.Name = "GuestsAccessPanel";
            this.GuestsAccessPanel.Size = new System.Drawing.Size(1, 1);
            this.GuestsAccessPanel.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(148, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 62);
            this.label1.TabIndex = 13;
            this.label1.Text = "Acceso para\r\nInvitados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewStudent
            // 
            this.NewStudent.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NewStudent.FlatAppearance.BorderSize = 0;
            this.NewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStudent.Location = new System.Drawing.Point(492, 275);
            this.NewStudent.Name = "NewStudent";
            this.NewStudent.Size = new System.Drawing.Size(204, 26);
            this.NewStudent.TabIndex = 14;
            this.NewStudent.Text = "¿Crear nuevo estudiante?";
            this.NewStudent.UseVisualStyleBackColor = true;
            this.NewStudent.Click += new System.EventHandler(this.NewStudent_Click);
            // 
            // LogoMIA
            // 
            this.LogoMIA.BackColor = System.Drawing.Color.Azure;
            this.LogoMIA.Image = global::MIA_2020.Properties.Resources.OurLogo;
            this.LogoMIA.Location = new System.Drawing.Point(34, 115);
            this.LogoMIA.Margin = new System.Windows.Forms.Padding(4);
            this.LogoMIA.Name = "LogoMIA";
            this.LogoMIA.Size = new System.Drawing.Size(285, 255);
            this.LogoMIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoMIA.TabIndex = 5;
            this.LogoMIA.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(5, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "P";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(5, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "A";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(12, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 51);
            this.button3.TabIndex = 17;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(876, 403);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewStudent);
            this.Controls.Add(this.GuestsAccessPanel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.LabelClave);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.LogoMIA);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciando Sesión";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GuestsAccessPanel.ResumeLayout(false);
            this.GuestsAccessPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton StudentsButton;
        private System.Windows.Forms.RadioButton TeachersButton;
        private System.Windows.Forms.RadioButton AdminsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton GuestsButton;
        private System.Windows.Forms.PictureBox LogoMIA;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.Label LabelClave;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel GuestsAccessPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewStudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

