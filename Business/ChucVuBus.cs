using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccess.Context;
using DataAccess.Entities;

namespace Business;

public class ChucVuBus : IBus<ChucVu>
{
    MyDbContext db = new MyDbContext();
    public List<ChucVu> GetAllData()
    {
        return db.ChucVus.ToList();
    }

    public DataTable GetAllDataTable()
    {
        throw new NotImplementedException();
    }

    public ChucVu GetDataById(object id)
    {
        throw new NotImplementedException();
    }

    public void AddData(ChucVu obj)
    {
        throw new NotImplementedException();
    }

    public void UpdateData(ChucVu obj)
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

    public List<ChucVu> SearchData(string tuKhoa)
    {
        throw new NotImplementedException();
    }
}