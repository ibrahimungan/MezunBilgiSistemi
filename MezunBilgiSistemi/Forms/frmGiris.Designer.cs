namespace MezunBilgiSistemi.Forms
{
    partial class frmGiris
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
            if (disposing && (components != null))
            {
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
            this.btnMezunGiris = new System.Windows.Forms.Button();
            this.btnSirketGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMezunGiris
            // 
            this.btnMezunGiris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMezunGiris.Location = new System.Drawing.Point(60, 94);
            this.btnMezunGiris.Name = "btnMezunGiris";
            this.btnMezunGiris.Size = new System.Drawing.Size(260, 41);
            this.btnMezunGiris.TabIndex = 0;
            this.btnMezunGiris.Text = "İş Arayan Bir Öğrenciyim";
            this.btnMezunGiris.UseVisualStyleBackColor = true;
            this.btnMezunGiris.Click += new System.EventHandler(this.btnMezunGiris_Click);
            // 
            // btnSirketGiris
            // 
            this.btnSirketGiris.Location = new System.Drawing.Point(407, 94);
            this.btnSirketGiris.Name = "btnSirketGiris";
            this.btnSirketGiris.Size = new System.Drawing.Size(260, 41);
            this.btnSirketGiris.TabIndex = 1;
            this.btnSirketGiris.Text = "Eleman Arayan Bir Şirketim";
            this.btnSirketGiris.UseVisualStyleBackColor = true;
            this.btnSirketGiris.Click += new System.EventHandler(this.btnSirketGiris_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 212);
            this.Controls.Add(this.btnSirketGiris);
            this.Controls.Add(this.btnMezunGiris);
            this.Name = "frmGiris";
            this.Text = "frmGiris";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMezunGiris;
        private System.Windows.Forms.Button btnSirketGiris;
    }
}