using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business;

public class ChucVuBus : IBus<ChucVu>
{
    MyDbContext db = new MyDbContext();
    public List<ChucVu> GetAllData()
    {
        return db.ChucVus.ToList();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("MaCv");
        dt.Columns.Add("TenCv");
        
        var data = GetAllData();
        foreach (var item in data)
        {
            dt.Rows.Add(item.MaCv, item.TenCv);
        }
        return dt;
    }

    public ChucVu GetDataById(object id)
    {
       return db.ChucVus.FirstOrDefault(e=>e.MaCv == (int)id);
    }

    public bool AddData(ChucVu obj)
    {
        var chucVu = db.ChucVus.FirstOrDefault(e => e.TenCv == obj.TenCv);
        if (chucVu != null)
        {
            return false;
        }
        db.ChucVus.Add(obj);
        db.SaveChanges();
        
        return true;
    }

    public void UpdateData(ChucVu obj)
    {
        var chucVu = db.ChucVus.FirstOrDefault(e => e.MaCv == obj.MaCv);
        if (chucVu != null)
        {
            chucVu.TenCv = obj.TenCv;
            db.SaveChanges();
        }
        
    }

    public bool AddData(object T)
    {
        throw new NotImplementedException();
    }

    public void UpdateData(object T)
    {
        throw new NotImplementedException();
    }

    public void DeleteData(object id)
    {
        // var chucVu = db.ChucVus.FirstOrDefault(e => e.MaCv == (int)id);
        // if (chucVu != null)
        // {
        //     db.ChucVus.Remove(chucVu);
        //     db.SaveChanges();
        // }
        // sử dụng sql để xóa dữ liệu
        db.Database.ExecuteSqlRaw("delete from ChucVus where MaCv = {0}", id);
    }

    public List<ChucVu> SearchData(string tuKhoa)
    {
        return db.ChucVus.Where(e => e.TenCv.Contains(tuKhoa)).ToList();
    }
}