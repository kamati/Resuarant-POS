using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace MetroTest
{
    class NetworkConnections
    {
        private Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private List<Socket> _cleintSocket = new List<Socket>();
        private byte[] _buffer = new byte[1025];
       
        public void SetUpServer()
        {
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any,5000));
            _serverSocket.Listen(5);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            try 
            { 
                Socket _socket = _serverSocket.EndAccept(ar);
                _cleintSocket.Add(_socket);
                _socket.BeginReceive(_buffer,0,_buffer.Length,SocketFlags.None,new AsyncCallback(ReceiveCallback),_socket);


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            Socket _socket = (Socket)ar.AsyncState;
            int received = _socket.EndReceive(ar);
            byte[] databuf = new byte[received];
            Array.Copy(_buffer,databuf,received);
            string RecievedText = Encoding.ASCII.GetString(_buffer);
           


        }

        

    }

    
}
