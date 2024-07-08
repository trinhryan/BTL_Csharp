using System.Data;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business;

public class PhieuNhapBus: IBus<PhieuNhap>
{
    MyDbContext db = new MyDbContext();
    public List<PhieuNhap> GetAllData()
    {
        return db.PhieuNhaps.ToList();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("MaPhieuNhap");
        dt.Columns.Add("NgayNhap");
        dt.Columns.Add("CuaHangNhap");
        dt.Columns.Add("NhanVienNhap");
        dt.Columns.Add("NhaCungcap");
        dt.Columns.Add("MaNCC");
        dt.Columns.Add("SoDienThoai");
        dt.Columns.Add("TenSanPham");
        dt.Columns.Add("MaSP");
        dt.Columns.Add("SoLuong");
        dt.Columns.Add("DonGia");

        var data = GetAllData();
        foreach (var item in data)
        {
               dt.Rows.Add(item.MaPn, item.NgayNhap, item.MaCHNNavigation?.TenCuaHang, item.MaQlNavigation?.TenQl, item.MaNccNavigation.TenNcc, item.SoDienThoai, item.TenSanPham, item.MaSP, item.SoLuong, item.DonGia);
            
        }

        return dt;
    }

    public PhieuNhap GetDataById(object id)
    {
        return db.PhieuNhaps.FirstOrDefault(e=>e.MaPn == (int)id);
        
    }

    public void AddData(PhieuNhap obj)
    {
        db.PhieuNhaps.Add(obj);
        db.SaveChanges();
    }

    public void UpdateData(PhieuNhap obj)
    {
        PhieuNhap phieuNhap = (PhieuNhap)obj;
        PhieuNhap phieuNhapUpdate = db.PhieuNhaps.FirstOrDefault(e=>e.MaPn == phieuNhap.MaPn);
        phieuNhapUpdate.NgayNhap = phieuNhap.NgayNhap;
        phieuNhapUpdate.MaCuaHang = phieuNhap.MaCHNNavigation.MaCuaHang;
        phieuNhapUpdate.MaQl = phieuNhap.MaQlNavigation.MaQl;
        phieuNhapUpdate.MaNcc = phieuNhap.MaNccNavigation.MaNcc;
        phieuNhapUpdate.SoDienThoai = phieuNhap.SoDienThoai;
        phieuNhapUpdate.TenSanPham = phieuNhap.TenSanPham;
        phieuNhapUpdate.MaSP = phieuNhap.MaSP;
        phieuNhapUpdate.SoLuong = phieuNhap.SoLuong;
        phieuNhapUpdate.DonGia = phieuNhap.DonGia;
        db.SaveChanges();
    }

    public void DeleteData(object id)
    {
        PhieuNhap phieuNhap = db.PhieuNhaps.FirstOrDefault(e=>e.MaPn == (int)id);
        db.PhieuNhaps.Remove(phieuNhap);
        db.SaveChanges();
    }

    public List<PhieuNhap> SearchData(string tuKhoa)
    {
        return db.PhieuNhaps.Where(e=>e.TenSanPham.Contains(tuKhoa)).ToList();
    }

}