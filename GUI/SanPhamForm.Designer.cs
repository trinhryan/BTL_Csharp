using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class SanPhamForm
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
            gbThongTinSapPham = new GroupBox();
            txtPhanLoai = new TextBox();
            txtNsx = new TextBox();
            txtHsd = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            NumberSoLuong = new NumericUpDown();
            txtGiaTien = new TextBox();
            txtTenSP = new TextBox();
            txtMaSanPham = new TextBox();
            btnSearch = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            dgvSanPham = new DataGridView();
            btnReload = new Button();
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
            txtSeach = new TextBox();
            gbThongTinSapPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumberSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gbThongTinSapPham
            // 
            gbThongTinSapPham.Controls.Add(btnReload);
            gbThongTinSapPham.Controls.Add(txtPhanLoai);
            gbThongTinSapPham.Controls.Add(txtNsx);
            gbThongTinSapPham.Controls.Add(txtHsd);
            gbThongTinSapPham.Controls.Add(label4);
            gbThongTinSapPham.Controls.Add(label3);
            gbThongTinSapPham.Controls.Add(label2);
            gbThongTinSapPham.Controls.Add(NumberSoLuong);
            gbThongTinSapPham.Controls.Add(txtGiaTien);
            gbThongTinSapPham.Controls.Add(txtTenSP);
            gbThongTinSapPham.Controls.Add(txtMaSanPham);
            gbThongTinSapPham.Controls.Add(btnThem);
            gbThongTinSapPham.Controls.Add(btnXoa);
            gbThongTinSapPham.Controls.Add(btnSua);
            gbThongTinSapPham.Controls.Add(label12);
            gbThongTinSapPham.Controls.Add(label11);
            gbThongTinSapPham.Controls.Add(label10);
            gbThongTinSapPham.Controls.Add(label9);
            gbThongTinSapPham.Location = new Point(0, 36);
            gbThongTinSapPham.Margin = new Padding(4, 3, 4, 3);
            gbThongTinSapPham.Name = "gbThongTinSapPham";
            gbThongTinSapPham.Padding = new Padding(4, 3, 4, 3);
            gbThongTinSapPham.Size = new Size(861, 243);
            gbThongTinSapPham.TabIndex = 69;
            gbThongTinSapPham.TabStop = false;
            gbThongTinSapPham.Text = "Thông tin sản phầm";
            // 
            // txtPhanLoai
            // 
            txtPhanLoai.Location = new Point(427, 140);
            txtPhanLoai.Margin = new Padding(4, 3, 4, 3);
            txtPhanLoai.Name = "txtPhanLoai";
            txtPhanLoai.Size = new Size(207, 23);
            txtPhanLoai.TabIndex = 29;
            // 
            // txtNsx
            // 
            txtNsx.Location = new Point(90, 191);
            txtNsx.Margin = new Padding(4, 3, 4, 3);
            txtNsx.Name = "txtNsx";
            txtNsx.Size = new Size(207, 23);
            txtNsx.TabIndex = 28;
            // 
            // txtHsd
            // 
            txtHsd.Location = new Point(90, 133);
            txtHsd.Margin = new Padding(4, 3, 4, 3);
            txtHsd.Name = "txtHsd";
            txtHsd.Size = new Size(207, 23);
            txtHsd.TabIndex = 27;
            // 
            // label4
            // 
            label4.Location = new Point(349, 140);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 27);
            label4.TabIndex = 26;
            label4.Text = "Phân loại ";
            // 
            // label3
            // 
            label3.Location = new Point(13, 191);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 27);
            label3.TabIndex = 25;
            label3.Text = "NSX";
            // 
            // label2
            // 
            label2.Location = new Point(13, 136);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 27);
            label2.TabIndex = 24;
            label2.Text = "HSD";
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
            // btnSearch
            // 
            btnSearch.Location = new Point(740, 337);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(121, 23);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(700, 21);
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
            btnXoa.Location = new Point(700, 80);
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
            btnSua.Location = new Point(700, 136);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(121, 38);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
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
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 282);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 39);
            label1.TabIndex = 24;
            label1.Text = "Danh sách sản phẩm";
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(4, 366);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.Size = new Size(861, 236);
            dgvSanPham.TabIndex = 70;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(700, 191);
            btnReload.Margin = new Padding(4, 3, 4, 3);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(121, 38);
            btnReload.TabIndex = 84;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, danhMụcNhânToolStripMenuItem, giaoDịchToolStripMenuItem, đơnHàngToolStripMenuItem, quảnLýKhoToolStripMenuItem, báoCáoToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(861, 24);
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
            // txtSeach
            // 
            txtSeach.Location = new Point(525, 337);
            txtSeach.Margin = new Padding(4, 3, 4, 3);
            txtSeach.Name = "txtSeach";
            txtSeach.Size = new Size(207, 23);
            txtSeach.TabIndex = 83;
            // 
            // SanPhamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 603);
            Controls.Add(txtSeach);
            Controls.Add(menuStrip1);
            Controls.Add(dgvSanPham);
            Controls.Add(label1);
            Controls.Add(gbThongTinSapPham);
            Controls.Add(btnSearch);
            Name = "SanPhamForm";
            Text = "SanPhamForm";
            gbThongTinSapPham.ResumeLayout(false);
            gbThongTinSapPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumberSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gbThongTinSapPham;
        private NumericUpDown NumberSoLuong;
        private TextBox txtGiaTien;
        private TextBox txtTenSP;
        private TextBox txtMaSanPham;
        private Button btnSearch;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label1;
        private DataGridView dgvSanPham;
        private TextBox txtPhanLoai;
        private TextBox txtNsx;
        private TextBox txtHsd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnReload;
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
        private TextBox txtSeach;
    }
}