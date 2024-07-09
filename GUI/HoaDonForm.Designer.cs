using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI;

partial class HoaDonForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        dgvChiTietDonHang = new DataGridView();
        gbThongTinSapPham = new GroupBox();
        txtThanhTien = new TextBox();
        label2 = new Label();
        txtMaHD = new TextBox();
        label1 = new Label();
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
        label3 = new Label();
        txtTongTien = new TextBox();
        btnInHoaDon = new Button();
        label4 = new Label();
        txtNgayBan = new TextBox();
        menuStrip1.SuspendLayout();
        ((ISupportInitialize)dgvChiTietDonHang).BeginInit();
        gbThongTinSapPham.SuspendLayout();
        ((ISupportInitialize)NumberSoLuong).BeginInit();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, danhMụcNhânToolStripMenuItem, giaoDịchToolStripMenuItem, đơnHàngToolStripMenuItem, quảnLýKhoToolStripMenuItem, báoCáoToolStripMenuItem, đăngXuấtToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(7, 2, 0, 2);
        menuStrip1.Size = new Size(891, 24);
        menuStrip1.TabIndex = 87;
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
        quảnLýKhoToolStripMenuItem.Click += quảnLýKhoToolStripMenuItem_Click;
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
        // dgvChiTietDonHang
        // 
        dgvChiTietDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvChiTietDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvChiTietDonHang.Location = new Point(18, 191);
        dgvChiTietDonHang.Margin = new Padding(4, 3, 4, 3);
        dgvChiTietDonHang.Name = "dgvChiTietDonHang";
        dgvChiTietDonHang.Size = new Size(836, 207);
        dgvChiTietDonHang.TabIndex = 89;
        // 
        // gbThongTinSapPham
        // 
        gbThongTinSapPham.Controls.Add(txtNgayBan);
        gbThongTinSapPham.Controls.Add(label4);
        gbThongTinSapPham.Controls.Add(txtThanhTien);
        gbThongTinSapPham.Controls.Add(label2);
        gbThongTinSapPham.Controls.Add(txtMaHD);
        gbThongTinSapPham.Controls.Add(label1);
        gbThongTinSapPham.Controls.Add(dgvChiTietDonHang);
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
        gbThongTinSapPham.Location = new Point(5, 27);
        gbThongTinSapPham.Margin = new Padding(4, 3, 4, 3);
        gbThongTinSapPham.Name = "gbThongTinSapPham";
        gbThongTinSapPham.Padding = new Padding(4, 3, 4, 3);
        gbThongTinSapPham.Size = new Size(873, 419);
        gbThongTinSapPham.TabIndex = 88;
        gbThongTinSapPham.TabStop = false;
        gbThongTinSapPham.Text = "Thông tin các sản phẩm";
        // 
        // txtThanhTien
        // 
        txtThanhTien.Location = new Point(427, 111);
        txtThanhTien.Margin = new Padding(4, 3, 4, 3);
        txtThanhTien.Name = "txtThanhTien";
        txtThanhTien.Size = new Size(207, 23);
        txtThanhTien.TabIndex = 93;
        // 
        // label2
        // 
        label2.Location = new Point(348, 114);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(88, 27);
        label2.TabIndex = 92;
        label2.Text = "Thành tiền";
        // 
        // txtMaHD
        // 
        txtMaHD.Location = new Point(90, 33);
        txtMaHD.Margin = new Padding(4, 3, 4, 3);
        txtMaHD.Name = "txtMaHD";
        txtMaHD.Size = new Size(207, 23);
        txtMaHD.TabIndex = 91;
        // 
        // label1
        // 
        label1.Location = new Point(0, 29);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(88, 27);
        label1.TabIndex = 90;
        label1.Text = "Mã hóa đơn ";
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
        // 
        // NumberSoLuong
        // 
        NumberSoLuong.Location = new Point(427, 27);
        NumberSoLuong.Margin = new Padding(4, 3, 4, 3);
        NumberSoLuong.Name = "NumberSoLuong";
        NumberSoLuong.Size = new Size(205, 23);
        NumberSoLuong.TabIndex = 23;
        // 
        // txtGiaTien
        // 
        txtGiaTien.Location = new Point(427, 71);
        txtGiaTien.Margin = new Padding(4, 3, 4, 3);
        txtGiaTien.Name = "txtGiaTien";
        txtGiaTien.Size = new Size(207, 23);
        txtGiaTien.TabIndex = 22;
        // 
        // txtTenSP
        // 
        txtTenSP.Location = new Point(90, 74);
        txtTenSP.Margin = new Padding(4, 3, 4, 3);
        txtTenSP.Name = "txtTenSP";
        txtTenSP.Size = new Size(207, 23);
        txtTenSP.TabIndex = 20;
        // 
        // txtMaSanPham
        // 
        txtMaSanPham.Location = new Point(90, 118);
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
        // 
        // label12
        // 
        label12.Location = new Point(349, 70);
        label12.Margin = new Padding(4, 0, 4, 0);
        label12.Name = "label12";
        label12.Size = new Size(88, 27);
        label12.TabIndex = 11;
        label12.Text = "Đơn giá";
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
        label10.Location = new Point(0, 74);
        label10.Margin = new Padding(4, 0, 4, 0);
        label10.Name = "label10";
        label10.Size = new Size(88, 27);
        label10.TabIndex = 9;
        label10.Text = "Tên sản phẩm";
        // 
        // label9
        // 
        label9.Location = new Point(0, 118);
        label9.Margin = new Padding(4, 0, 4, 0);
        label9.Name = "label9";
        label9.Size = new Size(88, 27);
        label9.TabIndex = 8;
        label9.Text = "Mã sản phẩm";
        // 
        // label3
        // 
        label3.Location = new Point(576, 449);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(68, 20);
        label3.TabIndex = 94;
        label3.Text = "Tổng tiền";
        // 
        // txtTongTien
        // 
        txtTongTien.Location = new Point(652, 446);
        txtTongTien.Margin = new Padding(4, 3, 4, 3);
        txtTongTien.Name = "txtTongTien";
        txtTongTien.Size = new Size(207, 23);
        txtTongTien.TabIndex = 94;
        // 
        // btnInHoaDon
        // 
        btnInHoaDon.Location = new Point(23, 437);
        btnInHoaDon.Margin = new Padding(4, 3, 4, 3);
        btnInHoaDon.Name = "btnInHoaDon";
        btnInHoaDon.Size = new Size(121, 38);
        btnInHoaDon.TabIndex = 94;
        btnInHoaDon.Text = "In hóa đơn";
        btnInHoaDon.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        label4.Location = new Point(733, 44);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(88, 27);
        label4.TabIndex = 94;
        label4.Text = "Ngày bán";
        // 
        // txtNgayBan
        // 
        txtNgayBan.Location = new Point(658, 74);
        txtNgayBan.Margin = new Padding(4, 3, 4, 3);
        txtNgayBan.Name = "txtNgayBan";
        txtNgayBan.Size = new Size(207, 23);
        txtNgayBan.TabIndex = 95;
        // 
        // HoaDonForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(891, 576);
        Controls.Add(btnInHoaDon);
        Controls.Add(txtTongTien);
        Controls.Add(label3);
        Controls.Add(gbThongTinSapPham);
        Controls.Add(menuStrip1);
        Name = "HoaDonForm";
        Text = "HoaDonForm";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ((ISupportInitialize)dgvChiTietDonHang).EndInit();
        gbThongTinSapPham.ResumeLayout(false);
        gbThongTinSapPham.PerformLayout();
        ((ISupportInitialize)NumberSoLuong).EndInit();
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
    private DataGridView dgvChiTietDonHang;
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
    private Label label1;
    private TextBox txtMaHD;
    private Label label2;
    private TextBox txtThanhTien;
    private Label label3;
    private TextBox txtTongTien;
    private Button btnInHoaDon;
    private TextBox txtNgayBan;
    private Label label4;
}