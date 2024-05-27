namespace _3.PRL.Views.DangNhap
{
    partial class Frm_DangNhap2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DangNhap2));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnDangNhap = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(254, 254, 254);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(143, 74);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(576, 425);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng nhập vào App On-li Fans";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(498, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(240, 242, 245);
            textBox2.Location = new Point(85, 209);
            textBox2.Margin = new Padding(3, 7, 3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(413, 32);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(240, 242, 245);
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(85, 106);
            textBox1.Margin = new Padding(3, 7, 3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 32);
            textBox1.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.White;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.ForeColor = SystemColors.Highlight;
            btnDangNhap.Location = new Point(85, 312);
            btnDangNhap.Margin = new Padding(0);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Padding = new Padding(10);
            btnDangNhap.Size = new Size(413, 71);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 164);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // Frm_DangNhap2
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(862, 573);
            Controls.Add(groupBox1);
            Name = "Frm_DangNhap2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_DangNhap2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnDangNhap;
        private Label label2;
        private Label label1;
    }
}