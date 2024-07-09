using System.Data;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business;

public class HoaDonBus : IBus<HoaDon>
{
    MyDbContext db = new MyDbContext();
    public List<HoaDon> GetAllData()
    {
        return db.HoaDons.ToList();
        throw new NotImplementedException();
    }

    public DataTable GetAllDataTable()
    {

        var dt = new DataTable();
        dt.Columns.Add("Mã hóa đơn");
        dt.Columns.Add("Tên sản phẩm");
        dt.Columns.Add("Mã sản phẩm");
        dt.Columns.Add("Số lượng");
        dt.Columns.Add("Đơn giá");
        dt.Columns.Add("Tổng tiền");

        var data = GetAllData();
        foreach (var item in data)
        {
            dt.Rows.Add(item.MaHd, item.TenSp, item.MaSp, item.SoLuong, item.DonGia, item.TongTien);
        }

        return dt;

    }

    public HoaDon GetDataById(object id)
    {
        return db.HoaDons.FirstOrDefault(e=>e.MaHd == (int)id);
        
    }

    public void AddData(HoaDon obj)
    {
        db.HoaDons.Add(obj);
        db.SaveChanges();
    }

    public void UpdateData(HoaDon obj)
    {
        HoaDon hoaDon = (HoaDon)obj;
        HoaDon hoaDonUpdate = db.HoaDons.FirstOrDefault(e=>e.MaHd == hoaDon.MaHd);
        hoaDonUpdate.TenSp = hoaDon.TenSp;
        hoaDonUpdate.MaSp = hoaDon.MaSp;
        hoaDonUpdate.SoLuong = hoaDon.SoLuong;
        hoaDonUpdate.DonGia = hoaDon.DonGia;
        hoaDonUpdate.TongTien = hoaDon.TongTien;
        db.SaveChanges();
    }

    public void AddData(object T)
    {
        HoaDon hoaDon = (HoaDon)T;
        db.HoaDons.Add(hoaDon);
        db.SaveChanges();
    }

    public void UpdateData(object T)
    {
        HoaDon hoaDon = (HoaDon)T;
        HoaDon hoaDonUpdate = db.HoaDons.FirstOrDefault(e=>e.MaHd == hoaDon.MaHd);
        hoaDonUpdate.TenSp = hoaDon.TenSp;
        hoaDonUpdate.MaSp = hoaDon.MaSp;
        hoaDonUpdate.SoLuong = hoaDon.SoLuong;
        hoaDonUpdate.DonGia = hoaDon.DonGia;
        hoaDonUpdate.TongTien = hoaDon.TongTien;
        db.SaveChanges();
    }

    public void DeleteData(object id)
    {
      db.Database.ExecuteSqlRaw("delete from HoaDon where MaHd = {0}", id);
    }

    public List<HoaDon> SearchData(string tuKhoa)
    {
        return db.HoaDons.Where(e=>e.TenSp.Contains(tuKhoa)).ToList();
    }
}