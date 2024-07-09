using System.Data;
using DataAccess.Context;
using DataAccess.Entities;

namespace Business;

public class DonHangBus:IBus<DonHang>
{
    private MyDbContext db = new MyDbContext();
    public List<DonHang> GetAllData()
    {
        return db.DonHangs.ToList();
    }

    public DataTable GetAllDataTable()
    {
        var dt = new DataTable();
        dt.Columns.Add("Mã đơn hàng");
        dt.Columns.Add("Ngày tạo đơn");
        dt.Columns.Add("Cửa hàng tạo đơn");
        
        dt.Columns.Add("Mã sản phẩm");
        dt.Columns.Add("Tên sản phẩm");
        dt.Columns.Add("Số lượng");
        dt.Columns.Add("Đơn giá sản phẩm");
        
        dt.Columns.Add("Trạng thái");
        dt.Columns.Add("Tổng đơn hàng");
        
        var data = GetAllData();
        foreach (var item in data)
        {
            dt.Rows.Add(item.MaDh, item.NgayTao, item.MaCuaHangNavigation.TenCuaHang, item.MaSp,
                item.MaSpNavigation.TenSp, item.MaSpNavigation.SoLuong, item.MaSpNavigation.GiaSp, item.TrangThai,
                item.TongTien);
        }

        return dt;
    }

    public DonHang GetDataById(object id)
    {
        return db.DonHangs.FirstOrDefault(e=>e.MaDh == (int)id);
    }

    public bool AddData(DonHang obj)
    {
        var donHang = db.DonHangs.FirstOrDefault(e=>e.MaDh == obj.MaDh);
        if (donHang != null)
        {
            return false;
        }
        db.DonHangs.Add(obj);
        db.SaveChanges();
        return true;
    }

    public void UpdateData(DonHang obj)
    {
        DonHang donHang = (DonHang)obj;
        DonHang donHangUpdate = db.DonHangs.FirstOrDefault(e=>e.MaDh == donHang.MaDh);
        donHangUpdate.NgayTao = donHang.NgayTao;
        donHangUpdate.TongTien = donHang.TongTien;
        donHangUpdate.TrangThai = donHang.TrangThai;
        donHangUpdate.MaCuaHang = donHang.MaCuaHang;
        donHangUpdate.MaSp = donHang.MaSp;
        donHangUpdate.MaKh = donHang.MaKh;
        db.SaveChanges();
    }

    public void DeleteData(object id)
    {
        DonHang donHang = db.DonHangs.FirstOrDefault(e=>e.MaDh == (int)id);
        db.DonHangs.Remove(donHang);
        db.SaveChanges();
    }

    public List<DonHang> SearchData(string tuKhoa)
    {
        return db.DonHangs.Where(e=>e.TrangThai.Contains(tuKhoa)).ToList();
    }
}