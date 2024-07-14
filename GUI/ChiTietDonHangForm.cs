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
    public partial class ChiTietDonHangForm : Form
    {
        ChiTietDonHangBus bus = new();
        public ChiTietDonHangForm()
        {
            InitializeComponent();
            dgvChiTietDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietDonHang.DataSource = bus.GetAllDataTable();
            txtTongTien.Text = bus.GetTongTien().ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDonHang.Text == "" || txtMaKH.Text == "" || txtMaSanPham.Text == "" ||
                    txtTenKhachHang.Text == "" || txtTenSP.Text == "" || txtSdt.Text == "" || txtGiaTien.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }

                var cuaHang = bus.GetCuaHang().FirstOrDefault(e => e.TenCuaHang == cobCuaHang.Text);
                var sanPham = bus.GetSanPham().FirstOrDefault(e => e.TenSp == txtTenSP.Text);
                var chiTietDonHang = new ChiTietDonHang()
                {
                    // MaDh = int.Parse(txtMaDonHang.Text),
                    NgayTao = DateOnly.TryParse(dateNgayNhap.Text, out var date) ? date : DateOnly.MinValue,
                    CuaHang = cuaHang.MaCuaHang,
                    MaKh = int.Parse(txtMaKH.Text),
                    TenKh = txtTenKhachHang.Text,
                    Sdt = txtSdt.Text,
                    MaSp = int.Parse(txtMaSanPham.Text),
                    TenSp = txtTenSP.Text,
                    SoLuongSp = (int)NumberSoLuong.Value,
                    TongGiaTien = decimal.Parse(txtGiaTien.Text)
                };

                var ketQua = bus.AddData(chiTietDonHang);
                MessageBox.Show(ketQua ? "Thêm thành công" : "Thêm thất bại");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvChiTietDonHang.DataSource = bus.GetAllDataTable();
            txtTongTien.Text = bus.GetTongTien().ToString();

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
            
            var ketQua = bus.DeleteData(txtMaDonHang.Text);
            MessageBox.Show(ketQua ? "Xóa thành công" : "Xóa thất bại");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDonHang.Text == "")
            {
                MessageBox.Show("Chưa chọn mã đơn hàng cần sửa");
                return;
            }

            var cuaHang = bus.GetCuaHang().FirstOrDefault(e => e.TenCuaHang == cobCuaHang.Text);
            var sanPham = bus.GetSanPham().FirstOrDefault(e => e.TenSp == txtTenSP.Text);
            var chiTietDonHang = new ChiTietDonHang()
            {
                MaDh = int.Parse(txtMaDonHang.Text),
                NgayTao = DateOnly.TryParse(dateNgayNhap.Text, out var date) ? date : DateOnly.MinValue,
                CuaHang = cuaHang.MaCuaHang,
                MaKh = int.Parse(txtMaKH.Text),
                TenKh = txtTenKhachHang.Text,
                Sdt = txtSdt.Text,
                MaSp = int.Parse(txtMaSanPham.Text),
                TenSp = txtTenSP.Text,
                SoLuongSp = (int) NumberSoLuong.Value,
                TongGiaTien = decimal.Parse(txtGiaTien.Text)
            };
            
            var ketQua = bus.UpdateData(chiTietDonHang);
            MessageBox.Show(ketQua ? "Sửa thành công" : "Sửa thất bại");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvChiTietDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // dt.Columns.Add("MaDh");
                // dt.Columns.Add("NgayTao");
                // dt.Columns.Add("CuaHang");
                // dt.Columns.Add("MaKh");
                // dt.Columns.Add("TenKh");
                // dt.Columns.Add("Sdt");
                // dt.Columns.Add("MaSp");
                // dt.Columns.Add("TenSp");
                // dt.Columns.Add("SoLuongSp");
                // dt.Columns.Add("TongGiaTien");
                var data = dgvChiTietDonHang.Rows[e.RowIndex].Cells;
                if (data[0].Value != null)
                {
                    txtMaDonHang.Text = data[0].Value.ToString();
                    dateNgayNhap.Text = data[1].Value.ToString();
                    cobCuaHang.Text = data[2].Value.ToString();
                    txtMaKH.Text = data[3].Value.ToString();
                    txtTenKhachHang.Text = data[4].Value.ToString();
                    txtSdt.Text = data[5].Value.ToString();
                    txtMaSanPham.Text = data[6].Value.ToString();
                    txtTenSP.Text = data[7].Value.ToString();
                    NumberSoLuong.Value = int.Parse(data[8].Value.ToString());
                    txtGiaTien.Text = data[9].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
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
