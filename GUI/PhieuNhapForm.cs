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
    public partial class PhieuNhapForm : Form
    {
         PhieuNhapBus bus = new();
        public PhieuNhapForm()
        {
            InitializeComponent();
        }

        private void NumberSoLuong_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhieuNhap pn = new PhieuNhap();
            pn.MaPhieuNhap = txtMaPhieuNhap.Text;
            pn.NgayNhap = DateTime.Parse(dateNgayNhap.Text);
            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvPhieuNhapHang.DataSource = bus.GetData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuNhap.Text == "")
            {
                MessageBox.Show("Chưa chọn mã phiếu nhập cần xóa");
                return;
            }

            bus.DeleteData(txtMaPhieuNhap.Text);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(txtMaPhieuNhap.Text == "")
            {
                MessageBox.Show("Chưa chọn mã phiếu nhập cần sua");
                return;
            }

            
            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void dgvPhieuNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
