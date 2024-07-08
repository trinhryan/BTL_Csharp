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
    public partial class PhieuXuatForm : Form
    {
        PhieuXuatBus bus = new();

        public PhieuXuatForm()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhieuXuat phieuXuat = new();
            phieuXuat.MaPhieuXuat = txtMaPhieuXuat.Text;
            phieuXuat.NgayXuat = DateTime.Parse(dateNgayNhap.Text);
            phieuXuat.CuaHangXuat = cobCHNhap.Text;
            phieuXuat.CuaHangNhan = cobCHXuat.Text;
            phieuXuat.NhanVienXuat = txtTenNV.Text;
            phieuXuat.MaNV = txtMaNV.Text;
            phieuXuat.Sdt = txtSdt.Text;
            phieuXuat.DiaChi = txtDiaChi.Text;
            phieuXuat.TenSanPham = txtTenSP.Text;
            phieuXuat.MaSanPham = txtMaSanPham.Text;
            phieuXuat.SoLuong = NumberSoLuong.Value;
            phieuXuat.GiaTien = txtGiaTien.Text;


        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvPhieuXuatHang.DataSource = bus.GetAllDataTable();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuXuat.Text == "")
            {
                MessageBox.Show("Chưa chọn mã phiếu xuất cần xóa");
                return;
            }

            bus.DeleteData(txtMaPhieuXuat.Text);

        }

        private void btnHuy_Click(object sender, EventArgs e) // sửa
        {
            if (txtMaPhieuXuat.Text == "")
            {
                MessageBox.Show("Chưa chọn mã phiếu xuất cần sửa");
                return;
            }

            PhieuXuat phieuXuat = new();
            phieuXuat.MaPhieuXuat = txtMaPhieuXuat.Text;
            phieuXuat.NgayXuat = DateTime.Parse(dateNgayNhap.Text);
            phieuXuat.CuaHangXuat = cobCHNhap.Text;
            phieuXuat.CuaHangNhan = cobCHXuat.Text;
            phieuXuat.NhanVienXuat = txtTenNV.Text;
            phieuXuat.MaNV = txtMaNV.Text;
            phieuXuat.Sdt = txtSdt.Text;
            phieuXuat.DiaChi = txtDiaChi.Text;
            phieuXuat.TenSanPham = txtTenSP.Text;
            phieuXuat.MaSanPham = txtMaSanPham.Text;
            phieuXuat.SoLuong = NumberSoLuong.Value;
            phieuXuat.GiaTien = txtGiaTien.Text;
            bus.UpdateData(phieuXuat);

            MessageBox.Show("Sửa thành công");

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            var form = new SanPhamForm();
            form.Show();
            this.Hide();
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In phiếu thành công");
        }

        private void dgvPhieuXuatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvPhieuXuatHang.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (data != null)
            {
                txtMaPhieuXuat.Text = data["MaPhieuXuat"].ToString();
                dateNgayNhap.Text = data["NgayXuat"].ToString();
                cobCHNhap.Text = data["CuaHangXuat"].ToString();
                cobCHXuat.Text = data["CuaHangNhan"].ToString();
                txtTenNV.Text = data["NhanVienXuat"].ToString();
                txtMaNV.Text = data["MaNV"].ToString();
                txtSdt.Text = data["Sdt"].ToString();
                txtDiaChi.Text = data["DiaChi"].ToString();
                txtTenSP.Text = data["TenSanPham"].ToString();
                txtMaSanPham.Text = data["MaSanPham"].ToString();
                NumberSoLuong.Value = int.Parse(data["SoLuong"].ToString());
                txtGiaTien.Text = data["GiaTien"].ToString();
            }

        }
    }
}
