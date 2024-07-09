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
    public partial class DonHangForm : Form
    {
        DonHangBus bus = new();
        public DonHangForm()
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

        private void dgvChiTietDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            donHang.MaDh = int.Parse(txtMaDonHang.Text);
            donHang.NgayTao = DateOnly.Parse(dateNgayNhap.Text);
            donHang.MaCuaHangNavigation.TenCuaHang= cobCuaHang.Text;
            donHang.MaSp = int.Parse(txtMaSanPham.Text);
            donHang.MaSpNavigation.TenSp = txtTenSP.Text;
            donHang.MaSpNavigation.SoLuong =  (int)NumberSoLuong.Value;
            donHang.MaSpNavigation.GiaSp = int.Parse(txtGiaTien.Text);
            donHang.TrangThai = rdbChuaThanhToan.Checked ? "Chưa thanh toán" : "Đã thanh toán";
            donHang.TongTien= (float?)(donHang.MaSpNavigation.GiaSp * donHang.MaSpNavigation.SoLuong);

            bus.AddData(donHang);
            
            MessageBox.Show("Thêm thành công");
        }

        private void btnHuy_Click(object sender, EventArgs e) //Sửa
        {
            // validate all fields
            if(txtMaDonHang.Text == "")
            {
                MessageBox.Show("Chưa chọn mã đơn hàng cần sửa");
                return;
            }
            
            DonHang donHang = new();
            donHang.MaDh = int.Parse(txtMaDonHang.Text);
            donHang.NgayTao = DateOnly.Parse(dateNgayNhap.Text);
            donHang.MaCuaHangNavigation.TenCuaHang= cobCuaHang.Text;
            donHang.MaSp = int.Parse(txtMaSanPham.Text);
            donHang.MaSpNavigation.TenSp = txtTenSP.Text;
            donHang.MaSpNavigation.SoLuong =  (int)NumberSoLuong.Value;
            donHang.MaSpNavigation.GiaSp = int.Parse(txtGiaTien.Text);
            donHang.TrangThai = rdbChuaThanhToan.Checked ? "Chưa thanh toán" : "Đã thanh toán";
            donHang.TongTien= (float?)(donHang.MaSpNavigation.GiaSp * donHang.MaSpNavigation.SoLuong);
            
            bus.UpdateData(donHang);
            
            MessageBox.Show("Sửa thành công");
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDonHang.Text == "")
            {
                MessageBox.Show("Chưa chọn mã đơn hàng cần xóa");
                return;
            }

            bus.DeleteData(int.Parse(txtMaDonHang.Text));
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
    }
}
