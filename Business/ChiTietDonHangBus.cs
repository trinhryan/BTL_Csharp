﻿using System.Data;
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
        dt.Columns.Add("MaSp");
        dt.Columns.Add("SoLuongSp");
      //  dt.Columns.Add("DonGia");
        dt.Columns.Add("TongGiaTien");
        
        
        var data = GetAllData();
        foreach (var item in data)
        {
            dt.Rows.Add(item.MaDh, item.MaSp, item.SoLuongSp, item.TongGiaTien);
        }

        return dt;
    }

    public ChiTietDonHang GetDataById(object id)
    {
        return db.ChiTietDonHangs.FirstOrDefault(e=>e.MaDh == (int)id);
    }

    public void AddData(ChiTietDonHang obj)
    {
        db.ChiTietDonHangs.Add(obj);
        db.SaveChanges();
    }

    public void UpdateData(ChiTietDonHang obj)
    {
       throw new NotImplementedException();
    }

    public void DeleteData(object id)
    {
        db.Database.ExecuteSqlRaw("delete from ChiTietDonHang where MaDh = {0}", id);
        
    }

    public List<ChiTietDonHang> SearchData(string tuKhoa)
    {
        return db.ChiTietDonHangs.Where(e => e.MaDh.ToString().Contains(tuKhoa) || e.MaSp.ToString().Contains(tuKhoa) || e.SoLuongSp.ToString().Contains(tuKhoa) || e.TongGiaTien.ToString().Contains(tuKhoa)).ToList();
    }
}