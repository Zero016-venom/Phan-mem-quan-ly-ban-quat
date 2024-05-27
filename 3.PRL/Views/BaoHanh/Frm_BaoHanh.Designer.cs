namespace _3.PRL.Views
{
    partial class Frm_BaoHanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BaoHanh));
            panel1 = new Panel();
            pbBack = new PictureBox();
            pbDangXuat = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            btnTaoPhieuBH = new Button();
            btnBaoHanh = new Button();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnKhachHang = new Button();
            panel7 = new Panel();
            panel10 = new Panel();
            dgvDSBaoHanh = new DataGridView();
            pictureBox9 = new PictureBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSBaoHanh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
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
            panel1.TabIndex = 2;
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
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(btnTaoPhieuBH);
            panel2.Controls.Add(btnBaoHanh);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnKhachHang);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 893);
            panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(38, 320);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(15, 17);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // btnTaoPhieuBH
            // 
            btnTaoPhieuBH.BackColor = Color.White;
            btnTaoPhieuBH.FlatAppearance.BorderSize = 0;
            btnTaoPhieuBH.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnTaoPhieuBH.FlatStyle = FlatStyle.Flat;
            btnTaoPhieuBH.ForeColor = Color.FromArgb(3, 43, 118);
            btnTaoPhieuBH.Location = new Point(59, 295);
            btnTaoPhieuBH.Name = "btnTaoPhieuBH";
            btnTaoPhieuBH.Size = new Size(218, 64);
            btnTaoPhieuBH.TabIndex = 23;
            btnTaoPhieuBH.Text = "Tạo phiếu bảo hành";
            btnTaoPhieuBH.TextAlign = ContentAlignment.MiddleLeft;
            btnTaoPhieuBH.UseVisualStyleBackColor = false;
            btnTaoPhieuBH.Click += btnTaoPhieuBH_Click;
            // 
            // btnBaoHanh
            // 
            btnBaoHanh.FlatAppearance.BorderSize = 0;
            btnBaoHanh.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnBaoHanh.FlatStyle = FlatStyle.Flat;
            btnBaoHanh.ForeColor = Color.FromArgb(3, 43, 118);
            btnBaoHanh.Location = new Point(106, 51);
            btnBaoHanh.Name = "btnBaoHanh";
            btnBaoHanh.Size = new Size(171, 64);
            btnBaoHanh.TabIndex = 22;
            btnBaoHanh.Text = "Bảo hành";
            btnBaoHanh.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoHanh.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(32, 51);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(64, 64);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
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
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.FromArgb(183, 209, 255);
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.ForeColor = Color.FromArgb(3, 43, 118);
            btnKhachHang.Location = new Point(59, 160);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(218, 64);
            btnKhachHang.TabIndex = 15;
            btnKhachHang.Text = "Danh sách bảo hành";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(183, 209, 255);
            panel7.Location = new Point(12, 51);
            panel7.Name = "panel7";
            panel7.Size = new Size(18, 64);
            panel7.TabIndex = 13;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(dgvDSBaoHanh);
            panel10.Controls.Add(pictureBox9);
            panel10.Controls.Add(textBox1);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(280, 60);
            panel10.Name = "panel10";
            panel10.Size = new Size(1602, 893);
            panel10.TabIndex = 4;
           
            // 
            // dgvDSBaoHanh
            // 
            dgvDSBaoHanh.BackgroundColor = SystemColors.ActiveCaption;
            dgvDSBaoHanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSBaoHanh.GridColor = SystemColors.ActiveCaption;
            dgvDSBaoHanh.Location = new Point(6, 160);
            dgvDSBaoHanh.Name = "dgvDSBaoHanh";
            dgvDSBaoHanh.RowHeadersWidth = 51;
            dgvDSBaoHanh.RowTemplate.Height = 29;
            dgvDSBaoHanh.Size = new Size(1593, 730);
            dgvDSBaoHanh.TabIndex = 10;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(559, 65);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(44, 34);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 9;
            pictureBox9.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(79, 65);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm mã hóa đơn...";
            textBox1.Size = new Size(474, 34);
            textBox1.TabIndex = 5;
            // 
            // Frm_BaoHanh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1882, 953);
            Controls.Add(panel10);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_BaoHanh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_BaoHanh";
            WindowState = FormWindowState.Maximized;
            Load += Frm_BaoHanh_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSBaoHanh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbBack;
        private PictureBox pbDangXuat;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button btnKhachHang;
        private Panel panel7;
        private Panel panel10;
        private PictureBox pictureBox9;
        private TextBox textBox1;
        private Button btnBaoHanh;
        private PictureBox pictureBox5;
        private DataGridView dgvDSBaoHanh;
        private PictureBox pictureBox3;
        private Button btnTaoPhieuBH;
    }
}