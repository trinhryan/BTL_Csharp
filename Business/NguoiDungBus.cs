using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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
            string gioiTinh;
            if (item.GioiTinh != null && item.GioiTinh.Contains('M'))
                gioiTinh = "Nam";
            else
                gioiTinh = "Nữ";
            dt.Rows.Add(item.HoTen, item.TenDangNhap, gioiTinh, item.Sdt, item.DiaChi);
        }

        return dt;
    }

    public NguoiDung GetDataById(object id)
    {
        return db.NguoiDungs.FirstOrDefault(e => e.TenDangNhap == id);
    }

    public bool AddData(NguoiDung obj)
    {
        var nguoiDung = db.NguoiDungs.FirstOrDefault(e => e.TenDangNhap == obj.TenDangNhap);
        if (nguoiDung != null)
        {
            return false;
        }

        db.NguoiDungs.Add(obj);
        db.SaveChanges();

        return true;
    }

    public bool UpdateData(NguoiDung obj)
    {
        var nguoiDung = db.NguoiDungs.FirstOrDefault(e => e.TenDangNhap == obj.TenDangNhap);
        if (nguoiDung == null)
        {
            return false;
        }

        nguoiDung.HoTen = obj.HoTen;
        if (!obj.MatKhau.IsNullOrEmpty()) nguoiDung.MatKhau = obj.MatKhau;
        nguoiDung.GioiTinh = obj.GioiTinh;
        nguoiDung.Sdt = obj.Sdt;
        nguoiDung.DiaChi = obj.DiaChi;
        db.SaveChanges();
        return true;
    }

    public bool DeleteData(object tenDangNhap)
    {
        var nguoiDung = db.NguoiDungs.FirstOrDefault(e => e.TenDangNhap == tenDangNhap);
        if (nguoiDung == null)
        {
            return false;
        }

        db.NguoiDungs.Remove(nguoiDung);
        db.SaveChanges();
        return true;
    }

    public List<NguoiDung> SearchData(string tuKhoa)
    {
        return db.NguoiDungs.Where(e =>
            (e.HoTen != null && e.HoTen.Contains(tuKhoa)) ||
            (e.TenDangNhap != null && e.TenDangNhap.Contains(tuKhoa)) ||
            (e.GioiTinh != null && e.GioiTinh.Contains(tuKhoa)) ||
            (e.Sdt != null && e.Sdt.Contains(tuKhoa)) ||
            (e.DiaChi != null && e.DiaChi.Contains(tuKhoa))
        ).Select(e => new NguoiDung
        {
            HoTen = e.HoTen,
            TenDangNhap = e.TenDangNhap,
            GioiTinh = (e.GioiTinh != null && e.GioiTinh.Contains('M')) == true ? "Nam" : "Nữ",
            Sdt = e.Sdt,
            DiaChi = e.DiaChi
        }).ToList();
    }

    public bool DangNhap(string text, string s)
    {
        // kiểm tra xem có tồn tại người dùng có tên đăng nhập và mật khẩu không
        var nguoiDung = db.NguoiDungs.FirstOrDefault(e => e.TenDangNhap == text && e.MatKhau == s);
        if (nguoiDung != null)
        {
            return true;
        }

        return false;
    }

    public bool KiemTraTenDangNhap(string tenDangNhap)
    {
        var nguoiDung = db.NguoiDungs.FirstOrDefault(e => e.TenDangNhap == tenDangNhap);
        if (nguoiDung != null)
        {
            return true;
        }

        return false;
    }
}