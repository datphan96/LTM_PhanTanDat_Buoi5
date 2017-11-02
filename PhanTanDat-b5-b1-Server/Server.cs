using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace PhanTanDat_b5_b1_Server
{
    public partial class Server : Form
    {
        Socket S;
        Socket C;
        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 12345);

            S.Bind(ip);

            S.Listen(10);

            C = S.Accept();

            S.BeginAccept(new AsyncCallback(AcceptCallback), S);
        }

        private void AcceptCallback(IAsyncResult iar)
        {
            C = S.EndAccept(iar);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes(textBox2.Text);
            C.Send(data);
            listBox1.Items.Add("Server: " + textBox2.Text);
            textBox2.Text = " ";


            //Khởi tạo mới data để không bị lỗi
            data = new byte[1024];
            C.Receive(data);
            listBox1.Items.Add("Client:" + Encoding.ASCII.GetString(data));
        }
    }
}
