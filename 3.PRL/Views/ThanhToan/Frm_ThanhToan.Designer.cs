namespace _3.PRL.Views.ThanhToan
{
    partial class Frm_ThanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThanhToan));
            panel1 = new Panel();
            pbBack = new PictureBox();
            pbDangXuat = new PictureBox();
            groupBox1 = new GroupBox();
            dtpNgayTT = new DateTimePicker();
            label6 = new Label();
            txtKhachDua = new TextBox();
            label5 = new Label();
            txtTienTraLai = new TextBox();
            label15 = new Label();
            cmbPTTT = new ComboBox();
            label14 = new Label();
            txtTienPhaiThanhToan = new TextBox();
            label13 = new Label();
            cmbMaHD = new ComboBox();
            label12 = new Label();
            cmbVanChuyen = new ComboBox();
            label1 = new Label();
            cmbKhachHang = new ComboBox();
            label2 = new Label();
            cmbNhanVien = new ComboBox();
            dtpNgayTao = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            btnTT = new Button();
            dgvSPMua = new DataGridView();
            groupBox2 = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSPMua).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 99, 223);
            panel1.Controls.Add(pbBack);
            panel1.Controls.Add(pbDangXuat);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1882, 60);
            panel1.TabIndex = 5;
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(106, 7);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(50, 50);
            pbBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBack.TabIndex = 2;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // pbDangXuat
            // 
            pbDangXuat.Cursor = Cursors.Hand;
            pbDangXuat.Image = (Image)resources.GetObject("pbDangXuat.Image");
            pbDangXuat.Location = new Point(32, 7);
            pbDangXuat.Name = "pbDangXuat";
            pbDangXuat.Size = new Size(50, 50);
            pbDangXuat.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDangXuat.TabIndex = 0;
            pbDangXuat.TabStop = false;
            pbDangXuat.Click += pbDangXuat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayTT);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtKhachDua);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTienTraLai);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(cmbPTTT);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtTienPhaiThanhToan);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(cmbMaHD);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cmbVanChuyen);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbKhachHang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbNhanVien);
            groupBox1.Controls.Add(dtpNgayTao);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1858, 367);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Hóa đơn ";
            // 
            // dtpNgayTT
            // 
            dtpNgayTT.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTT.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTT.Location = new Point(1165, 57);
            dtpNgayTT.Name = "dtpNgayTT";
            dtpNgayTT.Size = new Size(289, 32);
            dtpNgayTT.TabIndex = 81;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(915, 57);
            label6.Name = "label6";
            label6.Size = new Size(153, 25);
            label6.TabIndex = 80;
            label6.Text = "Ngày thanh toán";
            // 
            // txtKhachDua
            // 
            txtKhachDua.Location = new Point(1165, 233);
            txtKhachDua.Name = "txtKhachDua";
            txtKhachDua.Size = new Size(289, 32);
            txtKhachDua.TabIndex = 79;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(915, 234);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 78;
            label5.Text = "Khách đưa";
            // 
            // txtTienTraLai
            // 
            txtTienTraLai.Enabled = false;
            txtTienTraLai.Location = new Point(1165, 289);
            txtTienTraLai.Name = "txtTienTraLai";
            txtTienTraLai.Size = new Size(289, 32);
            txtTienTraLai.TabIndex = 77;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(915, 293);
            label15.Name = "label15";
            label15.Size = new Size(101, 25);
            label15.TabIndex = 76;
            label15.Text = "Tiền trả lại";
            // 
            // cmbPTTT
            // 
            cmbPTTT.FormattingEnabled = true;
            cmbPTTT.Location = new Point(1165, 176);
            cmbPTTT.Name = "cmbPTTT";
            cmbPTTT.Size = new Size(289, 33);
            cmbPTTT.TabIndex = 75;
            cmbPTTT.SelectedIndexChanged += cmbPTTT_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(915, 175);
            label14.Name = "label14";
            label14.Size = new Size(217, 25);
            label14.TabIndex = 74;
            label14.Text = "Phương thức thanh toán";
            // 
            // txtTienPhaiThanhToan
            // 
            txtTienPhaiThanhToan.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtTienPhaiThanhToan.ForeColor = Color.Red;
            txtTienPhaiThanhToan.Location = new Point(1165, 113);
            txtTienPhaiThanhToan.Name = "txtTienPhaiThanhToan";
            txtTienPhaiThanhToan.Size = new Size(289, 39);
            txtTienPhaiThanhToan.TabIndex = 73;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(915, 116);
            label13.Name = "label13";
            label13.Size = new Size(193, 25);
            label13.TabIndex = 72;
            label13.Text = "Tiền Phải Thanh Toán";
            // 
            // cmbMaHD
            // 
            cmbMaHD.FormattingEnabled = true;
            cmbMaHD.Location = new Point(209, 49);
            cmbMaHD.Name = "cmbMaHD";
            cmbMaHD.Size = new Size(193, 33);
            cmbMaHD.TabIndex = 71;
            cmbMaHD.SelectedIndexChanged += cmbMaHD_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(44, 52);
            label12.Name = "label12";
            label12.Size = new Size(70, 25);
            label12.TabIndex = 70;
            label12.Text = "Mã HD";
            // 
            // cmbVanChuyen
            // 
            cmbVanChuyen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbVanChuyen.FormattingEnabled = true;
            cmbVanChuyen.Location = new Point(209, 286);
            cmbVanChuyen.Name = "cmbVanChuyen";
            cmbVanChuyen.Size = new Size(380, 33);
            cmbVanChuyen.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 294);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 32;
            label1.Text = "Phí vận chuyển";
            // 
            // cmbKhachHang
            // 
            cmbKhachHang.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbKhachHang.FormattingEnabled = true;
            cmbKhachHang.Location = new Point(209, 230);
            cmbKhachHang.Name = "cmbKhachHang";
            cmbKhachHang.Size = new Size(378, 33);
            cmbKhachHang.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 233);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 30;
            label2.Text = "Khách hàng";
            // 
            // cmbNhanVien
            // 
            cmbNhanVien.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbNhanVien.FormattingEnabled = true;
            cmbNhanVien.Location = new Point(209, 168);
            cmbNhanVien.Name = "cmbNhanVien";
            cmbNhanVien.Size = new Size(380, 33);
            cmbNhanVien.TabIndex = 29;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTao.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTao.Location = new Point(209, 113);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(380, 32);
            dtpNgayTao.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 119);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 27;
            label4.Text = "Ngày tạo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 177);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 26;
            label3.Text = "Nhân viên";
            // 
            // btnTT
            // 
            btnTT.BackColor = Color.DeepSkyBlue;
            btnTT.Cursor = Cursors.Hand;
            btnTT.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnTT.ForeColor = Color.White;
            btnTT.Location = new Point(1671, 851);
            btnTT.Name = "btnTT";
            btnTT.Size = new Size(188, 54);
            btnTT.TabIndex = 39;
            btnTT.Text = "THANH TOÁN";
            btnTT.UseVisualStyleBackColor = false;
            btnTT.Click += btnTT_Click;
            // 
            // dgvSPMua
            // 
            dgvSPMua.BackgroundColor = SystemColors.ControlLightLight;
            dgvSPMua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSPMua.Location = new Point(8, 31);
            dgvSPMua.Name = "dgvSPMua";
            dgvSPMua.RowHeadersWidth = 51;
            dgvSPMua.RowTemplate.Height = 29;
            dgvSPMua.Size = new Size(1838, 289);
            dgvSPMua.TabIndex = 40;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSPMua);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(24, 482);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1858, 326);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Sản Phẩm";
            // 
            // Frm_ThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1882, 1053);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(btnTT);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Frm_ThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_ThanhToan";
            WindowState = FormWindowState.Maximized;
            Load += Frm_ThanhToan_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSPMua).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbBack;
        private PictureBox pbDangXuat;
        private GroupBox groupBox1;
        private Button btnTT;
        private ComboBox cmbVanChuyen;
        private Label label1;
        private ComboBox cmbKhachHang;
        private Label label2;
        private ComboBox cmbNhanVien;
        private DateTimePicker dtpNgayTao;
        private Label label4;
        private Label label3;
        private ComboBox cmbMaHD;
        private Label label12;
        private TextBox txtTienPhaiThanhToan;
        private Label label13;
        private ComboBox cmbPTTT;
        private Label label14;
        private TextBox txtTienTraLai;
        private Label label15;
        private DataGridView dgvSPMua;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtKhachDua;
        private DateTimePicker dtpNgayTT;
        private Label label6;
    }
}