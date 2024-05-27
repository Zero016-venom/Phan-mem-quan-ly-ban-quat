namespace _3.PRL.Views
{
    partial class Frm_TaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TaiKhoan));
            panel1 = new Panel();
            pbBack = new PictureBox();
            pbDangXuat = new PictureBox();
            panel2 = new Panel();
            panel9 = new Panel();
            pictureBox6 = new PictureBox();
            btnTaiKhoan = new Button();
            groupBox1 = new GroupBox();
            lbvt = new Label();
            lbtt = new Label();
            lbgt = new Label();
            lbdt = new Label();
            lbdc = new Label();
            lbns = new Label();
            lbten = new Label();
            label4 = new Label();
            lbtk = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox1.SuspendLayout();
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
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(btnTaiKhoan);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 893);
            panel2.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(183, 209, 255);
            panel9.Location = new Point(12, 71);
            panel9.Name = "panel9";
            panel9.Size = new Size(10, 64);
            panel9.TabIndex = 19;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(32, 71);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(64, 64);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.FlatAppearance.BorderSize = 0;
            btnTaiKhoan.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 209, 255);
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.ForeColor = Color.FromArgb(3, 43, 118);
            btnTaiKhoan.Location = new Point(106, 71);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(171, 64);
            btnTaiKhoan.TabIndex = 12;
            btnTaiKhoan.Text = "Tài khoản";
            btnTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbvt);
            groupBox1.Controls.Add(lbtt);
            groupBox1.Controls.Add(lbgt);
            groupBox1.Controls.Add(lbdt);
            groupBox1.Controls.Add(lbdc);
            groupBox1.Controls.Add(lbns);
            groupBox1.Controls.Add(lbten);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lbtk);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(286, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1206, 679);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // lbvt
            // 
            lbvt.AutoSize = true;
            lbvt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbvt.Location = new Point(187, 461);
            lbvt.Name = "lbvt";
            lbvt.Size = new Size(43, 25);
            lbvt.TabIndex = 18;
            lbvt.Text = "Mã:";
            // 
            // lbtt
            // 
            lbtt.AutoSize = true;
            lbtt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbtt.Location = new Point(187, 402);
            lbtt.Name = "lbtt";
            lbtt.Size = new Size(43, 25);
            lbtt.TabIndex = 17;
            lbtt.Text = "Mã:";
            // 
            // lbgt
            // 
            lbgt.AutoSize = true;
            lbgt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbgt.Location = new Point(187, 349);
            lbgt.Name = "lbgt";
            lbgt.Size = new Size(43, 25);
            lbgt.TabIndex = 16;
            lbgt.Text = "Mã:";
            // 
            // lbdt
            // 
            lbdt.AutoSize = true;
            lbdt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbdt.Location = new Point(187, 294);
            lbdt.Name = "lbdt";
            lbdt.Size = new Size(43, 25);
            lbdt.TabIndex = 15;
            lbdt.Text = "Mã:";
            // 
            // lbdc
            // 
            lbdc.AutoSize = true;
            lbdc.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbdc.Location = new Point(187, 246);
            lbdc.Name = "lbdc";
            lbdc.Size = new Size(43, 25);
            lbdc.TabIndex = 14;
            lbdc.Text = "Mã:";
            // 
            // lbns
            // 
            lbns.AutoSize = true;
            lbns.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbns.Location = new Point(187, 187);
            lbns.Name = "lbns";
            lbns.Size = new Size(43, 25);
            lbns.TabIndex = 13;
            lbns.Text = "Mã:";
            // 
            // lbten
            // 
            lbten.AutoSize = true;
            lbten.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbten.Location = new Point(187, 131);
            lbten.Name = "lbten";
            lbten.Size = new Size(43, 25);
            lbten.TabIndex = 12;
            lbten.Text = "Mã:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(63, 246);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 10;
            label4.Text = "Địa chỉ:";
            // 
            // lbtk
            // 
            lbtk.AutoSize = true;
            lbtk.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbtk.Location = new Point(430, 47);
            lbtk.Name = "lbtk";
            lbtk.Size = new Size(53, 38);
            lbtk.TabIndex = 9;
            lbtk.Text = "AS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(63, 461);
            label8.Name = "label8";
            label8.Size = new Size(73, 25);
            label8.TabIndex = 7;
            label8.Text = "Vai Trò:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(63, 402);
            label7.Name = "label7";
            label7.Size = new Size(100, 25);
            label7.TabIndex = 6;
            label7.Text = "Trạng thái:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(63, 349);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 5;
            label6.Text = "Giới tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(63, 294);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 4;
            label5.Text = "SĐT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 187);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 2;
            label3.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 131);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên:";
            // 
            // Frm_TaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1882, 953);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_TaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_TaiKhoan";
            WindowState = FormWindowState.Maximized;
            Load += Frm_TaiKhoan_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDangXuat).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbBack;
        private PictureBox pbDangXuat;
        private Panel panel2;
        private Panel panel9;
        private PictureBox pictureBox6;
        private Button btnTaiKhoan;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label lbtk;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lbvt;
        private Label lbtt;
        private Label lbgt;
        private Label lbdt;
        private Label lbdc;
        private Label lbns;
        private Label lbten;
        private Label lbma;
    }
}