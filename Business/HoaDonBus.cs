using System.Data;
using DataAccess.Context;
using DataAccess.Entities;

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
        throw new NotImplementedException();
        
    }

    public HoaDon GetDataById(object id)
    {
        throw new NotImplementedException();
    }

    public void AddData(HoaDon obj)
    {
        throw new NotImplementedException();
    }

    public void UpdateData(HoaDon obj)
    {
        throw new NotImplementedException();
    }

    public void AddData(object T)
    {
        throw new NotImplementedException();
    }

    public void UpdateData(object T)
    {
        throw new NotImplementedException();
    }

    public void DeleteData(object id)
    {
        throw new NotImplementedException();
    }

    public List<HoaDon> SearchData(string tuKhoa)
    {
        throw new NotImplementedException();
    }
}