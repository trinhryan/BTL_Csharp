﻿using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccess.Context;
using DataAccess.Entities;

namespace Business;

public class SaleBus:IBus<Sale>
{
    private MyDbContext db = new MyDbContext();
    
    public List<Sale> GetAllData()
    {
        return db.Sales.ToList();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("Mã nhân viên ");
        dt.Columns.Add("Tên nhân viên");
        dt.Columns.Add("Ngày sinh");
        dt.Columns.Add("Giới tính");
        dt.Columns.Add("Số điện thoại");
        dt.Columns.Add("Chức vụ");
        dt.Columns.Add("Cưả hàng");
       // dt.Columns.Add("Mã quản lý");
        dt.Columns.Add("Tên đăng nhập");

        var data = GetAllData();
        foreach (var item in data)
        {
            // dt.Rows.Add(item.MaSale, item.TenSale, item.NgaySinh, item.GioiTinh, item.Sdt, item.ChucVuNavigation.TenCv, item.CuaHangNavigation.TenCuaHang, item.TenDangNhap);
        }

        return dt;
    }

    public Sale GetDataById(object id)
    {
        return db.Sales.FirstOrDefault(e=>e.MaSale == (int)id);
    }

    public bool AddData(Sale obj)
    {
        var sale = db.Sales.FirstOrDefault(e=>e.MaSale == obj.MaSale);
        if (sale != null)
        {
            return false;
        }
        db.Sales.Add(obj);
        db.SaveChanges();
        return true;
    }

    public bool UpdateData(Sale obj)
    {
        Sale sale = (Sale)obj;
        Sale saleUpdate = db.Sales.FirstOrDefault(e=>e.MaSale == sale.MaSale);
        saleUpdate.TenSale = sale.TenSale;
        saleUpdate.NgaySinh = sale.NgaySinh;
        saleUpdate.GioiTinh = sale.GioiTinh;
        saleUpdate.Sdt = sale.Sdt;
        // saleUpdate.ChucVuNavigation.TenCv = sale.ChucVuNavigation.TenCv;
        saleUpdate.MaCuaHang = sale.MaCuaHang;
        saleUpdate.TenDangNhap = sale.TenDangNhap;
        db.SaveChanges();
        return true;

    }

    public bool DeleteData(object id)
    {
        Sale sale = db.Sales.FirstOrDefault(e=>e.MaSale == (int)id);
        db.Sales.Remove(sale);
        db.SaveChanges();
        return true;

    }

    public List<Sale> SearchData(string tuKhoa)
    {
        return db.Sales.Where(e=>e.TenSale.Contains(tuKhoa)).ToList();
    }

    public void InsertData(Sale sale)
    {
        throw new NotImplementedException();
    }
}