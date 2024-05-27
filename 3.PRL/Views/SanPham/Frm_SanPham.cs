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

namespace _3.PRL.Views
{
    public partial class Frm_SanPham : Form
    {
        public event EventHandler OpenThemSPForm;
        public event EventHandler OpenThemCTKhacForm;
        public event EventHandler OpenThemBienTheForm;
        Frm_TrangChu frm_TrangChu;
        public Frm_SanPham(Frm_TrangChu frm_TrangChu)
        {
            InitializeComponent();
            _BienTheService = new BienTheService();
            _SanphamService = new SanPhamService();
            LoadSP(sd, sc);
            if (st < 2)
            {
                button1.Enabled = false;
            }

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

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenThemSPForm?.Invoke(this, EventArgs.Empty);
        }

        private void btnThemCTKhac_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenThemCTKhacForm?.Invoke(this, EventArgs.Empty);
        }

        private void btnThemBienThe_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenThemBienTheForm?.Invoke(this, EventArgs.Empty);
        }
        SanPhamService _SanphamService;
        BienTheService _BienTheService;
        List<Panel> panels = new List<Panel>();
        int sd = 0;
        int sc = 9;
        int st = 1;
        public Frm_SanPham()
        {
            InitializeComponent();
            _BienTheService = new BienTheService();
            _SanphamService = new SanPhamService();
            LoadSP(sd, sc);
            if (st < 2)
            {
                button1.Enabled = false;
            }
        }
        private void LoadSP(int sodau, int socuoi)
        {
            var lst = (from b in _SanphamService.GetSanPham(null)
                       join a in _BienTheService.GetBienThe(null)
                       on b.IdSanPham equals a.IdSanPham
                       group a by b into g
                       select new
                       {
                           Ten = g.Key.Ten,
                           Gia = g.Select(x => x.GiaTien).ToArray(),
                           SoLuong = g.Select(x => x.SoLuong).ToArray(),
                           Hinh = g.Select(x => x.HinhAnh).ToArray()
                       }).ToArray();
            if (txtSearch.Text != null)
            {
                lst = lst.Where(x => x.Ten.ToLower().Contains(txtSearch.Text.ToLower())).ToArray();
            }
            int d = 0;
            int cardWidth = 456; // Kích thước chiều rộng của card
            int cardHeight = 200; // Kích thước chiều cao của card
            int cardSpacingX = 60; // Khoảng cách giữa các card theo chiều ngang
            int cardSpacingY = 30; // Khoảng cách giữa các card theo chiều dọc
            int cardsPerRow = 3; // Số lượng card trên mỗi dòng
            int startX = this.Width - cardWidth - 90; // Vị trí x ban đầu, tính từ lề phải
            int startY = 150 + 45; // Vị trí y ban đầu, dịch xuống 45px
            int pictureOffsetX = 10; // Khoảng cách giữa PictureBox và thành phải của card
            int labelPriceOffsetY = 5; // Khoảng cách giữa Label giá và thành dưới của card
            int max = lst.Count() > socuoi ? socuoi : lst.Count();
            for (int i = sodau; i < max; i++)
            {
                if (i < lst.Count())
                {
                    int? Soluong = 0;
                    foreach (var x in lst[i].SoLuong)
                    {
                        Soluong += x;
                    }
                    var priceMin = (lst[i].Gia.Length > 0) ? lst[i].Gia.Min() : 0;
                    var priceMax = (lst[i].Gia.Length > 0) ? lst[i].Gia.Max() : 0;
                    Panel cardPanel = new Panel();
                    cardPanel.BackColor = Color.White;
                    cardPanel.BorderStyle = BorderStyle.FixedSingle;
                    cardPanel.Size = new Size(cardWidth, cardHeight);

                    int row = d / cardsPerRow;
                    int col = d % cardsPerRow;

                    int cardPosX = startX - col * (cardWidth + cardSpacingX);
                    int cardPosY = startY + row * (cardHeight + cardSpacingY);

                    cardPanel.Location = new Point(cardPosX, cardPosY);

                    Label lbl = new Label();
                    lbl.Text = lst[i].Ten;
                    lbl.Font = new Font(lbl.Font.FontFamily, 12, FontStyle.Bold);
                    lbl.Size = new Size(180, 60);
                    lbl.ForeColor = Color.CadetBlue;
                    lbl.Location = new Point(20, 20);

                    Label labelPrice = new Label();
                    if (priceMax > priceMin)
                    {
                        labelPrice.Text = "Giá: " + Convert.ToDecimal(priceMin).ToString("N0") + " - " + Convert.ToDecimal(priceMax).ToString("N0") + " VND";
                    }
                    else
                    {
                        labelPrice.Text = "Giá: " + Convert.ToDecimal(priceMin).ToString("N0") + " VND";
                    }
                    labelPrice.Font = new Font(labelPrice.Font.FontFamily, 10);
                    labelPrice.Size = new Size(360, 80);
                    labelPrice.ForeColor = Color.Red;
                    labelPrice.Location = new Point(20, cardHeight - labelPrice.Height - labelPriceOffsetY + 45); // Đặt vị trí cố định cho label

                    Label labelSoLuong = new Label();
                    labelSoLuong.Text = "Số lượng: " + Soluong;
                    labelSoLuong.Font = new Font(labelSoLuong.Font.FontFamily, 10);
                    labelSoLuong.Size = new Size(360, 40);
                    labelSoLuong.ForeColor = Color.YellowGreen;
                    labelSoLuong.Location = new Point(20, (cardHeight - labelPrice.Height - labelPriceOffsetY + 45) - labelSoLuong.Height + 5); // Đặt vị trí cố định cho label số lượng

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(190, 170);
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox.Location = new Point(cardWidth - pictureBox.Width - pictureOffsetX, 15); // Đặt vị trí cố định cho pictureBox
                    if (lst[i].Hinh[0] != null)
                    {
                        using (MemoryStream ms = new MemoryStream(lst[i].Hinh[0]))
                        {
                            Image img = Image.FromStream(ms);
                            pictureBox.Image = img;
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {
                        pictureBox.Image = null;
                    }

                    cardPanel.Controls.Add(lbl);
                    cardPanel.Controls.Add(labelPrice);
                    cardPanel.Controls.Add(labelSoLuong);
                    cardPanel.Controls.Add(pictureBox);
                    panels.Add(cardPanel);
                    this.Controls.Add(cardPanel);
                    cardPanel.BringToFront();
                    lbl.BringToFront();
                    labelPrice.BringToFront();
                    labelSoLuong.BringToFront();
                    pictureBox.BringToFront();
                    d++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lst = (from b in _SanphamService.GetSanPham(null)
                       join a in _BienTheService.GetBienThe(null)
                       on b.IdSanPham equals a.IdSanPham
                       group a by b into g
                       select new
                       {
                           Ten = g.Key.Ten,
                           Gia = g.Select(x => x.GiaTien).ToArray(),
                           Hinh = g.Select(x => x.HinhAnh).ToArray()
                       }).ToArray();
            if (lst.Count() > st * 9)
            {
                for (int i = 0; i < panels.Count; i++)
                {
                    this.Controls.Remove(panels[i]);
                }
                sd += 9;
                sc += 9;
                st += 1;
                if (st < 2)
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
                LoadSP(sd, sc);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < panels.Count; i++)
            {
                this.Controls.Remove(panels[i]);
            }
            if (st > 1)
            {
                sd -= 9;
                sc -= 9;
                st -= 1;
                if (st < 2)
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
                LoadSP(sd, sc);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < panels.Count; i++)
            {
                this.Controls.Remove(panels[i]);
            }
            LoadSP(sd, sc);
        }
    }
}
