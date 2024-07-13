using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RegisterForm : Form
    {
        Client _client = new Client();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenDangNhap = textBox1.Text;
            var matKhau = textBox2.Text;
            
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống");
                return;
            }
            
            var result = _client.Register(tenDangNhap, matKhau);
            
            if (result)
            {
                MessageBox.Show("Đăng ký thành công");
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại");
            }
            
        }
    }
}
