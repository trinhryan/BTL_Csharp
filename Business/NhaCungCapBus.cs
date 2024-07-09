using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business;

public class NhaCungCapBus: IBus<NhaCungCap>
{
    MyDbContext db = new MyDbContext();

    public List<NhaCungCap> GetAllData()
    {
       return db.NhaCungCaps.ToList();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("Mã nhà cung cấp");
        dt.Columns.Add("Tên nhà cung cấp");
        dt.Columns.Add("Sdt");
        dt.Columns.Add("Địa chỉ");
        
        var data = GetAllData();
        foreach (var item in data)
        {
            dt.Rows.Add(item.MaNcc, item.TenNcc, item.Sdt, item.DiaChi);
        }

        return dt;
    }

    public NhaCungCap GetDataById(object id)
    {
        return db.NhaCungCaps.Where(e=>e.MaNcc == (int)id).FirstOrDefault();
    }

    public void AddData(NhaCungCap obj)
    {
        NhaCungCap nhaCungCap = (NhaCungCap)obj;
        db.Database.ExecuteSqlRaw("insert into NhaCungCap(TenNcc, Sdt, DiaChi) values({0}, {1}, {2})", nhaCungCap.TenNcc, nhaCungCap.Sdt, nhaCungCap.DiaChi);
        
    }

    public void UpdateData(NhaCungCap obj)
    {
        NhaCungCap nhaCungCap = (NhaCungCap)obj;
        NhaCungCap nhaCungCapUpdate = db.NhaCungCaps.FirstOrDefault(e => e.MaNcc == nhaCungCap.MaNcc);
        nhaCungCapUpdate.TenNcc = nhaCungCap.TenNcc;
        nhaCungCapUpdate.Sdt = nhaCungCap.Sdt;
        nhaCungCapUpdate.DiaChi = nhaCungCap.DiaChi;
        db.SaveChanges();
        
    }

    public void DeleteData(object id)
    {
       db.Database.ExecuteSqlRaw("delete from NhaCungCap where MaNcc = {0}", id);
    }

    public List<NhaCungCap> SearchData(string tuKhoa)
    {
        return db.NhaCungCaps.Where(e=>e.TenNcc.Contains(tuKhoa)).ToList();
    }
}