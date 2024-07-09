using System.Collections.Generic;
using System.Data;

namespace Business;

public interface IBus<T>
{
    // T is a generic type parameter that will be replaced by a concrete type when the interface is implemented
    // T là một tham số kiểu chung sẽ được thay thế bởi một kiểu cụ thể khi giao diện được triển khai
    public List<T> GetAllData();
    public DataTable GetAllDataTable();
    public T GetDataById(object id);
    public void AddData(T obj);
    public void UpdateData(T obj);
    public void DeleteData(object id);
    public List<T> SearchData( string tuKhoa);
}