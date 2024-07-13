using System.ComponentModel;
using System.Data;
using System.Diagnostics;

namespace GUI;

public partial class MainForm : Form
{
    Client _client = new();

    public MainForm()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var noiDung = richTextBox1.Text;
        var dapAnA = richTextBox2.Text;
        var dapAnB = richTextBox2.Text;
        var dapAnC = richTextBox2.Text;
        var dapAnD = richTextBox2.Text;
        var dapAnDung = comboBox1.Text;


        if (string.IsNullOrEmpty(noiDung) || string.IsNullOrEmpty(dapAnA) || string.IsNullOrEmpty(dapAnB) || string.IsNullOrEmpty(dapAnC) || string.IsNullOrEmpty(dapAnD) || string.IsNullOrEmpty(dapAnDung))
        {
            MessageBox.Show("Không được để trống");
            return;
        }

        var result = _client.AddQuestion(noiDung, dapAnA, dapAnB, dapAnC, dapAnD, dapAnDung);

        if (result)
        {
            MessageBox.Show("Thêm câu hỏi thành công");
        }
        else
        {
            MessageBox.Show("Thêm câu hỏi thất bại");
        }

    }

    private void button1_Click(object sender, EventArgs e)
    {
        TimKiem();
    }

    private void TimKiem()
    {
        try
        {
            var search = textBox1.Text;
            var result = _client.Search(search);

            var dataTable = new DataTable();
            dataTable.Columns.Add("Câu hỏi", typeof(string));


            var lines = result.Split("\n");
            foreach (var line in lines)
            {
                var row = dataTable.NewRow();
                row["Câu hỏi"] = line;
                dataTable.Rows.Add(row);
            }

            dataGridView1.DataSource = dataTable;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }

    private void textBox1_Enter(object sender, EventArgs e)
    {
        TimKiem();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        // gui dap an
        var maCauHoi = label7.Text;
        var dapAn = richTextBox3.Text;

        if (string.IsNullOrEmpty(dapAn))
        {
            MessageBox.Show("Không được để trống");
            return;
        }

        var result = _client.SendAnswer(maCauHoi, dapAn);

        if (result)
        {
            MessageBox.Show("Bạn đã trả lời đúnng");
        }
        else
        {
            MessageBox.Show("Bạn đã trả lời sai");
        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        var result = _client.GetQuestion();

        var lines = result.Split("|");

        label7.Text = lines[0];

        // noiDung
        richTextBox1.Text = lines[1];
        // dapAnA
        richTextBox2.Text = lines[2];
        // dapAnB
        richTextBox3.Text = lines[3];
        // dapAnC
        richTextBox4.Text = lines[4];
        // dapAnD
        richTextBox5.Text = lines[5];
    }

    private void button5_Click(object sender, EventArgs e)
    {
        try
        {
            var text = richTextBox6.Text;

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Không được để trống");
                return;
            }

            richTextBox7.Text += $"Me: {text}\n";

            var result = _client.SendMessage(text);

            richTextBox7.Text += $"Server: {result}\n";
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            MessageBox.Show("Lỗi kết nối đến server");
            throw;
        }

    }

    private void button6_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.CheckFileExists = true;
        openFileDialog.AddExtension = true;
        openFileDialog.Multiselect = true;
        openFileDialog.Filter = "All files (*.*)|*.*";

        // send file to server
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            foreach (var fileName in openFileDialog.FileNames)
            {
                byte[] fileData = File.ReadAllBytes(fileName);
                // convert to base64
                var base64 = Convert.ToBase64String(fileData);
                var result = _client.SendFile(fileName, base64);

                richTextBox7.Text += $"Server: {result}\n";
            }
        }
    }

    private void openFileDialog1_FileOk(object? sender, CancelEventArgs e)
    {
        // receive file from server
    }
}