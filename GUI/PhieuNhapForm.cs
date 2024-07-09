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
    public partial class PhieuNhapForm : Form
    {
         PhieuNhapBus bus = new();
        public PhieuNhapForm()
        {
            InitializeComponent();
        }

        private void NumberSoLuong_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhieuNhap phieuNhap = new();
            phieuNhap.MaPn = int.Parse(txtMaPhieuNhap.Text);
            phieuNhap.NgayNhap= DateOnly.Parse(dateNgayNhap.Text);
            
            phieuNhap.MaNccNavigation.MaNcc = int.Parse(txtMaNCC.Text);
            phieuNhap.MaNccNavigation.TenNcc = txtTenNCC.Text;
            phieuNhap.MaNccNavigation.Sdt = txtSdt.Text;
            
            phieuNhap.MaQlNavigation.MaQl = int.Parse(txtMaNV.Text);
            phieuNhap.MaQlNavigation.TenQl = txtTenNV.Text;
           
            
            phieuNhap.MaSpNavigation.TenSp = txtTenSP.Text;
            phieuNhap.MaSpNavigation.MaSp = int.Parse(txtMaSanPham.Text);
            phieuNhap.MaSpNavigation.SoLuong = (int)NumberSoLuong.Value;
            phieuNhap.MaSpNavigation.GiaSp = int.Parse(txtGiaTien.Text);
            
            bus.InsertData(phieuNhap);
            
            MessageBox.Show("Thêm thành công");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvPhieuNhapHang.DataSource = bus.GetAllDataTable();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuNhap.Text == "")
            {
                MessageBox.Show("Chưa chọn mã phiếu nhập cần xóa");
                return;
            }

            bus.DeleteData(txtMaPhieuNhap.Text);
            
            MessageBox.Show("Xóa thành công");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuNhap.Text == "")
            {
                MessageBox.Show("Chưa chọn mã phiếu nhập cần sửa");
                return;
            }
            
            PhieuNhap phieuNhap = new();
            phieuNhap.MaPn = int.Parse(txtMaPhieuNhap.Text);
            phieuNhap.NgayNhap= DateOnly.Parse(dateNgayNhap.Text);
            
            phieuNhap.MaNccNavigation.MaNcc = int.Parse(txtMaNCC.Text);
            phieuNhap.MaNccNavigation.TenNcc = txtTenNCC.Text;
            phieuNhap.MaNccNavigation.Sdt = txtSdt.Text;
            
            phieuNhap.MaQlNavigation.MaQl = int.Parse(txtMaNV.Text);
            phieuNhap.MaQlNavigation.TenQl = txtTenNV.Text;
           
            
            phieuNhap.MaSpNavigation.TenSp = txtTenSP.Text;
            phieuNhap.MaSpNavigation.MaSp = int.Parse(txtMaSanPham.Text);
            phieuNhap.MaSpNavigation.SoLuong = (int)NumberSoLuong.Value;
            phieuNhap.MaSpNavigation.GiaSp = int.Parse(txtGiaTien.Text);
            
            bus.UpdateData(phieuNhap);
            
            MessageBox.Show("Sửa thành công");
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var form = new SanPhamForm();
            form.Show();
            this.Hide();
        }

        private void dgvPhieuNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvPhieuNhapHang.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (data != null)
            {
                txtMaPhieuNhap.Text = data["MaPn"].ToString();
                dateNgayNhap.Text = data["NgayNhap"].ToString();
                txtMaNCC.Text = data["MaNcc"].ToString();
                txtTenNCC.Text = data["TenNcc"].ToString();
                txtSdt.Text = data["SdtNcc"].ToString();
                txtMaNV.Text = data["MaQl"].ToString();
                txtTenNV.Text = data["TenQl"].ToString();
                txtMaSanPham.Text = data["MaSp"].ToString();
                txtTenSP.Text = data["TenSp"].ToString();
                NumberSoLuong.Value = int.Parse(data["SoLuong"].ToString());
                txtGiaTien.Text = data["GiaSp"].ToString();
                
            }
        }
    }
}
