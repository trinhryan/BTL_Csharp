using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business;

public class SanPhamBus: IBus<SanPham>
    
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
        dt.Columns.Add("Mã sản phẩm");
        dt.Columns.Add("Tên sản phẩm");
        dt.Columns.Add("Giá");
        //dt.Columns.Add("SoLuong");
        dt.Columns.Add("Hạn sử dung");
        dt.Columns.Add("Ngày sản xuất");
        dt.Columns.Add("Phân loại sản phẩm");
        
        var data = GetAllData();
        foreach (var item in data)
        {
            dt.Rows.Add(item.MaSp, item.TenSp, item.GiaSp, item.Hsd, item.Nsx, item.PhanLoaiSp);
        }

        return dt;
        
    }

    public SanPham GetDataById(object id)
    {
        //su entity framework
        return db.SanPhams.Where(e=>e.MaSp == (int)id).FirstOrDefault();
         
        //su dung cau lenh sql 
        //return db.SanPhams.FromSqlRaw("select * from SanPham where MaSp = {0}", id).FirstOrDefault();
    }

    public bool AddData(SanPham obj)
    {
        SanPham sanPham = (SanPham)obj;
        db.SanPhams.Add(sanPham);
        db.SaveChanges();
        //var exist = db.SanPhams.FirstOrDefault(e => e.MaSp == obj.MaSp);
        //if (exist != null)
        //{
        //    return false;
        //}
        ////su dung cau lenh sql
        //SanPham sanPham = (SanPham)obj;
        //db.Database.ExecuteSqlRaw("insert into SanPham(MaSp, TenSp, GiaSp, Hsd, Nsx, PhanLoaiSp) values({0}, {1}, {2}, {3}, {4})",sanPham.MaSp, sanPham.TenSp, sanPham.GiaSp, sanPham.Hsd, sanPham.Nsx, sanPham.PhanLoaiSp);
        return true;
    }

    public void UpdateData(SanPham obj)
    {
        SanPham sanPham = (SanPham)obj;
        SanPham sanPhamUpdate = db.SanPhams.FirstOrDefault(e => e.MaSp == sanPham.MaSp);
        sanPhamUpdate.TenSp = sanPham.TenSp;
        sanPhamUpdate.GiaSp = sanPham.GiaSp;
        sanPhamUpdate.Hsd = sanPham.Hsd;
        sanPhamUpdate.Nsx = sanPham.Nsx;
        sanPhamUpdate.PhanLoaiSp = sanPham.PhanLoaiSp;
        db.SaveChanges();
    }

    public void DeleteData(object id)
    {
        SanPham sanPham = db.SanPhams.FirstOrDefault(e => e.MaSp == (int)id);
        db.SanPhams.Remove(sanPham);
        db.SaveChanges();
    }

    public List<SanPham> SearchData(string tuKhoa)
    {
        return db.SanPhams.Where(e => e.TenSp.Contains(tuKhoa)).ToList();
    }
}