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

namespace Econtact
{
    public partial class Chat_Client_App : Form
    {

        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public Chat_Client_App()
        {
            InitializeComponent();

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);


            textLocalIp.Text = GetLocalIP();
            textFrendsIp.Text = GetLocalIP();
            

        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                    if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "172.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {

            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if(size > 0){
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    listMessage.Items.Add("Friend: " + receivedMessage);
                 }

                byte[] buffer = new Byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);


            }catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void Start_Click(Object sender, EventArgs e)
        {

            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(textFrendsIp.Text), Convert.ToInt32(textFrendsPort.Text));
                sck.Bind(epRemote);

                byte[] buffer = new Byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                Start.Text = "Connected";
                Start.Enabled = false;
                SEND.Enabled = true;
                textMessage.Focus();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void SEND_Click(object sender, EventArgs e)
        {

            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textMessage.Text);

                sck.Send(msg);
                listMessage.Items.Add("You :" + textMessage.Text);
                textMessage.Clear();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }

        }
    }
}
