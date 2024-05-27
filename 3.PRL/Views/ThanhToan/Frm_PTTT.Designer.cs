namespace _3.PRL.Views.ThanhToan
{
    partial class Frm_PTTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PTTT));
            panel1 = new Panel();
            pbBack = new PictureBox();
            pbDangXuat = new PictureBox();
            groupBox1 = new GroupBox();
            txtTenPTTT = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSuaPTTT = new Button();
            btnThemPTTT = new Button();
            groupBox3 = new GroupBox();
            dgvDSPTTT = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSPTTT).BeginInit();
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
            panel1.Size = new Size(857, 60);
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
            groupBox1.Controls.Add(txtTenPTTT);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(583, 159);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin ";
            // 
            // txtTenPTTT
            // 
            txtTenPTTT.Location = new Point(133, 69);
            txtTenPTTT.Name = "txtTenPTTT";
            txtTenPTTT.Size = new Size(377, 32);
            txtTenPTTT.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 76);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSuaPTTT);
            groupBox2.Controls.Add(btnThemPTTT);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(613, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 159);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnSuaPTTT
            // 
            btnSuaPTTT.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuaPTTT.ForeColor = SystemColors.Highlight;
            btnSuaPTTT.Location = new Point(24, 105);
            btnSuaPTTT.Name = "btnSuaPTTT";
            btnSuaPTTT.Size = new Size(172, 48);
            btnSuaPTTT.TabIndex = 37;
            btnSuaPTTT.Text = "Sửa PTTT";
            btnSuaPTTT.UseVisualStyleBackColor = true;
            btnSuaPTTT.Click += btnSuaPTTT_Click;
            // 
            // btnThemPTTT
            // 
            btnThemPTTT.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemPTTT.ForeColor = SystemColors.Highlight;
            btnThemPTTT.Location = new Point(24, 31);
            btnThemPTTT.Name = "btnThemPTTT";
            btnThemPTTT.Size = new Size(172, 52);
            btnThemPTTT.TabIndex = 36;
            btnThemPTTT.Text = "Thêm PTTT";
            btnThemPTTT.UseVisualStyleBackColor = true;
            btnThemPTTT.Click += btnThemPTTT_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvDSPTTT);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(16, 240);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(829, 303);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách phương thức thanh toán";
            // 
            // dgvDSPTTT
            // 
            dgvDSPTTT.BackgroundColor = Color.DodgerBlue;
            dgvDSPTTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSPTTT.Location = new Point(6, 31);
            dgvDSPTTT.Name = "dgvDSPTTT";
            dgvDSPTTT.RowHeadersWidth = 51;
            dgvDSPTTT.RowTemplate.Height = 29;
            dgvDSPTTT.Size = new Size(819, 266);
            dgvDSPTTT.TabIndex = 0;
            dgvDSPTTT.CellClick += dgvDSPTTT_CellClick;
            // 
            // Frm_PTTT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(857, 554);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Frm_PTTT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_PTTT";
            Load += Frm_PTTT_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSPTTT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbBack;
        private PictureBox pbDangXuat;
        private GroupBox groupBox1;
        private TextBox txtTenPTTT;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnSuaPTTT;
        private Button btnThemPTTT;
        private DataGridView dgvDSPTTT;
    }
}