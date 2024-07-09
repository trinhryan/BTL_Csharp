using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using DataAccess.Entities;

namespace GUI
{
    public partial class NhanVienForm : Form
    {
        SaleBus bus = new();

        public NhanVienForm()
        {
            InitializeComponent();
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NguoiDungForm();
            form.Show();
            this.Hide();
        }

        private void DanhMucSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SanPhamForm();
            form.Show();
            this.Hide();
        }

        private void DanhMucNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var form = new NhanVienForm();
            form.Show();
            this.Hide();
        }

        private void danhMụcKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            var form = new KhachHangForm();
            form.Show();
            this.Hide();
        }

        private void danhMụcNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NhaCungCapForm();
            form.Show();
            this.Hide();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HoaDonForm();
            form.Show();
            this.Hide();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DonHangForm();
            form.Show();
            this.Hide();
        }

        private void phiếuNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PhieuNhapForm();
            form.Show();
            this.Hide();
        }

        private void phiếuXuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PhieuXuatForm();
            form.Show();
            this.Hide();
        }


        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new BaoCaoForm();
            form.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSeach.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                return;
            }

            dgvNhanVien.DataSource = bus.SearchData(txtSeach.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sale sale = new();
            sale.MaSale = int.Parse(txtMaNV.Text);
            sale.TenSale = txtTenNV.Text;
            sale.Sdt = txtSdt.Text;
            sale.DiaChi = txtDiaChi.Text;
            sale.NgaySinh = DateOnly.Parse(dateNgaySinh.Text);
            sale.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            Sale.ChucVu = int.Parse(cobChucVu.Text);
            sale.TenDangNhap = txtTenDangNhap.Text;

            bus.AddData(sale);

            MessageBox.Show("Thêm thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Chưa chọn nhân viên cần xóa");
                return;
            }

            bus.DeleteData(txtMaNV.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Chưa chọn nhân viên cần sửa");
                return;
            }

            Sale sale = new();
            sale.MaSale = int.Parse(txtMaNV.Text);
            sale.TenSale = txtTenNV.Text;
            sale.Sdt = txtSdt.Text;
            sale.DiaChi = txtDiaChi.Text;
            sale.NgaySinh = DateOnly.Parse(dateNgaySinh.Text);
            sale.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            Sale.ChucVu = int.Parse(cobChucVu.Text);
            sale.TenDangNhap = txtTenDangNhap.Text;

            bus.UpdateData(sale);

            MessageBox.Show("Sửa thành công");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = bus.GetAllDataTable();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvNhanVien.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (data != null)
            {
                txtMaNV.Text = data["MaSale"].ToString();
                txtTenNV.Text = data["TenSale"].ToString();
                txtSdt.Text = data["Sdt"].ToString();
                txtDiaChi.Text = data["DiaChi"].ToString();
                dateNgaySinh.Text = data["NgaySinh"].ToString();
                rdbNam.Checked = data["GioiTinh"].ToString() == "Nam";
                rdbNu.Checked = data["GioiTinh"].ToString() == "Nữ";
                cobChucVu.Text = data["ChucVu"].ToString();
                txtTenDangNhap.Text = data["TenDangNhap"].ToString();
            }
        }
    }
}
