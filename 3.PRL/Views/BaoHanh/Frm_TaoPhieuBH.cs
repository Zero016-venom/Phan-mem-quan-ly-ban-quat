using _3.PRL.Views.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PRL.Views.BaoHanh
{
    public partial class Frm_TaoPhieuBH : Form
    {
        public Frm_TaoPhieuBH()
        {
            InitializeComponent();
        }

        private void pbDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DangNhap2 frm_DangNhap2 = new Frm_DangNhap2();
            frm_DangNhap2.Show();
        }



        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TrangChu frm_TrangChu = new Frm_TrangChu();
            frm_TrangChu.Show();
        }

        private void btnDSBH_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_BaoHanh frm_BaoHanh = new Frm_BaoHanh();
            frm_BaoHanh.Show();
        }
    }
}
