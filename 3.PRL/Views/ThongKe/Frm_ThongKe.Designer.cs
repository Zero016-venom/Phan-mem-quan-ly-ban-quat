namespace _3.PRL.Views.ThongKe
{
    partial class Frm_ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThongKe));
            panel1 = new Panel();
            pbBack = new PictureBox();
            pbDangXuat = new PictureBox();
            panel2 = new Panel();
            panel7 = new Panel();
            pictureBox7 = new PictureBox();
            btnThanhToan = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            label3 = new Label();
            groupBox3 = new GroupBox();
            txtDT = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            dgvThongKe = new DataGridView();
            groupBox5 = new GroupBox();
            btnThongKe = new Button();
            rdbTatCa = new RadioButton();
            rdbSanPham = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            groupBox5.SuspendLayout();
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(btnThanhToan);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 893);
            panel2.TabIndex = 22;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(183, 209, 255);
            panel7.Location = new Point(8, 67);
            panel7.Name = "panel7";
            panel7.Size = new Size(18, 64);
            panel7.TabIndex = 21;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(32, 67);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(64, 64);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // btnThanhToan
            // 
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.ForeColor = Color.FromArgb(3, 43, 118);
            btnThanhToan.Location = new Point(106, 67);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(171, 64);
            btnThanhToan.TabIndex = 15;
            btnThanhToan.Text = "Thống kê";
            btnThanhToan.TextAlign = ContentAlignment.MiddleLeft;
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 61);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 27;
            label1.Text = "Từ Ngày";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDenNgay);
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(286, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1165, 109);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn ngày";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDenNgay.Location = new Point(697, 46);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(274, 38);
            dtpDenNgay.TabIndex = 37;
            dtpDenNgay.ValueChanged += dtpDenNgay_ValueChanged;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTuNgay.Location = new Point(149, 46);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(274, 38);
            dtpTuNgay.TabIndex = 36;
            dtpTuNgay.ValueChanged += dtpTuNgay_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(600, 61);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 35;
            label3.Text = "Đến Ngày";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDT);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(286, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1584, 636);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thống Kê";
            // 
            // txtDT
            // 
            txtDT.ForeColor = Color.Red;
            txtDT.Location = new Point(386, 65);
            txtDT.Name = "txtDT";
            txtDT.Size = new Size(355, 41);
            txtDT.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 68);
            label4.Name = "label4";
            label4.Size = new Size(143, 35);
            label4.TabIndex = 1;
            label4.Text = "Doanh Thu";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvThongKe);
            groupBox4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(6, 144);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1572, 486);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            // 
            // dgvThongKe
            // 
            dgvThongKe.AllowUserToAddRows = false;
            dgvThongKe.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(0, 12);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersVisible = false;
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.RowTemplate.Height = 29;
            dgvThongKe.Size = new Size(1572, 578);
            dgvThongKe.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnThongKe);
            groupBox5.Controls.Add(rdbTatCa);
            groupBox5.Controls.Add(rdbSanPham);
            groupBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(286, 181);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1165, 130);
            groupBox5.TabIndex = 33;
            groupBox5.TabStop = false;
            groupBox5.Text = "Doanh thu";
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.Highlight;
            btnThongKe.Cursor = Cursors.Hand;
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(746, 49);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(147, 57);
            btnThongKe.TabIndex = 27;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // rdbTatCa
            // 
            rdbTatCa.AutoSize = true;
            rdbTatCa.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rdbTatCa.Location = new Point(86, 65);
            rdbTatCa.Name = "rdbTatCa";
            rdbTatCa.Size = new Size(86, 29);
            rdbTatCa.TabIndex = 23;
            rdbTatCa.TabStop = true;
            rdbTatCa.Text = "Tất Cả";
            rdbTatCa.UseVisualStyleBackColor = true;
            // 
            // rdbSanPham
            // 
            rdbSanPham.AutoSize = true;
            rdbSanPham.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rdbSanPham.Location = new Point(404, 65);
            rdbSanPham.Name = "rdbSanPham";
            rdbSanPham.Size = new Size(164, 29);
            rdbSanPham.TabIndex = 24;
            rdbSanPham.TabStop = true;
            rdbSanPham.Text = "Theo Sản Phẩm";
            rdbSanPham.UseVisualStyleBackColor = true;
            // 
            // Frm_ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1882, 953);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_ThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_ThongKe";
            WindowState = FormWindowState.Maximized;
            Load += Frm_ThongKe_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbBack;
        private PictureBox pbDangXuat;
        private Panel panel2;
        private Panel panel7;
        private PictureBox pictureBox7;
        private Button btnThanhToan;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dgvThongKe;
        private Label label3;
        private GroupBox groupBox5;
        private Button btnThongKe;
        private RadioButton rdbTatCa;
        private RadioButton rdbSanPham;
        private TextBox txtDT;
        private Label label4;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
    }
}