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
            btnQuenMatKhau = new Button();
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
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 142);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(593, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng nhập";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(71, 185);
            txtMatKhau.Margin = new Padding(4, 4, 4, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(491, 23);
            txtMatKhau.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(71, 91);
            txtTenDangNhap.Margin = new Padding(4, 4, 4, 4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(491, 23);
            txtTenDangNhap.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(27, 146);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 49);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.Location = new Point(27, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 49);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(255, 192, 255);
            btnDangNhap.Location = new Point(699, 142);
            btnDangNhap.Margin = new Padding(4, 4, 4, 4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(163, 49);
            btnDangNhap.TabIndex = 1;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnQuenMatKhau
            // 
            btnQuenMatKhau.BackColor = Color.FromArgb(255, 192, 255);
            btnQuenMatKhau.Location = new Point(699, 219);
            btnQuenMatKhau.Margin = new Padding(4, 4, 4, 4);
            btnQuenMatKhau.Name = "btnQuenMatKhau";
            btnQuenMatKhau.Size = new Size(163, 49);
            btnQuenMatKhau.TabIndex = 2;
            btnQuenMatKhau.Text = "Quên mật khẩu";
            btnQuenMatKhau.UseVisualStyleBackColor = false;
            btnQuenMatKhau.Click += btnQuenMatKhau_Click;
            // 
            // btnDangKi
            // 
            btnDangKi.BackColor = Color.FromArgb(255, 192, 255);
            btnDangKi.Location = new Point(699, 302);
            btnDangKi.Margin = new Padding(4, 4, 4, 4);
            btnDangKi.Name = "btnDangKi";
            btnDangKi.Size = new Size(163, 49);
            btnDangKi.TabIndex = 3;
            btnDangKi.Text = "Đăng kí";
            btnDangKi.UseVisualStyleBackColor = false;
            btnDangKi.Click += btnDangKi_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 192, 255);
            btnThoat.Location = new Point(699, 373);
            btnThoat.Margin = new Padding(4, 4, 4, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(163, 49);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(40, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(741, 92);
            label3.TabIndex = 5;
            label3.Text = "ĐĂNG NHẬP VÀO HỆ THỐNG";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // DangNhapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(896, 486);
            Controls.Add(label3);
            Controls.Add(btnThoat);
            Controls.Add(btnDangKi);
            Controls.Add(btnQuenMatKhau);
            Controls.Add(btnDangNhap);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnQuenMatKhau;
        private System.Windows.Forms.Button btnDangKi;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox groupBox1;

    }
}