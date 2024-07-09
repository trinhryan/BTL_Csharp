using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class DonHangForm
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
            menuStrip1 = new MenuStrip();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            quảnLýNgườiDùngToolStripMenuItem = new ToolStripMenuItem();
            danhMụcNhânToolStripMenuItem = new ToolStripMenuItem();
            DanhMucSanPhamToolStripMenuItem = new ToolStripMenuItem();
            DanhMucNhanVienToolStripMenuItem = new ToolStripMenuItem();
            danhMụcKháchHàngToolStripMenuItem1 = new ToolStripMenuItem();
            danhMụcNhàCungCấpToolStripMenuItem = new ToolStripMenuItem();
            giaoDịchToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            đơnHàngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKhoToolStripMenuItem = new ToolStripMenuItem();
            phiếuNhậpHàngToolStripMenuItem = new ToolStripMenuItem();
            phiếuXuấtHàngToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            dgvDonHang = new DataGridView();
            txtMaDonHang = new TextBox();
            label2 = new Label();
            gbThongTInDonHang = new GroupBox();
            dateNgayNhap = new DateTimePicker();
            cobCuaHang = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            btnReload = new Button();
            NumberSoLuong = new NumericUpDown();
            txtTenSP = new TextBox();
            txtMaSanPham = new TextBox();
            btnThoat = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            gbThongTinSapPham = new GroupBox();
            txtGiaTien = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            rdbDaThanhToan = new RadioButton();
            rdbChuaThanhToan = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            gbThongTInDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumberSoLuong).BeginInit();
            gbThongTinSapPham.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, danhMụcNhânToolStripMenuItem, giaoDịchToolStripMenuItem, đơnHàngToolStripMenuItem, quảnLýKhoToolStripMenuItem, báoCáoToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(975, 24);
            menuStrip1.TabIndex = 86;
            menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýNgườiDùngToolStripMenuItem });
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(71, 20);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // quảnLýNgườiDùngToolStripMenuItem
            // 
            quảnLýNgườiDùngToolStripMenuItem.Name = "quảnLýNgườiDùngToolStripMenuItem";
            quảnLýNgườiDùngToolStripMenuItem.Size = new Size(180, 22);
            quảnLýNgườiDùngToolStripMenuItem.Text = "Quản lý người dùng";
            quảnLýNgườiDùngToolStripMenuItem.Click += quảnLýNgườiDùngToolStripMenuItem_Click;
            // 
            // danhMụcNhânToolStripMenuItem
            // 
            danhMụcNhânToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DanhMucSanPhamToolStripMenuItem, DanhMucNhanVienToolStripMenuItem, danhMụcKháchHàngToolStripMenuItem1, danhMụcNhàCungCấpToolStripMenuItem });
            danhMụcNhânToolStripMenuItem.Name = "danhMụcNhânToolStripMenuItem";
            danhMụcNhânToolStripMenuItem.Size = new Size(74, 20);
            danhMụcNhânToolStripMenuItem.Text = "Danh mục";
            // 
            // DanhMucSanPhamToolStripMenuItem
            // 
            DanhMucSanPhamToolStripMenuItem.Name = "DanhMucSanPhamToolStripMenuItem";
            DanhMucSanPhamToolStripMenuItem.Size = new Size(204, 22);
            DanhMucSanPhamToolStripMenuItem.Text = "Danh mục sản phẩm";
            DanhMucSanPhamToolStripMenuItem.Click += DanhMucSanPhamToolStripMenuItem_Click;
            // 
            // DanhMucNhanVienToolStripMenuItem
            // 
            DanhMucNhanVienToolStripMenuItem.Name = "DanhMucNhanVienToolStripMenuItem";
            DanhMucNhanVienToolStripMenuItem.Size = new Size(204, 22);
            DanhMucNhanVienToolStripMenuItem.Text = "Danh mục nhân viên";
            DanhMucNhanVienToolStripMenuItem.Click += DanhMucNhanVienToolStripMenuItem_Click;
            // 
            // danhMụcKháchHàngToolStripMenuItem1
            // 
            danhMụcKháchHàngToolStripMenuItem1.Name = "danhMụcKháchHàngToolStripMenuItem1";
            danhMụcKháchHàngToolStripMenuItem1.Size = new Size(204, 22);
            danhMụcKháchHàngToolStripMenuItem1.Text = "Danh mục khách hàng";
            danhMụcKháchHàngToolStripMenuItem1.Click += danhMụcKháchHàngToolStripMenuItem1_Click;
            // 
            // danhMụcNhàCungCấpToolStripMenuItem
            // 
            danhMụcNhàCungCấpToolStripMenuItem.Name = "danhMụcNhàCungCấpToolStripMenuItem";
            danhMụcNhàCungCấpToolStripMenuItem.Size = new Size(204, 22);
            danhMụcNhàCungCấpToolStripMenuItem.Text = "Danh mục nhà cung cấp";
            danhMụcNhàCungCấpToolStripMenuItem.Click += danhMụcNhàCungCấpToolStripMenuItem_Click;
            // 
            // giaoDịchToolStripMenuItem
            // 
            giaoDịchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hóaĐơnToolStripMenuItem });
            giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            giaoDịchToolStripMenuItem.Size = new Size(70, 20);
            giaoDịchToolStripMenuItem.Text = "Giao Dịch";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(120, 22);
            hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;
            // 
            // đơnHàngToolStripMenuItem
            // 
            đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            đơnHàngToolStripMenuItem.Size = new Size(73, 20);
            đơnHàngToolStripMenuItem.Text = "Đơn Hàng";
            đơnHàngToolStripMenuItem.Click += đơnHàngToolStripMenuItem_Click;
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            quảnLýKhoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { phiếuNhậpHàngToolStripMenuItem, phiếuXuấtHàngToolStripMenuItem });
            quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            quảnLýKhoToolStripMenuItem.Size = new Size(83, 20);
            quảnLýKhoToolStripMenuItem.Text = "Quản lý kho";
            // 
            // phiếuNhậpHàngToolStripMenuItem
            // 
            phiếuNhậpHàngToolStripMenuItem.Name = "phiếuNhậpHàngToolStripMenuItem";
            phiếuNhậpHàngToolStripMenuItem.Size = new Size(164, 22);
            phiếuNhậpHàngToolStripMenuItem.Text = "Phiếu nhập hàng";
            phiếuNhậpHàngToolStripMenuItem.Click += phiếuNhậpHàngToolStripMenuItem_Click;
            // 
            // phiếuXuấtHàngToolStripMenuItem
            // 
            phiếuXuấtHàngToolStripMenuItem.Name = "phiếuXuấtHàngToolStripMenuItem";
            phiếuXuấtHàngToolStripMenuItem.Size = new Size(164, 22);
            phiếuXuấtHàngToolStripMenuItem.Text = "Phiếu xuất hàng";
            phiếuXuấtHàngToolStripMenuItem.Click += phiếuXuấtHàngToolStripMenuItem_Click;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(63, 20);
            báoCáoToolStripMenuItem.Text = "Báo Cáo";
            báoCáoToolStripMenuItem.Click += báoCáoToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(73, 20);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // dgvDonHang
            // 
            dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonHang.Location = new Point(31, 333);
            dgvDonHang.Margin = new Padding(4, 3, 4, 3);
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.Size = new Size(912, 207);
            dgvDonHang.TabIndex = 89;
            dgvDonHang.CellContentClick += dgvChiTietDonHang_CellContentClick;
            // 
            // txtMaDonHang
            // 
            txtMaDonHang.Location = new Point(90, 92);
            txtMaDonHang.Margin = new Padding(4, 3, 4, 3);
            txtMaDonHang.Name = "txtMaDonHang";
            txtMaDonHang.Size = new Size(207, 23);
            txtMaDonHang.TabIndex = 8;
            // 
            // label2
            // 
            label2.Location = new Point(0, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 27);
            label2.TabIndex = 1;
            label2.Text = "Mã Đơn hàng";
            // 
            // gbThongTInDonHang
            // 
            gbThongTInDonHang.Controls.Add(label4);
            gbThongTInDonHang.Controls.Add(rdbChuaThanhToan);
            gbThongTInDonHang.Controls.Add(rdbDaThanhToan);
            gbThongTInDonHang.Controls.Add(dateNgayNhap);
            gbThongTInDonHang.Controls.Add(txtMaDonHang);
            gbThongTInDonHang.Controls.Add(cobCuaHang);
            gbThongTInDonHang.Controls.Add(gbThongTinSapPham);
            gbThongTInDonHang.Controls.Add(label3);
            gbThongTInDonHang.Controls.Add(label2);
            gbThongTInDonHang.Controls.Add(label1);
            gbThongTInDonHang.Location = new Point(38, 76);
            gbThongTInDonHang.Margin = new Padding(4, 3, 4, 3);
            gbThongTInDonHang.Name = "gbThongTInDonHang";
            gbThongTInDonHang.Padding = new Padding(4, 3, 4, 3);
            gbThongTInDonHang.Size = new Size(905, 218);
            gbThongTInDonHang.TabIndex = 87;
            gbThongTInDonHang.TabStop = false;
            gbThongTInDonHang.Text = "Thông tin đơn hàng";
            // 
            // dateNgayNhap
            // 
            dateNgayNhap.Location = new Point(90, 38);
            dateNgayNhap.Margin = new Padding(4, 3, 4, 3);
            dateNgayNhap.Name = "dateNgayNhap";
            dateNgayNhap.Size = new Size(204, 23);
            dateNgayNhap.TabIndex = 18;
            // 
            // cobCuaHang
            // 
            cobCuaHang.FormattingEnabled = true;
            cobCuaHang.Location = new Point(90, 147);
            cobCuaHang.Margin = new Padding(4, 3, 4, 3);
            cobCuaHang.Name = "cobCuaHang";
            cobCuaHang.Size = new Size(204, 23);
            cobCuaHang.TabIndex = 7;
            // 
            // label3
            // 
            label3.Location = new Point(7, 144);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 27);
            label3.TabIndex = 2;
            label3.Text = "Cửa hàng";
            // 
            // label1
            // 
            label1.Location = new Point(7, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 27);
            label1.TabIndex = 0;
            label1.Text = "Ngày Nhập";
            // 
            // btnReload
            // 
            btnReload.Location = new Point(564, 555);
            btnReload.Margin = new Padding(4, 3, 4, 3);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(121, 38);
            btnReload.TabIndex = 24;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            // 
            // NumberSoLuong
            // 
            NumberSoLuong.Location = new Point(328, 29);
            NumberSoLuong.Margin = new Padding(4, 3, 4, 3);
            NumberSoLuong.Name = "NumberSoLuong";
            NumberSoLuong.Size = new Size(154, 23);
            NumberSoLuong.TabIndex = 23;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(90, 29);
            txtTenSP.Margin = new Padding(4, 3, 4, 3);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(147, 23);
            txtTenSP.TabIndex = 20;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(90, 80);
            txtMaSanPham.Margin = new Padding(4, 3, 4, 3);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(147, 23);
            txtMaSanPham.TabIndex = 19;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(822, 555);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(121, 38);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(158, 555);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(121, 38);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(425, 555);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(121, 38);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(287, 555);
            btnHuy.Margin = new Padding(4, 3, 4, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(121, 38);
            btnHuy.TabIndex = 12;
            btnHuy.Text = "Sửa ";
            btnHuy.UseVisualStyleBackColor = true;
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
            gbThongTinSapPham.Location = new Point(366, 22);
            gbThongTinSapPham.Margin = new Padding(4, 3, 4, 3);
            gbThongTinSapPham.Name = "gbThongTinSapPham";
            gbThongTinSapPham.Padding = new Padding(4, 3, 4, 3);
            gbThongTinSapPham.Size = new Size(494, 119);
            gbThongTinSapPham.TabIndex = 88;
            gbThongTinSapPham.TabStop = false;
            gbThongTinSapPham.Text = "Thông tin sản phầm";
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(327, 76);
            txtGiaTien.Margin = new Padding(4, 3, 4, 3);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(155, 23);
            txtGiaTien.TabIndex = 22;
            // 
            // label12
            // 
            label12.Location = new Point(245, 76);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(88, 27);
            label12.TabIndex = 11;
            label12.Text = "Giá tiền";
            // 
            // label11
            // 
            label11.Location = new Point(245, 25);
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
            // rdbDaThanhToan
            // 
            rdbDaThanhToan.AutoSize = true;
            rdbDaThanhToan.Location = new Point(509, 147);
            rdbDaThanhToan.Name = "rdbDaThanhToan";
            rdbDaThanhToan.Size = new Size(100, 19);
            rdbDaThanhToan.TabIndex = 89;
            rdbDaThanhToan.TabStop = true;
            rdbDaThanhToan.Text = "Đã thanh toán";
            rdbDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rdbChuaThanhToan
            // 
            rdbChuaThanhToan.AutoSize = true;
            rdbChuaThanhToan.Location = new Point(509, 184);
            rdbChuaThanhToan.Name = "rdbChuaThanhToan";
            rdbChuaThanhToan.Size = new Size(114, 19);
            rdbChuaThanhToan.TabIndex = 90;
            rdbChuaThanhToan.TabStop = true;
            rdbChuaThanhToan.Text = "Chưa thanh toán";
            rdbChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(370, 147);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 27);
            label4.TabIndex = 91;
            label4.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 34);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 30);
            label5.TabIndex = 92;
            label5.Text = "ĐƠN HÀNG";
            // 
            // DonHangForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 609);
            Controls.Add(label5);
            Controls.Add(btnReload);
            Controls.Add(dgvDonHang);
            Controls.Add(gbThongTInDonHang);
            Controls.Add(btnThoat);
            Controls.Add(menuStrip1);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(btnHuy);
            Name = "DonHangForm";
            Text = "DonHangForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            gbThongTInDonHang.ResumeLayout(false);
            gbThongTInDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumberSoLuong).EndInit();
            gbThongTinSapPham.ResumeLayout(false);
            gbThongTinSapPham.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem quảnLýNgườiDùngToolStripMenuItem;
        private ToolStripMenuItem danhMụcNhânToolStripMenuItem;
        private ToolStripMenuItem DanhMucSanPhamToolStripMenuItem;
        private ToolStripMenuItem DanhMucNhanVienToolStripMenuItem;
        private ToolStripMenuItem danhMụcKháchHàngToolStripMenuItem1;
        private ToolStripMenuItem danhMụcNhàCungCấpToolStripMenuItem;
        private ToolStripMenuItem giaoDịchToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem đơnHàngToolStripMenuItem;
        private ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private ToolStripMenuItem phiếuNhậpHàngToolStripMenuItem;
        private ToolStripMenuItem phiếuXuấtHàngToolStripMenuItem;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private DataGridView dgvDonHang;
        private TextBox txtMaDonHang;
        private Label label2;
        private GroupBox gbThongTInDonHang;
        private DateTimePicker dateNgayNhap;
        private ComboBox cobCuaHang;
        private Label label3;
        private Label label1;
        private Button btnReload;
        private NumericUpDown NumberSoLuong;
        private TextBox txtTenSP;
        private TextBox txtMaSanPham;
        private Button btnThoat;
        private Button btnThem;
        private Button btnXoa;
        private Button btnHuy;
        private GroupBox gbThongTinSapPham;
        private TextBox txtGiaTien;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label4;
        private RadioButton rdbChuaThanhToan;
        private RadioButton rdbDaThanhToan;
        private Label label5;
    }
}