using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccess.Context;
using DataAccess.Entities;

namespace Business;

public class PhieuNhapBus: IBus<PhieuNhap>
{
    MyDbContext db = new MyDbContext();
    public List<PhieuNhap> GetAllData()
    {
        return db.PhieuNhaps.ToList();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("Mã phiếu nhập");
        dt.Columns.Add("Ngày nhập");
        dt.Columns.Add("Cửa hàng nhập");
        dt.Columns.Add("Nhân viên nhập");
        
        dt.Columns.Add("Mã NCC");
        dt.Columns.Add("Nhà cung cấp");
       
        dt.Columns.Add("Số điện thoại");
        dt.Columns.Add("Mã sản phẩm");
        dt.Columns.Add("Tên sản phẩm");
       
        dt.Columns.Add("Số lượng");
        dt.Columns.Add("Đơn giá ");

        var data = GetAllData();
        foreach (var item in data)
        {
               dt.Rows.Add(item.MaPn, item.NgayNhap, item.MaCuaHangNavigation?.TenCuaHang,item.MaQlNavigation.MaQl,item.MaNccNavigation.MaNcc, item.MaNccNavigation.TenNcc, item.SdtNcc, item.MaSpNavigation.TenSp, item.MaSpNavigation, item.MaSpNavigation.SoLuong, item.MaSpNavigation.GiaSp);
            
        }

        return dt;
    }

    public PhieuNhap GetDataById(object id)
    {
        return db.PhieuNhaps.FirstOrDefault(e=>e.MaPn == (int)id);
        
    }

    public bool AddData(PhieuNhap obj)
    {
        var phieuNhap = db.PhieuNhaps.FirstOrDefault(e => e.MaPn == obj.MaPn);
        if (phieuNhap != null)
        {
            return false;
        }
        db.PhieuNhaps.Add(obj);
        db.SaveChanges();
        
        return true;
    }

    public void UpdateData(PhieuNhap obj)
    {
        PhieuNhap phieuNhap = (PhieuNhap)obj;
        PhieuNhap phieuNhapUpdate = db.PhieuNhaps.FirstOrDefault(e=>e.MaPn == phieuNhap.MaPn);
        phieuNhapUpdate.NgayNhap = phieuNhap.NgayNhap;
        phieuNhapUpdate.MaCuaHang = phieuNhap.MaCuaHangNavigation.MaCuaHang;
        phieuNhapUpdate.MaQl = phieuNhap.MaQlNavigation.MaQl;
        phieuNhapUpdate.MaNcc = phieuNhap.MaNccNavigation.MaNcc;
        phieuNhapUpdate.SdtNcc = phieuNhap.SdtNcc;
        phieuNhapUpdate.MaSpNavigation.TenSp = phieuNhap.MaSpNavigation.TenSp;
        phieuNhapUpdate.MaSpNavigation.MaSp = phieuNhap.MaSpNavigation.MaSp;
        phieuNhapUpdate.MaSpNavigation.SoLuong = phieuNhap.MaSpNavigation.SoLuong;
        phieuNhapUpdate.MaSpNavigation.GiaSp = phieuNhap.MaSpNavigation.GiaSp;
        db.SaveChanges();
    }

    public void DeleteData(object id)
    {
        PhieuNhap phieuNhap = db.PhieuNhaps.FirstOrDefault(e=>e.MaPn == (int)id);
        db.PhieuNhaps.Remove(phieuNhap);
        db.SaveChanges();
    }

    public List<PhieuNhap> SearchData(string tuKhoa)
    {
        return db.PhieuNhaps.Where(e=>e.MaSpNavigation.TenSp.Contains(tuKhoa)).ToList();
    }

    public void InsertData(PhieuNhap phieuNhap)
    {
        throw new NotImplementedException();
    }
}