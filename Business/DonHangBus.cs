using System.Data;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business;

public class DonHangBus:IBus<DonHang>
{
    private MyDbContext db = new MyDbContext();
    public List<DonHang> GetAllData()
    {
        return db.DonHangs.ToList();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("MaDonHang");
        dt.Columns.Add("NgayTaoDon");
        dt.Columns.Add("CuaHangTaoDon");
        dt.Columns.Add("MaSanPham");
        dt.Columns.Add("TenSanPham");
        dt.Columns.Add("SoLuong");
        dt.Columns.Add("DonGiaSanPham");
        dt.Columns.Add("TrangThai");
        dt.Columns.Add("TongDonHang");
        
        var data = GetAllData();
        foreach (var item in data)
        {
            var tenSanPham = db.SanPhams.FirstOrDefault(e=>e.MaSp == item.MaSp)?.TenSp;
            var soLuong = db.SanPhams.FirstOrDefault(e=>e.MaSp == item.MaSp)?.SoLuong;
            var giaSp = db.SanPhams.FirstOrDefault(e=>e.MaSp == item.MaSp)?.GiaSp;
            var tenCuaHang = db.CuaHangs.FirstOrDefault(e=>e.MaCuaHang == item.MaCuaHang)?.TenCuaHang;
            
            dt.Rows.Add(item.MaDh, item.NgayTao, tenCuaHang, item.MaSp, tenSanPham, soLuong, giaSp, item.TrangThai, item.TongTien);
        }

        return dt;
    }

    public DonHang GetDataById(object id)
    {
        return db.DonHangs.FirstOrDefault(e=>e.MaDh == (int)id);
    }

    public bool AddData(DonHang obj)
    {
        var donHang = db.DonHangs.FirstOrDefault(e=>e.MaDh == obj.MaDh);
        if (donHang != null)
        {
            return false;
        }
        db.DonHangs.Add(obj);
        db.SaveChanges();
        return true;
    }

    public bool UpdateData(DonHang obj)
    {
        DonHang donHang = (DonHang)obj;
        DonHang donHangUpdate = db.DonHangs.FirstOrDefault(e=>e.MaDh == int.Parse(donHang.MaDh.ToString()));
        if (donHangUpdate == null)
        {
            return false;
        }
        donHangUpdate.NgayTao = donHang.NgayTao;
        donHangUpdate.TongTien = donHang.TongTien;
        donHangUpdate.TrangThai = donHang.TrangThai;
        donHangUpdate.MaCuaHang = donHang.MaCuaHang;
        donHangUpdate.MaSp = donHang.MaSp;
        db.SaveChanges();
        return true;

    }

    public bool DeleteData(object id)
    {
        DonHang donHang = db.DonHangs.FirstOrDefault(e=>e.MaDh == int.Parse(id.ToString()));
        if (donHang == null)
        {
            return false;
        }
        var chiTietDonHang = db.ChiTietDonHangs.Where(e=>e.MaDh == donHang.MaDh).ToList();
        foreach (var item in chiTietDonHang)
        {
            db.ChiTietDonHangs.Remove(item);
        }
        db.DonHangs.Remove(donHang);
        db.SaveChanges();
        return true;

    }

    public List<DonHang> SearchData(string tuKhoa)
    {
        return db.DonHangs.Where(e=>e.TrangThai.Contains(tuKhoa))
            .Include(e=>e.MaCuaHangNavigation)
            .Include(e=>e.MaSpNavigation)
            .Include(e=>e.MaKhNavigation)
            .ToList();
    }

    public List<string> GetCuaHang()
    {
        return db.CuaHangs.Select(e=>e.TenCuaHang).ToList();
    }
    
    public CuaHang GetCuaHang(string tenCuaHang)
    {
        return db.CuaHangs.FirstOrDefault(e=>e.TenCuaHang == tenCuaHang);
    }
}