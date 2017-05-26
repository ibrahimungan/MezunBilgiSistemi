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
    public partial class frmAgacIslemleri : Form
    {
        public frmAgacIslemleri()
        {
            InitializeComponent();
        }

        public frmAgacIslemleri(string str)
        {
            if (str == "Ağacın Derinliği")
            {
                txtAgac.Text = "";
            }
            else if (str == "InOrder")
            {
                txtAgac.Text = "";
            }
            else if (str == "PreOrder")
            {
                txtAgac.Text = "";
            }
            else if (str == "PostOrder")
            {
                txtAgac.Text = "";
            }
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgacIslemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[Application.OpenForms.Count - 1].Show();
        }

        private void frmAgacIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
