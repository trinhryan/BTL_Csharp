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
    public partial class SanPhamForm : Form
    {
        SanPhamBus bus = new();

        public SanPhamForm()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new();

            // sanPham.MaSp = txtMaSanPham.Text;
            // sanPham.TenSp = txtTenSP.Text;
            // sanPham.GiaSp = txtGiaTien.Text;
            // sanPham.SoLuong = NumberSoLuong.Value;
            // sanPham.Hsd = txtHsd.Text;
            // sanPham.Nsx = txtNsx.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // validate all fields
            if (txtMaSanPham.Text == " ")
            {
                MessageBox.Show(" Chưa chọn mã sản phẩm cần xóa");
                return;
            }

            bus.DeleteData(txtMaSanPham.Text);
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            if(txtSeach.Text == "")
            {
                MessageBox.Show("Chưa nhập tên sản phẩm cần tìm");
                return;
            }
            dgvSanPham.DataSource = bus.SearchData( txtSeach.Text);
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvSanPham.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (data != null)
            {
                txtMaSanPham.Text = data["MaSp"].ToString();
                txtTenSP.Text = data["TenSp"].ToString();
                txtGiaTien.Text = data["GiaSp"].ToString();
                NumberSoLuong.Value = Convert.ToInt32(data["SoLuong"]);
                txtHsd.Text = data["Hsd"].ToString();
                txtNsx.Text = data["Nsx"].ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // validate all fields
            if (txtMaSanPham.Text == " ")
            {
                MessageBox.Show(" Chưa chọn mã sản phẩm cần sửa");
                return;
            }

            // SanPham sanPham = new();
            // sanPham.MaSp = txtMaSanPham.Text;
            // sanPham.TenSp = txtTenSP.Text;
            // sanPham.GiaSp = txtGiaTien.Text;
            // sanPham.SoLuong = NumberSoLuong.Value;
            // sanPham.Hsd = txtHsd.Text;
            // sanPham.Nsx = txtNsx.Text;
            // bus.UpdateData(sanPham);

            MessageBox.Show("Sửa thành công");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = bus.GetAllDataTable();
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
    }
}
