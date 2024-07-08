using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class DangKyForm
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
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnThoat = new Button();
            btnDangKi = new Button();
            btnDangNhap = new Button();
            groupBox1 = new GroupBox();
            rdbNu = new RadioButton();
            rdbNam = new RadioButton();
            label4 = new Label();
            txtHoVaTen = new TextBox();
            label7 = new Label();
            txtDiaChi = new TextBox();
            label5 = new Label();
            txtSdt = new TextBox();
            label6 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(190, 142);
            txtMatKhau.Margin = new Padding(5, 3, 5, 3);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(413, 23);
            txtMatKhau.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(190, 87);
            txtTenDangNhap.Margin = new Padding(5, 3, 5, 3);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(413, 23);
            txtTenDangNhap.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(34, 142);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.Location = new Point(34, 87);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(153, 34);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(462, 54);
            label3.TabIndex = 11;
            label3.Text = "ĐĂNG KÝ VÀO HỆ THỐNG";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 192, 255);
            btnThoat.Location = new Point(546, 490);
            btnThoat.Margin = new Padding(5, 3, 5, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(162, 49);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangKi
            // 
            btnDangKi.BackColor = Color.FromArgb(255, 192, 255);
            btnDangKi.Location = new Point(376, 490);
            btnDangKi.Margin = new Padding(5, 3, 5, 3);
            btnDangKi.Name = "btnDangKi";
            btnDangKi.Size = new Size(162, 49);
            btnDangKi.TabIndex = 9;
            btnDangKi.Text = "Đăng kí";
            btnDangKi.UseVisualStyleBackColor = false;
            btnDangKi.Click += btnDangKy_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(255, 192, 255);
            btnDangNhap.Location = new Point(204, 490);
            btnDangNhap.Margin = new Padding(5, 3, 5, 3);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(162, 49);
            btnDangNhap.TabIndex = 7;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(rdbNu);
            groupBox1.Controls.Add(rdbNam);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 107);
            groupBox1.Margin = new Padding(5, 3, 5, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 3, 5, 3);
            groupBox1.Size = new Size(672, 369);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng kí";
            // 
            // rdbNu
            // 
            rdbNu.Location = new Point(376, 193);
            rdbNu.Margin = new Padding(5, 3, 5, 3);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(138, 30);
            rdbNu.TabIndex = 16;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            rdbNam.Location = new Point(190, 193);
            rdbNam.Margin = new Padding(5, 3, 5, 3);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(138, 30);
            rdbNam.TabIndex = 15;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(34, 193);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 34);
            label4.TabIndex = 14;
            label4.Text = "Giới tính";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(190, 42);
            txtHoVaTen.Margin = new Padding(5, 3, 5, 3);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(413, 23);
            txtHoVaTen.TabIndex = 13;
            // 
            // label7
            // 
            label7.Location = new Point(34, 46);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 12;
            label7.Text = "Họ và tên";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(190, 302);
            txtDiaChi.Margin = new Padding(5, 3, 5, 3);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(412, 23);
            txtDiaChi.TabIndex = 11;
            // 
            // label5
            // 
            label5.Location = new Point(34, 294);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 32);
            label5.TabIndex = 10;
            label5.Text = "Địa chỉ";
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(190, 253);
            txtSdt.Margin = new Padding(5, 3, 5, 3);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(412, 23);
            txtSdt.TabIndex = 9;
            // 
            // label6
            // 
            label6.Location = new Point(34, 253);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 32);
            label6.TabIndex = 6;
            label6.Text = "Số điện thoại";
            // 
            // label8
            // 
            label8.Location = new Point(38, 490);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(157, 49);
            label8.TabIndex = 12;
            label8.Text = "Bạn đã có tài khoản";
            // 
            // DangKyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 554);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(btnThoat);
            Controls.Add(btnDangKi);
            Controls.Add(btnDangNhap);
            Controls.Add(groupBox1);
            Margin = new Padding(5, 3, 5, 3);
            Name = "DangKyForm";
            Text = "DangKyForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoVaTen;

        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSdt;

        #endregion
    }
}