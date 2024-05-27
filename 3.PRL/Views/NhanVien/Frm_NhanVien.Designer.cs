namespace _3.PRL.Views
{
    partial class Frm_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NhanVien));
            panel1 = new Panel();
            pbBack = new PictureBox();
            pbDangXuat = new PictureBox();
            panel2 = new Panel();
            btnNhanVien = new Button();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnDSNV = new Button();
            panel7 = new Panel();
            dgvDSKH = new DataGridView();
            dgvNhanVien = new DataGridView();
            groupBox1 = new GroupBox();
            dtpNgaySinh = new DateTimePicker();
            groupBox3 = new GroupBox();
            rbtnNu = new RadioButton();
            rbtnNam = new RadioButton();
            rbtnNO = new RadioButton();
            rbtnYES = new RadioButton();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtTenNV = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSua = new Button();
            btnThem = new Button();
            txtTimNV = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSKH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 99, 223);
            panel1.Controls.Add(pbBack);
            panel1.Controls.Add(pbDangXuat);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1882, 60);
            panel1.TabIndex = 3;
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(106, 7);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(50, 50);
            pbBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBack.TabIndex = 1;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnNhanVien);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnDSNV);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 893);
            panel2.TabIndex = 4;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.ForeColor = Color.FromArgb(3, 43, 118);
            btnNhanVien.Location = new Point(106, 51);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(171, 64);
            btnNhanVien.TabIndex = 21;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(32, 51);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(38, 185);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 17);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // btnDSNV
            // 
            btnDSNV.BackColor = Color.FromArgb(183, 209, 255);
            btnDSNV.FlatAppearance.BorderSize = 0;
            btnDSNV.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnDSNV.FlatStyle = FlatStyle.Flat;
            btnDSNV.ForeColor = Color.FromArgb(3, 43, 118);
            btnDSNV.Location = new Point(59, 160);
            btnDSNV.Name = "btnDSNV";
            btnDSNV.Size = new Size(217, 64);
            btnDSNV.TabIndex = 15;
            btnDSNV.Text = "Danh sách nhân viên";
            btnDSNV.TextAlign = ContentAlignment.MiddleLeft;
            btnDSNV.UseVisualStyleBackColor = false;
            btnDSNV.Click += btnDSNV_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(183, 209, 255);
            panel7.Location = new Point(12, 51);
            panel7.Name = "panel7";
            panel7.Size = new Size(18, 64);
            panel7.TabIndex = 13;
            // 
            // dgvDSKH
            // 
            dgvDSKH.BackgroundColor = Color.WhiteSmoke;
            dgvDSKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSKH.GridColor = Color.LightGray;
            dgvDSKH.Location = new Point(280, 220);
            dgvDSKH.Name = "dgvDSKH";
            dgvDSKH.RowHeadersWidth = 51;
            dgvDSKH.RowTemplate.Height = 29;
            dgvDSKH.Size = new Size(1602, 861);
            dgvDSKH.TabIndex = 5;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(280, 220);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 29;
            dgvNhanVien.Size = new Size(1602, 344);
            dgvNhanVien.TabIndex = 22;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(rbtnNO);
            groupBox1.Controls.Add(rbtnYES);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(292, 570);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1206, 291);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(191, 155);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(364, 32);
            dtpNgaySinh.TabIndex = 28;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbtnNu);
            groupBox3.Controls.Add(rbtnNam);
            groupBox3.Location = new Point(695, 171);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(483, 39);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Giới tính";
            // 
            // rbtnNu
            // 
            rbtnNu.AutoSize = true;
            rbtnNu.Location = new Point(299, 0);
            rbtnNu.Name = "rbtnNu";
            rbtnNu.Size = new Size(58, 29);
            rbtnNu.TabIndex = 15;
            rbtnNu.TabStop = true;
            rbtnNu.Text = "Nữ";
            rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            rbtnNam.AutoSize = true;
            rbtnNam.Location = new Point(116, 0);
            rbtnNam.Name = "rbtnNam";
            rbtnNam.Size = new Size(73, 29);
            rbtnNam.TabIndex = 14;
            rbtnNam.TabStop = true;
            rbtnNam.Text = "Nam";
            rbtnNam.UseVisualStyleBackColor = true;
            // 
            // rbtnNO
            // 
            rbtnNO.AutoSize = true;
            rbtnNO.Location = new Point(994, 240);
            rbtnNO.Name = "rbtnNO";
            rbtnNO.Size = new Size(171, 29);
            rbtnNO.TabIndex = 14;
            rbtnNO.TabStop = true;
            rbtnNO.Text = "Dừng hoạt động";
            rbtnNO.UseVisualStyleBackColor = true;
            // 
            // rbtnYES
            // 
            rbtnYES.AutoSize = true;
            rbtnYES.Location = new Point(811, 240);
            rbtnYES.Name = "rbtnYES";
            rbtnYES.Size = new Size(122, 29);
            rbtnYES.TabIndex = 13;
            rbtnYES.TabStop = true;
            rbtnYES.Text = "Hoạt động";
            rbtnYES.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(814, 86);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(364, 32);
            txtDiaChi.TabIndex = 10;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(191, 235);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(364, 32);
            txtSDT.TabIndex = 8;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(191, 83);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(364, 32);
            txtTenNV.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(695, 89);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 5;
            label6.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(695, 242);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 3;
            label4.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 238);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 2;
            label3.Text = "SDT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 162);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 86);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(1498, 570);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 291);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = SystemColors.Highlight;
            btnSua.Location = new Point(6, 188);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(360, 75);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.Highlight;
            btnThem.Location = new Point(6, 54);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(360, 75);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTimNV
            // 
            txtTimNV.Location = new Point(374, 173);
            txtTimNV.Name = "txtTimNV";
            txtTimNV.PlaceholderText = "Nhập tên nhân viên để tìm kiếm...";
            txtTimNV.Size = new Size(674, 27);
            txtTimNV.TabIndex = 26;
            txtTimNV.TextChanged += txtTimNV_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(288, 180);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 25;
            label7.Text = "Tìm kiếm";
            // 
            // Frm_NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1882, 953);
            Controls.Add(txtTimNV);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvNhanVien);
            Controls.Add(dgvDSKH);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_NhanVien";
            WindowState = FormWindowState.Maximized;
            Load += Frm_NhanVien_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSKH).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pbBack;
        private PictureBox pbDangXuat;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button btnDSNV;
        private Panel panel7;
        private DataGridView dgvDSKH;
        private Button btnNhanVien;
        private PictureBox pictureBox4;
        private DataGridView dgvNhanVien;
        private GroupBox groupBox1;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtTenNV;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTimNV;
        private Label label7;
        private RadioButton rbtnNO;
        private RadioButton rbtnYES;
        private GroupBox groupBox3;
        private RadioButton rbtnNu;
        private RadioButton rbtnNam;
        private DateTimePicker dtpNgaySinh;
    }
}