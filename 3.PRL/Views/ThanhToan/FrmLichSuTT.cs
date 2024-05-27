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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PRL.Views.ThanhToan
{
    public partial class FrmLichSuTT : Form
    {
        LichSuttService _lsttService = new LichSuttService();
        PtttSerivce _ptttService = new PtttSerivce();
        HoaDonService _hdService = new HoaDonService();
        HoaDonCTService _hdctService = new HoaDonCTService();
        GiamGiaService _ggService = new GiamGiaService();
        BienTheService _btService = new BienTheService();
        VanChuyenService _vcService = new VanChuyenService();


        Guid _id;
        List<Guid> _idPttt = new List<Guid>();

        Frm_HoaDonBanHang frm_HoaDonBan;
        public FrmLichSuTT()
        {
            InitializeComponent();
        }

        public FrmLichSuTT(Frm_HoaDonBanHang frm_HoaDonBan)
        {
            InitializeComponent();
            this.frm_HoaDonBan = frm_HoaDonBan;
        }

        private void FrmLichSuTT_Load(object sender, EventArgs e)
        {
            LoadLSTT();
        }

        private void LoadLSTT()
        {
            int stt = 1;
            dgvLSTT.ColumnCount = 6;
            dgvLSTT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLSTT.Columns[0].Name = "ID_LSTT";
            dgvLSTT.Columns[0].Visible = false;
            dgvLSTT.Columns[1].Name = "STT";
            dgvLSTT.Columns[1].Width = 70;
            dgvLSTT.Columns[2].Name = "Ngày thanh toán";
            dgvLSTT.Columns[3].Name = "PTTT";
            dgvLSTT.Columns[4].Name = "Mã HD";
            dgvLSTT.Columns[5].Name = "Tồng tiền thanh toán";
            dgvLSTT.Rows.Clear();

            foreach (var item in _lsttService.GetLichSuTt(null))
            {
                var Pttt = _ptttService.GetPTTT().FirstOrDefault(a => a.IdPttt == item.IdPttt);
                string idHoaDon = item.IdHoaDon.ToString();
                string MaHD = idHoaDon.Substring(idHoaDon.Length - 10).ToUpper();

                dgvLSTT.Rows.Add(item.IdLstt, stt++, item.Ngay, Pttt.Ten,
                MaHD, Convert.ToDecimal(item.TongTien).ToString("N0"));
            }
        }

        private void dgvLSTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            var selectedLstt = dgvLSTT.Rows[rowIndex];
            _id = Guid.Parse(selectedLstt.Cells[0].Value.ToString());

            txtMaHD.Text = selectedLstt.Cells[4].Value.ToString();
            dtpNgayTT.Text = selectedLstt.Cells[2].Value.ToString();
            txtPTTT.Text = selectedLstt.Cells[3].Value.ToString();
            txtTien.Text = Convert.ToDecimal(selectedLstt.Cells[5].Value).ToString("N0");
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
            frm_HoaDonBan?.Show();
        }
    }
}
