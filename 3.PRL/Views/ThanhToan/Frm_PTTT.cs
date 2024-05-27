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
    public partial class Frm_PTTT : Form
    {
        PtttSerivce _ptttService = new PtttSerivce();
        Guid _id;
        public Frm_PTTT()
        {
            InitializeComponent();
        }

        private void Frm_PTTT_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_HoaDonBanHang frm_hdbh = new Frm_HoaDonBanHang();
            frm_hdbh.Show();
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

        private void LoadGrid()
        {
            int stt = 1;
            dgvDSPTTT.ColumnCount = 3;
            dgvDSPTTT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSPTTT.Columns[0].Name = "ID_PTTT";
            dgvDSPTTT.Columns[0].Visible = false;
            dgvDSPTTT.Columns[1].Name = "STT";
            dgvDSPTTT.Columns[1].Width = 200;
            dgvDSPTTT.Columns[2].Name = "Tên phương thức thanh toán";
            dgvDSPTTT.Rows.Clear();

            foreach (var item in _ptttService.GetPTTT())
            {
                dgvDSPTTT.Rows.Add(item.IdPttt, stt++, item.Ten);
            }
        }

        private void dgvDSPTTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex > dgvDSPTTT.ColumnCount)
                return;

            var selectedPTTT = dgvDSPTTT.Rows[rowIndex];
            _id = Guid.Parse(selectedPTTT.Cells[0].Value.ToString());
            txtTenPTTT.Text = selectedPTTT.Cells[2].Value.ToString();
        }
        private void btnThemPTTT_Click(object sender, EventArgs e)
        {
            if (CheckTextBox() == false)
            {
                return;
            }
            else
            {
                Pttt pttt = new Pttt();
                pttt.IdPttt = new Guid();
                pttt.Ten = txtTenPTTT.Text;

                var option = MessageBox.Show("Bạn muốn Thêm PTTT mới không ?", "Thông Báo !", MessageBoxButtons.YesNo);
                if (option == DialogResult.Yes)
                {
                    if (_ptttService.AddPTTT(pttt))
                    {
                        MessageBox.Show("Thêm PTTT thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Thêm PTTT thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
            LoadGrid();
        }
        public bool CheckTextBox()
        {
            //kiểm tra xem các text box có null ko
            if (string.IsNullOrEmpty(txtTenPTTT.Text))
            {
                MessageBox.Show("Không được để trống", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSuaPTTT_Click(object sender, EventArgs e)
        {
            if (CheckTextBox() == false)
            {
                return;
            }
            else
            {
                Pttt updatePttt = new Pttt();
                
                updatePttt.Ten = txtTenPTTT.Text;

                var option = MessageBox.Show("Bạn muốn sửa PTTT không ?", "Thông Báo !", MessageBoxButtons.YesNo);
                if (option == DialogResult.Yes)
                {
                    if (_ptttService.UpdatePTTT(_id, updatePttt))
                    {
                        MessageBox.Show("Sửa PTTT thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Sửa PTTT thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
            LoadGrid();
        }
    }
}
