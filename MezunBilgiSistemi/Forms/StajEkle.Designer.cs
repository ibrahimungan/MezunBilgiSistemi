namespace MezunBilgiSistemi.Forms
{
    partial class frmStajEkle
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
            this.txtStajDep = new System.Windows.Forms.TextBox();
            this.dateStajTarih = new System.Windows.Forms.DateTimePicker();
            this.lbStajDep = new System.Windows.Forms.Label();
            this.lbStajTarih = new System.Windows.Forms.Label();
            this.txtSirketAd = new System.Windows.Forms.TextBox();
            this.lbSirketAd = new System.Windows.Forms.Label();
            this.btnStajEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStajDep
            // 
            this.txtStajDep.Location = new System.Drawing.Point(192, 106);
            this.txtStajDep.Name = "txtStajDep";
            this.txtStajDep.Size = new System.Drawing.Size(200, 22);
            this.txtStajDep.TabIndex = 28;
            // 
            // dateStajTarih
            // 
            this.dateStajTarih.Location = new System.Drawing.Point(192, 70);
            this.dateStajTarih.Name = "dateStajTarih";
            this.dateStajTarih.Size = new System.Drawing.Size(200, 22);
            this.dateStajTarih.TabIndex = 27;
            // 
            // lbStajDep
            // 
            this.lbStajDep.AutoSize = true;
            this.lbStajDep.Location = new System.Drawing.Point(30, 109);
            this.lbStajDep.Name = "lbStajDep";
            this.lbStajDep.Size = new System.Drawing.Size(109, 17);
            this.lbStajDep.TabIndex = 26;
            this.lbStajDep.Text = "Staj Departmanı";
            // 
            // lbStajTarih
            // 
            this.lbStajTarih.AutoSize = true;
            this.lbStajTarih.Location = new System.Drawing.Point(31, 75);
            this.lbStajTarih.Name = "lbStajTarih";
            this.lbStajTarih.Size = new System.Drawing.Size(72, 17);
            this.lbStajTarih.TabIndex = 25;
            this.lbStajTarih.Text = "Staj Tarihi";
            // 
            // txtSirketAd
            // 
            this.txtSirketAd.Location = new System.Drawing.Point(192, 32);
            this.txtSirketAd.Name = "txtSirketAd";
            this.txtSirketAd.Size = new System.Drawing.Size(200, 22);
            this.txtSirketAd.TabIndex = 24;
            // 
            // lbSirketAd
            // 
            this.lbSirketAd.AutoSize = true;
            this.lbSirketAd.Location = new System.Drawing.Point(30, 37);
            this.lbSirketAd.Name = "lbSirketAd";
            this.lbSirketAd.Size = new System.Drawing.Size(68, 17);
            this.lbSirketAd.TabIndex = 23;
            this.lbSirketAd.Text = "Şirket Adı";
            // 
            // btnStajEkle
            // 
            this.btnStajEkle.Location = new System.Drawing.Point(192, 155);
            this.btnStajEkle.Name = "btnStajEkle";
            this.btnStajEkle.Size = new System.Drawing.Size(83, 46);
            this.btnStajEkle.TabIndex = 29;
            this.btnStajEkle.Text = "Ekle";
            this.btnStajEkle.UseVisualStyleBackColor = true;
            // 
            // frmStajEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 237);
            this.Controls.Add(this.btnStajEkle);
            this.Controls.Add(this.txtStajDep);
            this.Controls.Add(this.dateStajTarih);
            this.Controls.Add(this.lbStajDep);
            this.Controls.Add(this.lbStajTarih);
            this.Controls.Add(this.txtSirketAd);
            this.Controls.Add(this.lbSirketAd);
            this.Name = "frmStajEkle";
            this.Text = "StajEkle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StajEkle_FormClosed);
            this.Load += new System.EventHandler(this.StajEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStajDep;
        private System.Windows.Forms.DateTimePicker dateStajTarih;
        private System.Windows.Forms.Label lbStajDep;
        private System.Windows.Forms.Label lbStajTarih;
        private System.Windows.Forms.TextBox txtSirketAd;
        private System.Windows.Forms.Label lbSirketAd;
        private System.Windows.Forms.Button btnStajEkle;
    }
}