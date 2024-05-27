using _3.PRL.Views.BaoHanh;
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

namespace _3.PRL.Views
{
    public partial class Frm_BaoHanh : Form
    {
        public Frm_BaoHanh()
        {
            InitializeComponent();
        }

        private void Frm_BaoHanh_Load(object sender, EventArgs e)
        {
            LoadGrid(null);
        }
        private void LoadGrid(string input)
        {
            int stt = 1;
            dgvDSBaoHanh.ColumnCount = 8;
            dgvDSBaoHanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSBaoHanh.Columns[0].Name = "STT";
            dgvDSBaoHanh.Columns[1].Name = "ID_HoaDon";
            dgvDSBaoHanh.Columns[1].Visible = false;
            dgvDSBaoHanh.Columns[2].Name = "Tên khách hàng";
            dgvDSBaoHanh.Columns[3].Name = "Tên nhân viên";
            dgvDSBaoHanh.Columns[4].Name = "Tên sản phẩm";
            dgvDSBaoHanh.Columns[5].Name = "Số lượng";
            dgvDSBaoHanh.Columns[6].Name = "Ngày giao dịch";
            dgvDSBaoHanh.Columns[7].Name = "Tổng tiền";
            dgvDSBaoHanh.Rows.Clear();


        }



        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TrangChu frm_TrangChu = new Frm_TrangChu();
            frm_TrangChu.Show();
        }

        private void btnTaoPhieuBH_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TaoPhieuBH frm_TaoPhieu = new Frm_TaoPhieuBH();
            frm_TaoPhieu.Show();
        }

        private void pbDangXuat_Click(object sender, EventArgs e)
        {
            var option = MessageBox.Show("Bạn muốn đăng xuất không ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                this.Hide();
                Frm_DangNhap2 frm_DangNhap = new Frm_DangNhap2();
                frm_DangNhap.Show();
            }
            else
            {
                return;
            }
        }

        
    }
}
