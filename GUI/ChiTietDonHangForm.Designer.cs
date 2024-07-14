using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class ChiTietDonHangForm
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
            components = new System.ComponentModel.Container();
            gbThongTInDonHang = new GroupBox();
            dateNgayNhap = new DateTimePicker();
            txtSdt = new TextBox();
            txtTenKhachHang = new TextBox();
            txtMaKH = new TextBox();
            txtMaDonHang = new TextBox();
            cobCuaHang = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            dgvChiTietDonHang = new DataGridView();
            chiTietDonHangBindingSource = new BindingSource(components);
            label13 = new Label();
            txtTongTien = new TextBox();
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
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            orderitemsBindingSource = new BindingSource(components);
            label4 = new Label();
            gbThongTInDonHang.SuspendLayout();
            gbThongTinSapPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumberSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDonHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chiTietDonHangBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderitemsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gbThongTInDonHang
            // 
            gbThongTInDonHang.Controls.Add(dateNgayNhap);
            gbThongTInDonHang.Controls.Add(txtSdt);
            gbThongTInDonHang.Controls.Add(txtTenKhachHang);
            gbThongTInDonHang.Controls.Add(txtMaKH);
            gbThongTInDonHang.Controls.Add(txtMaDonHang);
            gbThongTInDonHang.Controls.Add(cobCuaHang);
            gbThongTInDonHang.Controls.Add(label7);
            gbThongTInDonHang.Controls.Add(label6);
            gbThongTInDonHang.Controls.Add(label5);
            gbThongTInDonHang.Controls.Add(label3);
            gbThongTInDonHang.Controls.Add(label2);
            gbThongTInDonHang.Controls.Add(label1);
            gbThongTInDonHang.Location = new Point(17, 90);
            gbThongTInDonHang.Margin = new Padding(5, 3, 5, 3);
            gbThongTInDonHang.Name = "gbThongTInDonHang";
            gbThongTInDonHang.Padding = new Padding(5, 3, 5, 3);
            gbThongTInDonHang.Size = new Size(1034, 193);
            gbThongTInDonHang.TabIndex = 3;
            gbThongTInDonHang.TabStop = false;
            gbThongTInDonHang.Text = "Thông tin đơn hàng";
            // 
            // dateNgayNhap
            // 
            dateNgayNhap.Location = new Point(103, 41);
            dateNgayNhap.Margin = new Padding(5, 3, 5, 3);
            dateNgayNhap.Name = "dateNgayNhap";
            dateNgayNhap.Size = new Size(233, 23);
            dateNgayNhap.TabIndex = 18;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(488, 150);
            txtSdt.Margin = new Padding(5, 3, 5, 3);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(236, 23);
            txtSdt.TabIndex = 17;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(488, 33);
            txtTenKhachHang.Margin = new Padding(5, 3, 5, 3);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(236, 23);
            txtTenKhachHang.TabIndex = 12;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(486, 98);
            txtMaKH.Margin = new Padding(5, 3, 5, 3);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(236, 23);
            txtMaKH.TabIndex = 11;
            // 
            // txtMaDonHang
            // 
            txtMaDonHang.Location = new Point(103, 98);
            txtMaDonHang.Margin = new Padding(5, 3, 5, 3);
            txtMaDonHang.Name = "txtMaDonHang";
            txtMaDonHang.Size = new Size(236, 23);
            txtMaDonHang.TabIndex = 8;
            // 
            // cobCuaHang
            // 
            cobCuaHang.FormattingEnabled = true;
            cobCuaHang.Items.AddRange(new object[] { "Shop quần áo", "Shop giầy dép" });
            cobCuaHang.Location = new Point(103, 157);
            cobCuaHang.Margin = new Padding(5, 3, 5, 3);
            cobCuaHang.Name = "cobCuaHang";
            cobCuaHang.Size = new Size(233, 24);
            cobCuaHang.TabIndex = 7;
            // 
            // label7
            // 
            label7.Location = new Point(399, 150);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(101, 29);
            label7.TabIndex = 6;
            label7.Text = "SĐT";
            // 
            // label6
            // 
            label6.Location = new Point(399, 33);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 29);
            label6.TabIndex = 5;
            label6.Text = "Tên khách hàng";
            // 
            // label5
            // 
            label5.Location = new Point(399, 102);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 29);
            label5.TabIndex = 4;
            label5.Text = "Mã khách hàng";
            // 
            // label3
            // 
            label3.Location = new Point(8, 154);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 29);
            label3.TabIndex = 2;
            label3.Text = "Cửa hàng";
            // 
            // label2
            // 
            label2.Location = new Point(0, 102);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 29);
            label2.TabIndex = 1;
            label2.Text = "Mã Đơn hàng";
            // 
            // label1
            // 
            label1.Location = new Point(8, 37);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 29);
            label1.TabIndex = 0;
            label1.Text = "Ngày Nhập";
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
            gbThongTinSapPham.Location = new Point(16, 303);
            gbThongTinSapPham.Margin = new Padding(5, 3, 5, 3);
            gbThongTinSapPham.Name = "gbThongTinSapPham";
            gbThongTinSapPham.Padding = new Padding(5, 3, 5, 3);
            gbThongTinSapPham.Size = new Size(1034, 211);
            gbThongTinSapPham.TabIndex = 4;
            gbThongTinSapPham.TabStop = false;
            gbThongTinSapPham.Text = "Thông tin sản phầm";
            // 
            // btnReload
            // 
            btnReload.Location = new Point(398, 157);
            btnReload.Margin = new Padding(5, 3, 5, 3);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(138, 41);
            btnReload.TabIndex = 24;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // NumberSoLuong
            // 
            NumberSoLuong.Location = new Point(488, 29);
            NumberSoLuong.Margin = new Padding(5, 3, 5, 3);
            NumberSoLuong.Name = "NumberSoLuong";
            NumberSoLuong.Size = new Size(234, 23);
            NumberSoLuong.TabIndex = 23;
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(487, 85);
            txtGiaTien.Margin = new Padding(5, 3, 5, 3);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(236, 23);
            txtGiaTien.TabIndex = 22;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(103, 31);
            txtTenSP.Margin = new Padding(5, 3, 5, 3);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(236, 23);
            txtTenSP.TabIndex = 20;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(103, 85);
            txtMaSanPham.Margin = new Padding(5, 3, 5, 3);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(236, 23);
            txtMaSanPham.TabIndex = 19;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(838, 157);
            btnThoat.Margin = new Padding(5, 3, 5, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(138, 41);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(250, 157);
            btnThem.Margin = new Padding(5, 3, 5, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(138, 41);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(545, 157);
            btnXoa.Margin = new Padding(5, 3, 5, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(138, 41);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(693, 157);
            btnHuy.Margin = new Padding(5, 3, 5, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(138, 41);
            btnHuy.TabIndex = 12;
            btnHuy.Text = "Sửa ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnSua_Click;
            // 
            // label12
            // 
            label12.Location = new Point(399, 85);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(101, 29);
            label12.TabIndex = 11;
            label12.Text = "Giá tiền";
            // 
            // label11
            // 
            label11.Location = new Point(399, 27);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(101, 29);
            label11.TabIndex = 10;
            label11.Text = "Số lượng";
            // 
            // label10
            // 
            label10.Location = new Point(5, 34);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(101, 29);
            label10.TabIndex = 9;
            label10.Text = "Tên sản phẩm";
            // 
            // label9
            // 
            label9.Location = new Point(8, 81);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(101, 29);
            label9.TabIndex = 8;
            label9.Text = "Mã sản phẩm";
            // 
            // dgvChiTietDonHang
            // 
            dgvChiTietDonHang.AllowUserToOrderColumns = true;
            dgvChiTietDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietDonHang.Location = new Point(8, 529);
            dgvChiTietDonHang.Margin = new Padding(5, 3, 5, 3);
            dgvChiTietDonHang.Name = "dgvChiTietDonHang";
            dgvChiTietDonHang.Size = new Size(1042, 221);
            dgvChiTietDonHang.TabIndex = 5;
            dgvChiTietDonHang.CellClick += dgvChiTietDonHang_CellClick;
            // 
            // chiTietDonHangBindingSource
            // 
            chiTietDonHangBindingSource.DataMember = "ChiTietDonHangBus";
            // 
            // label13
            // 
            label13.Location = new Point(746, 759);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(101, 29);
            label13.TabIndex = 23;
            label13.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(854, 756);
            txtTongTien.Margin = new Padding(5, 3, 5, 3);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(148, 23);
            txtTongTien.TabIndex = 23;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, danhMụcNhânToolStripMenuItem, giaoDịchToolStripMenuItem, đơnHàngToolStripMenuItem, quảnLýKhoToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1066, 24);
            menuStrip1.TabIndex = 31;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýNgườiDùngToolStripMenuItem });
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(91, 20);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // quảnLýNgườiDùngToolStripMenuItem
            // 
            quảnLýNgườiDùngToolStripMenuItem.Name = "quảnLýNgườiDùngToolStripMenuItem";
            quảnLýNgườiDùngToolStripMenuItem.Size = new Size(218, 22);
            quảnLýNgườiDùngToolStripMenuItem.Text = "Quản lý người dùng";
            quảnLýNgườiDùngToolStripMenuItem.Click += quảnLýNgườiDùngToolStripMenuItem_Click;
            // 
            // danhMụcNhânToolStripMenuItem
            // 
            danhMụcNhânToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DanhMucSanPhamToolStripMenuItem, DanhMucNhanVienToolStripMenuItem, danhMụcKháchHàngToolStripMenuItem1, danhMụcNhàCungCấpToolStripMenuItem });
            danhMụcNhânToolStripMenuItem.Name = "danhMụcNhânToolStripMenuItem";
            danhMụcNhânToolStripMenuItem.Size = new Size(83, 20);
            danhMụcNhânToolStripMenuItem.Text = "Danh mục";
            // 
            // DanhMucSanPhamToolStripMenuItem
            // 
            DanhMucSanPhamToolStripMenuItem.Name = "DanhMucSanPhamToolStripMenuItem";
            DanhMucSanPhamToolStripMenuItem.Size = new Size(242, 22);
            DanhMucSanPhamToolStripMenuItem.Text = "Danh mục sản phẩm";
            DanhMucSanPhamToolStripMenuItem.Click += DanhMucSanPhamToolStripMenuItem_Click;
            // 
            // DanhMucNhanVienToolStripMenuItem
            // 
            DanhMucNhanVienToolStripMenuItem.Name = "DanhMucNhanVienToolStripMenuItem";
            DanhMucNhanVienToolStripMenuItem.Size = new Size(242, 22);
            DanhMucNhanVienToolStripMenuItem.Text = "Danh mục nhân viên";
            DanhMucNhanVienToolStripMenuItem.Click += DanhMucNhanVienToolStripMenuItem_Click;
            // 
            // danhMụcKháchHàngToolStripMenuItem1
            // 
            danhMụcKháchHàngToolStripMenuItem1.Name = "danhMụcKháchHàngToolStripMenuItem1";
            danhMụcKháchHàngToolStripMenuItem1.Size = new Size(242, 22);
            danhMụcKháchHàngToolStripMenuItem1.Text = "Danh mục khách hàng";
            danhMụcKháchHàngToolStripMenuItem1.Click += danhMụcKháchHàngToolStripMenuItem1_Click;
            // 
            // danhMụcNhàCungCấpToolStripMenuItem
            // 
            danhMụcNhàCungCấpToolStripMenuItem.Name = "danhMụcNhàCungCấpToolStripMenuItem";
            danhMụcNhàCungCấpToolStripMenuItem.Size = new Size(242, 22);
            danhMụcNhàCungCấpToolStripMenuItem.Text = "Danh mục nhà cung cấp";
            danhMụcNhàCungCấpToolStripMenuItem.Click += danhMụcNhàCungCấpToolStripMenuItem_Click;
            // 
            // giaoDịchToolStripMenuItem
            // 
            giaoDịchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hóaĐơnToolStripMenuItem });
            giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            giaoDịchToolStripMenuItem.Size = new Size(91, 20);
            giaoDịchToolStripMenuItem.Text = "Giao Dịch";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(130, 22);
            hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;
            // 
            // đơnHàngToolStripMenuItem
            // 
            đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            đơnHàngToolStripMenuItem.Size = new Size(83, 20);
            đơnHàngToolStripMenuItem.Text = "Đơn Hàng";
            đơnHàngToolStripMenuItem.Click += đơnHàngToolStripMenuItem_Click;
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            quảnLýKhoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { phiếuNhậpHàngToolStripMenuItem, phiếuXuấtHàngToolStripMenuItem });
            quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            quảnLýKhoToolStripMenuItem.Size = new Size(107, 20);
            quảnLýKhoToolStripMenuItem.Text = "Quản lý kho";
            // 
            // phiếuNhậpHàngToolStripMenuItem
            // 
            phiếuNhậpHàngToolStripMenuItem.Name = "phiếuNhậpHàngToolStripMenuItem";
            phiếuNhậpHàngToolStripMenuItem.Size = new Size(194, 22);
            phiếuNhậpHàngToolStripMenuItem.Text = "Phiếu nhập hàng";
            phiếuNhậpHàngToolStripMenuItem.Click += phiếuNhậpHàngToolStripMenuItem_Click;
            // 
            // phiếuXuấtHàngToolStripMenuItem
            // 
            phiếuXuấtHàngToolStripMenuItem.Name = "phiếuXuấtHàngToolStripMenuItem";
            phiếuXuấtHàngToolStripMenuItem.Size = new Size(194, 22);
            phiếuXuấtHàngToolStripMenuItem.Text = "Phiếu xuất hàng";
            phiếuXuấtHàngToolStripMenuItem.Click += phiếuXuấtHàngToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(91, 20);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // orderitemsBindingSource
            // 
            orderitemsBindingSource.DataMember = "order_items";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 37);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(250, 27);
            label4.TabIndex = 93;
            label4.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // ChiTietDonHangForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 853);
            Controls.Add(label4);
            Controls.Add(menuStrip1);
            Controls.Add(txtTongTien);
            Controls.Add(label13);
            Controls.Add(dgvChiTietDonHang);
            Controls.Add(gbThongTinSapPham);
            Controls.Add(gbThongTInDonHang);
            Margin = new Padding(5, 3, 5, 3);
            Name = "ChiTietDonHangForm";
            Text = "ChiTietDonHangForm";
            gbThongTInDonHang.ResumeLayout(false);
            gbThongTInDonHang.PerformLayout();
            gbThongTinSapPham.ResumeLayout(false);
            gbThongTinSapPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumberSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDonHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)chiTietDonHangBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderitemsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcKháchHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuXuấtHàngToolStripMenuItem;

        private System.Windows.Forms.DateTimePicker dateNgayNhap;

        private System.Windows.Forms.NumericUpDown NumberSoLuong;

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTongTien;

        private System.Windows.Forms.DataGridView dgvChiTietDonHang;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtGiaTien;

        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKhachHang;

        private System.Windows.Forms.ComboBox cobCuaHang;

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbThongTInDonHang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DanhMucSanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DanhMucNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbThongTinSapPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        #endregion

       // private BikeStoresDataSet1 bikeStoresDataSet1;
        private System.Windows.Forms.BindingSource orderitemsBindingSource;
      //  private BikeStoresDataSet1TableAdapters.order_itemsTableAdapter order_itemsTableAdapter;
       // private DATABASE_QL_BAN_HANGDataSet3 dATABASE_QL_BAN_HANGDataSet3;
        private System.Windows.Forms.BindingSource chiTietDonHangBindingSource;
      //  private DATABASE_QL_BAN_HANGDataSet3TableAdapters.ChiTietDonHangTableAdapter chiTietDonHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuaHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongGiaTienDataGridViewTextBoxColumn;
        private Button btnReload;
        private Label label4;
    }
}
