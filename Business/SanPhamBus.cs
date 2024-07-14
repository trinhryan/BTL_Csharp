using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business;

public class SanPhamBus : IBus<SanPham>

{
    MyDbContext db = new MyDbContext();

    public List<SanPham> GetAllData()
    {
        return db.SanPhams.ToList();
        throw new NotImplementedException();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("MaSanPham");
        dt.Columns.Add("TenSanPham");
        dt.Columns.Add("Gia");
        dt.Columns.Add("SoLuong");
        dt.Columns.Add("HanSuDung");
        dt.Columns.Add("NgaySanXuat");
        dt.Columns.Add("PhanLoaiSanPham");

        var data = GetAllData();
        foreach (var item in data)
        {
            dt.Rows.Add(item.MaSp, item.TenSp, item.GiaSp, item.SoLuong, item.Hsd, item.Nsx, item.PhanLoaiSp);
        }

        return dt;
    }

    public SanPham GetDataById(object id)
    {
        //su entity framework
        return db.SanPhams.Where(e => e.MaSp == (int)id).FirstOrDefault();
    }

    public bool AddData(SanPham obj)
    {
        SanPham sanPham = (SanPham)obj;
        db.SanPhams.Add(sanPham);
        db.SaveChanges();
        return true;
    }

    public bool UpdateData(SanPham obj)
    {
        SanPham sanPham = (SanPham)obj;
        SanPham sanPhamUpdate = db.SanPhams.FirstOrDefault(e => e.MaSp == sanPham.MaSp);
        sanPhamUpdate.TenSp = sanPham.TenSp;
        sanPhamUpdate.GiaSp = sanPham.GiaSp;
        sanPhamUpdate.Hsd = sanPham.Hsd;
        sanPhamUpdate.Nsx = sanPham.Nsx;
        sanPhamUpdate.PhanLoaiSp = sanPham.PhanLoaiSp;
        db.SaveChanges();

        return true;
    }

    public bool DeleteData(object id)
    {
        SanPham sanPham = db.SanPhams.FirstOrDefault(e => e.MaSp == (int)id);
        db.SanPhams.Remove(sanPham);
        db.SaveChanges();
        return true;
    }

    public List<SanPham> SearchData(string tuKhoa)
    {
        return db.SanPhams.Where(e => e.TenSp.Contains(tuKhoa)).ToList();
    }
}