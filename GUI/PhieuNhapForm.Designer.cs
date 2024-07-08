﻿using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class PhieuNhapForm
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
            dgvPhieuNhapHang = new DataGridView();
            gbThongTinSapPham = new GroupBox();
            btnReload = new Button();
            NumberSoLuong = new NumericUpDown();
            txtGiaTien = new TextBox();
            txtTenSP = new TextBox();
            txtMaSanPham = new TextBox();
            btnThoat = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            gbThongTInDonHang = new GroupBox();
            txtMaPhieuNhap = new TextBox();
            label2 = new Label();
            txtMaNV = new TextBox();
            label8 = new Label();
            txtTenNV = new TextBox();
            label4 = new Label();
            dateNgayNhap = new DateTimePicker();
            txtSdt = new TextBox();
            txtTenNCC = new TextBox();
            txtMaNCC = new TextBox();
            cobCuaHang = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnInPhieu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhapHang).BeginInit();
            gbThongTinSapPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumberSoLuong).BeginInit();
            gbThongTInDonHang.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPhieuNhapHang
            // 
            dgvPhieuNhapHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhapHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhapHang.Location = new Point(49, 430);
            dgvPhieuNhapHang.Margin = new Padding(4, 3, 4, 3);
            dgvPhieuNhapHang.Name = "dgvPhieuNhapHang";
            dgvPhieuNhapHang.Size = new Size(912, 207);
            dgvPhieuNhapHang.TabIndex = 8;
            dgvPhieuNhapHang.CellClick += dgvPhieuNhapHang_CellClick;
            // 
            // gbThongTinSapPham
            // 
            gbThongTinSapPham.Controls.Add(btnReload);
            gbThongTinSapPham.Controls.Add(NumberSoLuong);
            gbThongTinSapPham.Controls.Add(txtGiaTien);
            gbThongTinSapPham.Controls.Add(txtTenSP);
            gbThongTinSapPham.Controls.Add(txtMaSanPham);
            gbThongTinSapPham.Controls.Add(btnThoat);
            gbThongTinSapPham.Controls.Add(btnThem);
            gbThongTinSapPham.Controls.Add(btnXoa);
            gbThongTinSapPham.Controls.Add(btnHuy);
            gbThongTinSapPham.Controls.Add(label12);
            gbThongTinSapPham.Controls.Add(label11);
            gbThongTinSapPham.Controls.Add(label10);
            gbThongTinSapPham.Controls.Add(label9);
            gbThongTinSapPham.Location = new Point(56, 224);
            gbThongTinSapPham.Margin = new Padding(4, 3, 4, 3);
            gbThongTinSapPham.Name = "gbThongTinSapPham";
            gbThongTinSapPham.Padding = new Padding(4, 3, 4, 3);
            gbThongTinSapPham.Size = new Size(905, 211);
            gbThongTinSapPham.TabIndex = 7;
            gbThongTinSapPham.TabStop = false;
            gbThongTinSapPham.Text = "Thông tin sản phầm nhập";
            // 
            // btnReload
            // 
            btnReload.Location = new Point(348, 147);
            btnReload.Margin = new Padding(4, 3, 4, 3);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(121, 38);
            btnReload.TabIndex = 24;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // NumberSoLuong
            // 
            NumberSoLuong.Location = new Point(427, 27);
            NumberSoLuong.Margin = new Padding(4, 3, 4, 3);
            NumberSoLuong.Name = "NumberSoLuong";
            NumberSoLuong.Size = new Size(205, 23);
            NumberSoLuong.TabIndex = 23;
            NumberSoLuong.ValueChanged += NumberSoLuong_ValueChanged;
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(426, 80);
            txtGiaTien.Margin = new Padding(4, 3, 4, 3);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(207, 23);
            txtGiaTien.TabIndex = 22;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(90, 29);
            txtTenSP.Margin = new Padding(4, 3, 4, 3);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(207, 23);
            txtTenSP.TabIndex = 20;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(90, 80);
            txtMaSanPham.Margin = new Padding(4, 3, 4, 3);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(207, 23);
            txtMaSanPham.TabIndex = 19;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(733, 147);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(121, 38);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(219, 147);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(121, 38);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(477, 147);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(121, 38);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(606, 147);
            btnHuy.Margin = new Padding(4, 3, 4, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(121, 38);
            btnHuy.TabIndex = 12;
            btnHuy.Text = "Sửa ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label12
            // 
            label12.Location = new Point(349, 80);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(88, 27);
            label12.TabIndex = 11;
            label12.Text = "Giá tiền";
            // 
            // label11
            // 
            label11.Location = new Point(349, 25);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(88, 27);
            label11.TabIndex = 10;
            label11.Text = "Số lượng";
            // 
            // label10
            // 
            label10.Location = new Point(4, 32);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(88, 27);
            label10.TabIndex = 9;
            label10.Text = "Tên sản phẩm";
            // 
            // label9
            // 
            label9.Location = new Point(7, 76);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(88, 27);
            label9.TabIndex = 8;
            label9.Text = "Mã sản phẩm";
            // 
            // gbThongTInDonHang
            // 
            gbThongTInDonHang.Controls.Add(txtMaPhieuNhap);
            gbThongTInDonHang.Controls.Add(label2);
            gbThongTInDonHang.Controls.Add(txtMaNV);
            gbThongTInDonHang.Controls.Add(label8);
            gbThongTInDonHang.Controls.Add(txtTenNV);
            gbThongTInDonHang.Controls.Add(label4);
            gbThongTInDonHang.Controls.Add(dateNgayNhap);
            gbThongTInDonHang.Controls.Add(txtSdt);
            gbThongTInDonHang.Controls.Add(txtTenNCC);
            gbThongTInDonHang.Controls.Add(txtMaNCC);
            gbThongTInDonHang.Controls.Add(cobCuaHang);
            gbThongTInDonHang.Controls.Add(label7);
            gbThongTInDonHang.Controls.Add(label6);
            gbThongTInDonHang.Controls.Add(label5);
            gbThongTInDonHang.Controls.Add(label3);
            gbThongTInDonHang.Controls.Add(label1);
            gbThongTInDonHang.Location = new Point(56, 9);
            gbThongTInDonHang.Margin = new Padding(4, 3, 4, 3);
            gbThongTInDonHang.Name = "gbThongTInDonHang";
            gbThongTInDonHang.Padding = new Padding(4, 3, 4, 3);
            gbThongTInDonHang.Size = new Size(905, 209);
            gbThongTInDonHang.TabIndex = 6;
            gbThongTInDonHang.TabStop = false;
            gbThongTInDonHang.Text = "Thông tin phiếu nhập";
            // 
            // txtMaPhieuNhap
            // 
            txtMaPhieuNhap.Location = new Point(136, 37);
            txtMaPhieuNhap.Margin = new Padding(4, 3, 4, 3);
            txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            txtMaPhieuNhap.Size = new Size(204, 23);
            txtMaPhieuNhap.TabIndex = 30;
            // 
            // label2
            // 
            label2.Location = new Point(8, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 27);
            label2.TabIndex = 29;
            label2.Text = "MaPhieuNhap";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(136, 180);
            txtMaNV.Margin = new Padding(4, 3, 4, 3);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(204, 23);
            txtMaNV.TabIndex = 28;
            // 
            // label8
            // 
            label8.Location = new Point(7, 183);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(290, 66);
            label8.TabIndex = 27;
            label8.Text = "Mã nhân viên";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(136, 135);
            txtTenNV.Margin = new Padding(4, 3, 4, 3);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(204, 23);
            txtTenNV.TabIndex = 26;
            // 
            // label4
            // 
            label4.Location = new Point(7, 138);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(290, 68);
            label4.TabIndex = 25;
            label4.Text = "Nhân viến xuất phiếu";
            // 
            // dateNgayNhap
            // 
            dateNgayNhap.Location = new Point(539, 177);
            dateNgayNhap.Margin = new Padding(4, 3, 4, 3);
            dateNgayNhap.Name = "dateNgayNhap";
            dateNgayNhap.Size = new Size(204, 23);
            dateNgayNhap.TabIndex = 18;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(539, 135);
            txtSdt.Margin = new Padding(4, 3, 4, 3);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(207, 23);
            txtSdt.TabIndex = 17;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(539, 44);
            txtTenNCC.Margin = new Padding(4, 3, 4, 3);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(207, 23);
            txtTenNCC.TabIndex = 12;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(539, 92);
            txtMaNCC.Margin = new Padding(4, 3, 4, 3);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(207, 23);
            txtMaNCC.TabIndex = 11;
            // 
            // cobCuaHang
            // 
            cobCuaHang.FormattingEnabled = true;
            cobCuaHang.Location = new Point(136, 92);
            cobCuaHang.Margin = new Padding(4, 3, 4, 3);
            cobCuaHang.Name = "cobCuaHang";
            cobCuaHang.Size = new Size(204, 23);
            cobCuaHang.TabIndex = 7;
            // 
            // label7
            // 
            label7.Location = new Point(426, 134);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 27);
            label7.TabIndex = 6;
            label7.Text = "SĐT";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.Location = new Point(424, 44);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 27);
            label6.TabIndex = 5;
            label6.Text = "Tên nhà cung cấp";
            // 
            // label5
            // 
            label5.Location = new Point(427, 88);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 27);
            label5.TabIndex = 4;
            label5.Text = "Mã NCC";
            // 
            // label3
            // 
            label3.Location = new Point(4, 88);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 27);
            label3.TabIndex = 2;
            label3.Text = "Cửa hàng nhập";
            // 
            // label1
            // 
            label1.Location = new Point(426, 177);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 27);
            label1.TabIndex = 0;
            label1.Text = "Ngày Nhập";
            // 
            // btnInPhieu
            // 
            btnInPhieu.Location = new Point(840, 643);
            btnInPhieu.Margin = new Padding(4, 3, 4, 3);
            btnInPhieu.Name = "btnInPhieu";
            btnInPhieu.Size = new Size(121, 38);
            btnInPhieu.TabIndex = 27;
            btnInPhieu.Text = "In phiếu";
            btnInPhieu.UseVisualStyleBackColor = true;
            // 
            // PhieuNhapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 702);
            Controls.Add(btnInPhieu);
            Controls.Add(dgvPhieuNhapHang);
            Controls.Add(gbThongTinSapPham);
            Controls.Add(gbThongTInDonHang);
            Name = "PhieuNhapForm";
            Text = "PhieuNhapForm";
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhapHang).EndInit();
            gbThongTinSapPham.ResumeLayout(false);
            gbThongTinSapPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumberSoLuong).EndInit();
            gbThongTInDonHang.ResumeLayout(false);
            gbThongTInDonHang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPhieuNhapHang;
        private GroupBox gbThongTinSapPham;
        private Button btnReload;
        private NumericUpDown NumberSoLuong;
        private TextBox txtGiaTien;
        private TextBox txtTenSP;
        private TextBox txtMaSanPham;
        private Button btnThoat;
        private Button btnThem;
        private Button btnXoa;
        private Button btnHuy;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private GroupBox gbThongTInDonHang;
        private DateTimePicker dateNgayNhap;
        private TextBox txtSdt;
        private TextBox txtTenNCC;
        private TextBox txtMaNCC;
        private ComboBox cobCuaHang;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox txtMaNV;
        private Label label8;
        private TextBox txtTenNV;
        private Label label4;
        private Button btnInPhieu;
        private TextBox txtMaPhieuNhap;
        private Label label2;
    }
}