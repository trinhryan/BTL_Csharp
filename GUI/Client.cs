using System.Net;
using System.Net.Sockets;

namespace GUI;

public class Client
{
    private TcpClient _client = new();

    public Client()
    {
        _client.Connect(ip, port);
    }

    public string ip { get; set; } = GetIpAddress();
    public int port { get; set; } = 12345;


    public void Send(string data)
    {
        try
        {
            var stream = _client.GetStream();
            var writer = new StreamWriter(stream) { AutoFlush = true };

            writer.WriteLine(data);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public string? Receive()
    {
        try
        {
            var stream = _client.GetStream();
            var reader = new StreamReader(stream);
            
            return reader.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    private static string GetIpAddress()
    {
        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                return ip.ToString();
            }
        }

        return "";
    }

    public bool Register(string tenDangNhap, string matKhau)
    {
        try
        {
            var data = $"register {tenDangNhap} {matKhau}";
            Send(data);

            var response = Receive();

            return response == "success";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    public bool Login(string tenDangNhap, string matKhau)
    {
        try
        {
            var data = $"login {tenDangNhap} {matKhau}";
            Send(data);

            var response = Receive();

            return response == "success";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}