namespace MiIndiceAcademico_F1
{
    partial class LogIn
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
            this.userLabel = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.userTXT = new System.Windows.Forms.TextBox();
            this.pwdTXT = new System.Windows.Forms.TextBox();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(25, 73);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(61, 17);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Usuario:";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 207);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(119, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "Iniciar Sesión";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(221, 207);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // userTXT
            // 
            this.userTXT.Location = new System.Drawing.Point(102, 70);
            this.userTXT.Name = "userTXT";
            this.userTXT.Size = new System.Drawing.Size(179, 22);
            this.userTXT.TabIndex = 3;
            this.userTXT.Text = "admin";
            // 
            // pwdTXT
            // 
            this.pwdTXT.Location = new System.Drawing.Point(102, 125);
            this.pwdTXT.Name = "pwdTXT";
            this.pwdTXT.Size = new System.Drawing.Size(179, 22);
            this.pwdTXT.TabIndex = 5;
            this.pwdTXT.Text = "admin";
            this.pwdTXT.UseSystemPasswordChar = true;
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Location = new System.Drawing.Point(25, 128);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(47, 17);
            this.pwdLabel.TabIndex = 4;
            this.pwdLabel.Text = "Clave:";
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hintLabel.Location = new System.Drawing.Point(123, 150);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(88, 17);
            this.hintLabel.TabIndex = 6;
            this.hintLabel.Text = "admin/admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inicio de Sesión";
            // 
            // LogIn
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(326, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.pwdTXT);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.userTXT);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.userLabel);
            this.Name = "LogIn";
            this.Text = "Inicio de Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox userTXT;
        private System.Windows.Forms.TextBox pwdTXT;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Label label1;
    }
}