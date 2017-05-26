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
    public partial class frmStajEkle : Form
    {
        public frmStajEkle()
        {
            InitializeComponent();
        }

    private void StajEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[Application.OpenForms.Count - 1].Show();
        }

        private void StajEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnStajEkle_Click(object sender, EventArgs e)
        {

        }
    }

   
}
