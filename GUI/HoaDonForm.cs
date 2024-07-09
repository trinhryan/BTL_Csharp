using System;
using System.Windows.Forms;
using Business;

namespace GUI;

public partial class HoaDonForm : Form
{
    private HoaDonBus bus = new();
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
}