using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class NhanVienForm
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
            groupBox1 = new GroupBox();
            txtTenDangNhap = new TextBox();
            label9 = new Label();
            label8 = new Label();
            rdbNu = new RadioButton();
            rdbNam = new RadioButton();
            label7 = new Label();
            dateNgaySinh = new DateTimePicker();
            cobChucVu = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtSeach = new TextBox();
            label3 = new Label();
            btnSearch = new Button();
            label4 = new Label();
            btnReload = new Button();
            txtMaNV = new TextBox();
            btnSua = new Button();
            txtTenNV = new TextBox();
            btnXoa = new Button();
            txtSdt = new TextBox();
            btnThem = new Button();
            txtDiaChi = new TextBox();
            label5 = new Label();
            dgvNhanVien = new DataGridView();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(rdbNu);
            groupBox1.Controls.Add(rdbNam);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateNgaySinh);
            groupBox1.Controls.Add(cobChucVu);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSeach);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnReload);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Location = new Point(24, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(944, 299);
            groupBox1.TabIndex = 88;
            groupBox1.TabStop = false;
            groupBox1.Text = "thông tin nhân viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(633, 203);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(254, 23);
            txtTenDangNhap.TabIndex = 91;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(523, 206);
            label9.Name = "label9";
            label9.Size = new Size(111, 16);
            label9.TabIndex = 90;
            label9.Text = "Tên đăng nhập";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(523, 99);
            label8.Name = "label8";
            label8.Size = new Size(79, 16);
            label8.TabIndex = 89;
            label8.Text = "Giới tính";
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(720, 95);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(41, 20);
            rdbNu.TabIndex = 88;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(615, 95);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(49, 20);
            rdbNam.TabIndex = 87;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(523, 39);
            label7.Name = "label7";
            label7.Size = new Size(79, 16);
            label7.TabIndex = 86;
            label7.Text = "Ngày sinh";
            // 
            // dateNgaySinh
            // 
            dateNgaySinh.Location = new Point(630, 34);
            dateNgaySinh.Name = "dateNgaySinh";
            dateNgaySinh.Size = new Size(257, 23);
            dateNgaySinh.TabIndex = 85;
            // 
            // cobChucVu
            // 
            cobChucVu.FormattingEnabled = true;
            cobChucVu.Location = new Point(633, 154);
            cobChucVu.Name = "cobChucVu";
            cobChucVu.Size = new Size(254, 24);
            cobChucVu.TabIndex = 84;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(523, 158);
            label6.Name = "label6";
            label6.Size = new Size(55, 16);
            label6.TabIndex = 83;
            label6.Text = "Chứ vụ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(103, 16);
            label1.TabIndex = 69;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 99);
            label2.Name = "label2";
            label2.Size = new Size(111, 16);
            label2.TabIndex = 70;
            label2.Text = "Tên nhân viên";
            // 
            // txtSeach
            // 
            txtSeach.Location = new Point(8, 261);
            txtSeach.Margin = new Padding(5, 3, 5, 3);
            txtSeach.Name = "txtSeach";
            txtSeach.Size = new Size(254, 23);
            txtSeach.TabIndex = 82;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 155);
            label3.Name = "label3";
            label3.Size = new Size(111, 16);
            label3.TabIndex = 71;
            label3.Text = "Số điện thoại";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Khaki;
            btnSearch.Location = new Point(264, 256);
            btnSearch.Margin = new Padding(5, 3, 5, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(131, 32);
            btnSearch.TabIndex = 81;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 206);
            label4.Name = "label4";
            label4.Size = new Size(63, 16);
            label4.TabIndex = 72;
            label4.Text = "Địa chỉ";
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.Khaki;
            btnReload.Location = new Point(776, 252);
            btnReload.Margin = new Padding(5, 3, 5, 3);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(111, 41);
            btnReload.TabIndex = 80;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(141, 31);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(254, 23);
            txtMaNV.TabIndex = 73;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Khaki;
            btnSua.Location = new Point(663, 252);
            btnSua.Margin = new Padding(5, 3, 5, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(104, 41);
            btnSua.TabIndex = 79;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(141, 91);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(254, 23);
            txtTenNV.TabIndex = 74;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Khaki;
            btnXoa.Location = new Point(541, 252);
            btnXoa.Margin = new Padding(5, 3, 5, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(113, 41);
            btnXoa.TabIndex = 78;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(141, 155);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(254, 23);
            txtSdt.TabIndex = 75;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Khaki;
            btnThem.Location = new Point(415, 252);
            btnThem.Margin = new Padding(5, 3, 5, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(117, 41);
            btnThem.TabIndex = 77;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(141, 206);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(254, 23);
            txtDiaChi.TabIndex = 76;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(296, 353);
            label5.Name = "label5";
            label5.Size = new Size(354, 31);
            label5.TabIndex = 87;
            label5.Text = "Danh sách thông tin nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(24, 397);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Size = new Size(944, 265);
            dgvNhanVien.TabIndex = 86;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, danhMụcNhânToolStripMenuItem, giaoDịchToolStripMenuItem, đơnHàngToolStripMenuItem, quảnLýKhoToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(978, 24);
            menuStrip1.TabIndex = 89;
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
            // NhanVienForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 665);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(dgvNhanVien);
            Name = "NhanVienForm";
            Text = "NhanVienForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtSeach;
        private Label label3;
        private Button btnSearch;
        private Label label4;
        private Button btnReload;
        private TextBox txtMaNV;
        private Button btnSua;
        private TextBox txtTenNV;
        private Button btnXoa;
        private TextBox txtSdt;
        private Button btnThem;
        private TextBox txtDiaChi;
        private Label label5;
        private DataGridView dgvNhanVien;
        private ComboBox cobChucVu;
        private Label label6;
        private TextBox txtTenDangNhap;
        private Label label9;
        private Label label8;
        private RadioButton rdbNu;
        private RadioButton rdbNam;
        private Label label7;
        private DateTimePicker dateNgaySinh;
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
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}