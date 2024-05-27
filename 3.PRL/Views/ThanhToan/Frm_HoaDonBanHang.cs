using _1.DAL.Model1s;
using _2.BUS.Services;
using _3.PRL.Views.DangNhap;
using _3.PRL.Views.SanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace _3.PRL.Views.ThanhToan
{
    public partial class Frm_HoaDonBanHang : Form
    {
        Frm_TrangChu frm_TrangChu;

        HoaDonService _hoaDonService = new HoaDonService();
        NhanVienService _nhanVienService = new NhanVienService();
        KhachHangService _khachHangService = new KhachHangService();
        VanChuyenService _vanChuyenService = new VanChuyenService();
        PtttSerivce _ptttService = new PtttSerivce();
        LichSuttService _lichSuttService = new LichSuttService();
        HoaDonCTService _HDctService = new HoaDonCTService();
        BienTheService _bienTheService = new BienTheService();
        GiamGiaService _giamGiaService = new GiamGiaService();
        HoaDonCTService _hdctService = new HoaDonCTService();
        SanPhamService _sanPhamService = new SanPhamService();


        Guid _id;
        List<Guid> _idKH = new List<Guid>();
        List<Guid> _idNV = new List<Guid>();
        List<Guid> _idVC = new List<Guid>();
        List<Guid> _idBT = new List<Guid>();
        List<Guid> _idGG = new List<Guid>();
        List<Guid> _idSanPham = new List<Guid>();
        List<Guid> _idHD = new List<Guid>();

        public Frm_HoaDonBanHang()
        {
            InitializeComponent();
        }

        public Frm_HoaDonBanHang(Frm_TrangChu frm_TrangChu)
        {
            InitializeComponent();
            this.frm_TrangChu = frm_TrangChu;
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

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_TrangChu?.Show();
        }

        private void Frm_HoaDonBanHang_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadKhachHang();
            LoadVanChuyen();
            LoadGridHD(null);
            LoadMaBT();
            LoadGiamGia();
            LoadMaHD();
            LoadGridHDCT(null);
        }
        private void LoadNhanVien()
        {
            foreach (var item in _nhanVienService.GetNhanVien(null))
            {
                _idNV.Add(item.IdNv);
                cmbNhanVien.Items.Add(item.Ten);
            }
            cmbNhanVien.SelectedIndex = -1;
        }

        private void LoadKhachHang()
        {
            foreach (var item in _khachHangService.GetKhach(null))
            {
                _idKH.Add(item.IdKh);
                cmbKhachHang.Items.Add(item.TenKh);
            }
            cmbKhachHang.SelectedIndex = -1;
        }

        private void LoadVanChuyen()
        {
            foreach (var item in _vanChuyenService.GetVanChuyen().OrderBy(a => a.TongTien.Length).ThenBy(b => b.TongTien))
            {
                _idVC.Add(item.IdVc);
                cmbVanChuyen.Items.Add(Convert.ToDecimal(item.TongTien).ToString("N0"));
            }
            cmbKhachHang.SelectedIndex = -1;
        }

        private void LoadMaBT()
        {          
            foreach (var item in _bienTheService.GetBienThe(null).OrderBy(a => a.MaBienThe))
            {
                _idBT.Add(item.IdBienThe);
                cmbBienThe.Items.Add(item.MaBienThe);
            }
            cmbBienThe.SelectedIndex = -1;
        }

        private void LoadGiamGia()
        {
            DateTime ngayHienTai = DateTime.Now.Date;

            string ngayHienTaiString = ngayHienTai.ToString("dd/MM/yyyy");
            foreach (var item in _giamGiaService.GetGiamGia(ngayHienTaiString).OrderBy(a => a.GiaTri))
            {
                _idGG.Add(item.IdGiamGia);
                cmbGiamGia.Items.Add(item.GiaTri);
            }
            cmbGiamGia.SelectedIndex = -1;
        }

        private void cmbBienThe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbBienThe.SelectedIndex;

            if (selectedIndex > 0 && selectedIndex < _idBT.Count)
            {
                Guid selectedId = _idBT[selectedIndex];
                var bienThe = _bienTheService.GetBienThe(null).FirstOrDefault(a => a.IdBienThe == selectedId);
                if (bienThe != null)
                {
                    if (bienThe.GiaTien != null)
                    {
                        txtDonGia.Text = Convert.ToDecimal(bienThe.GiaTien).ToString("N0");
                    }
                    else
                    {
                        txtDonGia.Text = string.Empty;
                    }
                    string prefix = "";
                    if (bienThe.MaBienThe.StartsWith("QDH"))
                    {
                        prefix = "Quạt Điều Hòa";
                    }
                    else if (bienThe.MaBienThe.StartsWith("QTN"))
                    {
                        prefix = "Quạt Trong Nhà";
                    }
                    else if (bienThe.MaBienThe.StartsWith("QG"))
                    {
                        prefix = "Quạt Gió";
                    }
                    else if (bienThe.MaBienThe.StartsWith("QS"))
                    {
                        prefix = "Quạt Sưởi";
                    }
                    else
                    {
                        prefix = "Quạt Công Nghiệp";
                    }
                    txtTenSP.Text = $"{prefix} {bienThe.MaBienThe.Substring(4)}";
                }
            }
        }

        private void LoadGridHD(string input)
        {
            int stt = 1;
            dgvHoaDon.ColumnCount = 9;
            //dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.Columns[0].Name = "ID";
            dgvHoaDon.Columns[0].Visible = false;
            dgvHoaDon.Columns[1].Name = "STT";
            dgvHoaDon.Columns[1].Width = 40;
            dgvHoaDon.Columns[2].Name = "Mã HD";
            dgvHoaDon.Columns[2].Width = 110;
            dgvHoaDon.Columns[3].Name = "Khách Hàng";
            dgvHoaDon.Columns[3].Width = 170;
            dgvHoaDon.Columns[4].Name = "Nhân Viên";
            dgvHoaDon.Columns[4].Width = 150;
            dgvHoaDon.Columns[5].Name = "Ngày Tạo";
            dgvHoaDon.Columns[6].Name = "Trạng Thái";
            dgvHoaDon.Columns[6].Width = 110;
            dgvHoaDon.Columns[7].Name = "Phí vận chuyển";
            dgvHoaDon.Columns[7].Width = 80;
            dgvHoaDon.Columns[8].Name = "Thanh Toan";
            //dgvHoaDon.Columns[8].Visible = false;
            dgvHoaDon.Rows.Clear();

            foreach (var item in _hoaDonService.GetHoaDon(input).OrderBy(a => a.NgayGd))
            {
                var KH = _khachHangService.GetKhach(null).FirstOrDefault(a => a.IdKh == item.IdKh);
                var NV = _nhanVienService.GetNhanVien(null).FirstOrDefault(a => a.IdNv == item.IdNv);
                var VC = _vanChuyenService.GetVanChuyen().FirstOrDefault(a => a.IdVc == item.IdVc);
                var CT = _HDctService.GetHoaDonCts(null).FirstOrDefault(a => a.IdHoaDon == item.IdHoaDon);
                var hoaDonCT = _hdctService.GetHoaDonCts(null).Where(a => a.IdHoaDon == item.IdHoaDon).ToList();

                string idHoaDon = item.IdHoaDon.ToString();
                string MaHD = idHoaDon.Substring(idHoaDon.Length - 10);

                var tienHang = hoaDonCT
                    .Join(_bienTheService.GetBienThe(null), ct => ct.IdBienThe, sp => sp.IdBienThe, (ct, sp) => new { ct, sp })
                    .Join(_giamGiaService.GetGiamGia(null), a => a.ct.IdGiamGia, b => b.IdGiamGia, (a, b) => new { a.ct, a.sp, b })
                    .Sum(x => (x.ct.SoLuong * x.sp.GiaTien * (100 - Convert.ToDecimal(x.b.GiaTri)) / 100));

                var TongTienCaShip = tienHang + Convert.ToDecimal(VC?.TongTien);

                dgvHoaDon.Rows.Add(item.IdHoaDon, stt++, MaHD.ToUpper(), KH?.TenKh, NV?.Ten,
                    item.NgayGd.ToString(), item.TrangThai == true ? "Đã thanh toán" : "Chưa thanh toán",
                    Convert.ToDecimal(VC?.TongTien).ToString("N0"),
                    Convert.ToDecimal(TongTienCaShip).ToString("N0"));
            }
            RowsColor();
        }

        private void RowsColor()
        {
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                string tt = (dgvHoaDon.Rows[i].Cells[6].Value.ToString());
                if (tt.Equals("Chưa thanh toán"))
                {
                    dgvHoaDon.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex > dgvHoaDon.RowCount)
                return;

            var selectedHoaDon = dgvHoaDon.Rows[rowIndex];
            _id = Guid.Parse(selectedHoaDon.Cells[0].Value.ToString());
            cmbKhachHang.Text = selectedHoaDon.Cells[3].Value.ToString();
            cmbNhanVien.Text = selectedHoaDon.Cells[4].Value.ToString();
            dtpNgayTao.Text = selectedHoaDon.Cells[5].Value.ToString();
            if (selectedHoaDon.Cells[6].Value.ToString().Equals("Đã thanh toán"))
            {
                rdbDaThanhToan.Checked = true;
            }
            else
            {
                rdbChuaThanhToan.Checked = true;
            }
            cmbVanChuyen.Text = selectedHoaDon.Cells[7].Value.ToString();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (CheckComboxBoxHD() == false)
            {
                return;
            }
            else
            {
                HoaDon hd = new HoaDon();
                hd.IdHoaDon = new Guid();
                hd.NgayGd = dtpNgayTao.Value;
                hd.IdKh = _idKH[cmbKhachHang.SelectedIndex];
                hd.IdNv = _idNV[cmbNhanVien.SelectedIndex];
                hd.IdVc = _idVC[cmbVanChuyen.SelectedIndex];

                if (rdbChuaThanhToan.Checked)
                {
                    hd.TrangThai = false;
                }
                else
                {
                    hd.TrangThai = true;
                }

                hd.TongTien = 0;

                var option = MessageBox.Show("Bạn muốn tạo Hóa Đơn không ?", "Thông Báo !", MessageBoxButtons.YesNo);
                if (option == DialogResult.Yes)
                {
                    if (_hoaDonService.AddHoaDon(hd))
                    {
                        MessageBox.Show("Tạo Hóa đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LoadGridHD(null);
                    }
                    else
                    {
                        MessageBox.Show("Tạo Hóa đơn thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
            LoadMaHD();
        }

        private bool CheckComboxBoxHD()
        {
            if (cmbKhachHang.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn khách hàng !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn nhân viên !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbVanChuyen.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phí vận chuyển !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if (CheckComboxBoxHD() == false)
            {
                return;
            }
            else
            {
                HoaDon updateHD = new HoaDon();
                updateHD.NgayGd = dtpNgayTao.Value;
                updateHD.IdKh = _idKH[cmbKhachHang.SelectedIndex];
                updateHD.IdNv = _idNV[cmbNhanVien.SelectedIndex];
                updateHD.IdVc = _idVC[cmbVanChuyen.SelectedIndex];

                if (rdbChuaThanhToan.Checked)
                {
                    updateHD.TrangThai = false;
                }
                else
                {
                    updateHD.TrangThai = true;
                }

                var option = MessageBox.Show("Bạn sửa Hóa Đơn không ?", "Thông Báo !", MessageBoxButtons.YesNo);
                if (option == DialogResult.Yes)
                {
                    if (_hoaDonService.UpdateHoaDon(_id, updateHD))
                    {
                        MessageBox.Show("Sửa Hóa đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LoadGridHD(null);
                    }
                    else
                    {
                        MessageBox.Show("Sửa Hóa đơn thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnLamMoiHD_Click(object sender, EventArgs e)
        {
            dtpNgayTao.Value = DateTime.Today;
            cmbNhanVien.SelectedIndex = -1;
            cmbKhachHang.SelectedIndex = -1;
            cmbVanChuyen.SelectedIndex = -1;
            rdbChuaThanhToan.Checked = true;
        }

        private bool CheckComboBoxHDCT()
        {
            if (cmbMaHD.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn mã HD!", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbBienThe.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn sản phẩm!", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtSoLuong.Text.Length == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LoadMaHD()
        {
            //cmbMaHD.Items.Clear();
            foreach (var item in _hoaDonService.GetHoaDon(null))
            {
                string MaHoaDon = item.IdHoaDon.ToString().Substring(item.IdHoaDon.ToString().Length - 10).ToUpper();
                if (!cmbMaHD.Items.Contains(MaHoaDon))
                {
                    _idHD.Add(item.IdHoaDon);
                    cmbMaHD.Items.Add(MaHoaDon);
                }
            }
            cmbMaHD.SelectedIndex = -1;
        }

        private void LoadGridHDCT(string input)
        {
            int stt = 1;
            dgvHDCT.ColumnCount = 10;
            dgvHDCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHDCT.Columns[0].Name = "ID";
            dgvHDCT.Columns[0].Visible = false;
            dgvHDCT.Columns[1].Name = "STT";
            dgvHDCT.Columns[1].Width = 40;
            dgvHDCT.Columns[2].Name = "Mã HD";
            dgvHDCT.Columns[2].Width = 110;
            dgvHDCT.Columns[3].Name = "Mã Biến Thể";
            dgvHDCT.Columns[4].Name = "Tên sản phẩm";
            dgvHDCT.Columns[5].Name = "Số Lượng";
            dgvHDCT.Columns[5].Width = 80;
            dgvHDCT.Columns[6].Name = "Đơn Giá";
            dgvHDCT.Columns[7].Name = "Giảm Giá %";
            dgvHDCT.Columns[7].Width = 80;
            dgvHDCT.Columns[8].Name = "Chiết Khấu";
            dgvHDCT.Columns[9].Name = "Thành Tiền";

            dgvHDCT.Rows.Clear();

            foreach (var item in _hdctService.GetHoaDonCts(input))
            {
                var HD = _hoaDonService.GetHoaDon(null).FirstOrDefault(a => a.IdHoaDon == item.IdHoaDon);
                var BT = _bienTheService.GetBienThe(null).FirstOrDefault(a => a.IdBienThe == item.IdBienThe);
                var GG = _giamGiaService.GetGiamGia(null).FirstOrDefault(a => a.IdGiamGia == item.IdGiamGia);
                var SP = _sanPhamService.GetSanPham(null).FirstOrDefault(a => a.IdSanPham == BT.IdSanPham);

                string idHoaDon = item.IdHoaDon.ToString();
                string MaHD = idHoaDon.Substring(idHoaDon.Length - 10);

                var sum = item.SoLuong * BT?.GiaTien;

                var giamGia = sum * Convert.ToDecimal(GG?.GiaTri) / 100;

                var thanhTien = sum - giamGia;

                dgvHDCT.Rows.Add(item.IdHoaDonCt, stt++, MaHD.ToUpper(), BT.MaBienThe, SP.Ten, item.SoLuong,
                    Convert.ToDecimal(BT.GiaTien).ToString("N0"), GG.GiaTri,
                    Convert.ToDecimal(giamGia).ToString("N0"),
                    Convert.ToDecimal(thanhTien).ToString("N0"));
            }
        }

        private void dgvHDCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex > dgvHDCT.RowCount)
                return;

            var selectedHoaDonCT = dgvHDCT.Rows[rowIndex];
            _id = Guid.Parse(selectedHoaDonCT.Cells[0].Value.ToString());
            cmbMaHD.Text = selectedHoaDonCT.Cells[2].Value.ToString();
            cmbBienThe.Text = selectedHoaDonCT.Cells[3].Value.ToString();
            txtSoLuong.Text = selectedHoaDonCT.Cells[5].Value.ToString();
            txtDonGia.Text = selectedHoaDonCT.Cells[6].Value.ToString();
            cmbGiamGia.Text = selectedHoaDonCT.Cells[7].Value.ToString();
        }

        private void btnThemHDCT_Click(object sender, EventArgs e)
        {
            if (CheckComboBoxHDCT() == false)
            {
                return;
            }
            else
            {
                HoaDonCt hdCT = new HoaDonCt();
                hdCT.IdHoaDonCt = new Guid();
                hdCT.IdBienThe = _idBT[cmbBienThe.SelectedIndex];
                hdCT.IdHoaDon = _idHD[cmbMaHD.SelectedIndex];
                hdCT.Gia = Convert.ToDecimal(txtDonGia.Text);
                hdCT.SoLuong = Convert.ToInt32(txtSoLuong.Text);

                bool hasDiscount = cmbGiamGia.SelectedIndex >= 0;
                if (hasDiscount)
                {
                    hdCT.IdGiamGia = _idGG[cmbGiamGia.SelectedIndex];
                }
                else
                {
                    hdCT.IdGiamGia = Guid.Empty;
                }

                var option2 = MessageBox.Show("Bạn muốn tạo Hóa Đơn CT không ?", "Thông Báo !", MessageBoxButtons.YesNo);
                if (option2 == DialogResult.Yes)
                {
                    if (_hdctService.AddHoaDonCT(hdCT))
                    {
                        MessageBox.Show("Tạo Hóa đơn CT thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LoadGridHDCT(null);
                        LoadGridHD(null);
                    }
                    else
                    {
                        MessageBox.Show("Tạo Hóa đơn CT thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSuaHDCT_Click(object sender, EventArgs e)
        {
            if (CheckComboBoxHDCT() == false)
            {
                return;
            }
            else
            {
                HoaDonCt updateHDCT = new HoaDonCt();
                updateHDCT.IdBienThe = _idBT[cmbBienThe.SelectedIndex];
                updateHDCT.IdGiamGia = _idGG[cmbGiamGia.SelectedIndex];
                updateHDCT.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                updateHDCT.IdHoaDon = _idHD[cmbMaHD.SelectedIndex];

                var option = MessageBox.Show("Bạn sửa Hóa Đơn CT không ?", "Thông Báo !", MessageBoxButtons.YesNo);
                if (option == DialogResult.Yes)
                {
                    if (_hdctService.UpdateHoaDonCT(_id, updateHDCT))
                    {
                        MessageBox.Show("Sửa Hóa đơn CT thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LoadGridHDCT(null);
                        LoadGridHD(null);
                    }
                    else
                    {
                        MessageBox.Show("Sửa Hóa đơn CT thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnXoaHDCT_Click(object sender, EventArgs e)
        {
            var option = MessageBox.Show("Bạn chắc chắn muốn xóa Hóa đơn CT ?", "Thông Báo !", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                if (_hdctService.DeleteHoaDonCT(_id))
                {
                    MessageBox.Show("Xóa Hóa Đơn CT thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadGridHDCT(null);
                    LoadGridHD(null);
                }
                else
                {
                    MessageBox.Show("Xóa Hóa đơn CT thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length == 0)
            {
                LoadGridHD(null);
                LoadGridHDCT(null);
            }
            else
            {
                LoadGridHD(txtTimKiem.Text);
                LoadGridHDCT(txtTimKiem.Text);
            }
        }

        private void btnThemCTKhac_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLichSuTT frmLichSuTT = new FrmLichSuTT(this);
            frmLichSuTT.Show();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThanhToan frm_ThanhToan = new Frm_ThanhToan(this);
            frm_ThanhToan.Show();
        }

        private void btnLamMoiHDCT_Click(object sender, EventArgs e)
        {
            cmbGiamGia.SelectedIndex = -1;
            txtSoLuong.Text = string.Empty;
            cmbBienThe.SelectedIndex = -1;
            txtTenSP.Text = string.Empty;
            cmbMaHD.SelectedIndex = -1;
            txtDonGia.Text = string.Empty;
        }
    }
}
