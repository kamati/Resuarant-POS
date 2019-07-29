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
using System.Windows.Forms;

namespace MetroTest
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {

        private byte[] _buffer = new byte[1024];
        public List<Socket> __ClientSockets = new List<Socket>();
        List<string> _names = new List<string>();
        private Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private Button buttonClick;
        int k =0;

        public MainForm()
        {
            InitializeComponent();
            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           /// CreateOrderList();
            SetupServer();
            buttonClick = new System.Windows.Forms.Button();
            

            //wifiAdapter = new WifiCommunications();
        }


        private void SetupServer()
        {
           // rich_Text.AppendText("Setting up server....");
            // Console.WriteLine("Setting up server....");
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
            _serverSocket.Listen(6);
            _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private void AppceptCallback(IAsyncResult ar)
        {
            Socket socket = _serverSocket.EndAccept(ar);
            __ClientSockets.Add(socket);
            AppendCheckBock(socket.RemoteEndPoint.ToString());

            AppendToolbar("Number of clients connected" + __ClientSockets.Count.ToString());
            AppendeTextBox( "Client connected. . .","connectining");
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }
        private void ReceiveCallback(IAsyncResult ar)
        {

            Socket socket = (Socket)ar.AsyncState;
            if (socket.Connected)
            {
                int received;
                try
                {
                    received = socket.EndReceive(ar);
                }
                catch (Exception)
                {
                    // client đóng kết nối
                    for (int i = 0; i < __ClientSockets.Count; i++)
                    {
                        if (__ClientSockets[i].RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            __ClientSockets.RemoveAt(i);
                            AppendToolbar( "Number Of Client Conneceted: " + __ClientSockets.Count.ToString());
                        }
                    }
                    // xóa trong list
                    return;
                }
                if (received != 0)
                {
                    byte[] dataBuf = new byte[received];
                    Array.Copy(_buffer, dataBuf, received);
                    string text = Encoding.ASCII.GetString(dataBuf);
                   // AppendToolbar( "Text received: " + text);

                    string reponse = string.Empty;
                    //if (text.Contains("@@"))
                    //{
                    //    for (int i = 0; i < list_Client.Items.Count; i++)
                    //    {
                    //        if (socket.RemoteEndPoint.ToString().Equals(__ClientSockets[i]._Socket.RemoteEndPoint.ToString()))
                    //        {
                    //            list_Client.Items.RemoveAt(i);
                    //            list_Client.Items.Insert(i, text.Substring(1, text.Length - 1));
                    //            __ClientSockets[i]._Name = text;
                    //            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
                    //            return;
                    //        }
                    //    }
                    //}

                    for (int i = 0; i < __ClientSockets.Count; i++)
                    {
                        if (socket.RemoteEndPoint.ToString().Equals(__ClientSockets[i].RemoteEndPoint.ToString()))
                        {
                            AppendeTextBox( __ClientSockets[i].ToString(),text);
                        }
                    }



                    if (text == "bye")
                    {
                        return;
                    }
                    reponse = "server da nhan" + text;
                    Sendata(socket, reponse);
                }
                else
                {
                    for (int i = 0; i < __ClientSockets.Count; i++)
                    {
                        if (__ClientSockets[i].RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            __ClientSockets.RemoveAt(i);
                            AppendToolbar("clients connected " + __ClientSockets.Count.ToString());
                        }
                    }
                }
            }
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
        }

        private void Sendata(Socket _Sock, String Message)
        {

            byte[] data = Encoding.ASCII.GetBytes(Message);
            _Sock.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), _Sock);
            _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);

        }

        private void SendCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }



        private void SendInfo() {

            for (int i = 0; i < list_Client.SelectedItems.Count; i++)
            {

                string t = list_Client.SelectedItems[i].ToString();
                for (int j = 0; j < __ClientSockets.Count; j++)
                {
                    //if (__ClientSockets[j]._Socket.Connected && __ClientSockets[j]._Name.Equals("@"+t))
                    {
                        Sendata(__ClientSockets[j], txt_Text.Text);
                    }
                }
            }
            AppendeTextBox("\nServer: " , txt_Text.Text);
        
        }

        private void AppendToolbar(String text)
        {

            MethodInvoker invoker = new MethodInvoker(delegate
            {
                lb_soluong.Text = text;
            });
            this.Invoke(invoker);

        }

        private void AppendCheckBock(String ClientName)
        {

            MethodInvoker invoker = new MethodInvoker(delegate
            {
                list_Client.Items.Add(ClientName) ;
            });
            this.Invoke(invoker);

        }

        private void AppendeTextBox(String Client, String message)
        {

            MethodInvoker invoker = new MethodInvoker(delegate
            {
                rich_Text.AppendText("\n" + Client + ": " + message);
                updateOrder(message);
            });
            this.Invoke(invoker);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Docket myDocket = new Docket();
            buttonClick = myDocket.getButton();
            buttonClick.Click += new EventHandler(b_Click);
            flowLayoutPanel1.Controls.Add(myDocket.CreateDocket(k));
            //InitializeComponent();
            k++;

            if (k == 15)
                k = 0;
        }

        public void updateOrder(String text)
        {

            MethodInvoker invoker = new MethodInvoker(delegate
            {
                if (text.Contains("*"))
                {

                    String[] Order = text.Split('*');
                    String TableId = Order[0];
                    

                    int tableid = 0;
                    int.TryParse(TableId, out tableid);

                    String[] Fullorder = Order[1].Split('$');
                    String orderName = "";
                    String orderCost = "";
                    for (int i = 0; i < Fullorder.Length; i++) {
                        String[] singeOrder = Fullorder[i].Split(',');
                        for (int j = 0; j < singeOrder.Length; j++) {
                            

                            if (singeOrder[j].Contains("#")) { 
                                String[] ordName =singeOrder[j].Split('#');
                                orderName =ordName[0];
                                
                                
                            }
                            else if (singeOrder[j].Contains("@")) {
                                String[] ordCost = singeOrder[j].Split('@');
                                orderCost= ordCost[0];
                               // MessageBox.Show(orderCost);
                            }
                            double cost;
                            int.TryParse(TableId, out tableid);
                            if (double.TryParse(orderCost, out cost))
                            {
                                DatabaseConnections myDB = new DatabaseConnections();
                                myDB.CreateOrder(orderName, cost, tableid);
                            }
                            
                         }
                    
                    }

                    
 

                    Docket myDocket = new Docket();
                    buttonClick = myDocket.getButton();
                    buttonClick.Click += new EventHandler(b_Click);
                    flowLayoutPanel1.Controls.Add(myDocket.CreateDocket(tableid));

                }
              
            });
            this.Invoke(invoker); 
            
        }

        private void b_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int ButtonIndex = 0;
            int.TryParse(b.Name, out ButtonIndex);
            MessageBox.Show("you clicked " + b.Name);
            if (flowLayoutPanel1.Controls.Count!=0)
                flowLayoutPanel1.Controls.RemoveAt(ButtonIndex);
            else
                flowLayoutPanel1.Controls.RemoveAt(ButtonIndex);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //wifiAdapter = new WifiCommunications();
        }

        private void metroTileEmployeesmangment_Click(object sender, EventArgs e)
        {
            EmployeesForm employeeform = new EmployeesForm();
            employeeform.Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendInfo();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            TablesManagment tables = new TablesManagment();
            tables.Show();
        }

        private void metroTile5_MouseEnter(object sender, EventArgs e)
        {
            
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Blue;
        }

        private void metroTile5_MouseLeave(object sender, EventArgs e)
        {
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void metroTileProducts_MouseEnter(object sender, EventArgs e)
        {
            this.metroTileProducts.Style = MetroFramework.MetroColorStyle.Magenta;
        }

        private void metroTileProducts_MouseLeave(object sender, EventArgs e)
        {
            this.metroTileProducts.Style = MetroFramework.MetroColorStyle.Lime;

        }

        

        private void metroTileStock_MouseEnter(object sender, EventArgs e)
        {
            this.metroTileStock.Style = MetroFramework.MetroColorStyle.Purple;
        }

        private void metroTileStock_MouseLeave(object sender, EventArgs e)
        {
            this.metroTileStock.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void metroTileNetworks_MouseEnter(object sender, EventArgs e)
        {
            this.metroTileNetworks.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void metroTileNetworks_MouseLeave(object sender, EventArgs e)
        {
            this.metroTileNetworks.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void metroTileStates_MouseLeave(object sender, EventArgs e)
        {
            this.metroTileStates.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void metroTileStates_MouseEnter(object sender, EventArgs e)
        {
            this.metroTileStates.Style = MetroFramework.MetroColorStyle.Orange;
        }

        private void metroTileEmployeesmangment_MouseEnter(object sender, EventArgs e)
        {
            this.metroTileEmployeesmangment.Style = MetroFramework.MetroColorStyle.Red;
        }

        private void metroTileEmployeesmangment_MouseLeave(object sender, EventArgs e)
        {
            this.metroTileEmployeesmangment.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void metroTileStock_Click(object sender, EventArgs e)
        {
            Stock_Managment sm = new Stock_Managment();
            sm.Show();
        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
 
    }

    public class SocketT2h
    {
        public Socket _Socket { get; set; }
        public string _Name { get; set; }
        public SocketT2h(Socket socket)
        {
            this._Socket = socket;
        }
    }
}
