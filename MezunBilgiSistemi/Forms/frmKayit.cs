using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MezunBilgiSistemi.Models;

namespace MezunBilgiSistemi.Forms
{
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
            BusinessLayer.BL.createFakeJSON();
            var a = BusinessLayer.BL.DeserializeFromFile(@"../../mezunListesi.txt");
        }

        public static DataTable staj = new DataTable();

        private void frmKayit_Load(object sender, EventArgs e)
        {
            dataGridStaj.DataSource = staj;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmStajEkle se = new frmStajEkle();
            se.Show();
            this.Hide();
        }

        private void frmKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[Application.OpenForms.Count - 1].Show();
        }

        private void btnOgrGuncelle_Click(object sender, EventArgs e)
        {
            frmOgrenciGuncelle og = new frmOgrenciGuncelle();
            og.Show();
            Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Mezun m = new Mezun();
            m.Ad = txtAd.Text;
            m.Adres = txtAdres.Text;
            m.BolumBilgileri.Last.Value.BaslangicYili = Convert.ToInt32(txtBaslangicYili.Text);
            m.BolumBilgileri.Last.Value.BitisYili = Convert.ToInt32(txtBitisYili.Text);
            m.BolumBilgileri.Last.Value.BolumAdi= txtBolumAd.Text;
            m.BolumBilgileri.Last.Value.NotOrtalamasi = Convert.ToInt32(txtNotOrt.Text);
            m.BolumBilgileri.Last.Value.BasariBelgesiAlmisMi = chbBasari.Checked;
            m.DogumTarihi = dateDogumTarihi.Value.Date;
            m.ePosta = txtEposta.Text;
            //m.IlgiAlanları = 
            m.OgrenciNo = Convert.ToInt64(txtOgrNo.Text);
            //m.StajBilgileri.Last.Value.SirketAdi 
            m.Telefon = txtTel.Text;
            m.Uyruk = txtUyruk.Text;
            //m.YabanciDil = cboxDil.Text;
        }
    }
}
