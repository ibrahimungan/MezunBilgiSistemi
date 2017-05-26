using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MezunBilgiSistemi.BusinessLayer;

namespace MezunBilgiSistemi.Forms
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnMezunGiris_Click(object sender, EventArgs e)
        {
            frmKayit fk = new frmKayit();
            fk.Show();
            Hide();
        }

        private void btnSirketGiris_Click(object sender, EventArgs e)
        {
            frmOgrenciList fl = new frmOgrenciList();
            fl.Show();
            Hide();
        }

        private void btnAgacDerinligi_Click(object sender, EventArgs e)
        {
            int derinlik = BL.binaryMezunlar.Derinlik(BL.binaryMezunlar.kok);
            string s = "Ağacın derinliği: " + derinlik.ToString();

            frmAgacIslemleri fa = new frmAgacIslemleri(s = "Ağacın derinliği: " + 2);
            fa.Show();
            Hide();
        }
        private void btnInOrder_Click(object sender, EventArgs e)
        {
            BL.binaryMezunlar.InOrder();
            string inorder = BL.binaryMezunlar.dugumler;
            frmAgacIslemleri frm = new frmAgacIslemleri(inorder);
            this.Hide();
            frm.Show();

        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            BL.olustur();
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            BL.binaryMezunlar.PreOrder();
            string preorder = BL.binaryMezunlar.dugumler;
            frmAgacIslemleri frm = new frmAgacIslemleri(preorder);
            this.Hide();
            frm.Show();
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            BL.binaryMezunlar.PostOrder();
            string postorder = BL.binaryMezunlar.dugumler;
            frmAgacIslemleri frm = new frmAgacIslemleri(postorder);
            this.Hide();
            frm.Show();
        }
    }
}
