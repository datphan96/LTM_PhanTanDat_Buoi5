using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanTanDat_b5_b1_Client
{
    public partial class Client : Form
    {
        //Socket S;
        Socket C;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            C = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
        }

        private void btn_cnt_Click(object sender, EventArgs e)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            C.Connect(ip);
            byte[] data;
            data = new byte[1024];
            C.Receive(data);
            listBox1.Items.Add("Server:" + Encoding.ASCII.GetString(data));
        }

        private void btn_snd_Click(object sender, EventArgs e)
        {
            //Khởi tạo mới data để không bị lỗi
            byte[] data;

            data = Encoding.ASCII.GetBytes(textBox2.Text);
            C.Send(data);
            listBox1.Items.Add("Client: " + textBox2.Text);
            data = new byte[1024];
            C.Receive(data);
            listBox1.Items.Add("Server:" + Encoding.ASCII.GetString(data));
        }

        private void btn_file_Click(object sender, EventArgs e)
        {

        }
    }
}
