using _1.DAL.Model1s;
using _2.BUS.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PRL.Views.DangNhap
{
    public partial class Frm_DangNhap2 : Form
    {
        private TaiKhoanService taiKhoanService = new TaiKhoanService();
        private VaiTroService vaiTroService = new VaiTroService();
        private NhanVienService nhanVienService = new NhanVienService();
        public Frm_DangNhap2()
        {
            InitializeComponent();
        }

        private void linkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Frm_QuenMK frm_QuenMK = new Frm_QuenMK();
            frm_QuenMK.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dangnhap();
        }
        private void dangnhap()
        {
            var user = taiKhoanService.GetKhoans().FirstOrDefault(u => u.TaiKhoan1 == textBox1.Text && u.MatKhau == textBox2.Text);

            if (user != null)
            {
                if (user.IdVaiTro != null && new VaiTroService().GetVaiTros().FirstOrDefault(a => a.IdVaiTro == user.IdVaiTro).Ten == "Quản lý")
                {
                    MessageBox.Show("Đăng nhập thành công với quyền Admin!");
                    this.Hide();
                    Frm_TrangChu frm_TrangChuAdmin = new Frm_TrangChu(user, true);
                    frm_TrangChuAdmin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công với quyền Nhân viên!");
                    this.Hide();
                    Frm_TrangChu frm_TrangChuNhanVien = new Frm_TrangChu(user, false);
                    frm_TrangChuNhanVien.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại.");
            }
        }
    }
}
