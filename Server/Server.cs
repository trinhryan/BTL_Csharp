using System.Net.Sockets;
using DataAccess.Context;
using DataAccess.Migrations;

namespace Server;

public class Server
{
    public TcpListener _Listener { get; set; } = new TcpListener(System.Net.IPAddress.Any, 12345);
    
    private MyDbContext _dbContext = new();

    public Server()
    {
        _Listener.Start();
    }

    public void Receive()
    {
        var client = _Listener.AcceptTcpClient();
        var stream = client.GetStream();
        var reader = new StreamReader(stream);
        
        var data = reader.ReadLine();
        
        var response = ProcessData(data);
        
        Send(response);
    }

    private string ProcessData(string? data)
    {
        if (data == null)
        {
            return "error";
        }

        var parts = data.Split(' ');

        if (parts.Length < 2)
        {
            return "error";
        }

        var command = parts[0];
        var rest = parts[1..];

        switch (command)
        {
            case "register":
                return Register(rest);
            case "login":
                return Login(rest);
            default:
                return "error";
        }
    }

    private string Login(string[] rest)
    {
        if (rest.Length < 2)
        {
            return "error";
        }

        var tenDangNhap = rest[0];
        var matKhau = rest[1];

        var taiKhoan = _dbContext.TaiKhoans.Find(tenDangNhap);

        if (taiKhoan == null || taiKhoan.MatKhau != matKhau)
        {
            return "error";
        }

        return "success";
    }

    private string Register(string[] rest)
    {
        if (rest.Length < 2)
        {
            return "error";
        }

        var tenDangNhap = rest[0];
        var matKhau = rest[1];

        var taiKhoan = _dbContext.TaiKhoans.Find(tenDangNhap);

        if (taiKhoan != null)
        {
            return "error";
        }

        _dbContext.TaiKhoans.Add(new TaiKhoan
        {
            TenDangNhap = tenDangNhap,
            MatKhau = matKhau,
            Quyen = "user"
        });

        _dbContext.SaveChanges();

        return "success";
    }


    public void Send(string data)
    {
        var client = _Listener.AcceptTcpClient();
        var stream = client.GetStream();
        var writer = new StreamWriter(stream) { AutoFlush = true };
        
        writer.WriteLine(data);
        
        client.Close();
    }
}