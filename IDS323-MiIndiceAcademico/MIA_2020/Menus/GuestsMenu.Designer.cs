namespace MIA_2020.Menus
{
    partial class GuestsMenu
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
            this.label3 = new System.Windows.Forms.Label();
            this.SubMenuPanel = new System.Windows.Forms.Panel();
            this.CloseSystem = new System.Windows.Forms.Button();
            this.LogOffButton = new System.Windows.Forms.Button();
            this.TopFillPanel = new System.Windows.Forms.Panel();
            this.TablaRanking = new System.Windows.Forms.DataGridView();
            this.ID_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Honor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(479, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ranking";
            // 
            // SubMenuPanel
            // 
            this.SubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SubMenuPanel.Controls.Add(this.CloseSystem);
            this.SubMenuPanel.Controls.Add(this.LogOffButton);
            this.SubMenuPanel.Controls.Add(this.TopFillPanel);
            this.SubMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SubMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SubMenuPanel.Name = "SubMenuPanel";
            this.SubMenuPanel.Size = new System.Drawing.Size(188, 456);
            this.SubMenuPanel.TabIndex = 18;
            // 
            // CloseSystem
            // 
            this.CloseSystem.Location = new System.Drawing.Point(3, 396);
            this.CloseSystem.Name = "CloseSystem";
            this.CloseSystem.Size = new System.Drawing.Size(182, 46);
            this.CloseSystem.TabIndex = 15;
            this.CloseSystem.Text = "Cerrar Sistema";
            this.CloseSystem.UseVisualStyleBackColor = true;
            this.CloseSystem.Click += new System.EventHandler(this.CloseSystem_Click);
            // 
            // LogOffButton
            // 
            this.LogOffButton.Location = new System.Drawing.Point(3, 344);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.Size = new System.Drawing.Size(182, 46);
            this.LogOffButton.TabIndex = 14;
            this.LogOffButton.Text = "Volver al Menú";
            this.LogOffButton.UseVisualStyleBackColor = true;
            this.LogOffButton.Click += new System.EventHandler(this.LogOffButton_Click);
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
            this.TablaRanking.Location = new System.Drawing.Point(188, 62);
            this.TablaRanking.Name = "TablaRanking";
            this.TablaRanking.ReadOnly = true;
            this.TablaRanking.RowHeadersWidth = 51;
            this.TablaRanking.RowTemplate.Height = 24;
            this.TablaRanking.Size = new System.Drawing.Size(710, 394);
            this.TablaRanking.TabIndex = 19;
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
            // GuestsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(898, 456);
            this.Controls.Add(this.TablaRanking);
            this.Controls.Add(this.SubMenuPanel);
            this.Controls.Add(this.label3);
            this.Name = "GuestsMenu";
            this.Text = "Menú de Invitados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuestsMenu_FormClosing);
            this.Load += new System.EventHandler(this.GuestsMenu_Load);
            this.SubMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel SubMenuPanel;
        private System.Windows.Forms.Button CloseSystem;
        private System.Windows.Forms.Button LogOffButton;
        private System.Windows.Forms.Panel TopFillPanel;
        private System.Windows.Forms.DataGridView TablaRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Honor;
    }
}