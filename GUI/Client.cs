using System.Data;
using System.Net;
using System.Net.Sockets;

namespace GUI;

public class Client
{
    public TcpClient _client = new();

    public Client()
    {
        try
        {
            if (!_client.Connected)
            {
                _client = new TcpClient(ip, port);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show("Không thể kết nối đến server");
        }
    }

    public string ip { get; set; } = GetIpAddress();
    public int port { get; set; } = 12345;


    public void Send(string data)
    {
        try
        {
            EnsureConnected(); // Ensure the client is connected

            var stream = _client.GetStream();
            var writer = new StreamWriter(stream) { AutoFlush = true };

            writer.WriteLine(data);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public string? Receive()
    {
        try
        {
            EnsureConnected(); // Ensure the client is connected

            var stream = _client.GetStream();
            using var reader = new StreamReader(stream);
            return reader.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
        return null;
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
            var data = $"register|{tenDangNhap}|{matKhau}";
            Send(data);

            var response = Receive();

            return response == "success";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public bool Login(string tenDangNhap, string matKhau)
    {
        try
        {
            var data = $"login|{tenDangNhap}|{matKhau}";
            Send(data);

            var response = Receive();

            return response == "success";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public string Search(string search)
    {
        try
        {
            var data = $"search|{search}";
            Send(data);

            var response = Receive();

            return response;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public bool AddQuestion(string noiDung, string dapAnA, string dapAnB, string dapAnC, string dapAnD,
        string dapAnDung)
    {
        try
        {
            var data = $"addQuestion|{noiDung}|{dapAnA}|{dapAnB}|{dapAnC}|{dapAnD}|{dapAnDung}";
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

    public bool SendAnswer(string maCauHoi, string dapAn)
    {
        try
        {
            var data = $"sendAnswer|{maCauHoi}|{dapAn}";
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

    public string GetQuestion()
    {
        try
        {
            var data = "getQuestion|themcainayvaocungksaoca";
            Send(data);

            var response = Receive();

            return response;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public string SendMessage(string text)
    {
        try
        {
            var data = $"sendMessage|{text}";
            Send(data);

            var response = Receive();

            return response;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public string SendFile(string fileName, string base64)
    {
        try
        {
            var data = $"sendFile|{fileName}|{base64}";
            Send(data);

            var response = Receive();

            return response;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    public void EnsureConnected()
    {
        if (_client == null || !_client.Connected)
        {
            _client = new TcpClient(ip, port);
        }
    }
}