namespace MIA_2020.Resources
{
    partial class SplashScreen
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
            this.loadAndCloseTimer = new System.Windows.Forms.Timer(this.components);
            this.SkipLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadAndCloseTimer
            // 
            this.loadAndCloseTimer.Enabled = true;
            this.loadAndCloseTimer.Tick += new System.EventHandler(this.loadAndCloseTimer_Tick);
            // 
            // SkipLabel
            // 
            this.SkipLabel.AutoSize = true;
            this.SkipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkipLabel.Location = new System.Drawing.Point(555, 370);
            this.SkipLabel.Name = "SkipLabel";
            this.SkipLabel.Size = new System.Drawing.Size(250, 20);
            this.SkipLabel.TabIndex = 0;
            this.SkipLabel.Text = "Presione \'ESC\' para Saltar...";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIA_2020.Properties.Resources.OurLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(853, 399);
            this.Controls.Add(this.SkipLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SplashScreen_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SplashScreen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer loadAndCloseTimer;
        private System.Windows.Forms.Label SkipLabel;
    }
}