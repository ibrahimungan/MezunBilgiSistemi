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
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
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
    }
}
