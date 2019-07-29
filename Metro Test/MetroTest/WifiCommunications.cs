using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace MetroTest
{
    class WifiCommunications 
    {
        private static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static List<Socket> _CleientSockets = new List<Socket>();
        private static byte[] _buffer = new byte[1024];

        public WifiCommunications() {

            SetupServer();
            Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            List<Socket> _CleientSockets = new List<Socket>();
            byte[] _buffer = new byte[1024];
        
        }

        private void SetupServer()
        {
           // Console.WriteLine("Setting up server....");
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
            _serverSocket.Listen(5);
            _serverSocket.BeginAccept(new AsyncCallback(Acceptcallback), null);
        }

        private void Acceptcallback(IAsyncResult AR)
        {
            Socket socket = _serverSocket.EndAccept(AR); // returns accepted connections 
            _CleientSockets.Add(socket);
           // Console.WriteLine("client connected");
            //recieving data 
            // we can update code by recieving buffer size first 
            AppendCheckBock(socket.RemoteEndPoint.ToString());
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
            _serverSocket.BeginAccept(new AsyncCallback(Acceptcallback), null); //  we start accepting the next client 

        }


        private static void ReceiveCallBack(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int recieved = socket.EndReceive(AR); // return the amount of data revieved

            // were are now goint to trim the data depanding he the amount of data recieved 
            // this is to ensure that we dont have any null bytes 

            byte[] dataBuf = new byte[recieved]; // temp buffer 
            Array.Copy(_buffer, dataBuf, recieved);

            String text = Encoding.ASCII.GetString(dataBuf);
            Console.WriteLine("Text recieved" + text);

            String response = string.Empty;

            if(text.Contains("**")){

                String[] Order = text.Split(',');
                String OrderName = Order[0];
                String ORderCost = Order[1];
                String TableId = Order[2];
                int tableid = 0;
                double cost;

                int.TryParse(TableId, out tableid);
                double.TryParse(ORderCost, out cost);

               // DatabaseConnections myDB = new DatabaseConnections();
               // myDB.CreateOrder(text);

                MainForm UI = new MainForm();
               // UI.updateOrder(tableid);
                
            
            }

            if (text.ToLower() != "get time")
            {

                response = "Invalid request";
            }
            else
            {
                response = DateTime.Now.ToString();
            }

            byte[] data = Encoding.ASCII.GetBytes(response);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallBack), socket);
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
        }

        private static void SendCallBack(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            socket.EndSend(ar);
        }


        private void Sendata(Socket _Sock,String Message){

            byte[] data = Encoding.ASCII.GetBytes(Message);
            _Sock.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallBack), _Sock);
            _Sock.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), _Sock);
        
        }


        private void AppendCheckBock(String ClientName){

            MethodInvoker invoker = new MethodInvoker(delegate {
               // this.list_Client.Text =ClientName;
            });
        
        }

        public void SendData(String message) {

            

            for (int i= 0; i < _CleientSockets.Count;i++ )
            {
                string  t = _CleientSockets[i].ToString();
                for (int j = 0; j < _CleientSockets.Count;j++ )
                {
                    Sendata(_CleientSockets[j], message);
                }
            }


        
        }

    }
}
