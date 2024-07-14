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
    public partial class KhachHangForm : Form
    {
        KhachHangBus bus = new();

        public KhachHangForm()
        {
            InitializeComponent();
            dgvKhacHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhacHang.DataSource = bus.GetAllDataTable();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            KhachHang khachHang = new();
            khachHang.TenKh = txtTenKH.Text;
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.Sdt = txtSdt.Text;

            var ketqua = bus.AddData(khachHang);
            MessageBox.Show(ketqua ? "Thêm thành công" : "Thêm thất bại");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // validate all fields
            if (txtMaKH.Text == " ")
            {
                MessageBox.Show(" Chưa chọn mã khách hàng cần sửa");
                return;
            }

            if (txtTenKH.Text == " ")
            {
                MessageBox.Show(" Chưa chọn tên khách hàng cần sửa");
                return;
            }

            if (txtDiaChi.Text == " ")
            {
                MessageBox.Show(" Chưa chọn địa chỉ cần sửa");
                return;
            }

            KhachHang khachHang = new();
            khachHang.MaKh = int.Parse(txtMaKH.Text);
            khachHang.TenKh = txtTenKH.Text;
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.Sdt = txtSdt.Text;
            var ketQua = bus.UpdateData(khachHang);

            MessageBox.Show(ketQua ? "Sửa thành công" : "Sửa thất bại");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show(" Chưa chọn mã khách hàng cần xóa");
                return;
            }

            var ketQua = bus.DeleteData(txtMaKH.Text);
            MessageBox.Show(ketQua ? "Xóa thành công" : "Xóa thất bại");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvKhacHang.DataSource = bus.GetAllDataTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var data = bus.SearchData(txtSeach.Text);
            var dt = new DataTable();
            dt.Columns.Add("MaKhachHang");
            dt.Columns.Add("TenKhachHang");
            dt.Columns.Add("Sdt");
            dt.Columns.Add("DiaChi");
            
            foreach (var item in data)
            {
                dt.Rows.Add(item.MaKh, item.TenKh, item.Sdt, item.DiaChi);
            }
            
            dgvKhacHang.DataSource = dt;
        }

        private void dgvKhacHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var data = dgvKhacHang.Rows[e.RowIndex].DataBoundItem as DataRowView;
                if (data != null)
                {
                    txtMaKH.Text = data["MaKhachHang"].ToString();
                    txtTenKH.Text = data["TenKhachHang"].ToString();
                    txtDiaChi.Text = data["DiaChi"].ToString();
                    txtSdt.Text = data["Sdt"].ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
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
