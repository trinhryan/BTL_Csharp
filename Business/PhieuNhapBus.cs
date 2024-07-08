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
        return DbType.PhieuNhaps.ToList();
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
               dt.Rows.Add(item.MaPhieuNhap, item.NgayNhap, item.CuaHangNhap, item.NhanVienNhap, item.NhaCungcap, item.MaNCC, item.SoDienThoai, item.TenSanPham, item.MaSP, item.SoLuong, item.DonGia);
            
        }

        return dt;
    }

    public PhieuNhap GetDataById(object id)
    {
        return db.PhieuNhaps.FirstOrDefault(e=>e.MaPhieuNhap == (int)id);
        
    }

    public void AddData(PhieuNhap obj)
    {
        db.PhieuNhaps.Add(obj);
        db.SaveChanges();
    }

    public void UpdateData(PhieuNhap obj)
    {
        PhieuNhap phieuNhap = (PhieuNhap)obj;
        PhieuNhap phieuNhapUpdate = db.PhieuNhaps.FirstOrDefault(e=>e.MaPhieuNhap == phieuNhap.MaPhieuNhap);
        phieuNhapUpdate.NgayNhap = phieuNhap.NgayNhap;
        phieuNhapUpdate.CuaHangNhap = phieuNhap.CuaHangNhap;
        phieuNhapUpdate.NhanVienNhap = phieuNhap.NhanVienNhap;
        phieuNhapUpdate.NhaCungcap = phieuNhap.NhaCungcap;
        phieuNhapUpdate.MaNCC = phieuNhap.MaNCC;
        phieuNhapUpdate.SoDienThoai = phieuNhap.SoDienThoai;
        phieuNhapUpdate.TenSanPham = phieuNhap.TenSanPham;
        phieuNhapUpdate.MaSP = phieuNhap.MaSP;
        phieuNhapUpdate.SoLuong = phieuNhap.SoLuong;
        phieuNhapUpdate.DonGia = phieuNhap.DonGia;
        db.SaveChanges();
    }

    public void DeleteData(object id)
    {
        PhieuNhap phieuNhap = db.PhieuNhaps.FirstOrDefault(e=>e.MaPhieuNhap == (int)id);
        db.PhieuNhaps.Remove(phieuNhap);
        db.SaveChanges();
    }

    public List<PhieuNhap> SearchData(string tuKhoa)
    {
        return db.PhieuNhaps.Where(e=>e.TenSanPham.Contains(tuKhoa)).ToList();
    }
}