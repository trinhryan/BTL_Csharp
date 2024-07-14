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
    public partial class DonHangForm : Form
    {
        DonHangBus bus = new();

        public DonHangForm()
        {
            InitializeComponent();
            dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonHang.DataSource = bus.GetAllDataTable();
            cobCuaHang.DataSource = bus.GetCuaHang();
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

        private void dgvChiTietDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvDonHang.Rows[index];
                txtMaDonHang.Text = selectedRow.Cells["MaDonHang"].Value.ToString();
                dateNgayNhap.Text = selectedRow.Cells["NgayTaoDon"].Value.ToString();
                cobCuaHang.Text = selectedRow.Cells["CuaHangTaoDon"].Value.ToString();
                txtMaSanPham.Text = selectedRow.Cells["MaSanPham"].Value.ToString();
                txtTenSP.Text = selectedRow.Cells["TenSanPham"].Value.ToString();
                NumberSoLuong.Value = int.Parse(selectedRow.Cells["SoLuong"].Value.ToString());
                txtGiaTien.Text = selectedRow.Cells["DonGiaSanPham"].Value.ToString();
                rdbChuaThanhToan.Checked = selectedRow.Cells["TrangThai"].Value.ToString() == "Chưa thanh toán";
                rdbDaThanhToan.Checked = selectedRow.Cells["TrangThai"].Value.ToString() == "Đã thanh toán";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiem tra nhap du thong tin chua
            if (txtMaDonHang.Text == "" || txtMaSanPham.Text == "" || NumberSoLuong.Text == "" || txtGiaTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            DonHang donHang = new();
            if (donHang.NgayTao.HasValue && DateOnly.TryParse(dateNgayNhap.Text, out var date))
            {
                donHang.NgayTao = date;
            }

            if (donHang.MaCuaHangNavigation != null) donHang.MaCuaHangNavigation.TenCuaHang = cobCuaHang.Text;
            donHang.MaSp = int.Parse(txtMaSanPham.Text);
            if (donHang.MaSpNavigation != null)
            {
                donHang.MaSpNavigation.TenSp = txtTenSP.Text;
                donHang.MaSpNavigation.SoLuong = (int)NumberSoLuong.Value;
                donHang.MaSpNavigation.GiaSp = int.Parse(txtGiaTien.Text);
                donHang.TrangThai = rdbChuaThanhToan.Checked ? "Chưa thanh toán" : "Đã thanh toán";
                donHang.TongTien = (donHang.MaSpNavigation.GiaSp * donHang.MaSpNavigation.SoLuong);
            }

            var ketQua = bus.AddData(donHang);

            MessageBox.Show(ketQua ? "Thêm thành công" : "Thêm thất bại");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // validate all fields
            if (txtMaDonHang.Text == "")
            {
                MessageBox.Show("Chưa chọn mã đơn hàng cần sửa");
                return;
            }

            DonHang donHang = new();
            donHang.MaDh = int.Parse(txtMaDonHang.Text);
            if (!dateNgayNhap.Text.IsNullOrEmpty() && DateOnly.TryParse(dateNgayNhap.Text, out var date))
            {
                donHang.NgayTao = date;
            }

            var cuaHang = bus.GetCuaHang(cobCuaHang.Text);
            donHang.MaCuaHang = cuaHang.MaCuaHang;
            donHang.MaSp = int.Parse(txtMaSanPham.Text);
            donHang.TrangThai = rdbChuaThanhToan.Checked ? "Chưa thanh toán" : "Đã thanh toán";
            var giaSp = decimal.Parse(txtGiaTien.Text);
            var soLuong = (decimal)NumberSoLuong.Value;
            donHang.TongTien = giaSp * soLuong;

            var ketQua = bus.UpdateData(donHang);

            MessageBox.Show(ketQua ? "Sửa thành công" : "Sửa thất bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDonHang.Text == "")
            {
                MessageBox.Show("Chưa chọn mã đơn hàng cần xóa");
                return;
            }

            var ketQua = bus.DeleteData(int.Parse(txtMaDonHang.Text));
            MessageBox.Show(ketQua ? "Xóa thành công" : "Xóa thất bại");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = bus.GetAllDataTable();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var form = new SanPhamForm();
            form.Show();
            this.Hide();
        }

        private void btnChiTietDonHang_Click(object sender, EventArgs e)
        {
            var form = new ChiTietDonHangForm();
            form.Show();
            this.Hide();
        }
    }
}