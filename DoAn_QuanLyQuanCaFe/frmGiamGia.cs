using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyQuanCaFe
{
    public partial class frmGiamGia : Form
    {
        public string magiamgia;
        public frmGiamGia()
        {
            InitializeComponent();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            magiamgia = txtMa.Text;
            this.Close();
        }
    }
}
