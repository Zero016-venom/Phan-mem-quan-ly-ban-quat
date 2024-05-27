using _1.DAL.Model1s;
using _2.BUS.Services;
using _3.PRL.Views.BaoHanh;
using _3.PRL.Views.DangNhap;
using _3.PRL.Views.GiamGia;
using _3.PRL.Views.SanPham;
using _3.PRL.Views.ThanhToan;
using _3.PRL.Views.ThongKe;
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
    public partial class Frm_TrangChu : Form
    {

        public Frm_TrangChu()
        {
            InitializeComponent();
        }

        public Frm_TrangChu(TaiKhoan user, bool isAdmin)
        {
            InitializeComponent();
            this.user = user;
            this.isAdmin = isAdmin;
        }

        private TaiKhoan user;
        private bool isAdmin;
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

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_KhachHang frm_KhachHang = new Frm_KhachHang(this);
            frm_KhachHang.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                // Kiểm tra xem Ten có null hay không trước khi so sánh giá trị
                if (user.IdVaiTro != null && new VaiTroService().GetVaiTros().FirstOrDefault(a => a.IdVaiTro == user.IdVaiTro).Ten == "Quản lý")
                {
                    this.Hide();
                    Frm_NhanVien frm_NhanVien = new Frm_NhanVien(this);
                    frm_NhanVien.Show();

                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập chức năng này.");
                }
            }
        }
        //sản phẩm liên kết

        private Frm_SanPham frm_SanPham;
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_SanPham = new Frm_SanPham(this);
            frm_SanPham.OpenThemSPForm += Form_OpenThemSPForm;
            frm_SanPham.OpenThemCTKhacForm += Form_OpenThemCTKhacForm;
            frm_SanPham.OpenThemBienTheForm += Form_OpenThemBienTheForm;
            frm_SanPham.Show();
        }
        private void Form_OpenThemSPForm(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemSP frm_ThemSP = new Frm_ThemSP(this);
            frm_ThemSP.OpenSanPhamForm += Form_OpenTrangChuForm;
            frm_ThemSP.OpenThemCTKhacForm += Form_OpenThemCTKhacForm;
            frm_ThemSP.OpenThemBienTheForm += Form_OpenThemBienTheForm;
            frm_ThemSP.Show();
        }

        private void Form_OpenThemCTKhacForm(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemCTKhac frm_ThemCTKhac = new Frm_ThemCTKhac(this);
            frm_ThemCTKhac.OpenSanPhamForm += Form_OpenTrangChuForm;
            frm_ThemCTKhac.OpenThemBienTheForm += Form_OpenThemBienTheForm;
            frm_ThemCTKhac.OpenThemSPForm += Form_OpenThemSPForm;
            frm_ThemCTKhac.Show();
        }

        private void Form_OpenThemBienTheForm(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThemBienThe frm_ThemBienThe = new Frm_ThemBienThe(this);
            frm_ThemBienThe.OpenSanPhamForm += Form_OpenTrangChuForm;
            frm_ThemBienThe.OpenThemSPForm += Form_OpenThemSPForm;
            frm_ThemBienThe.OpenThemCTKhacForm += Form_OpenThemCTKhacForm;
            frm_ThemBienThe.Show();
        }
        private void Form_OpenTrangChuForm(object sender, EventArgs e)
        {
            frm_SanPham.Show();
        }
        //thanh toán liên kết

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_HoaDonBanHang frm = new(this);
            frm.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TaiKhoan frm_TaiKhoan = new Frm_TaiKhoan(this, user);
            frm_TaiKhoan.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_GiamGia frm_GiamGia = new Frm_GiamGia(this);
            frm_GiamGia.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                if (user.IdVaiTro != null && new VaiTroService().GetVaiTros().FirstOrDefault(a => a.IdVaiTro == user.IdVaiTro).Ten == "Quản lý")
                {
                    this.Hide();
                    Frm_ThongKe frm = new Frm_ThongKe(this);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập chức năng này !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }

}
