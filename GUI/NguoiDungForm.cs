using System;
using System.Data;
using System.Windows.Forms;
using Business;
using DataAccess.Entities;

namespace GUI;

public partial class NguoiDungForm : Form
{
    NguoiDungBus bus = new();
    public NguoiDungForm()
    {
        InitializeComponent();
        dgvNguoiDung.DataSource = bus.GetAllDataTable();
        dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    private void btnReload_Click(object sender, EventArgs e)
    {
        dgvNguoiDung.DataSource = bus.GetAllDataTable();
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        // kiem tra nguoi dung da nhap day du thong tin chua
        if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "" || txtHoTen.Text == "" || txtDiaChi.Text == "" || txtSdt.Text == "")
        {
            MessageBox.Show("Chưa nhập đủ thông tin");
            return;
        }
        
        NguoiDung nguoiDung = new();
        nguoiDung.TenDangNhap = txtTenDangNhap.Text;
        nguoiDung.MatKhau = txtMatKhau.Text;
        nguoiDung.HoTen = txtHoTen.Text;
        nguoiDung.DiaChi = txtDiaChi.Text;
        nguoiDung.Sdt = txtSdt.Text;
        var ketqua = bus.AddData(nguoiDung);

        if (ketqua)
        {
            MessageBox.Show("Thêm thành công");
        }
        else
        {
            MessageBox.Show("Tên đăng nhập đã tồn tại");
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (txtTenDangNhap.Text == "")
        {
            MessageBox.Show("Chưa chọn tên đăng nhập cần xóa");
            return;
        }
        var ketQua = bus.DeleteData(txtTenDangNhap.Text);
        MessageBox.Show(ketQua ? "Xóa thành công" : "Xóa thất bại");
    }

    private void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            var data = dgvNguoiDung.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (data == null) return;
            txtTenDangNhap.Text = data["TenDangNhap"].ToString();
            txtHoTen.Text = data["HoTen"].ToString();
            txtDiaChi.Text = data["DiaChi"].ToString();
            txtSdt.Text = data["Sdt"].ToString();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
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
        var ketQua = bus.UpdateData(nguoiDung);
        MessageBox.Show(ketQua ? "Sửa thành công" : "Sửa thất bại | Tên đăng nhập không được thay đổi");
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

    private void btnSearch_Click(object? sender, EventArgs e)
    {
        if (txtSearch.Text == "")
        {
            MessageBox.Show("Chưa nhập từ khóa tìm kiếm");
            return;
        }

        var data = bus.SearchData(txtSearch.Text);
        
        var dataTable = new DataTable();
        dataTable.Columns.Add("TenDangNhap");
        dataTable.Columns.Add("HoTen");
        dataTable.Columns.Add("GioiTinh");
        dataTable.Columns.Add("DiaChi");
        dataTable.Columns.Add("Sdt");
        
        foreach (var nguoiDung in data)
        {
            dataTable.Rows.Add(nguoiDung.TenDangNhap, nguoiDung.HoTen, nguoiDung.GioiTinh, nguoiDung.DiaChi, nguoiDung.Sdt);
        }
        
        dgvNguoiDung.DataSource = dataTable;
    }
}