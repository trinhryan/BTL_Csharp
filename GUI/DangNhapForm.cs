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

namespace GUI
{
    public partial class DangNhapForm : Form
    {
        NguoiDungBus bus = new();
        public DangNhapForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object? sender, EventArgs e)
        {
            var tenDangNhap = txtTenDangNhap.Text;
            var matKhau = txtMatKhau.Text;
            // check if tenDangNhap and matKhau are empty
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu");
                return;
            }

            var result = bus.DangNhap(tenDangNhap, matKhau);

            if (result)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                var mainForm = new NguoiDungForm();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btnDangKi_Click(object? sender, EventArgs e)
        {
            var form = new DangKyForm();
            form.Show();
            this.Hide();
        }

        private void btnQuenMatKhau_Click(object? sender, EventArgs e)
        {
            var form = new QuenMatKhauForm();
            form.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // exit the application
            Application.Exit();
        }
    }
}
