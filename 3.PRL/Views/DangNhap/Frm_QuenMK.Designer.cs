namespace _3.PRL.Views.DangNhap
{
    partial class Frm_QuenMK
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(210, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 276);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quên mật khẩu?";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(59, 184);
            button1.Name = "button1";
            button1.Size = new Size(332, 55);
            button1.TabIndex = 2;
            button1.Text = "Tiếp tục";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(240, 242, 245);
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(59, 116);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "vidu@gmail.com";
            textBox1.Size = new Size(332, 36);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 0;
            label1.Text = "Email của bạn";
            // 
            // Frm_QuenMKcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(870, 573);
            Controls.Add(groupBox1);
            Name = "Frm_QuenMKcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_QuenMKcs";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}