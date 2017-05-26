namespace MezunBilgiSistemi.Forms
{
    partial class frmAgacIslemleri
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
            this.txtAgac = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAgac
            // 
            this.txtAgac.Location = new System.Drawing.Point(13, 13);
            this.txtAgac.Multiline = true;
            this.txtAgac.Name = "txtAgac";
            this.txtAgac.Size = new System.Drawing.Size(804, 312);
            this.txtAgac.TabIndex = 0;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(702, 331);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(115, 39);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "Geri Dön";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // frmAgacIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 382);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.txtAgac);
            this.Name = "frmAgacIslemleri";
            this.Text = "frmAgacIslemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAgacIslemleri_FormClosed);
            this.Load += new System.EventHandler(this.frmAgacIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAgac;
        private System.Windows.Forms.Button btnIptal;
    }
}