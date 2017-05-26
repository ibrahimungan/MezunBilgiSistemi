using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            frmAgacIslemleri fa = new frmAgacIslemleri();
            fa.Show();
            Hide();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            BusinessLayer.BL.olustur();
        }
    }
}
