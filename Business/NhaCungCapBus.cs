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
        dt.Columns.Add("MaNhaCungCap");
        dt.Columns.Add("TenNhaCungCap");
        dt.Columns.Add("Sdt");
        dt.Columns.Add("DiaChi");
        
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

    public bool AddData(NhaCungCap obj)
    {
        var exist = db.NhaCungCaps.FirstOrDefault(e => e.MaNcc == obj.MaNcc);
        if (exist != null)
        {
            return false;
        }
        NhaCungCap nhaCungCap = (NhaCungCap)obj;
        
        db.NhaCungCaps.Add(nhaCungCap);
        db.SaveChanges();

        return true;
    }

    public bool UpdateData(NhaCungCap obj)
    {
        NhaCungCap nhaCungCap = (NhaCungCap)obj;
        NhaCungCap nhaCungCapUpdate = db.NhaCungCaps.FirstOrDefault(e => e.MaNcc == nhaCungCap.MaNcc);
        if (nhaCungCapUpdate == null)
        {
            return false;
        }
        nhaCungCapUpdate.TenNcc = nhaCungCap.TenNcc;
        nhaCungCapUpdate.Sdt = nhaCungCap.Sdt;
        nhaCungCapUpdate.DiaChi = nhaCungCap.DiaChi;
        
        db.NhaCungCaps.Update(nhaCungCapUpdate);
        db.SaveChanges();
        return true;
    }

    public bool DeleteData(object id)
    {
        NhaCungCap nhaCungCap = db.NhaCungCaps.FirstOrDefault(e => e.MaNcc == int.Parse(id.ToString()));
        
        if (nhaCungCap == null)
        {
            return false;
        }
        db.NhaCungCaps.Remove(nhaCungCap);
        db.SaveChanges();
       return true;
    }

    public List<NhaCungCap> SearchData(string tuKhoa)
    {
        return db.NhaCungCaps.Where(e=>e.TenNcc.Contains(tuKhoa)).ToList();
    }
}