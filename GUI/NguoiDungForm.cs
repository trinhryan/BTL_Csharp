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

  
}