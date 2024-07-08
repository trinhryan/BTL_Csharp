using System.Data;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business;

public class NguoiDungBus : IBus<NguoiDung>
{
    MyDbContext db = new MyDbContext();

    public List<NguoiDung> GetAllData()
    {
        return db.NguoiDungs.ToList();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("HoTen");
        dt.Columns.Add("TenDangNhap");
        dt.Columns.Add("GioiTinh");
        dt.Columns.Add("Sdt");
        dt.Columns.Add("DiaChi");
        
        var data = GetAllData();
        foreach (var item in data)
        {
            dt.Rows.Add(item.HoTen, item.TenDangNhap, item.GioiTinh, item.Sdt, item.DiaChi);
        }
        return dt;
    }

    public NguoiDung GetDataById(object id)
    {
        return db.NguoiDungs.FirstOrDefault(e=>e.TenDangNhap == id);
    }

    public void AddData(NguoiDung obj)
    {
        db.NguoiDungs.Add(obj);
        db.SaveChanges();
    }

    public void UpdateData(NguoiDung obj)
    {
        throw new NotImplementedException();
    }

    public void AddData(object T)
    {
        // ép kiểu object về kiểu NguoiDung
        NguoiDung nguoiDung = (NguoiDung)T;
        db.NguoiDungs.Add(nguoiDung);
        db.SaveChanges();
    }

    public void UpdateData(object T)
    {
        NguoiDung nguoiDung = (NguoiDung)T;
        NguoiDung nguoiDungUpdate = db.NguoiDungs.FirstOrDefault(e => e.TenDangNhap == nguoiDung.TenDangNhap);
        nguoiDungUpdate.HoTen = nguoiDung.HoTen;
        nguoiDungUpdate.MatKhau = nguoiDung.MatKhau;
        nguoiDungUpdate.GioiTinh = nguoiDung.GioiTinh;
        nguoiDungUpdate.Sdt = nguoiDung.Sdt;
        nguoiDungUpdate.DiaChi = nguoiDung.DiaChi;
        db.SaveChanges();
    }

    public void DeleteData(object id)
    {
        // sử dụng hàm Remove để xóa dữ liệu
        // NguoiDung nguoiDung = db.NguoiDungs.FirstOrDefault(e => e.TenDangNhap == id);
        // db.NguoiDungs.Remove(nguoiDung);
        // db.SaveChanges();
        
        // sử dụng sql để xóa dữ liệu
        db.Database.ExecuteSql($"DELETE FROM NguoiDungs WHERE TenDangNhap = {id}");
    }

    public List<NguoiDung> SearchData(string tuKhoa)
    {
        throw new NotImplementedException();
    }
}