using _1.DAL.Model1s;
using _2.BUS.Services;
using _3.PRL.Views.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PRL.Views.SanPham
{
    public partial class Frm_ThemCTKhac : Form
    {
        public event EventHandler OpenThemSPForm;
        public event EventHandler OpenSanPhamForm;
        public event EventHandler OpenThemBienTheForm;

        Frm_TrangChu frm_TrangChu;
        public Frm_ThemCTKhac(Frm_TrangChu frm_TrangChu)
        {
            InitializeComponent();
            _chatLieuService = new ChatLieuService();
            _mauSacService = new MauSacService();
            _soCanhService = new SoCanhService();
            _LoaiSPService = new LoaiSPService();
            LoadAttributes();
            this.frm_TrangChu = frm_TrangChu;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_TrangChu?.Show();
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

        private void btnTCSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenSanPhamForm?.Invoke(this, EventArgs.Empty);
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenThemSPForm?.Invoke(this, EventArgs.Empty);
        }

        private void btnThemBienThe_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenThemBienTheForm?.Invoke(this, EventArgs.Empty);
        }
        private ChatLieuService _chatLieuService;
        private MauSacService _mauSacService;
        private SoCanhService _soCanhService;
        private LoaiSPService _LoaiSPService;
        Dictionary<string, string> lstloai = new Dictionary<string, string>();
        public Frm_ThemCTKhac()
        {
            InitializeComponent();
            _chatLieuService = new ChatLieuService();
            _mauSacService = new MauSacService();
            _soCanhService = new SoCanhService();
            _LoaiSPService = new LoaiSPService();
            LoadAttributes();
        }
        private void LoadAttributes()
        {
            cboChatLieu.Items.Clear();
            cboLoaiSP.Items.Clear();
            cboMau.Items.Clear();
            cboSoCanh.Items.Clear();
            lstloai.Clear();
            cboSoCanh.Text = string.Empty;
            cboMau.Text = string.Empty;
            cboLoaiSP.Text = string.Empty;
            cboChatLieu.Text = string.Empty;
            rtxtMoTa.Text = string.Empty;
            var chatlieu = (from i in _chatLieuService.GetChatLieu(null)
                            select i.TenChatLieu).ToArray();
            cboChatLieu.Items.AddRange(chatlieu);

            var Mau = (from i in _mauSacService.GetMau(null)
                       select i.TenMau).ToArray();
            cboMau.Items.AddRange(Mau);

            var Socanh = (from i in _soCanhService.GetSoCanh(null)
                          select i.SoCanh1.ToString()).ToArray();
            cboSoCanh.Items.AddRange(Socanh);

            var loaisp = _LoaiSPService.GetLoaiSanPham(null);
            foreach (var i in loaisp)
            {
                lstloai.Add(i.TenLoai, i.MoTa);
            }
            var lstTen = lstloai.Keys.ToArray();
            cboLoaiSP.Items.AddRange(lstTen);
        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxtMoTa.Text = lstloai.FirstOrDefault(x => x.Key == cboLoaiSP.Text).Value;
        }
        private void AddChatLieu()
        {
            ChatLieu chatLieu = new ChatLieu()
            {
                IdChatLieu = Guid.NewGuid(),
                TenChatLieu = cboChatLieu.Text,
            };
            if (Xacnhan())
            {
                bool result = _chatLieuService.CreateChatLieu(chatLieu);
                ThongBao(result);
            }
            LoadAttributes();
        }

        private void AddMau()
        {
            Mau chatMau = new Mau()
            {
                IdMau = Guid.NewGuid(),
                TenMau = cboMau.Text,
            };
            if (Xacnhan())
            {
                bool result = _mauSacService.CreateMau(chatMau);
                ThongBao(result);
            }
            LoadAttributes();
        }

        private void AddSoCanh()
        {
            SoCanh chatSoCanh = new SoCanh()
            {
                IdCanh = Guid.NewGuid(),
                SoCanh1 = int.Parse(cboSoCanh.Text)
            };
            if (Xacnhan())
            {
                bool result = _soCanhService.CreateSoCanh(chatSoCanh);
                ThongBao(result);
            }
            LoadAttributes();
        }

        private void AddLoaiSP()
        {
            LoaiSanPham loaiSanPham = new LoaiSanPham()
            {
                IdLoaiSanPham = Guid.NewGuid(),
                TenLoai = cboLoaiSP.Text,
                MoTa = rtxtMoTa.Text
            };
            if (Xacnhan())
            {
                bool result = _LoaiSPService.CreateLoaiSanPham(loaiSanPham);
                ThongBao(result);
            }
            LoadAttributes();
        }

        private bool Xacnhan()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void ThongBao(bool result)
        {
            if (result == true)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }


        private void changeBG()
        {
            grbCL.BackColor = Color.White;
            grbSC.BackColor = Color.White;
            grbMS.BackColor = Color.White;
            grbLSP.BackColor = Color.White;
        }

        private void grbCL_Enter(object sender, EventArgs e)
        {
            changeBG();
            grbCL.BackColor = Color.LightBlue;
        }

        private void grbMS_Enter(object sender, EventArgs e)
        {
            changeBG();
            grbMS.BackColor = Color.LightBlue;
        }

        private void grbSC_Enter(object sender, EventArgs e)
        {
            changeBG();
            grbSC.BackColor = Color.LightBlue;
        }

        private void grbLSP_Enter(object sender, EventArgs e)
        {
            changeBG();
            grbLSP.BackColor = Color.LightBlue;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (grbLSP.BackColor == Color.LightBlue)
            {
                if (checkEmpty(cboLoaiSP.Text) &&
                    checkExistLoaiSP(_LoaiSPService.GetLoaiSanPham(null), cboLoaiSP.Text)
                    && checkFormat(cboLoaiSP.Text))
                {
                    AddLoaiSP();
                }
            }
            if (grbSC.BackColor == Color.LightBlue)
            {
                if (checkEmpty(cboSoCanh.Text) &&
                    checkExistSocanh(_soCanhService.GetSoCanh(null), cboSoCanh.Text)
                    && checkFormatSC(cboSoCanh.Text))
                {
                    AddSoCanh();
                }
            }
            if (grbMS.BackColor == Color.LightBlue)
            {
                if (checkEmpty(cboMau.Text) &&
                    checkExistMau(_mauSacService.GetMau(null), cboMau.Text)
                    && checkFormat(cboMau.Text))
                {
                    AddMau();
                }
            }
            if (grbCL.BackColor == Color.LightBlue)
            {
                if (checkEmpty(cboChatLieu.Text) &&
                    checkExistChatLieu(_chatLieuService.GetChatLieu(null), cboChatLieu.Text)
                    && checkFormat(cboChatLieu.Text))
                {
                    AddChatLieu();
                }
            }
        }
        private bool checkEmpty(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            return true;
        }

        private bool checkFormat(string text)
        {
            string regex = @"^[A-Za-z0-9\p{L} ]+$";
            if (!Regex.IsMatch(text, regex))
            {
                MessageBox.Show("Vui lòng chỉ nhập chữ cái và số!");
                return false;
            }
            return true;
        }

        private bool checkFormatSC(string text)
        {
            string regex = @"^[0-9]+$";
            if (!Regex.IsMatch(text, regex))
            {
                MessageBox.Show("Số cánh phải là số nguyên");
                return false;
            }
            return true;
        }

        private bool checkExistMau(List<Mau> lst, string text)
        {
            if (lst.Any(x => x.TenMau.ToLower() == text.ToLower()))
            {
                MessageBox.Show("Màu đã tồn tại");
                return false;
            }
            return true;
        }

        private bool checkExistChatLieu(List<ChatLieu> lst, string text)
        {
            if (lst.Any(x => x.TenChatLieu.ToLower() == text.ToLower()))
            {
                MessageBox.Show("Chất liệu đã tồn tại");
                return false;
            }
            return true;
        }

        private bool checkExistSocanh(List<SoCanh> lst, string text)
        {
            if (lst.Any(x => x.SoCanh1 == int.Parse(text)))
            {
                MessageBox.Show("Số cánh đã tồn tại");
                return false;
            }
            return true;
        }

        private bool checkExistLoaiSP(List<LoaiSanPham> lst, string text)
        {
            if (lst.Any(x => x.TenLoai.ToLower() == text.ToLower())/* != null*/)
            {
                MessageBox.Show("Tên loại đã tồn tại");
                return false;
            }
            return true;
        }
    }
}
