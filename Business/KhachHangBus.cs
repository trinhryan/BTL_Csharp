using System.Data;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business;

public class KhachHangBus: IBus<KhachHang>
{
    MyDbContext db = new MyDbContext();
    public List<KhachHang> GetAllData()
    {
        return db.KhachHangs.ToList();
        throw new NotImplementedException();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("MaKh");
        dt.Columns.Add("TenKh");
        dt.Columns.Add("Sdt");
        dt.Columns.Add("DiaChi");
        
        var data = GetAllData();
        foreach (var item in data)
        {
            dt.Rows.Add(item.MaKh, item.TenKh, item.Sdt, item.DiaChi);
        }

        return dt;
    }

    public KhachHang GetDataById(object id)
    {
        //su entity framework
       // return db.KhachHangs.Where(e=>e.MaKh == (int)id).FirstOrDefault();
        
        //su dung cau lenh sql 
        return db.KhachHangs.FromSqlRaw("select * from KhachHang where MaKh = {0}", id).FirstOrDefault();
    }

    public void AddData(KhachHang obj)
    {
        throw new NotImplementedException();
    }

    public void UpdateData(KhachHang obj)
    {
        throw new NotImplementedException();
    }

    public void AddData(object T)
    {
        // KhachHang khachHang = (KhachHang)T;
        // db.KhachHangs.Add(khachHang);
        // db.SaveChanges();
        
        //su dung cau lenh sql
        KhachHang khachHang = (KhachHang)T;
        db.Database.ExecuteSqlRaw("insert into KhachHang(TenKh, Sdt, DiaChi) values({0}, {1}, {2})", khachHang.TenKh, khachHang.Sdt, khachHang.DiaChi);
    }

    public void UpdateData(object T)
    {
        throw new NotImplementedException();
    }

    public void DeleteData(object id)
    {
        throw new NotImplementedException();
    }

    public List<KhachHang> SearchData(string ten)
    {
        throw new NotImplementedException();
    }

    public List<KhachHang> GetKhachHangByTen(string ten)
    {
        return db.KhachHangs.Where(e => e.TenKh.Contains(ten)).ToList();
    }
}