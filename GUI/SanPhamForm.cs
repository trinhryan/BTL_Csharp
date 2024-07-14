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
    public partial class SanPhamForm : Form
    {
        SanPhamBus bus = new();

        public SanPhamForm()
        {
            InitializeComponent();
            dgvSanPham.DataSource = bus.GetAllDataTable();
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new();
            sanPham.TenSp = txtTenSP.Text;
            sanPham.GiaSp = decimal.Parse(txtGiaTien.Text);
            sanPham.SoLuong = int.Parse(NumberSoLuong.Value.ToString());
            sanPham.Hsd = DateOnly.Parse(txtHsd.Text);
            sanPham.Nsx = DateOnly.Parse(txtNsx.Text);
            var ketQua = bus.AddData(sanPham);
            MessageBox.Show(ketQua ? "Thêm thành công" : "Thêm thất bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // validate all fields
            if (txtMaSanPham.Text == "")
            {
                MessageBox.Show(" Chưa chọn mã sản phẩm cần xóa");
                return;
            }

            var ketQua = bus.DeleteData(txtMaSanPham.Text);
            MessageBox.Show(ketQua ? "Xóa thành công" : "Xóa thất bại");
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSeach.Text == "")
            {
                MessageBox.Show("Chưa nhập tên sản phẩm cần tìm");
                return;
            }

            var dt = new DataTable();
            dt.Columns.Add("MaSanPham");
            dt.Columns.Add("TenSanPham");
            dt.Columns.Add("Gia");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("HanSuDung");
            dt.Columns.Add("NgaySanXuat");
            dt.Columns.Add("PhanLoaiSanPham");
            var data = bus.SearchData(txtSeach.Text);
            foreach (var item in data)
            {
                dt.Rows.Add(item.MaSp, item.TenSp, item.GiaSp, item.SoLuong, item.Hsd, item.Nsx, item.PhanLoaiSp);
            }

            dgvSanPham.DataSource = dt;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var data = dgvSanPham.Rows[e.RowIndex].DataBoundItem as DataRowView;
                if (data != null)
                {
                    txtMaSanPham.Text = data["MaSanPham"].ToString();
                    txtTenSP.Text = data["TenSanPham"].ToString();
                    txtGiaTien.Text = data["Gia"].ToString();
                    NumberSoLuong.Value = Convert.ToInt32(data["SoLuong"]);
                    txtHsd.Text = data["HanSuDung"].ToString();
                    txtNsx.Text = data["NgaySanXuat"].ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text == "")
            {
                MessageBox.Show(" Chưa chọn mã sản phẩm cần sửa");
                return;
            }

            SanPham sanPham = new();
            sanPham.MaSp = int.Parse(txtMaSanPham.Text);
            sanPham.TenSp = txtTenSP.Text;
            sanPham.GiaSp = decimal.Parse(txtGiaTien.Text);
            sanPham.SoLuong = int.Parse(NumberSoLuong.Value.ToString());
            if(!txtHsd.Text.IsNullOrEmpty() && DateOnly.TryParse(txtHsd.Text, out _)) sanPham.Hsd = DateOnly.Parse(txtHsd.Text);
            if(!txtNsx.Text.IsNullOrEmpty() && DateOnly.TryParse(txtNsx.Text, out _)) sanPham.Nsx = DateOnly.Parse(txtNsx.Text);
            if(!txtPhanLoai.Text.IsNullOrEmpty()) sanPham.PhanLoaiSp = txtPhanLoai.Text;
            var ketQua = bus.UpdateData(sanPham);

            MessageBox.Show(ketQua ? "Sửa thành công" : "Sửa thất bại");
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