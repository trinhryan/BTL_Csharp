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
    public partial class DangKiForm : Form
    {
        NguoiDungBus bus = new ();

        public DangKiForm()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object? sender, EventArgs e)
        {
            var hoTen = txtHoVaTen.Text;
            var tenDangNhap = txtTenDangNhap.Text;
            var matKhau = txtMatKhau.Text;
            var gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            var sdt = txtSdt.Text;
            var diaChi = txtDiaChi.Text;
            
            // check if hoTen, tenDangNhap, matKhau, sdt, diaChi are empty
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            
            // check if matKhau is less than 6 characters
            if (matKhau.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự");
                return;
            }
            
            // check if sdt is not a number
            if (!int.TryParse(sdt, out _))
            {
                MessageBox.Show("Số điện thoại phải là số");
                return;
            }
            
            // check if tenDangNhap already exists
            var isExist = bus.KiemTraTenDangNhap(tenDangNhap);
            if (isExist)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
                return;
            }

            var nguoiDung = new NguoiDung
            {
                HoTen = hoTen,
                TenDangNhap = tenDangNhap,
                MatKhau = matKhau,
                GioiTinh = gioiTinh,
                Sdt = sdt,
                DiaChi = diaChi
            };
            // add new user
            bus.AddData(nguoiDung);
            
            MessageBox.Show("Đăng kí thành công");
        }

        private void btnDangNhap_Click(object? sender, EventArgs e)
        {
            var form = new DangNhapForm();
            form.Show();
            this.Hide();
        }

        private void btnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
