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
            this.btn90Ustu = new System.Windows.Forms.Button();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn90Ustu
            // 
            this.btn90Ustu.Location = new System.Drawing.Point(647, 12);
            this.btn90Ustu.Name = "btn90Ustu";
            this.btn90Ustu.Size = new System.Drawing.Size(173, 46);
            this.btn90Ustu.TabIndex = 5;
            this.btn90Ustu.Text = "Ortalaması 90 Üstü";
            this.btn90Ustu.UseVisualStyleBackColor = true;
            this.btn90Ustu.Click += new System.EventHandler(this.btn90Ustu_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(647, 64);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(173, 46);
            this.btnAdvanced.TabIndex = 6;
            this.btnAdvanced.Text = "İngilizcesi Advanced";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(629, 305);
            this.textBox1.TabIndex = 7;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(647, 271);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(173, 46);
            this.btnGeriDon.TabIndex = 8;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // frmOgrenciList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 329);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.btn90Ustu);
            this.Name = "frmOgrenciList";
            this.Text = "Öğrenci Listele";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOgrenciList_FormClosed);
            this.Load += new System.EventHandler(this.frmOgrenciList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn90Ustu;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGeriDon;
    }
}