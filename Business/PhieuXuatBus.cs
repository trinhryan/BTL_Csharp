using System.Data;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business;

public class PhieuXuatBus: IBus<PhieuXuat>
{
    private MyDbContext db = new MyDbContext();
    public List<PhieuXuat> GetAllData()
    {
        return db.PhieuXuats.ToList();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("MaPhieuXuat");
        dt.Columns.Add("NgayXuat");
        dt.Columns.Add("CuaHangXuat");
        dt.Columns.Add("CuaHangNhan");
        dt.Columns.Add("NhanVienXuat");
        dt.Columns.Add("MaNV");
        dt.Columns.Add("DiaChi");
        dt.Columns.Add("SoDienThoai");
        dt.Columns.Add("TenSanPham");
        dt.Columns.Add("MaSP");
        dt.Columns.Add("SoLuong");
        dt.Columns.Add("DonGia");
        
        var data = GetAllData();
        foreach (var item in data)
        {
            dt.Rows.Add(item.MaPhieuXuat, item.NgayXuat, item.CuaHangNhap, item.CuaHangNhan, item.NhanVienXuat, item.MaNV, item.DiaChi, item.SoDienThoai, item.TenSanPham, item.MaSP, item.SoLuong, item.DonGia);
        }

        return dt;
    }

    public PhieuXuat GetDataById(object id)
    {
        return db.PhieuXuats.FromSqlRaw("select * from PhieuXuat where MaPhieuXuat = {0}", id).FirstOrDefault();
    }

    public void AddData(PhieuXuat obj)
    {
        PhieuXuat phieuXuat = (PhieuXuat)obj;
        db.Database.ExecuteSqlRaw("insert into PhieuXuat(NgayXuat, CuaHangXuat, CuaHangNhan, NhanVienXuat, MaNV, DiaChi, SoDienThoai, TenSanPham, MaSP, SoLuong, DonGia) values({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", phieuXuat.NgayXuat, phieuXuat.CuaHangXuat, phieuXuat.CuaHangNhan, phieuXuat.NhanVienXuat, phieuXuat.MaNV, phieuXuat.DiaChi, phieuXuat.SoDienThoai, phieuXuat.TenSanPham, phieuXuat.MaSP, phieuXuat.SoLuong, phieuXuat.DonGia);
    }

    public void UpdateData(PhieuXuat obj)
    {
        PhieuXuat phieuXuat = (PhieuXuat)obj;
        PhieuXuat phieuXuatUpdate = db.PhieuXuats.FirstOrDefault(e=>e.MaPhieuXuat == phieuXuat.MaPhieuXuat);
        phieuXuatUpdate.NgayXuat = phieuXuat.NgayXuat;
        phieuXuatUpdate.CuaHangXuat = phieuXuat.CuaHangXuat;
        phieuXuatUpdate.CuaHangNhan = phieuXuat.CuaHangNhan;
        phieuXuatUpdate.NhanVienXuat = phieuXuat.NhanVienXuat;
        phieuXuatUpdate.MaNV = phieuXuat.MaNV;
        phieuXuatUpdate.DiaChi = phieuXuat.DiaChi;
        phieuXuatUpdate.Sdt = phieuXuat.Sdt;
        phieuXuatUpdate.TenSanPham = phieuXuat.TenSanPham;
        phieuXuatUpdate.MaSP = phieuXuat.MaSP;
        phieuXuatUpdate.SoLuong = phieuXuat.SoLuong;
        phieuXuatUpdate.DonGia = phieuXuat.DonGia;
        db.SaveChanges();
    }

    public void DeleteData(object id)
    {
        db.Database.ExecuteSqlRaw("delete from PhieuXuat where MaPhieuXuat = {0}", id);
    }

    public List<PhieuXuat> SearchData(string tuKhoa)
    {
        return db.PhieuXuats.Where(e => e.MaPhieuXuat.Contains(tuKhoa)).ToList();
    }
}