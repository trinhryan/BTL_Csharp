using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Business;

public class SaleBus : IBus<Sale>
{
    private MyDbContext db = new MyDbContext();

    public List<Sale> GetAllData()
    {
        return db.Sales.ToList();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("MaNhaVien");
        dt.Columns.Add("TenNhanVien");
        dt.Columns.Add("NgaySinh");
        dt.Columns.Add("GioiTinh");
        dt.Columns.Add("Sdt");
        dt.Columns.Add("ChucVu");
        dt.Columns.Add("CuaHang");
        dt.Columns.Add("TenDangNhap");

        var data = GetAllData();
        foreach (var item in data)
        {
            var tenCuaHang = db.CuaHangs.FirstOrDefault(e => e.MaCuaHang == item.MaCuaHang)?.TenCuaHang;
            var chucVu = db.ChucVus.FirstOrDefault(e => e.MaCv == item.MaCv)?.TenCv;
            dt.Rows.Add(item.MaSale, item.TenSale, item.NgaySinh, item.GioiTinh, item.Sdt, chucVu, tenCuaHang,
                item.TenDangNhap);
        }

        return dt;
    }

    public Sale GetDataById(object id)
    {
        return db.Sales.FirstOrDefault(e => e.MaSale == (int)id);
    }

    public bool AddData(Sale obj)
    {
        var sale = db.Sales.FirstOrDefault(e => e.MaSale == obj.MaSale);
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
        Sale saleUpdate = db.Sales.FirstOrDefault(e => e.MaSale == sale.MaSale);
        if (saleUpdate == null)
        {
            return false;
        }

        if (!sale.TenSale.IsNullOrEmpty()) saleUpdate.TenSale = sale.TenSale;
        if (!sale.Sdt.IsNullOrEmpty()) saleUpdate.Sdt = sale.Sdt;
        if (!sale.DiaChi.IsNullOrEmpty()) saleUpdate.DiaChi = sale.DiaChi;
        if(sale.NgaySinh.HasValue) saleUpdate.NgaySinh = sale.NgaySinh;
        if (!sale.GioiTinh.IsNullOrEmpty()) saleUpdate.GioiTinh = sale.GioiTinh;
        if (sale.MaCv.HasValue) saleUpdate.MaCv = sale.MaCv;
        if (sale.MaCuaHang.HasValue) saleUpdate.MaCuaHang = sale.MaCuaHang;
        if (!sale.TenDangNhap.IsNullOrEmpty()) saleUpdate.TenDangNhap = sale.TenDangNhap;

        db.Sales.Update(saleUpdate);
        db.SaveChanges();
        return true;
    }

    public bool DeleteData(object id)
    {
        Sale sale = db.Sales.FirstOrDefault(e => e.MaSale == int.Parse(id.ToString()));
        if (sale == null)
        {
            return false;
        }
        var phieuXuats = db.PhieuXuats.Where(e => e.MaSale == sale.MaSale).ToList();
        foreach (var phieuXuat in phieuXuats)
        {
            db.PhieuXuats.Remove(phieuXuat);
        }
        db.Sales.Remove(sale);
        db.SaveChanges();
        return true;
    }

    public List<Sale> SearchData(string tuKhoa)
    {
        var sales = db.Sales.Where(e => e.TenSale.Contains(tuKhoa))
            .Include(e => e.MaCuaHangNavigation)
            .Include(e => e.MaCvNavigation)
            .ToList();
        return sales;
    }

    public CuaHang GetCuaHangById(int? itemMaCuaHang)
    {
        return db.CuaHangs.FirstOrDefault(e => e.MaCuaHang == itemMaCuaHang);
    }

    public ChucVu GetChucVuById(int? itemMaCv)
    {
        return db.ChucVus.FirstOrDefault(e => e.MaCv == itemMaCv);
    }

    public ChucVu GetChucVuByTen(string itemMaCv)
    {
        return db.ChucVus.FirstOrDefault(e => e.TenCv == itemMaCv);
    }

    public List<string> GetChucVu()
    {
        return db.ChucVus.Select(e => e.TenCv).ToList();
    }

    public CuaHang GetCuaHangByTen(string text)
    {
        return db.CuaHangs.FirstOrDefault(e => e.TenCuaHang == text);
    }
}