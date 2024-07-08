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

namespace GUI
{
    public partial class ChiTietDonHang : Form
    {
        ChiTietDonHangBus bus = new();
        public ChiTietDonHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChiTietDonHangBus chiTietDonHang = new();

            chiTietDonHang.MaDH = txtMaDonHang.Text;
            chiTietDonHang.MaSP = txtMaSanPham.Text;
            chiTietDonHang.SoLuong = int.Parse(NumberSoLuong.Value.ToString());
            chiTietDonHang.CuaHang = cobCuaHang.Text;
            chiTietDonHang.TenKhachHang = txtTenKhachHang.Text;
            chiTietDonHang.GiaTien = txtGiaTien.Text;
            chiTietDonHang.MaKhachHang = txtMaKH.Text;
            chiTietDonHang.NgayTao = dateNgayNhap.Value;
            chiTietDonHang.Sdt = txtSdt.Text;
            bus.Add(chiTietDonHang);

            // if (txtMaDonHang.Text != "" && txtMaSanPham.Text != "" && txtTenSP.Text != "" && txtTenKhachHang.Text != "" && txtGiaTien.Text != "" && txtMaKH.Text != "" && txtSdt.Text != "")
            // {
            //     MessageBox.Show("Thêm thành công");
            // }
            // else
            // {
            //     MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            // }


        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvChiTietDonHang.DataSource = bus.GetAllDataTable();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDonHang.Text != "")
            {

                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void dgvChiTietDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvChiTietDonHang.Rows[e.RowIndex].Cells;
            if (data[0].Value != null)
            {
                txtMaDonHang.Text = data[0].Value.ToString();
                txtMaSanPham.Text = data[1].Value.ToString();
                txtTenSP.Text = data[8].Value.ToString();
                NumberSoLuong.Value = int.Parse(data[2].Value.ToString());
                cobCuaHang.Text = data[3].Value.ToString();
                txtTenKhachHang.Text = data[4].Value.ToString();
                txtGiaTien.Text = data[6].Value.ToString();
                txtMaKH.Text = data[5].Value.ToString();
                dateNgayNhap.Value = DateTime.Parse(data[7].Value.ToString());
                txtSdt.Text = data[9].Value.ToString();
            }
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var form = new DonHangForm();
            form.Show();
            this.Hide();
        }
    }
}
