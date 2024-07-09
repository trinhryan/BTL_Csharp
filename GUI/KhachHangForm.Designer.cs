using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class KhachHangForm
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
            dgvKhacHang = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            txtSdt = new TextBox();
            txtDiaChi = new TextBox();
            txtSeach = new TextBox();
            btnSearch = new Button();
            btnReload = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvKhacHang).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKhacHang
            // 
            dgvKhacHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhacHang.Location = new Point(12, 403);
            dgvKhacHang.Name = "dgvKhacHang";
            dgvKhacHang.Size = new Size(776, 248);
            dgvKhacHang.TabIndex = 68;
            dgvKhacHang.CellClick += dgvKhacHang_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 69;
            label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 93);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 70;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 153);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 71;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 218);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 72;
            label4.Text = "Địa chỉ";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(123, 29);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(223, 23);
            txtMaKH.TabIndex = 73;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(123, 85);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(223, 23);
            txtTenKH.TabIndex = 74;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(123, 150);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(223, 23);
            txtSdt.TabIndex = 75;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(123, 215);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(223, 23);
            txtDiaChi.TabIndex = 76;
            // 
            // txtSeach
            // 
            txtSeach.Location = new Point(408, 367);
            txtSeach.Margin = new Padding(4, 3, 4, 3);
            txtSeach.Name = "txtSeach";
            txtSeach.Size = new Size(223, 23);
            txtSeach.TabIndex = 82;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Khaki;
            btnSearch.Location = new Point(657, 362);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 30);
            btnSearch.TabIndex = 81;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.Khaki;
            btnReload.Location = new Point(663, 157);
            btnReload.Margin = new Padding(4, 3, 4, 3);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(125, 38);
            btnReload.TabIndex = 80;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Khaki;
            btnSua.Location = new Point(663, 56);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(125, 38);
            btnSua.TabIndex = 79;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Khaki;
            btnXoa.Location = new Point(476, 157);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(125, 38);
            btnXoa.TabIndex = 78;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Khaki;
            btnThem.Location = new Point(476, 56);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(125, 38);
            btnThem.TabIndex = 77;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(192, 320);
            label5.Name = "label5";
            label5.Size = new Size(310, 29);
            label5.TabIndex = 83;
            label5.Text = "Danh sách thông tin khách hàng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 280);
            groupBox1.TabIndex = 84;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, danhMụcNhânToolStripMenuItem, giaoDịchToolStripMenuItem, đơnHàngToolStripMenuItem, quảnLýKhoToolStripMenuItem, báoCáoToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(795, 24);
            menuStrip1.TabIndex = 85;
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
            // KhachHangForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 657);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(txtSeach);
            Controls.Add(label5);
            Controls.Add(btnReload);
            Controls.Add(dgvKhacHang);
            Controls.Add(btnXoa);
            Controls.Add(btnSearch);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "KhachHangForm";
            Text = "KhachHangForm";
            ((System.ComponentModel.ISupportInitialize)dgvKhacHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvKhacHang;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMaKH;
        private TextBox txtTenKH;
        private TextBox txtSdt;
        private TextBox txtDiaChi;
        private TextBox txtSeach;
        private Button btnSearch;
        private Button btnReload;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label5;
        private GroupBox groupBox1;
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
}