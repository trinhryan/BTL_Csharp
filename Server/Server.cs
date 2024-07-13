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
        try
        {
            var client = _Listener.AcceptTcpClient().GetStream();
            var reader = new StreamReader(client);

            var data = reader.ReadLine();

            Console.WriteLine("Received: " + data);

            var response = ProcessData(data);

            var writer = new StreamWriter(client) { AutoFlush = true };

            writer.WriteLine(response);

            Console.WriteLine("Sent: " + response);
            
            client.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    private string ProcessData(string? data)
    {
        if (data == null)
        {
            return "error";
        }

        var parts = data.Split('|');

        var command = parts[0];
        var rest = parts[1..];

        switch (command)
        {
            case "register":
                return Register(rest);
            case "login":
                return Login(rest);
            case "search":
                return Search(rest);
            case "addQuestion":
                return AddQuestion(rest);
            case "sendAnswer":
                return CheckAnswer(rest);
            case "getQuestion":
                return GetRandomQuestion(rest);
            case "sendMessage":
                return SendMessage(rest);
            case "sendFile":
                return SendFile(rest);
            default:
                return "error";
        }
    }

    private string SendFile(string[] rest)
    {
        var fileName = rest[0].Split('\\').Last();
        Console.WriteLine("Received file: " + fileName);
        var base64 = rest[1];

        var fileData = Convert.FromBase64String(base64);
        
        File.WriteAllBytes(fileName, fileData);
        return fileName;
    }

    private string SendMessage(string[] rest)
    {

        Console.WriteLine("Client: " + rest[0]);

        return "hello from server";
    }

    private string GetRandomQuestion(string[] rest)
    {
        try
        {
            var random = new Random();
            var cauHois = _dbContext.CauHois.ToList();
            var question = cauHois[random.Next(cauHois.Count)];

            return $"{question.MaCauHoi}|{question.NoiDung}|{question.DapAnA}|{question.DapAnB}|{question.DapAnC}|{question.DapAnD}";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return "error";
        }
    }

    private string CheckAnswer(string[] rest)
    {
        if (rest.Length < 2)
        {
            return "error";
        }

        var maCauHoi = rest[0];
        var dapAn = rest[1];

        var cauHoi = _dbContext.CauHois.Find(int.Parse(maCauHoi));

        if (cauHoi == null)
        {
            return "error";
        }

        if (cauHoi.DapAnDung.ToLower().Trim() == dapAn.ToLower().Trim())
        {
            return "success";
        }

        return "error";
    }

    private string AddQuestion(string[] rest)
    {
        if (rest.Length < 5)
        {
            return "error";
        }

        var noiDung = rest[0];
        var dapAnA = rest[1];
        var dapAnB = rest[2];
        var dapAnC = rest[3];
        var dapAnD = rest[4];
        var dapAnDung = rest[5];

        _dbContext.CauHois.Add(new CauHoi
        {
            NoiDung = noiDung,
            DapAnA = dapAnA,
            DapAnB = dapAnB,
            DapAnC = dapAnC,
            DapAnD = dapAnD,
            DapAnDung = dapAnDung
        });

        _dbContext.SaveChanges();

        return "success";
    }

    private string Search(string[] rest)
    {
        if (rest.Length < 1)
        {
            return "error";
        }

        var search = rest[0];

        var result = _dbContext.CauHois.Where(s => s.NoiDung.Contains(search)).ToList();

        var response = string.Join("\n", result.Select(s => s.NoiDung));

        return response;
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
}