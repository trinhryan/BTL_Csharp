using System;
using System.Data;
using System.Windows.Forms;
using Business;
using DataAccess.Entities;

namespace GUI
{
    public partial class HoaDonForm : Form
    {
        HoaDonBus bus = new();

        public HoaDonForm()
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

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new();
            hoaDon.MaHd = int.Parse(txtMaHD.Text);
         
            // hoaDon.MaSpNavigation.TenSp = txtTenSP.Text;
            // hoaDon.MaSpNavigation.SoLuong = (int)NumberSoLuong.Value;
            // hoaDon.MaSpNavigation.GiaSp = decimal.Parse(txtGiaTien.Text);
            hoaDon.NgayBan = DateOnly.Parse(dateNgayBan.Text);
            // hoaDon.TongTien = hoaDon.MaSpNavigation.GiaSp * hoaDon.MaSpNavigation.SoLuong;
            bus.AddData(hoaDon);
            MessageBox.Show("Thêm thành công");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = bus.GetAllDataTable();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Chưa chọn mã hóa đơn cần xóa");
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Chưa chọn mã hóa đơn cần sửa");
                return;
            }

            HoaDon hoaDon = new();
            hoaDon.MaHd = int.Parse(txtMaHD.Text);
            // hoaDon.MaSpNavigation.TenSp = txtTenSP.Text;
            // hoaDon.MaSpNavigation.SoLuong = (int)NumberSoLuong.Value;
            // hoaDon.MaSpNavigation.GiaSp = decimal.Parse(txtGiaTien.Text);
            hoaDon.NgayBan = DateOnly.Parse(dateNgayBan.Text);
            // hoaDon.TongTien = hoaDon.MaSpNavigation.GiaSp * hoaDon.MaSpNavigation.SoLuong;

            bus.UpdateData(hoaDon);
            MessageBox.Show("Sửa thành công");

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var form = new SanPhamForm();
            form.Show();
            this.Hide();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In hóa đơn thành công  ");
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvHoaDon.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (data != null)
            {
                txtMaHD.Text = data["MaHd"].ToString();
                dateNgayBan.Text = data["NgayBan"].ToString();
                txtTenSP.Text = data["TenSp"].ToString();
                NumberSoLuong.Text = data["SoLuong"].ToString();
                txtGiaTien.Text = data["GiaSp"].ToString();
                
            }
        }
    }
}
