namespace _3.PRL.Views.ThanhToan
{
    partial class FrmLichSuTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLichSuTT));
            panel1 = new Panel();
            pbBack = new PictureBox();
            pbDangXuat = new PictureBox();
            dgvLSTT = new DataGridView();
            groupBox1 = new GroupBox();
            dtpNgayTT = new DateTimePicker();
            txtTien = new TextBox();
            txtPTTT = new TextBox();
            txtMaHD = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLSTT).BeginInit();
            groupBox1.SuspendLayout();
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
            panel1.Size = new Size(982, 60);
            panel1.TabIndex = 6;
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
            // dgvLSTT
            // 
            dgvLSTT.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvLSTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLSTT.Location = new Point(12, 324);
            dgvLSTT.Name = "dgvLSTT";
            dgvLSTT.RowHeadersWidth = 51;
            dgvLSTT.RowTemplate.Height = 29;
            dgvLSTT.Size = new Size(958, 329);
            dgvLSTT.TabIndex = 7;
            dgvLSTT.CellClick += dgvLSTT_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayTT);
            groupBox1.Controls.Add(txtTien);
            groupBox1.Controls.Add(txtPTTT);
            groupBox1.Controls.Add(txtMaHD);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(958, 241);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // dtpNgayTT
            // 
            dtpNgayTT.Enabled = false;
            dtpNgayTT.Location = new Point(203, 145);
            dtpNgayTT.Name = "dtpNgayTT";
            dtpNgayTT.Size = new Size(252, 32);
            dtpNgayTT.TabIndex = 8;
            // 
            // txtTien
            // 
            txtTien.Enabled = false;
            txtTien.Location = new Point(692, 142);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(233, 32);
            txtTien.TabIndex = 7;
            // 
            // txtPTTT
            // 
            txtPTTT.Enabled = false;
            txtPTTT.Location = new Point(692, 63);
            txtPTTT.Name = "txtPTTT";
            txtPTTT.Size = new Size(233, 32);
            txtPTTT.TabIndex = 6;
            // 
            // txtMaHD
            // 
            txtMaHD.Enabled = false;
            txtMaHD.Location = new Point(203, 63);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(252, 32);
            txtMaHD.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(537, 149);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 3;
            label4.Text = "Tổng tiền TT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(537, 63);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 2;
            label3.Text = "Phương thức TT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 145);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 1;
            label2.Text = "Ngày Thanh Toán";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 66);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã HD";
            // 
            // FrmLichSuTT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 669);
            Controls.Add(groupBox1);
            Controls.Add(dgvLSTT);
            Controls.Add(panel1);
            Name = "FrmLichSuTT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLichSuTT";
            Load += FrmLichSuTT_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLSTT).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbBack;
        private PictureBox pbDangXuat;
        private DataGridView dgvLSTT;
        private GroupBox groupBox1;
        private DateTimePicker dtpNgayTT;
        private TextBox txtTien;
        private TextBox txtPTTT;
        private TextBox txtMaHD;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}