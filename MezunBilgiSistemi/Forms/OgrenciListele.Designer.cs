namespace MezunBilgiSistemi.Forms
{
    partial class frmOgrenciList
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
            this.dataGridOgrList = new System.Windows.Forms.DataGridView();
            this.ogrenciNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbBolum = new System.Windows.Forms.Label();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.btnOgrList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOgrList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOgrList
            // 
            this.dataGridOgrList.AllowUserToAddRows = false;
            this.dataGridOgrList.AllowUserToDeleteRows = false;
            this.dataGridOgrList.AllowUserToOrderColumns = true;
            this.dataGridOgrList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridOgrList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOgrList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciNo,
            this.ogrenciBolum,
            this.ogrenciAdi,
            this.ogrenciOrt});
            this.dataGridOgrList.Location = new System.Drawing.Point(21, 34);
            this.dataGridOgrList.Name = "dataGridOgrList";
            this.dataGridOgrList.ReadOnly = true;
            this.dataGridOgrList.RowTemplate.Height = 24;
            this.dataGridOgrList.Size = new System.Drawing.Size(551, 406);
            this.dataGridOgrList.TabIndex = 0;
            // 
            // ogrenciNo
            // 
            this.ogrenciNo.HeaderText = "Öğrenci No";
            this.ogrenciNo.Name = "ogrenciNo";
            this.ogrenciNo.ReadOnly = true;
            // 
            // ogrenciBolum
            // 
            this.ogrenciBolum.HeaderText = "Bölümü";
            this.ogrenciBolum.Name = "ogrenciBolum";
            this.ogrenciBolum.ReadOnly = true;
            // 
            // ogrenciAdi
            // 
            this.ogrenciAdi.HeaderText = "Öğrenci Adı";
            this.ogrenciAdi.Name = "ogrenciAdi";
            this.ogrenciAdi.ReadOnly = true;
            // 
            // ogrenciOrt
            // 
            this.ogrenciOrt.HeaderText = "Not Ortalaması";
            this.ogrenciOrt.Name = "ogrenciOrt";
            this.ogrenciOrt.ReadOnly = true;
            // 
            // lbBolum
            // 
            this.lbBolum.AutoSize = true;
            this.lbBolum.Location = new System.Drawing.Point(647, 56);
            this.lbBolum.Name = "lbBolum";
            this.lbBolum.Size = new System.Drawing.Size(47, 17);
            this.lbBolum.TabIndex = 2;
            this.lbBolum.Text = "Bölüm";
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(742, 53);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(173, 22);
            this.txtBolum.TabIndex = 3;
            // 
            // btnOgrList
            // 
            this.btnOgrList.Location = new System.Drawing.Point(810, 106);
            this.btnOgrList.Name = "btnOgrList";
            this.btnOgrList.Size = new System.Drawing.Size(105, 46);
            this.btnOgrList.TabIndex = 4;
            this.btnOgrList.Text = "Öğrenci Listesi";
            this.btnOgrList.UseVisualStyleBackColor = true;
            // 
            // frmOgrenciList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 617);
            this.Controls.Add(this.btnOgrList);
            this.Controls.Add(this.txtBolum);
            this.Controls.Add(this.lbBolum);
            this.Controls.Add(this.dataGridOgrList);
            this.Name = "frmOgrenciList";
            this.Text = "Öğrenci Listele";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOgrList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOgrList;
        private System.Windows.Forms.Label lbBolum;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Button btnOgrList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciBolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciOrt;
    }
}