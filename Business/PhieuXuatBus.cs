using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business;

public class PhieuXuatBus: IBus<PhieuXuat>
{
    private MyDbContext db = new MyDbContext();
    public List<PhieuXuat> GetAllData()
    {
        return db.PhieuXuats.ToList();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("MaPhieuXuat");
        dt.Columns.Add("NgayXuat");
        dt.Columns.Add("CuaHangXuat");
        dt.Columns.Add("CuaHangNhan");
        dt.Columns.Add("MaNV");
        dt.Columns.Add("NhanVienXuat");
       
        dt.Columns.Add("DiaChi");
        dt.Columns.Add("SoDienThoai");
        dt.Columns.Add("MaSP");
        dt.Columns.Add("TenSanPham");
       
        dt.Columns.Add("SoLuong");
        dt.Columns.Add("DonGia");
        
        var data = GetAllData();
        foreach (var item in data)
        {
            dt.Rows.Add(item.MaPx, item.NgayXuat, item.MaCuaHangNavigation.TenCuaHang, item.MaCuaHangNavigation.TenCuaHang, item.MaQlNavigation.MaQl,item.MaQlNavigation.TenQl, item.MaCuaHangNavigation.DiaChi, item.MaQlNavigation.Sdt, item.MaSPNavigation.MaSp, item.MaSPNavigation.TenSp, item.MaSPNavigation.SoLuong, item.MaSPNavigation.GiaSp);
        }

        return dt;
    }

    public PhieuXuat GetDataById(object id)
    {
        return db.PhieuXuats.FromSqlRaw("select * from PhieuXuat where MaPhieuXuat = {0}", id).FirstOrDefault();
    }

    public void AddData(PhieuXuat obj)
    {
        db.PhieuXuats.Add(obj);
        db.SaveChanges();
      }

    public void UpdateData(PhieuXuat obj)
    {
        PhieuXuat phieuXuat = (PhieuXuat)obj;
        PhieuXuat phieuXuatUpdate = db.PhieuXuats.FirstOrDefault(e=>e.MaPx == phieuXuat.MaPx);
        phieuXuatUpdate.NgayXuat = phieuXuat.NgayXuat;
        phieuXuatUpdate.MaCuaHangNavigation.TenCuaHang = phieuXuat.MaCuaHangNavigation.TenCuaHang;
        phieuXuatUpdate.MaCuaHangNavigation.TenCuaHang = phieuXuat.MaCuaHangNavigation.TenCuaHang;
        
        phieuXuatUpdate.MaQlNavigation.MaQl = phieuXuat.MaQlNavigation.MaQl;
        phieuXuatUpdate.MaQlNavigation.TenQl = phieuXuat.MaQlNavigation.TenQl;
        
        phieuXuatUpdate.MaCuaHangNavigation.DiaChi = phieuXuat.MaCuaHangNavigation.DiaChi;
        phieuXuatUpdate.MaQlNavigation.Sdt = phieuXuat.MaQlNavigation.Sdt;
        phieuXuatUpdate.MaSPNavigation.MaSp = phieuXuat.MaSPNavigation.MaSp;
        phieuXuatUpdate.MaSPNavigation.TenSp = phieuXuat.MaSPNavigation.TenSp ;
        
       
        phieuXuatUpdate.MaSPNavigation.SoLuong = phieuXuat.MaSPNavigation.SoLuong;
        phieuXuatUpdate.MaSPNavigation.GiaSp = phieuXuat.MaSPNavigation.GiaSp;
        db.SaveChanges();
    }

    public void DeleteData(object id)
    {
        db.Database.ExecuteSqlRaw("delete from PhieuXuat where MaPhieuXuat = {0}", id);
    }

    public List<PhieuXuat> SearchData(string tuKhoa)
    {
        return db.PhieuXuats.FromSqlRaw("select * from PhieuXuat where TenSanPham like '%{0}%'", tuKhoa).ToList();
    }

    public void InsertData(PhieuXuat phieuXuat)
    {
        throw new NotImplementedException();
    }
}