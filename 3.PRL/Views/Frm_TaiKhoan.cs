using _1.DAL.Model1s;
using _2.BUS.Services;
using _3.PRL.Views.DangNhap;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Frm_TaiKhoan : Form
    {
        Frm_TrangChu frm_TrangChu;
        public Frm_TaiKhoan(Frm_TrangChu frm_TrangChu, TaiKhoan user1)
        {
            InitializeComponent();
            this.frm_TrangChu = frm_TrangChu;
            user = user1;
        }
        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_TrangChu?.Show();
        }
        TaiKhoanService taiKhoanService;
        TaiKhoan user;
        public Frm_TaiKhoan(TaiKhoanService taiKhoanService)
        {
            InitializeComponent();

            this.taiKhoanService = taiKhoanService;


            // Display account information when the MainForm is loaded
        }
        public Frm_TaiKhoan()
        {
            InitializeComponent();
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
        private void DisplayAccountInformation()
        {
            taiKhoanService = new TaiKhoanService();
            var nvSer = new NhanVienService();
            var vaitroSer = new VaiTroService();
            var kq = taiKhoanService.GetKhoans().Where(a => a.IdTk == user.IdTk).Join(nvSer.GetNhanVien(null), a => a.IdTk, b => b.IdTk, (c, d) =>
            {
                return new
                {
                    Ten = d.Ten,
                    Sdt = d.Sdt,
                    ns = d.NgaySinh,
                    gioiTinh = d.GioiTinh,
                    TrangThai = d.TrangThai,
                    idVaiTro = c.IdVaiTro,
                    DiaChi = d.DiaChi
                };
            }).Join(vaitroSer.GetVaiTros(), a => a.idVaiTro, b => b.IdVaiTro, (d, k) =>
            {
                return new
                {
                    Ten = d.Ten,
                    Sdt = d.Sdt,
                    ns = d.ns,
                    gioiTinh = d.gioiTinh,
                    TrangThai = d.TrangThai,
                    DiaChi = d.DiaChi,
                    vaiTro = k.Ten
                };
            }).FirstOrDefault();

            if (kq != null)
            {
                lbtk.Text= "HỒ SƠ CỦA: "+user.TaiKhoan1;
                lbten.Text = kq.Ten;
                lbns.Text = kq.ns.Value.ToString("dd/MM/yyyy");

                lbdc.Text = kq.DiaChi;
                lbdt.Text = kq.Sdt;
                var gioiTinh = "Nam";
                if (kq.gioiTinh == false)
                {
                    gioiTinh = "Nữ";
                }
                lbgt.Text = gioiTinh;
                var tt = "Hoạt động";
                if (kq.TrangThai == false)
                {
                    tt = "Không hoạt động";
                }

                lbtt.Text = tt;
                lbvt.Text = kq.vaiTro;
            }


        }

        private void Frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            DisplayAccountInformation();
        }
    }
}
