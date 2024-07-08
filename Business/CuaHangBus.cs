using System.Data;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business;

public class CuaHangBus:IBus<CuaHang>
{
    MyDbContext db = new MyDbContext();
    public List<CuaHang> GetAllData()
    {
       return db.CuaHangs.ToList();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("MaCh");
        dt.Columns.Add("TenCh");
       // dt.Columns.Add("Sdt");
        dt.Columns.Add("DiaChi");
        
        var data = GetAllData();
        foreach (var item in data)
        {
            dt.Rows.Add(item.MaCuaHang, item.TenCuaHang, item.DiaChi);
        }

        return dt;
    }

    public CuaHang GetDataById(object id)
    {
        return db.CuaHangs.Where(e=>e.MaCuaHang == (int)id).FirstOrDefault();
        
    }

    public void AddData(CuaHang obj)
    {
        CuaHang cuaHang = (CuaHang)obj;
        db.Database.ExecuteSqlRaw("insert into CuaHang(TenCh, DiaChi) values({0}, {1})", cuaHang.TenCuaHang, cuaHang.DiaChi);
    }

    public void UpdateData(CuaHang obj)
    {
        CuaHang cuaHang = (CuaHang)obj;
        CuaHang cuaHangUpdate = db.CuaHangs.FirstOrDefault(e => e.MaCuaHang == cuaHang.MaCuaHang);
        cuaHangUpdate.TenCuaHang = cuaHang.TenCuaHang;
        cuaHangUpdate.DiaChi = cuaHang.DiaChi;
        db.SaveChanges();
        
    }

    public void DeleteData(object id)
    {
         db.Database.ExecuteSqlRaw("delete from CuaHang where MaCh = {0}", id);
         
    }

    public List<CuaHang> SearchData(string tuKhoa)
    {
        return db.CuaHangs.Where(e => e.MaCuaHang.ToString().Contains(tuKhoa) || e.TenCuaHang.Contains(tuKhoa) || e.DiaChi.Contains(tuKhoa)).ToList();
    }
}