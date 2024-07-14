using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business;

public class ChiTietDonHangBus:IBus<ChiTietDonHang>
{
    MyDbContext db = new MyDbContext();
    public List<ChiTietDonHang> GetAllData()
    {
        return db.ChiTietDonHangs.ToList();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("MaDh");
        dt.Columns.Add("NgayTao");
        dt.Columns.Add("CuaHang");
        dt.Columns.Add("MaKh");
        dt.Columns.Add("TenKh");
        dt.Columns.Add("Sdt");
        dt.Columns.Add("MaSp");
        dt.Columns.Add("TenSp");
        dt.Columns.Add("SoLuongSp");
        dt.Columns.Add("TongGiaTien");
        
        var data = GetAllData();
        foreach (var item in data)
        {
            var khachHang = db.KhachHangs.FirstOrDefault(e=>e.MaKh == item.MaKh);
            var sanPham = db.SanPhams.FirstOrDefault(e=>e.MaSp == item.MaSp);
            var cuaHang = db.CuaHangs.FirstOrDefault(e=>e.MaCuaHang == item.CuaHang);
            dt.Rows.Add(item.MaDh, item.NgayTao, cuaHang.TenCuaHang, khachHang.MaKh, khachHang.TenKh, khachHang.Sdt, item.MaSp, sanPham.TenSp, item.SoLuongSp, item.TongGiaTien);
        }

        return dt;
    }

    public ChiTietDonHang GetDataById(object id)
    {
        return db.ChiTietDonHangs.FirstOrDefault(e=>e.MaDh == (int)id);
    }

    public bool AddData(ChiTietDonHang obj)
    {
        var chiTietDonHang = db.ChiTietDonHangs.FirstOrDefault(e => e.MaDh == obj.MaDh);
        if (chiTietDonHang != null)
        {
            return false;
        }
        // get max id of ChiTietDonHang
        var maxId = db.ChiTietDonHangs.Max(e => e.MaDh);
        obj.MaDh = maxId + 1;
        // using sql query to insert data
        db.Database.ExecuteSqlRaw("INSERT INTO ChiTietDonHang (MaDh, NgayTao, CuaHang, MaKh, TenKh, Sdt, MaSp, TenSp, SoLuongSp, TongGiaTien) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", obj.MaDh, obj.NgayTao, obj.CuaHang, obj.MaKh, obj.TenKh, obj.Sdt, obj.MaSp, obj.TenSp, obj.SoLuongSp, obj.TongGiaTien);
        db.SaveChanges();
        
        return true;
    }

    public bool UpdateData(ChiTietDonHang obj)
    {
        var chiTietDonHang = db.ChiTietDonHangs.FirstOrDefault(e => e.MaDh == obj.MaDh);
        if (chiTietDonHang == null)
        {
            return false;
        }
        chiTietDonHang.MaSp = obj.MaSp;
        chiTietDonHang.SoLuongSp = obj.SoLuongSp;
        chiTietDonHang.TongGiaTien = obj.TongGiaTien;
        db.Database.ExecuteSqlRaw("UPDATE ChiTietDonHang SET MaSp = {0}, SoLuongSp = {1}, TongGiaTien = {2} WHERE MaDh = {3}", obj.MaSp, obj.SoLuongSp, obj.TongGiaTien, obj.MaDh);
        db.SaveChanges();
        return true;
    }

    public bool DeleteData(object id)
    {
        var chiTietDonHang = db.ChiTietDonHangs.FirstOrDefault(e => e.MaDh ==int.Parse(id.ToString()));
        if (chiTietDonHang == null)
        {
            return false;
        }
        
        db.Database.ExecuteSqlRaw("DELETE FROM ChiTietDonHang WHERE MaDh = {0}", chiTietDonHang.MaDh);
        db.SaveChanges();
        return true;
    }

    public List<ChiTietDonHang> SearchData(string tuKhoa)
    {
        return db.ChiTietDonHangs.Where(e => e.MaDh.ToString().Contains(tuKhoa) || e.MaSp.ToString().Contains(tuKhoa) || e.SoLuongSp.ToString().Contains(tuKhoa) || e.TongGiaTien.ToString().Contains(tuKhoa)).ToList();
    }

    public decimal GetTongTien()
    {
        return db.ChiTietDonHangs.Sum(e=>e.TongGiaTien).Value;
    }

    public List<CuaHang> GetCuaHang()
    {
        return db.CuaHangs.ToList();
    }

    public List<SanPham> GetSanPham()
    {
        return db.SanPhams.ToList();
    }
}