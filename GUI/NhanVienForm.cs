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
using Microsoft.IdentityModel.Tokens;

namespace GUI
{
    public partial class NhanVienForm : Form
    {
        SaleBus bus = new();

        public NhanVienForm()
        {
            InitializeComponent();
            dgvNhanVien.DataSource = bus.GetAllDataTable();
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cobChucVu.DataSource = bus.GetChucVu();
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

            var data = bus.SearchData(txtSeach.Text);
            var dt = new DataTable();
            dt.Columns.Add("MaNhaVien");
            dt.Columns.Add("TenNhanVien");
            dt.Columns.Add("NgaySinh");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("Sdt");
            dt.Columns.Add("ChucVu");
            dt.Columns.Add("CuaHang");
            dt.Columns.Add("TenDangNhap");

            foreach (var item in data)
            {
                var tenCuaHang = bus.GetCuaHangById(item.MaCuaHang)?.TenCuaHang;
                var chucVu = bus.GetChucVuById(item.MaCv)?.TenCv;
                string gioiTinh;
                if (!item.GioiTinh.IsNullOrEmpty() && item.GioiTinh.Contains("M"))
                {
                    gioiTinh = "Nam";
                }
                else
                {
                    gioiTinh = "Nữ";
                }

                dt.Rows.Add(item.MaSale, item.TenSale, item.NgaySinh, gioiTinh, item.Sdt, chucVu, tenCuaHang,
                    item.TenDangNhap);
            }

            dgvNhanVien.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sale sale = new();
            sale.TenSale = txtTenNV.Text;
            sale.Sdt = txtSdt.Text;
            sale.DiaChi = txtDiaChi.Text;
            sale.NgaySinh = DateOnly.Parse(dateNgaySinh.Text);
            sale.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            var chucVu = bus.GetChucVuByTen(cobChucVu.Text);
            sale.MaCv = chucVu.MaCv;
            var ketQua = bus.AddData(sale);

            MessageBox.Show(ketQua ? "Thêm thành công" : "Thêm thất bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Chưa chọn mã nhân viên cần xóa");
                return;
            }

            var ketQua = bus.DeleteData(txtMaNV.Text);
            MessageBox.Show(ketQua ? "Xóa thành công" : "Xóa thất bại");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Chưa chọn mã nhân viên cần sửa");
                return;
            }

            Sale sale = new();
            sale.MaSale = int.Parse(txtMaNV.Text);
            sale.TenSale = txtTenNV.Text;
            sale.Sdt = txtSdt.Text;
            sale.DiaChi = txtDiaChi.Text;
            if (dateNgaySinh.Text == "" && DateOnly.TryParse(dateNgaySinh.Text, out var date))
            {
                sale.NgaySinh = date;
            }
            sale.GioiTinh = rdbNam.Checked ? "M" : "F";
            sale.MaCv = bus.GetChucVuByTen(cobChucVu.Text).MaCv;
            sale.TenDangNhap = txtTenDangNhap.Text;
            var ketQua = bus.UpdateData(sale);
            
            MessageBox.Show(ketQua ? "Sửa thành công" : "Sửa thất bại");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = bus.GetAllDataTable();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateNgaySinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }

                txtSdt.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                cobChucVu.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtTenDangNhap.Text = dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}