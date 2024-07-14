using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class NhaCungCapForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMaNCC = new TextBox();
            txtTenNCC = new TextBox();
            txtSdt = new TextBox();
            txtDiaChi = new TextBox();
            txtSeach = new TextBox();
            btnSearch = new Button();
            btnReload = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label5 = new Label();
            dgvNcc = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvNcc).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaNCC);
            groupBox1.Controls.Add(txtTenNCC);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 280);
            groupBox1.TabIndex = 88;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 32);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 69;
            label1.Text = "Mã nhà cung cấp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 93);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 70;
            label2.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 150);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 71;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 215);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 72;
            label4.Text = "Địa chỉ";
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(123, 29);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(223, 23);
            txtMaNCC.TabIndex = 73;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(123, 90);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(223, 23);
            txtTenNCC.TabIndex = 74;
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
            txtSeach.Location = new Point(225, 367);
            txtSeach.Margin = new Padding(4, 3, 4, 3);
            txtSeach.Name = "txtSeach";
            txtSeach.Size = new Size(223, 23);
            txtSeach.TabIndex = 82;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Khaki;
            btnSearch.Location = new Point(456, 363);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 27);
            btnSearch.TabIndex = 81;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.Khaki;
            btnReload.Location = new Point(456, 242);
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
            btnSua.Location = new Point(456, 120);
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
            btnXoa.Location = new Point(456, 177);
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
            btnThem.Location = new Point(456, 59);
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
            label5.Location = new Point(42, 310);
            label5.Name = "label5";
            label5.Size = new Size(332, 29);
            label5.TabIndex = 87;
            label5.Text = "Danh sách thông tin nhà cung cấp";
            // 
            // dgvNcc
            // 
            dgvNcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNcc.Location = new Point(20, 400);
            dgvNcc.Name = "dgvNcc";
            dgvNcc.Size = new Size(561, 248);
            dgvNcc.TabIndex = 86;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, danhMụcNhânToolStripMenuItem, giaoDịchToolStripMenuItem, đơnHàngToolStripMenuItem, quảnLýKhoToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(607, 24);
            menuStrip1.TabIndex = 89;
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
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(73, 20);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // NhaCungCapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 660);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(txtSeach);
            Controls.Add(label5);
            Controls.Add(btnReload);
            Controls.Add(dgvNcc);
            Controls.Add(btnSearch);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Name = "NhaCungCapForm";
            Text = "NhaCungCapForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNcc).EndInit();
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
        private TextBox txtMaNCC;
        private Button btnSua;
        private TextBox txtTenNCC;
        private Button btnXoa;
        private TextBox txtSdt;
        private Button btnThem;
        private TextBox txtDiaChi;
        private Label label5;
        private DataGridView dgvNcc;
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