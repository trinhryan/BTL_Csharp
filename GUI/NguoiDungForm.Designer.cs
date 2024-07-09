using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI;

partial class NguoiDungForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        txtSearch = new TextBox();
        btnSearch = new Button();
        btnReload = new Button();
        btnSua = new Button();
        btnXoa = new Button();
        btnThem = new Button();
        dgvNguoiDung = new DataGridView();
        txtMatKhau = new TextBox();
        txtSdt = new TextBox();
        txtTenDangNhap = new TextBox();
        txtHoTen = new TextBox();
        label5 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        label4 = new Label();
        txtDiaChi = new TextBox();
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
        ((System.ComponentModel.ISupportInitialize)dgvNguoiDung).BeginInit();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(584, 235);
        txtSearch.Margin = new Padding(4, 3, 4, 3);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(190, 23);
        txtSearch.TabIndex = 29;
        // 
        // btnSearch
        // 
        btnSearch.BackColor = Color.Khaki;
        btnSearch.Location = new Point(782, 227);
        btnSearch.Margin = new Padding(4, 3, 4, 3);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(125, 38);
        btnSearch.TabIndex = 28;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = false;
        btnSearch.Click += btnSearch_Click;
        // 
        // btnReload
        // 
        btnReload.BackColor = Color.Khaki;
        btnReload.Location = new Point(420, 227);
        btnReload.Margin = new Padding(4, 3, 4, 3);
        btnReload.Name = "btnReload";
        btnReload.Size = new Size(125, 38);
        btnReload.TabIndex = 27;
        btnReload.Text = "Reload";
        btnReload.UseVisualStyleBackColor = false;
        btnReload.Click += btnReload_Click;
        // 
        // btnSua
        // 
        btnSua.BackColor = Color.Khaki;
        btnSua.Location = new Point(288, 227);
        btnSua.Margin = new Padding(4, 3, 4, 3);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(125, 38);
        btnSua.TabIndex = 26;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = false;
        btnSua.Click += btnSua_Click;
        // 
        // btnXoa
        // 
        btnXoa.BackColor = Color.Khaki;
        btnXoa.Location = new Point(156, 227);
        btnXoa.Margin = new Padding(4, 3, 4, 3);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(125, 38);
        btnXoa.TabIndex = 25;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = false;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnThem
        // 
        btnThem.BackColor = Color.Khaki;
        btnThem.Location = new Point(24, 227);
        btnThem.Margin = new Padding(4, 3, 4, 3);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(125, 38);
        btnThem.TabIndex = 24;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = false;
        btnThem.Click += btnThem_Click;
        // 
        // dgvNguoiDung
        // 
        dgvNguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvNguoiDung.Location = new Point(14, 275);
        dgvNguoiDung.Margin = new Padding(4, 3, 4, 3);
        dgvNguoiDung.Name = "dgvNguoiDung";
        dgvNguoiDung.Size = new Size(919, 243);
        dgvNguoiDung.TabIndex = 23;
        dgvNguoiDung.CellClick += dgvNguoiDung_CellClick;
        // 
        // txtMatKhau
        // 
        txtMatKhau.Location = new Point(158, 162);
        txtMatKhau.Margin = new Padding(4, 3, 4, 3);
        txtMatKhau.Name = "txtMatKhau";
        txtMatKhau.Size = new Size(258, 23);
        txtMatKhau.TabIndex = 64;
        // 
        // txtSdt
        // 
        txtSdt.Location = new Point(584, 63);
        txtSdt.Margin = new Padding(4, 3, 4, 3);
        txtSdt.Name = "txtSdt";
        txtSdt.Size = new Size(258, 23);
        txtSdt.TabIndex = 62;
        // 
        // txtTenDangNhap
        // 
        txtTenDangNhap.Location = new Point(158, 111);
        txtTenDangNhap.Margin = new Padding(4, 3, 4, 3);
        txtTenDangNhap.Name = "txtTenDangNhap";
        txtTenDangNhap.Size = new Size(258, 23);
        txtTenDangNhap.TabIndex = 61;
        // 
        // txtHoTen
        // 
        txtHoTen.Location = new Point(158, 63);
        txtHoTen.Margin = new Padding(4, 3, 4, 3);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new Size(258, 23);
        txtHoTen.TabIndex = 60;
        // 
        // label5
        // 
        label5.Location = new Point(38, 162);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(74, 33);
        label5.TabIndex = 58;
        label5.Text = "Mật khẩu";
        // 
        // label3
        // 
        label3.Location = new Point(474, 63);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(112, 33);
        label3.TabIndex = 56;
        label3.Text = "Số điện thoại";
        // 
        // label2
        // 
        label2.Location = new Point(38, 114);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(112, 33);
        label2.TabIndex = 55;
        label2.Text = "Tên dăng nhập";
        // 
        // label1
        // 
        label1.Location = new Point(38, 63);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(112, 33);
        label1.TabIndex = 54;
        label1.Text = "Họ Tên";
        // 
        // label4
        // 
        label4.Location = new Point(474, 111);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(71, 33);
        label4.TabIndex = 67;
        label4.Text = "Địa chỉ";
        // 
        // txtDiaChi
        // 
        txtDiaChi.Location = new Point(584, 108);
        txtDiaChi.Margin = new Padding(4, 3, 4, 3);
        txtDiaChi.Name = "txtDiaChi";
        txtDiaChi.Size = new Size(258, 23);
        txtDiaChi.TabIndex = 68;
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, danhMụcNhânToolStripMenuItem, giaoDịchToolStripMenuItem, đơnHàngToolStripMenuItem, quảnLýKhoToolStripMenuItem, báoCáoToolStripMenuItem, đăngXuấtToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(7, 2, 0, 2);
        menuStrip1.Size = new Size(933, 24);
        menuStrip1.TabIndex = 88;
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
        hóaĐơnToolStripMenuItem.Size = new Size(180, 22);
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
        phiếuNhậpHàngToolStripMenuItem.Size = new Size(180, 22);
        phiếuNhậpHàngToolStripMenuItem.Text = "Phiếu nhập hàng";
        phiếuNhậpHàngToolStripMenuItem.Click += phiếuNhậpHàngToolStripMenuItem_Click;
        // 
        // phiếuXuấtHàngToolStripMenuItem
        // 
        phiếuXuấtHàngToolStripMenuItem.Name = "phiếuXuấtHàngToolStripMenuItem";
        phiếuXuấtHàngToolStripMenuItem.Size = new Size(180, 22);
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
        // NguoiDungForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(933, 519);
        Controls.Add(menuStrip1);
        Controls.Add(txtDiaChi);
        Controls.Add(label4);
        Controls.Add(txtMatKhau);
        Controls.Add(txtSdt);
        Controls.Add(txtTenDangNhap);
        Controls.Add(txtHoTen);
        Controls.Add(label5);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtSearch);
        Controls.Add(btnSearch);
        Controls.Add(btnReload);
        Controls.Add(btnSua);
        Controls.Add(btnXoa);
        Controls.Add(btnThem);
        Controls.Add(dgvNguoiDung);
        Margin = new Padding(4, 3, 4, 3);
        Name = "NguoiDungForm";
        Text = "NguoiDung";
        ((System.ComponentModel.ISupportInitialize)dgvNguoiDung).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtMatKhau;
    private System.Windows.Forms.TextBox txtSdt;
    private System.Windows.Forms.TextBox txtTenDangNhap;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnReload;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.DataGridView dgvNguoiDung;

    #endregion

    private System.Windows.Forms.BindingSource nguoiDungBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
    private Label label4;
    private TextBox txtDiaChi;
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
}