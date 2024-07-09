using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class DangNhapForm
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
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnDangNhap = new Button();
            btnDangKi = new Button();
            btnThoat = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 133);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(519, 263);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng nhập";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(62, 151);
            txtMatKhau.Margin = new Padding(4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(430, 23);
            txtMatKhau.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(62, 85);
            txtTenDangNhap.Margin = new Padding(4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(430, 23);
            txtTenDangNhap.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(24, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.Location = new Point(24, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 46);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(255, 192, 255);
            btnDangNhap.Location = new Point(349, 209);
            btnDangNhap.Margin = new Padding(4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(143, 46);
            btnDangNhap.TabIndex = 1;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnDangKi
            // 
            btnDangKi.BackColor = Color.FromArgb(255, 192, 255);
            btnDangKi.Location = new Point(209, 414);
            btnDangKi.Margin = new Padding(4);
            btnDangKi.Name = "btnDangKi";
            btnDangKi.Size = new Size(143, 28);
            btnDangKi.TabIndex = 3;
            btnDangKi.Text = "Đăng kí";
            btnDangKi.UseVisualStyleBackColor = false;
            btnDangKi.Click += btnDangKi_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 192, 255);
            btnThoat.Location = new Point(371, 414);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(143, 28);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(98, 57);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(381, 50);
            label3.TabIndex = 5;
            label3.Text = "ĐĂNG NHẬP VÀO HỆ THỐNG";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // DangNhapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(553, 454);
            Controls.Add(label3);
            Controls.Add(btnThoat);
            Controls.Add(btnDangKi);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "DangNhapForm";
            Text = "DangNhapForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangKi;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox groupBox1;

    }
}