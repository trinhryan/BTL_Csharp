using System.Data;
using Business;
using DataAccess.Entities;

namespace GUI;

public partial class NguoiDungForm : Form
{
    NguoiDungBus bus = new();
    public NguoiDungForm()
    {
        InitializeComponent();
    }

    private void btnReload_Click(object sender, EventArgs e)
    {
        dgvNguoiDung.DataSource = bus.GetAllDataTable();
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        NguoiDung nguoiDung = new();
        nguoiDung.TenDangNhap = txtTenDangNhap.Text;
        nguoiDung.MatKhau = txtMatKhau.Text;
        nguoiDung.HoTen = txtHoTen.Text;
        nguoiDung.DiaChi = txtDiaChi.Text;
        nguoiDung.Sdt = txtSdt.Text;
        bus.AddData(nguoiDung);
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (txtTenDangNhap.Text == "")
        {
            MessageBox.Show("Chưa chọn tên đăng nhập cần xóa");
            return;
        }

        bus.DeleteData(txtTenDangNhap.Text);
    }

    private void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        var data = dgvNguoiDung.Rows[e.RowIndex].DataBoundItem as DataRowView;
        if (data != null)
        {
            txtTenDangNhap.Text = data["TenDangNhap"].ToString();
            txtHoTen.Text = data["HoTen"].ToString();
            txtDiaChi.Text = data["DiaChi"].ToString();
            txtSdt.Text = data["Sdt"].ToString();
        }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        // validate all fields
        if (txtTenDangNhap.Text == "")
        {
            MessageBox.Show("Chưa chọn tên đăng nhập cần sửa");
            return;
        }

        if (txtHoTen.Text == "")
        {
            MessageBox.Show("Chưa nhập họ tên");
            return;
        }

        if (txtDiaChi.Text == "")
        {
            MessageBox.Show("Chưa nhập địa chỉ");
            return;
        }

        if (txtSdt.Text == "")
        {
            MessageBox.Show("Chưa nhập số điện thoại");
            return;
        }

        NguoiDung nguoiDung = new();
        nguoiDung.TenDangNhap = txtTenDangNhap.Text;
        nguoiDung.HoTen = txtHoTen.Text;
        nguoiDung.DiaChi = txtDiaChi.Text;
        nguoiDung.Sdt = txtSdt.Text;
        bus.UpdateData(nguoiDung);

        MessageBox.Show("Sửa thành công");
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