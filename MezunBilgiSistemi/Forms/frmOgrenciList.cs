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
    public partial class frmOgrenciList : Form
    {
        public frmOgrenciList()
        {
            InitializeComponent();
        }

        public frmOgrenciList(string str)
        {
            InitializeComponent();
            textBox1.Text = str;
        }

        private void btnOgrList_Click(object sender, EventArgs e)
        {

        }

        private void frmOgrenciList_Load(object sender, EventArgs e)
        {

        }

        private void frmOgrenciList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[Application.OpenForms.Count - 1].Show();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn90Ustu_Click(object sender, EventArgs e)
        {
            var mezunlar = BusinessLayer.BL.binaryMezunlar.Ortalama90UstuMezunlariGetir();
            string s = "";
            foreach (var m in mezunlar)
            {
                s += "Ad: " + m.Ad + " Bölüm: " + m.BolumBilgileri.Last.Value.BolumAdi + " " + Environment.NewLine;
            }
            textBox1.Text = s;
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            var mezunlar = BusinessLayer.BL.binaryMezunlar.IngilizcesiAdvancedOlanMezunlariGetir();
            string s = "";
            foreach (var m in mezunlar)
            {
                s += "Ad: " + m.Ad + " Bölüm: " + m.BolumBilgileri.Last.Value.BolumAdi + " " + Environment.NewLine;
            }
            textBox1.Text = s;
        }
    }
}
