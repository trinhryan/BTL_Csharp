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
        txtSeach = new TextBox();
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
        menuStrip1 = new MenuStrip();
        trangChủToolStripMenuItem = new ToolStripMenuItem();
        quảnLýNgườiDùngToolStripMenuItem = new ToolStripMenuItem();
        danhMụcNhânToolStripMenuItem = new ToolStripMenuItem();
        nhânViênBánToolStripMenuItem = new ToolStripMenuItem();
        nhânViênKhoToolStripMenuItem = new ToolStripMenuItem();
        danhMụcKháchHàngToolStripMenuItem1 = new ToolStripMenuItem();
        danhMụcNhàCungCấpToolStripMenuItem = new ToolStripMenuItem();
        đơnHàngToolStripMenuItem = new ToolStripMenuItem();
        đơnHàngĐãĐặtToolStripMenuItem = new ToolStripMenuItem();
        đơnHàngĐãGiaoToolStripMenuItem = new ToolStripMenuItem();
        tạoPhiếuĐặtHàngToolStripMenuItem = new ToolStripMenuItem();
        quảnLýKhoToolStripMenuItem = new ToolStripMenuItem();
        phiếuNhậpHàngToolStripMenuItem = new ToolStripMenuItem();
        phiếuXuấtHàngToolStripMenuItem = new ToolStripMenuItem();
        báoCáoToolStripMenuItem = new ToolStripMenuItem();
        báoCáoDoanhToolStripMenuItem = new ToolStripMenuItem();
        đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
        label4 = new Label();
        txtDiaChi = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dgvNguoiDung).BeginInit();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // txtSeach
        // 
        txtSeach.Location = new Point(667, 251);
        txtSeach.Margin = new Padding(5, 3, 5, 3);
        txtSeach.Name = "txtSeach";
        txtSeach.Size = new Size(217, 23);
        txtSeach.TabIndex = 29;
        // 
        // btnSearch
        // 
        btnSearch.BackColor = Color.Khaki;
        btnSearch.Location = new Point(894, 242);
        btnSearch.Margin = new Padding(5, 3, 5, 3);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(143, 41);
        btnSearch.TabIndex = 28;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = false;
        // 
        // btnReload
        // 
        btnReload.BackColor = Color.Khaki;
        btnReload.Location = new Point(480, 242);
        btnReload.Margin = new Padding(5, 3, 5, 3);
        btnReload.Name = "btnReload";
        btnReload.Size = new Size(143, 41);
        btnReload.TabIndex = 27;
        btnReload.Text = "Reload";
        btnReload.UseVisualStyleBackColor = false;
        btnReload.Click += btnReload_Click;
        // 
        // btnSua
        // 
        btnSua.BackColor = Color.Khaki;
        btnSua.Location = new Point(329, 242);
        btnSua.Margin = new Padding(5, 3, 5, 3);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(143, 41);
        btnSua.TabIndex = 26;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = false;
        btnSua.Click += btnSua_Click;
        // 
        // btnXoa
        // 
        btnXoa.BackColor = Color.Khaki;
        btnXoa.Location = new Point(178, 242);
        btnXoa.Margin = new Padding(5, 3, 5, 3);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(143, 41);
        btnXoa.TabIndex = 25;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = false;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnThem
        // 
        btnThem.BackColor = Color.Khaki;
        btnThem.Location = new Point(27, 242);
        btnThem.Margin = new Padding(5, 3, 5, 3);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(143, 41);
        btnThem.TabIndex = 24;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = false;
        btnThem.Click += btnThem_Click;
        // 
        // dgvNguoiDung
        // 
        dgvNguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvNguoiDung.Location = new Point(16, 293);
        dgvNguoiDung.Margin = new Padding(5, 3, 5, 3);
        dgvNguoiDung.Name = "dgvNguoiDung";
        dgvNguoiDung.Size = new Size(1050, 259);
        dgvNguoiDung.TabIndex = 23;
        dgvNguoiDung.CellClick += dgvNguoiDung_CellClick;
        // 
        // txtMatKhau
        // 
        txtMatKhau.Location = new Point(181, 173);
        txtMatKhau.Margin = new Padding(5, 3, 5, 3);
        txtMatKhau.Name = "txtMatKhau";
        txtMatKhau.Size = new Size(294, 23);
        txtMatKhau.TabIndex = 64;
        // 
        // txtSdt
        // 
        txtSdt.Location = new Point(667, 67);
        txtSdt.Margin = new Padding(5, 3, 5, 3);
        txtSdt.Name = "txtSdt";
        txtSdt.Size = new Size(294, 23);
        txtSdt.TabIndex = 62;
        // 
        // txtTenDangNhap
        // 
        txtTenDangNhap.Location = new Point(181, 118);
        txtTenDangNhap.Margin = new Padding(5, 3, 5, 3);
        txtTenDangNhap.Name = "txtTenDangNhap";
        txtTenDangNhap.Size = new Size(294, 23);
        txtTenDangNhap.TabIndex = 61;
        // 
        // txtHoTen
        // 
        txtHoTen.Location = new Point(181, 67);
        txtHoTen.Margin = new Padding(5, 3, 5, 3);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new Size(294, 23);
        txtHoTen.TabIndex = 60;
        // 
        // label5
        // 
        label5.Location = new Point(43, 173);
        label5.Margin = new Padding(5, 0, 5, 0);
        label5.Name = "label5";
        label5.Size = new Size(85, 35);
        label5.TabIndex = 58;
        label5.Text = "Mật khẩu";
        // 
        // label3
        // 
        label3.Location = new Point(542, 67);
        label3.Margin = new Padding(5, 0, 5, 0);
        label3.Name = "label3";
        label3.Size = new Size(128, 35);
        label3.TabIndex = 56;
        label3.Text = "Số điện thoại";
        // 
        // label2
        // 
        label2.Location = new Point(43, 122);
        label2.Margin = new Padding(5, 0, 5, 0);
        label2.Name = "label2";
        label2.Size = new Size(128, 35);
        label2.TabIndex = 55;
        label2.Text = "Tên dăng nhập";
        // 
        // label1
        // 
        label1.Location = new Point(43, 67);
        label1.Margin = new Padding(5, 0, 5, 0);
        label1.Name = "label1";
        label1.Size = new Size(128, 35);
        label1.TabIndex = 54;
        label1.Text = "Họ Tên";
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, danhMụcNhânToolStripMenuItem, đơnHàngToolStripMenuItem, quảnLýKhoToolStripMenuItem, báoCáoToolStripMenuItem, đăngXuấtToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(8, 2, 0, 2);
        menuStrip1.Size = new Size(1066, 24);
        menuStrip1.TabIndex = 66;
        menuStrip1.Text = "menuStrip1";
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
        // 
        // danhMụcNhânToolStripMenuItem
        // 
        danhMụcNhânToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nhânViênBánToolStripMenuItem, nhânViênKhoToolStripMenuItem, danhMụcKháchHàngToolStripMenuItem1, danhMụcNhàCungCấpToolStripMenuItem });
        danhMụcNhânToolStripMenuItem.Name = "danhMụcNhânToolStripMenuItem";
        danhMụcNhânToolStripMenuItem.Size = new Size(83, 20);
        danhMụcNhânToolStripMenuItem.Text = "Danh mục";
        // 
        // nhânViênBánToolStripMenuItem
        // 
        nhânViênBánToolStripMenuItem.Name = "nhânViênBánToolStripMenuItem";
        nhânViênBánToolStripMenuItem.Size = new Size(242, 22);
        nhânViênBánToolStripMenuItem.Text = "Danh mục sản phẩm";
        // 
        // nhânViênKhoToolStripMenuItem
        // 
        nhânViênKhoToolStripMenuItem.Name = "nhânViênKhoToolStripMenuItem";
        nhânViênKhoToolStripMenuItem.Size = new Size(242, 22);
        nhânViênKhoToolStripMenuItem.Text = "Danh mục nhân viên";
        // 
        // danhMụcKháchHàngToolStripMenuItem1
        // 
        danhMụcKháchHàngToolStripMenuItem1.Name = "danhMụcKháchHàngToolStripMenuItem1";
        danhMụcKháchHàngToolStripMenuItem1.Size = new Size(242, 22);
        danhMụcKháchHàngToolStripMenuItem1.Text = "Danh mục khách hàng";
        // 
        // danhMụcNhàCungCấpToolStripMenuItem
        // 
        danhMụcNhàCungCấpToolStripMenuItem.Name = "danhMụcNhàCungCấpToolStripMenuItem";
        danhMụcNhàCungCấpToolStripMenuItem.Size = new Size(242, 22);
        danhMụcNhàCungCấpToolStripMenuItem.Text = "Danh mục nhà cung cấp";
        // 
        // đơnHàngToolStripMenuItem
        // 
        đơnHàngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đơnHàngĐãĐặtToolStripMenuItem, đơnHàngĐãGiaoToolStripMenuItem, tạoPhiếuĐặtHàngToolStripMenuItem });
        đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
        đơnHàngToolStripMenuItem.Size = new Size(83, 20);
        đơnHàngToolStripMenuItem.Text = "Đơn Hàng";
        // 
        // đơnHàngĐãĐặtToolStripMenuItem
        // 
        đơnHàngĐãĐặtToolStripMenuItem.Name = "đơnHàngĐãĐặtToolStripMenuItem";
        đơnHàngĐãĐặtToolStripMenuItem.Size = new Size(218, 22);
        đơnHàngĐãĐặtToolStripMenuItem.Text = "Đơn hàng khách đặt";
        // 
        // đơnHàngĐãGiaoToolStripMenuItem
        // 
        đơnHàngĐãGiaoToolStripMenuItem.Name = "đơnHàngĐãGiaoToolStripMenuItem";
        đơnHàngĐãGiaoToolStripMenuItem.Size = new Size(218, 22);
        đơnHàngĐãGiaoToolStripMenuItem.Text = "Đơn hàng đã giao";
        // 
        // tạoPhiếuĐặtHàngToolStripMenuItem
        // 
        tạoPhiếuĐặtHàngToolStripMenuItem.Name = "tạoPhiếuĐặtHàngToolStripMenuItem";
        tạoPhiếuĐặtHàngToolStripMenuItem.Size = new Size(218, 22);
        tạoPhiếuĐặtHàngToolStripMenuItem.Text = "Tạo phiếu đặt hàng";
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
        // 
        // phiếuXuấtHàngToolStripMenuItem
        // 
        phiếuXuấtHàngToolStripMenuItem.Name = "phiếuXuấtHàngToolStripMenuItem";
        phiếuXuấtHàngToolStripMenuItem.Size = new Size(194, 22);
        phiếuXuấtHàngToolStripMenuItem.Text = "Phiếu xuất hàng";
        // 
        // báoCáoToolStripMenuItem
        // 
        báoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { báoCáoDoanhToolStripMenuItem });
        báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
        báoCáoToolStripMenuItem.Size = new Size(75, 20);
        báoCáoToolStripMenuItem.Text = "Báo Cáo";
        // 
        // báoCáoDoanhToolStripMenuItem
        // 
        báoCáoDoanhToolStripMenuItem.Name = "báoCáoDoanhToolStripMenuItem";
        báoCáoDoanhToolStripMenuItem.Size = new Size(210, 22);
        báoCáoDoanhToolStripMenuItem.Text = "Báo cáo doanh thu";
        // 
        // đăngXuấtToolStripMenuItem
        // 
        đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
        đăngXuấtToolStripMenuItem.Size = new Size(91, 20);
        đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
        // 
        // label4
        // 
        label4.Location = new Point(542, 118);
        label4.Margin = new Padding(5, 0, 5, 0);
        label4.Name = "label4";
        label4.Size = new Size(81, 35);
        label4.TabIndex = 67;
        label4.Text = "Địa chỉ";
        // 
        // txtDiaChi
        // 
        txtDiaChi.Location = new Point(667, 115);
        txtDiaChi.Margin = new Padding(5, 3, 5, 3);
        txtDiaChi.Name = "txtDiaChi";
        txtDiaChi.Size = new Size(294, 23);
        txtDiaChi.TabIndex = 68;
        // 
        // NguoiDungForm
        // 
        AutoScaleDimensions = new SizeF(8F, 16F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1066, 554);
        Controls.Add(txtDiaChi);
        Controls.Add(label4);
        Controls.Add(menuStrip1);
        Controls.Add(txtMatKhau);
        Controls.Add(txtSdt);
        Controls.Add(txtTenDangNhap);
        Controls.Add(txtHoTen);
        Controls.Add(label5);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtSeach);
        Controls.Add(btnSearch);
        Controls.Add(btnReload);
        Controls.Add(btnSua);
        Controls.Add(btnXoa);
        Controls.Add(btnThem);
        Controls.Add(dgvNguoiDung);
        Margin = new Padding(5, 3, 5, 3);
        Name = "NguoiDungForm";
        Text = "NguoiDung";
        ((System.ComponentModel.ISupportInitialize)dgvNguoiDung).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiDùngToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem danhMụcKháchHàngToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem danhMụcNhàCungCấpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tạoPhiếuĐặtHàngToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem quảnLýKhoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem phiếuNhậpHàngToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem phiếuXuấtHàngToolStripMenuItem;

    private System.Windows.Forms.TextBox txtMatKhau;
    private System.Windows.Forms.TextBox txtSdt;
    private System.Windows.Forms.TextBox txtTenDangNhap;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem đơnHàngĐãĐặtToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem đơnHàngĐãGiaoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem danhMụcNhânToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nhânViênBánToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nhânViênKhoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem báoCáoDoanhToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;

    private System.Windows.Forms.TextBox txtSeach;
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
}