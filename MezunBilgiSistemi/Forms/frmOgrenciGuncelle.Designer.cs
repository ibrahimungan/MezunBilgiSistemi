namespace MezunBilgiSistemi.Forms
{
    partial class frmOgrenciGuncelle
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
            this.btnOgrAra = new System.Windows.Forms.Button();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.lbOgrNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOgrAra
            // 
            this.btnOgrAra.Location = new System.Drawing.Point(185, 83);
            this.btnOgrAra.Name = "btnOgrAra";
            this.btnOgrAra.Size = new System.Drawing.Size(200, 27);
            this.btnOgrAra.TabIndex = 31;
            this.btnOgrAra.Text = "Öğrenci Ara";
            this.btnOgrAra.UseVisualStyleBackColor = true;
            this.btnOgrAra.Click += new System.EventHandler(this.btnOgrAra_Click);
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(185, 44);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(200, 22);
            this.txtOgrNo.TabIndex = 30;
            // 
            // lbOgrNo
            // 
            this.lbOgrNo.AutoSize = true;
            this.lbOgrNo.Location = new System.Drawing.Point(25, 49);
            this.lbOgrNo.Name = "lbOgrNo";
            this.lbOgrNo.Size = new System.Drawing.Size(80, 17);
            this.lbOgrNo.TabIndex = 29;
            this.lbOgrNo.Text = "Öğrenci No";
            // 
            // frmOgrenciGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 182);
            this.Controls.Add(this.btnOgrAra);
            this.Controls.Add(this.txtOgrNo);
            this.Controls.Add(this.lbOgrNo);
            this.Name = "frmOgrenciGuncelle";
            this.Text = "frmOgrenciGuncelle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOgrenciGuncelle_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOgrAra;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.Label lbOgrNo;
    }
}