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
            this.btnAgacDerinligi = new System.Windows.Forms.Button();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMezunGiris
            // 
            this.btnMezunGiris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMezunGiris.Location = new System.Drawing.Point(45, 76);
            this.btnMezunGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMezunGiris.Name = "btnMezunGiris";
            this.btnMezunGiris.Size = new System.Drawing.Size(195, 33);
            this.btnMezunGiris.TabIndex = 0;
            this.btnMezunGiris.Text = "İş Arayan Bir Öğrenciyim";
            this.btnMezunGiris.UseVisualStyleBackColor = true;
            this.btnMezunGiris.Click += new System.EventHandler(this.btnMezunGiris_Click);
            // 
            // btnSirketGiris
            // 
            this.btnSirketGiris.Location = new System.Drawing.Point(305, 76);
            this.btnSirketGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSirketGiris.Name = "btnSirketGiris";
            this.btnSirketGiris.Size = new System.Drawing.Size(195, 33);
            this.btnSirketGiris.TabIndex = 1;
            this.btnSirketGiris.Text = "Eleman Arayan Bir Şirketim";
            this.btnSirketGiris.UseVisualStyleBackColor = true;
            this.btnSirketGiris.Click += new System.EventHandler(this.btnSirketGiris_Click);
            // 
            // btnAgacDerinligi
            // 
            this.btnAgacDerinligi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgacDerinligi.Location = new System.Drawing.Point(4, 17);
            this.btnAgacDerinligi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgacDerinligi.Name = "btnAgacDerinligi";
            this.btnAgacDerinligi.Size = new System.Drawing.Size(178, 33);
            this.btnAgacDerinligi.TabIndex = 2;
            this.btnAgacDerinligi.Text = "Ağacın Derinliği";
            this.btnAgacDerinligi.UseVisualStyleBackColor = true;
            this.btnAgacDerinligi.Click += new System.EventHandler(this.btnAgacDerinligi_Click);
            // 
            // btnInOrder
            // 
            this.btnInOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInOrder.Location = new System.Drawing.Point(265, 17);
            this.btnInOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(178, 33);
            this.btnInOrder.TabIndex = 3;
            this.btnInOrder.Text = "InOrder";
            this.btnInOrder.UseVisualStyleBackColor = true;
            this.btnInOrder.Click += new System.EventHandler(this.btnInOrder_Click);
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPreOrder.Location = new System.Drawing.Point(4, 70);
            this.btnPreOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(178, 33);
            this.btnPreOrder.TabIndex = 4;
            this.btnPreOrder.Text = "PreOrder";
            this.btnPreOrder.UseVisualStyleBackColor = true;
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPostOrder.Location = new System.Drawing.Point(265, 70);
            this.btnPostOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(178, 33);
            this.btnPostOrder.TabIndex = 5;
            this.btnPostOrder.Text = "PostOrder";
            this.btnPostOrder.UseVisualStyleBackColor = true;
            this.btnPostOrder.Click += new System.EventHandler(this.btnPostOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgacDerinligi);
            this.groupBox1.Controls.Add(this.btnPostOrder);
            this.groupBox1.Controls.Add(this.btnInOrder);
            this.groupBox1.Controls.Add(this.btnPreOrder);
            this.groupBox1.Location = new System.Drawing.Point(45, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(455, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ağaç İşlemleri";
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSirketGiris);
            this.Controls.Add(this.btnMezunGiris);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGiris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMezunGiris;
        private System.Windows.Forms.Button btnSirketGiris;
        private System.Windows.Forms.Button btnAgacDerinligi;
        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.Button btnPostOrder;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}