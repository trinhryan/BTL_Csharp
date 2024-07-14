using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        dt.Columns.Add("MaKhachHang");
        dt.Columns.Add("TenKhachHang");
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

    public bool AddData(KhachHang obj)
    {
        var exist = db.KhachHangs.FirstOrDefault(e => e.MaKh == obj.MaKh);
        if (exist != null)
        {
            return false;
        }
        KhachHang khachHang = (KhachHang)obj;
        db.KhachHangs.Add(khachHang);
        db.SaveChanges();
        return true;
    }

    public bool UpdateData(KhachHang obj)
    {
        KhachHang khachHang = (KhachHang)obj;
        KhachHang khachHangUpdate = db.KhachHangs.FirstOrDefault(e => e.MaKh == int.Parse(khachHang.MaKh.ToString()));
        if (khachHangUpdate == null)
        {
            return false;
        }
        khachHangUpdate.TenKh = khachHang.TenKh;
        khachHangUpdate.Sdt = khachHang.Sdt;
        khachHangUpdate.DiaChi = khachHang.DiaChi;
        db.SaveChanges();
        return true;
        
    }

    public bool DeleteData(object id)
    {
        KhachHang khachHang = db.KhachHangs.FirstOrDefault(e => e.MaKh == int.Parse(id.ToString()));
        if (khachHang == null)
        {
            return false;
        }
        db.KhachHangs.Remove(khachHang);
        db.SaveChanges();
        
        return true;
    }

    public List<KhachHang> SearchData(string ten)
    {
        return db.KhachHangs.Where(e => e.TenKh.Contains(ten)||
                                        e.Sdt.Contains(ten)||
                                        e.DiaChi.Contains(ten)).ToList();
    }

    public List<KhachHang> GetKhachHangByTen(string ten)
    {
        return db.KhachHangs.Where(e => e.TenKh.Contains(ten)).ToList();
    }
}