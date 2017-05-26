namespace MezunBilgiSistemi.Forms
{
    partial class frmKayit
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
            this.lbOgrBilgi = new System.Windows.Forms.Label();
            this.lbAd = new System.Windows.Forms.Label();
            this.lbAdres = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbEposta = new System.Windows.Forms.Label();
            this.lbDil = new System.Windows.Forms.Label();
            this.lbUyruk = new System.Windows.Forms.Label();
            this.lbDogumTarih = new System.Windows.Forms.Label();
            this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtUyruk = new System.Windows.Forms.TextBox();
            this.lbStajBilgi = new System.Windows.Forms.Label();
            this.cboxDil = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbOgrNo = new System.Windows.Forms.Label();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.btnOgrAra = new System.Windows.Forms.Button();
            this.btnOgrKaldir = new System.Windows.Forms.Button();
            this.lbBolAd = new System.Windows.Forms.Label();
            this.lbBaslangic = new System.Windows.Forms.Label();
            this.lbBitis = new System.Windows.Forms.Label();
            this.lbNotOrt = new System.Windows.Forms.Label();
            this.lbBasariBelgesi = new System.Windows.Forms.Label();
            this.chbBasari = new System.Windows.Forms.CheckBox();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.txtNotOrt = new System.Windows.Forms.TextBox();
            this.btnOgrEkle = new System.Windows.Forms.Button();
            this.btnOgrGuncelle = new System.Windows.Forms.Button();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.dataGridStaj = new System.Windows.Forms.DataGridView();
            this.btnStajEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaj)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOgrBilgi
            // 
            this.lbOgrBilgi.AutoSize = true;
            this.lbOgrBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbOgrBilgi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbOgrBilgi.Location = new System.Drawing.Point(175, 30);
            this.lbOgrBilgi.Name = "lbOgrBilgi";
            this.lbOgrBilgi.Size = new System.Drawing.Size(224, 20);
            this.lbOgrBilgi.TabIndex = 0;
            this.lbOgrBilgi.Text = "- - - Öğrenci Bilgileri - - -";
            // 
            // lbAd
            // 
            this.lbAd.AutoSize = true;
            this.lbAd.Location = new System.Drawing.Point(27, 85);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(69, 17);
            this.lbAd.TabIndex = 1;
            this.lbAd.Text = "Ad Soyad";
            // 
            // lbAdres
            // 
            this.lbAdres.AutoSize = true;
            this.lbAdres.Location = new System.Drawing.Point(27, 119);
            this.lbAdres.Name = "lbAdres";
            this.lbAdres.Size = new System.Drawing.Size(45, 17);
            this.lbAdres.TabIndex = 2;
            this.lbAdres.Text = "Adres";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(27, 245);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(56, 17);
            this.lbTel.TabIndex = 3;
            this.lbTel.Text = "Telefon";
            // 
            // lbEposta
            // 
            this.lbEposta.AutoSize = true;
            this.lbEposta.Location = new System.Drawing.Point(27, 285);
            this.lbEposta.Name = "lbEposta";
            this.lbEposta.Size = new System.Drawing.Size(66, 17);
            this.lbEposta.TabIndex = 4;
            this.lbEposta.Text = "E - Posta";
            // 
            // lbDil
            // 
            this.lbDil.AutoSize = true;
            this.lbDil.Location = new System.Drawing.Point(27, 323);
            this.lbDil.Name = "lbDil";
            this.lbDil.Size = new System.Drawing.Size(135, 17);
            this.lbDil.TabIndex = 5;
            this.lbDil.Text = "Yabancı Dil Seviyesi";
            // 
            // lbUyruk
            // 
            this.lbUyruk.AutoSize = true;
            this.lbUyruk.Location = new System.Drawing.Point(27, 361);
            this.lbUyruk.Name = "lbUyruk";
            this.lbUyruk.Size = new System.Drawing.Size(45, 17);
            this.lbUyruk.TabIndex = 6;
            this.lbUyruk.Text = "Uyruk";
            // 
            // lbDogumTarih
            // 
            this.lbDogumTarih.AutoSize = true;
            this.lbDogumTarih.Location = new System.Drawing.Point(27, 397);
            this.lbDogumTarih.Name = "lbDogumTarih";
            this.lbDogumTarih.Size = new System.Drawing.Size(93, 17);
            this.lbDogumTarih.TabIndex = 7;
            this.lbDogumTarih.Text = "Doğum Tarihi";
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.Location = new System.Drawing.Point(189, 397);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Size = new System.Drawing.Size(200, 22);
            this.dateDogumTarihi.TabIndex = 8;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(189, 80);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.TabIndex = 9;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(189, 119);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 107);
            this.txtAdres.TabIndex = 10;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(189, 240);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 22);
            this.txtTel.TabIndex = 11;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(189, 280);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(200, 22);
            this.txtEposta.TabIndex = 12;
            // 
            // txtUyruk
            // 
            this.txtUyruk.Location = new System.Drawing.Point(189, 356);
            this.txtUyruk.Name = "txtUyruk";
            this.txtUyruk.Size = new System.Drawing.Size(200, 22);
            this.txtUyruk.TabIndex = 14;
            // 
            // lbStajBilgi
            // 
            this.lbStajBilgi.AutoSize = true;
            this.lbStajBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbStajBilgi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbStajBilgi.Location = new System.Drawing.Point(185, 451);
            this.lbStajBilgi.Name = "lbStajBilgi";
            this.lbStajBilgi.Size = new System.Drawing.Size(191, 20);
            this.lbStajBilgi.TabIndex = 15;
            this.lbStajBilgi.Text = "- - - Staj Bilgileri - - -";
            // 
            // cboxDil
            // 
            this.cboxDil.FormattingEnabled = true;
            this.cboxDil.Items.AddRange(new object[] {
            "PreIntermediate",
            "Intermediate",
            "UpperIntermediate",
            "Advanced"});
            this.cboxDil.Location = new System.Drawing.Point(189, 316);
            this.cboxDil.Name = "cboxDil";
            this.cboxDil.Size = new System.Drawing.Size(200, 24);
            this.cboxDil.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(864, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "- - - Öğrenci Okul - - -";
            // 
            // lbOgrNo
            // 
            this.lbOgrNo.AutoSize = true;
            this.lbOgrNo.Location = new System.Drawing.Point(701, 85);
            this.lbOgrNo.Name = "lbOgrNo";
            this.lbOgrNo.Size = new System.Drawing.Size(80, 17);
            this.lbOgrNo.TabIndex = 25;
            this.lbOgrNo.Text = "Öğrenci No";
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(861, 80);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(200, 22);
            this.txtOgrNo.TabIndex = 26;
            // 
            // btnOgrAra
            // 
            this.btnOgrAra.Location = new System.Drawing.Point(861, 119);
            this.btnOgrAra.Name = "btnOgrAra";
            this.btnOgrAra.Size = new System.Drawing.Size(92, 36);
            this.btnOgrAra.TabIndex = 27;
            this.btnOgrAra.Text = "Öğrenci Ara";
            this.btnOgrAra.UseVisualStyleBackColor = true;
            // 
            // btnOgrKaldir
            // 
            this.btnOgrKaldir.Location = new System.Drawing.Point(959, 119);
            this.btnOgrKaldir.Name = "btnOgrKaldir";
            this.btnOgrKaldir.Size = new System.Drawing.Size(106, 36);
            this.btnOgrKaldir.TabIndex = 28;
            this.btnOgrKaldir.Text = "Öğrenci Kaldır";
            this.btnOgrKaldir.UseVisualStyleBackColor = true;
            // 
            // lbBolAd
            // 
            this.lbBolAd.AutoSize = true;
            this.lbBolAd.Location = new System.Drawing.Point(701, 245);
            this.lbBolAd.Name = "lbBolAd";
            this.lbBolAd.Size = new System.Drawing.Size(71, 17);
            this.lbBolAd.TabIndex = 29;
            this.lbBolAd.Text = "Bölüm Adı";
            // 
            // lbBaslangic
            // 
            this.lbBaslangic.AutoSize = true;
            this.lbBaslangic.Location = new System.Drawing.Point(701, 285);
            this.lbBaslangic.Name = "lbBaslangic";
            this.lbBaslangic.Size = new System.Drawing.Size(91, 17);
            this.lbBaslangic.TabIndex = 30;
            this.lbBaslangic.Text = "Başlangıç Yılı";
            // 
            // lbBitis
            // 
            this.lbBitis.AutoSize = true;
            this.lbBitis.Location = new System.Drawing.Point(701, 323);
            this.lbBitis.Name = "lbBitis";
            this.lbBitis.Size = new System.Drawing.Size(56, 17);
            this.lbBitis.TabIndex = 31;
            this.lbBitis.Text = "Bitiş Yılı";
            // 
            // lbNotOrt
            // 
            this.lbNotOrt.AutoSize = true;
            this.lbNotOrt.Location = new System.Drawing.Point(701, 361);
            this.lbNotOrt.Name = "lbNotOrt";
            this.lbNotOrt.Size = new System.Drawing.Size(102, 17);
            this.lbNotOrt.TabIndex = 32;
            this.lbNotOrt.Text = "Not Ortalaması";
            // 
            // lbBasariBelgesi
            // 
            this.lbBasariBelgesi.AutoSize = true;
            this.lbBasariBelgesi.Location = new System.Drawing.Point(701, 397);
            this.lbBasariBelgesi.Name = "lbBasariBelgesi";
            this.lbBasariBelgesi.Size = new System.Drawing.Size(98, 17);
            this.lbBasariBelgesi.TabIndex = 33;
            this.lbBasariBelgesi.Text = "Başarı Belgesi";
            // 
            // chbBasari
            // 
            this.chbBasari.AutoSize = true;
            this.chbBasari.Location = new System.Drawing.Point(861, 397);
            this.chbBasari.Name = "chbBasari";
            this.chbBasari.Size = new System.Drawing.Size(52, 21);
            this.chbBasari.TabIndex = 34;
            this.chbBasari.Text = "Var";
            this.chbBasari.UseVisualStyleBackColor = true;
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Location = new System.Drawing.Point(861, 240);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(200, 22);
            this.txtBolumAd.TabIndex = 35;
            // 
            // txtNotOrt
            // 
            this.txtNotOrt.Location = new System.Drawing.Point(861, 356);
            this.txtNotOrt.Name = "txtNotOrt";
            this.txtNotOrt.Size = new System.Drawing.Size(200, 22);
            this.txtNotOrt.TabIndex = 38;
            // 
            // btnOgrEkle
            // 
            this.btnOgrEkle.Location = new System.Drawing.Point(861, 451);
            this.btnOgrEkle.Name = "btnOgrEkle";
            this.btnOgrEkle.Size = new System.Drawing.Size(92, 44);
            this.btnOgrEkle.TabIndex = 39;
            this.btnOgrEkle.Text = "Öğrenci Ekle";
            this.btnOgrEkle.UseVisualStyleBackColor = true;
            // 
            // btnOgrGuncelle
            // 
            this.btnOgrGuncelle.Location = new System.Drawing.Point(973, 451);
            this.btnOgrGuncelle.Name = "btnOgrGuncelle";
            this.btnOgrGuncelle.Size = new System.Drawing.Size(92, 44);
            this.btnOgrGuncelle.TabIndex = 40;
            this.btnOgrGuncelle.Text = "Öğrenci Güncelle";
            this.btnOgrGuncelle.UseVisualStyleBackColor = true;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Location = new System.Drawing.Point(861, 280);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(200, 22);
            this.dateBaslangic.TabIndex = 41;
            // 
            // dateBitis
            // 
            this.dateBitis.Location = new System.Drawing.Point(861, 318);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(200, 22);
            this.dateBitis.TabIndex = 42;
            // 
            // dataGridStaj
            // 
            this.dataGridStaj.AllowUserToAddRows = false;
            this.dataGridStaj.AllowUserToDeleteRows = false;
            this.dataGridStaj.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridStaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStaj.Location = new System.Drawing.Point(30, 474);
            this.dataGridStaj.Name = "dataGridStaj";
            this.dataGridStaj.ReadOnly = true;
            this.dataGridStaj.RowTemplate.Height = 24;
            this.dataGridStaj.Size = new System.Drawing.Size(458, 119);
            this.dataGridStaj.TabIndex = 43;
            // 
            // btnStajEkle
            // 
            this.btnStajEkle.Location = new System.Drawing.Point(511, 474);
            this.btnStajEkle.Name = "btnStajEkle";
            this.btnStajEkle.Size = new System.Drawing.Size(101, 60);
            this.btnStajEkle.TabIndex = 44;
            this.btnStajEkle.Text = "Staj Ekle";
            this.btnStajEkle.UseVisualStyleBackColor = true;
            this.btnStajEkle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 665);
            this.Controls.Add(this.btnStajEkle);
            this.Controls.Add(this.dataGridStaj);
            this.Controls.Add(this.dateBitis);
            this.Controls.Add(this.dateBaslangic);
            this.Controls.Add(this.btnOgrGuncelle);
            this.Controls.Add(this.btnOgrEkle);
            this.Controls.Add(this.txtNotOrt);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.chbBasari);
            this.Controls.Add(this.lbBasariBelgesi);
            this.Controls.Add(this.lbNotOrt);
            this.Controls.Add(this.lbBitis);
            this.Controls.Add(this.lbBaslangic);
            this.Controls.Add(this.lbBolAd);
            this.Controls.Add(this.btnOgrKaldir);
            this.Controls.Add(this.btnOgrAra);
            this.Controls.Add(this.txtOgrNo);
            this.Controls.Add(this.lbOgrNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboxDil);
            this.Controls.Add(this.lbStajBilgi);
            this.Controls.Add(this.txtUyruk);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.dateDogumTarihi);
            this.Controls.Add(this.lbDogumTarih);
            this.Controls.Add(this.lbUyruk);
            this.Controls.Add(this.lbDil);
            this.Controls.Add(this.lbEposta);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.lbAdres);
            this.Controls.Add(this.lbAd);
            this.Controls.Add(this.lbOgrBilgi);
            this.Name = "frmKayit";
            this.Text = "Öğrenci Bilgileri";
            this.Load += new System.EventHandler(this.frmKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOgrBilgi;
        private System.Windows.Forms.Label lbAd;
        private System.Windows.Forms.Label lbAdres;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbEposta;
        private System.Windows.Forms.Label lbDil;
        private System.Windows.Forms.Label lbUyruk;
        private System.Windows.Forms.Label lbDogumTarih;
        private System.Windows.Forms.DateTimePicker dateDogumTarihi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtUyruk;
        private System.Windows.Forms.Label lbStajBilgi;
        private System.Windows.Forms.ComboBox cboxDil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbOgrNo;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.Button btnOgrAra;
        private System.Windows.Forms.Button btnOgrKaldir;
        private System.Windows.Forms.Label lbBolAd;
        private System.Windows.Forms.Label lbBaslangic;
        private System.Windows.Forms.Label lbBitis;
        private System.Windows.Forms.Label lbNotOrt;
        private System.Windows.Forms.Label lbBasariBelgesi;
        private System.Windows.Forms.CheckBox chbBasari;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.TextBox txtNotOrt;
        private System.Windows.Forms.Button btnOgrEkle;
        private System.Windows.Forms.Button btnOgrGuncelle;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.DataGridView dataGridStaj;
        private System.Windows.Forms.Button btnStajEkle;
    }
}