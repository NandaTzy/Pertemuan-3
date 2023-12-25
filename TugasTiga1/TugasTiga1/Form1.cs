using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class frmTulisanBerjalan : Form
    {
        public frmTulisanBerjalan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNIM1.Text = "22.11.4751";
            lblNama1.Text = "Fernanda Pandu J";
            lblKelas1.Text = "Informatika 04";
        }

        private void frmTulisanBerjalan_Load(object sender, EventArgs e)
        {

        }

        private void lblHilangkan_Click(object sender, EventArgs e)
        {
            lblNIM1.Text = "";
            lblNama1.Text = "";
            lblKelas1.Text = "";
        }
    }
}
