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
            dgvPhieuXuatHang.DataSource = bus.GetAllDataTable();
            dgvPhieuXuatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhieuXuat phieuXuat = new();
            phieuXuat.MaPx = int .Parse(txtMaPhieuXuat.Text);
            phieuXuat.NgayXuat = DateOnly.Parse(dateNgayNhap.Text);
            phieuXuat.MaCuaHangNavigation.TenCuaHang = cobCHNhap.Text;
            phieuXuat.MaCuaHangNavigation.TenCuaHang = cobCHXuat.Text;
            phieuXuat.MaCuaHangNavigation.DiaChi = txtDiaChi.Text;
            
            phieuXuat.MaQlNavigation.MaQl = int .Parse(txtMaNV.Text);
            phieuXuat.MaQlNavigation.TenQl = txtTenNV.Text;
            phieuXuat.MaQlNavigation.Sdt = txtSdt.Text;
           
            // phieuXuat.MaSPNavigation.TenSp = txtTenSP.Text;
            // phieuXuat.MaSPNavigation.MaSp = int.Parse(txtMaSanPham.Text);
            // phieuXuat.MaSPNavigation.SoLuong = (int)NumberSoLuong.Value;
            // phieuXuat.MaSPNavigation.GiaSp = int.Parse(txtGiaTien.Text);
            
            bus.InsertData(phieuXuat);
          

            MessageBox.Show("Thêm thành công");

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
            phieuXuat.MaPx = int .Parse(txtMaPhieuXuat.Text);
            phieuXuat.NgayXuat = DateOnly.Parse(dateNgayNhap.Text);
            phieuXuat.MaCuaHangNavigation.TenCuaHang = cobCHNhap.Text;
            phieuXuat.MaCuaHangNavigation.TenCuaHang = cobCHXuat.Text;
            phieuXuat.MaCuaHangNavigation.DiaChi = txtDiaChi.Text;
            
            phieuXuat.MaQlNavigation.TenQl  = txtTenNV.Text;
            phieuXuat.MaQlNavigation.MaQl  = int .Parse(txtMaNV.Text);
            phieuXuat.MaQlNavigation.Sdt = txtSdt.Text;
          
            // phieuXuat.MaSPNavigation.TenSp = txtTenSP.Text;
            // phieuXuat.MaSPNavigation.MaSp  =  int.Parse(txtMaSanPham.Text);
            // phieuXuat.MaSPNavigation.SoLuong = (int)NumberSoLuong.Value;
            // phieuXuat.MaSPNavigation.GiaSp = int.Parse(txtGiaTien.Text);
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
