using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class PhieuXuatForm
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
            NumberSoLuong = new NumericUpDown();
            dgvPhieuXuatHang = new DataGridView();
            gbThongTinSapPham = new GroupBox();
            btnReload = new Button();
            txtGiaTien = new TextBox();
            txtTenSP = new TextBox();
            txtMaSanPham = new TextBox();
            btnThoat = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            gbThongTInDonHang = new GroupBox();
            txtMaPhieuXuat = new TextBox();
            label5 = new Label();
            txtMaNV = new TextBox();
            label8 = new Label();
            txtTenNV = new TextBox();
            label4 = new Label();
            cobCHNhap = new ComboBox();
            label2 = new Label();
            dateNgayNhap = new DateTimePicker();
            txtSdt = new TextBox();
            txtDiaChi = new TextBox();
            cobCHXuat = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnInPhieu = new Button();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)NumberSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuXuatHang).BeginInit();
            gbThongTinSapPham.SuspendLayout();
            gbThongTInDonHang.SuspendLayout();
            SuspendLayout();
            // 
            // NumberSoLuong
            // 
            NumberSoLuong.Location = new Point(479, 23);
            NumberSoLuong.Margin = new Padding(4, 3, 4, 3);
            NumberSoLuong.Name = "NumberSoLuong";
            NumberSoLuong.Size = new Size(205, 23);
            NumberSoLuong.TabIndex = 23;
            // 
            // dgvPhieuXuatHang
            // 
            dgvPhieuXuatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuXuatHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuXuatHang.Location = new Point(67, 401);
            dgvPhieuXuatHang.Margin = new Padding(4, 3, 4, 3);
            dgvPhieuXuatHang.Name = "dgvPhieuXuatHang";
            dgvPhieuXuatHang.Size = new Size(887, 207);
            dgvPhieuXuatHang.TabIndex = 11;
            dgvPhieuXuatHang.CellClick += dgvPhieuXuatHang_CellClick;
            // 
            // gbThongTinSapPham
            // 
            gbThongTinSapPham.Controls.Add(NumberSoLuong);
            gbThongTinSapPham.Controls.Add(txtGiaTien);
            gbThongTinSapPham.Controls.Add(txtTenSP);
            gbThongTinSapPham.Controls.Add(txtMaSanPham);
            gbThongTinSapPham.Controls.Add(label12);
            gbThongTinSapPham.Controls.Add(label11);
            gbThongTinSapPham.Controls.Add(label10);
            gbThongTinSapPham.Controls.Add(label9);
            gbThongTinSapPham.Location = new Point(63, 214);
            gbThongTinSapPham.Margin = new Padding(4, 3, 4, 3);
            gbThongTinSapPham.Name = "gbThongTinSapPham";
            gbThongTinSapPham.Padding = new Padding(4, 3, 4, 3);
            gbThongTinSapPham.Size = new Size(720, 120);
            gbThongTinSapPham.TabIndex = 10;
            gbThongTinSapPham.TabStop = false;
            gbThongTinSapPham.Text = "Thông tin sản phầm xuất";
            // 
            // btnReload
            // 
            btnReload.Location = new Point(833, 226);
            btnReload.Margin = new Padding(4, 3, 4, 3);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(121, 38);
            btnReload.TabIndex = 24;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(479, 73);
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
            btnThoat.Location = new Point(833, 296);
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
            btnThem.Location = new Point(833, 15);
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
            btnXoa.Location = new Point(833, 152);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(121, 38);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(833, 75);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(121, 38);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnHuy_Click;
            // 
            // label12
            // 
            label12.Location = new Point(383, 73);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(88, 27);
            label12.TabIndex = 11;
            label12.Text = "Giá tiền";
            // 
            // label11
            // 
            label11.Location = new Point(381, 23);
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
            gbThongTInDonHang.Controls.Add(txtMaPhieuXuat);
            gbThongTInDonHang.Controls.Add(label5);
            gbThongTInDonHang.Controls.Add(txtMaNV);
            gbThongTInDonHang.Controls.Add(label8);
            gbThongTInDonHang.Controls.Add(txtTenNV);
            gbThongTInDonHang.Controls.Add(label4);
            gbThongTInDonHang.Controls.Add(cobCHNhap);
            gbThongTInDonHang.Controls.Add(label2);
            gbThongTInDonHang.Controls.Add(dateNgayNhap);
            gbThongTInDonHang.Controls.Add(txtSdt);
            gbThongTInDonHang.Controls.Add(txtDiaChi);
            gbThongTInDonHang.Controls.Add(cobCHXuat);
            gbThongTInDonHang.Controls.Add(label7);
            gbThongTInDonHang.Controls.Add(label6);
            gbThongTInDonHang.Controls.Add(label3);
            gbThongTInDonHang.Controls.Add(label1);
            gbThongTInDonHang.Location = new Point(63, -1);
            gbThongTInDonHang.Margin = new Padding(4, 3, 4, 3);
            gbThongTInDonHang.Name = "gbThongTInDonHang";
            gbThongTInDonHang.Padding = new Padding(4, 3, 4, 3);
            gbThongTInDonHang.Size = new Size(720, 209);
            gbThongTInDonHang.TabIndex = 9;
            gbThongTInDonHang.TabStop = false;
            gbThongTInDonHang.Text = "Thông tin phiếu xuất";
            // 
            // txtMaPhieuXuat
            // 
            txtMaPhieuXuat.Location = new Point(90, 31);
            txtMaPhieuXuat.Margin = new Padding(4, 3, 4, 3);
            txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            txtMaPhieuXuat.Size = new Size(207, 23);
            txtMaPhieuXuat.TabIndex = 26;
            // 
            // label5
            // 
            label5.Location = new Point(4, 34);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 27);
            label5.TabIndex = 25;
            label5.Text = "Mã phiếu xuất";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(477, 80);
            txtMaNV.Margin = new Padding(4, 3, 4, 3);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(207, 23);
            txtMaNV.TabIndex = 24;
            // 
            // label8
            // 
            label8.Location = new Point(381, 83);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 23;
            label8.Text = "Mã nhân viên";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(477, 38);
            txtTenNV.Margin = new Padding(4, 3, 4, 3);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(207, 23);
            txtTenNV.TabIndex = 22;
            // 
            // label4
            // 
            label4.Location = new Point(381, 38);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 32);
            label4.TabIndex = 21;
            label4.Text = "Nhân viên  xuất phiếu";
            // 
            // cobCHNhap
            // 
            cobCHNhap.FormattingEnabled = true;
            cobCHNhap.Location = new Point(90, 124);
            cobCHNhap.Margin = new Padding(4, 3, 4, 3);
            cobCHNhap.Name = "cobCHNhap";
            cobCHNhap.Size = new Size(204, 23);
            cobCHNhap.TabIndex = 20;
            // 
            // label2
            // 
            label2.Location = new Point(4, 127);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 27);
            label2.TabIndex = 19;
            label2.Text = "Cửa hàng nhập";
            // 
            // dateNgayNhap
            // 
            dateNgayNhap.Location = new Point(477, 180);
            dateNgayNhap.Margin = new Padding(4, 3, 4, 3);
            dateNgayNhap.Name = "dateNgayNhap";
            dateNgayNhap.Size = new Size(204, 23);
            dateNgayNhap.TabIndex = 18;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(477, 131);
            txtSdt.Margin = new Padding(4, 3, 4, 3);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(207, 23);
            txtSdt.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(90, 168);
            txtDiaChi.Margin = new Padding(4, 3, 4, 3);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(207, 23);
            txtDiaChi.TabIndex = 12;
            // 
            // cobCHXuat
            // 
            cobCHXuat.FormattingEnabled = true;
            cobCHXuat.Location = new Point(90, 76);
            cobCHXuat.Margin = new Padding(4, 3, 4, 3);
            cobCHXuat.Name = "cobCHXuat";
            cobCHXuat.Size = new Size(204, 23);
            cobCHXuat.TabIndex = 7;
            // 
            // label7
            // 
            label7.Location = new Point(381, 134);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 27);
            label7.TabIndex = 6;
            label7.Text = "SĐT";
            // 
            // label6
            // 
            label6.Location = new Point(7, 168);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 27);
            label6.TabIndex = 5;
            label6.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.Location = new Point(0, 76);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 27);
            label3.TabIndex = 2;
            label3.Text = "Cửa hàng xuất";
            // 
            // label1
            // 
            label1.Location = new Point(381, 176);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 27);
            label1.TabIndex = 0;
            label1.Text = "Ngày xuất";
            // 
            // btnInPhieu
            // 
            btnInPhieu.Location = new Point(833, 614);
            btnInPhieu.Margin = new Padding(4, 3, 4, 3);
            btnInPhieu.Name = "btnInPhieu";
            btnInPhieu.Size = new Size(121, 38);
            btnInPhieu.TabIndex = 26;
            btnInPhieu.Text = "In phiếu";
            btnInPhieu.UseVisualStyleBackColor = true;
            btnInPhieu.Click += btnInPhieu_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(412, 358);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(268, 30);
            label13.TabIndex = 96;
            label13.Text = "DANH SÁCH PHIẾU XUẤT";
            // 
            // PhieuXuatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 661);
            Controls.Add(label13);
            Controls.Add(btnReload);
            Controls.Add(btnInPhieu);
            Controls.Add(dgvPhieuXuatHang);
            Controls.Add(gbThongTinSapPham);
            Controls.Add(btnThoat);
            Controls.Add(gbThongTInDonHang);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Name = "PhieuXuatForm";
            Text = "PhieuXuatForm";
            ((System.ComponentModel.ISupportInitialize)NumberSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuXuatHang).EndInit();
            gbThongTinSapPham.ResumeLayout(false);
            gbThongTinSapPham.PerformLayout();
            gbThongTInDonHang.ResumeLayout(false);
            gbThongTInDonHang.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumberSoLuong;
        private DataGridView dgvPhieuXuatHang;
        private GroupBox gbThongTinSapPham;
        private Button btnReload;
        private TextBox txtGiaTien;
        private TextBox txtTenSP;
        private TextBox txtMaSanPham;
        private Button btnThoat;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private GroupBox gbThongTInDonHang;
        private DateTimePicker dateNgayNhap;
        private TextBox txtSdt;
        private TextBox txtDiaChi;
        private ComboBox cobCHXuat;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label1;
        private ComboBox cobCHNhap;
        private Label label2;
        private Button btnInPhieu;
        private TextBox txtMaNV;
        private Label label8;
        private TextBox txtTenNV;
        private Label label4;
        private TextBox txtMaPhieuXuat;
        private Label label5;
        private Label label13;
    }
}