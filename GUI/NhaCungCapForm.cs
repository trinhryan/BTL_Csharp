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
    public partial class NhaCungCapForm : Form
    {
         NhaCungCapBus bus = new();
        public NhaCungCapForm()
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhaCungCap nhaCungCap = new();
            nhaCungCap.MaNcc= int.Parse(txtMaNCC.Text);
            nhaCungCap.TenNcc = txtTenNCC.Text;
            nhaCungCap.Sdt = int.Parse(txtSdt.Text);
            nhaCungCap.DiaChi = txtDiaChi.Text;
            
            bus.AddData(nhaCungCap);
            
            MessageBox.Show("Thêm thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Chưa chọn mã nhà cung cấp cần sửa");
                return;
            }

            NhaCungCap nhaCungCap = new();
            nhaCungCap.MaNcc = int.Parse(txtMaNCC.Text);
            nhaCungCap.TenNcc = txtTenNCC.Text;
            nhaCungCap.Sdt = int.Parse(txtSdt.Text);
            nhaCungCap.DiaChi = txtDiaChi.Text;

            bus.UpdateData(nhaCungCap);

            MessageBox.Show("Sửa thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Chưa chọn mã nhà cung cấp cần xóa");
                return;
            }

            bus.DeleteData(txtMaNCC.Text);

            MessageBox.Show("Xóa thành công");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvNcc.DataSource = bus.GetAllDataTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSeach.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                return;
            }
            dgvNcc.DataSource = bus.SearchData(txtSeach.Text);
        }
    }
}
