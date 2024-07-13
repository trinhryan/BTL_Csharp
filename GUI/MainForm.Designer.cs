namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            richTextBox6 = new RichTextBox();
            button5 = new Button();
            richTextBox7 = new RichTextBox();
            label8 = new Label();
            button6 = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(469, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(319, 303);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(469, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 1;
            textBox1.Enter += textBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(696, 90);
            button1.Name = "button1";
            button1.Size = new Size(92, 23);
            button1.TabIndex = 2;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 42);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(55, 90);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(388, 41);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(55, 152);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(388, 42);
            richTextBox3.TabIndex = 5;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(55, 214);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(388, 40);
            richTextBox4.TabIndex = 6;
            richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(55, 276);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(388, 39);
            richTextBox5.TabIndex = 7;
            richTextBox5.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(13, 102);
            label1.Name = "label1";
            label1.Size = new Size(27, 29);
            label1.TabIndex = 8;
            label1.Text = "A";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(13, 165);
            label2.Name = "label2";
            label2.Size = new Size(27, 29);
            label2.TabIndex = 9;
            label2.Text = "B";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(13, 225);
            label3.Name = "label3";
            label3.Size = new Size(27, 29);
            label3.TabIndex = 10;
            label3.Text = "C";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.Location = new Point(13, 286);
            label4.Name = "label4";
            label4.Size = new Size(27, 29);
            label4.TabIndex = 11;
            label4.Text = "D";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(63, 16);
            label5.TabIndex = 12;
            label5.Text = "Câu hỏi";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A", "B", "C", "D" });
            comboBox1.Location = new Point(12, 367);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 24);
            comboBox1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(12, 348);
            label6.Name = "label6";
            label6.Size = new Size(55, 16);
            label6.TabIndex = 14;
            label6.Text = "Đáp án";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Location = new Point(351, 367);
            button2.Name = "button2";
            button2.Size = new Size(92, 23);
            button2.TabIndex = 15;
            button2.Text = "Lưu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(139, 367);
            button3.Name = "button3";
            button3.Size = new Size(92, 23);
            button3.TabIndex = 16;
            button3.Text = "Gửi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(237, 367);
            button4.Name = "button4";
            button4.Size = new Size(108, 23);
            button4.TabIndex = 17;
            button4.Text = "Load câu hỏi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(696, 9);
            label7.Name = "label7";
            label7.Size = new Size(87, 16);
            label7.TabIndex = 18;
            label7.Text = "Mã câu hỏi";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(12, 457);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(237, 73);
            richTextBox6.TabIndex = 19;
            richTextBox6.Text = "";
            // 
            // button5
            // 
            button5.Location = new Point(255, 457);
            button5.Name = "button5";
            button5.Size = new Size(124, 23);
            button5.TabIndex = 20;
            button5.Text = "Gửi tin nhắn";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // richTextBox7
            // 
            richTextBox7.Location = new Point(13, 566);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(237, 123);
            richTextBox7.TabIndex = 21;
            richTextBox7.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(13, 547);
            label8.Name = "label8";
            label8.Size = new Size(135, 16);
            label8.TabIndex = 22;
            label8.Text = "Nhật ký tin nhắn";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // button6
            // 
            button6.Location = new Point(255, 496);
            button6.Name = "button6";
            button6.Size = new Size(90, 23);
            button6.TabIndex = 23;
            button6.Text = "Gửi file";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 701);
            Controls.Add(button6);
            Controls.Add(label8);
            Controls.Add(richTextBox7);
            Controls.Add(button5);
            Controls.Add(richTextBox6);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private RichTextBox richTextBox6;
        private Button button5;
        private RichTextBox richTextBox7;
        private Label label8;
        private Button button6;
        private OpenFileDialog openFileDialog1;
    }
}
