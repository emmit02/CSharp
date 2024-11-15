using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Client
{
    class Program
    {
        public class ObjectState
        {
            public const int BufferSize = 256;
            public Socket wSocket = null;
            public byte[] buffer = new byte[BufferSize];
            public StringBuilder sb = new StringBuilder();
        }
        public class AsyncSocketClient
        {
            private const int Port = 4343;
            private static ManualResetEvent connectCompleted = new ManualResetEvent(false);
            private static ManualResetEvent sendCompleted = new ManualResetEvent(false);
            private static ManualResetEvent recieveCompleted = new ManualResetEvent(false);
            private static string response = String.Empty;

            public static void startClient()
            {
                try
                {
                    IPHostEntry iPHost = Dns.GetHostEntry(Dns.GetHostName());
                    IPAddress ip = iPHost.AddressList[0];
                    IPEndPoint remoteEndPoint = new IPEndPoint(ip, port);

                    Socket client = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    client.BeginConnect(remoteEndPoint, new AsyncCallback(ConnectionCallBack), client);
                    Send(client, "THIS IS SOCKET MESSAGE <EOF>");
                    SendCompleted.WaitOne();

                    Receive(client);
                    receiveCompleted.WaitOne();
                    Console.WriteLine($"Response Recieved { response }");
                    client.Shutdown(Socket.Shutdown.both);
                    client.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            private static void Receive(Socket client)
            {
                try
                {
                    ObjectState state = new ObjectState();
                    state.wSocket = client;
                    client.BeginReceive(State.Buffer, 0, ObjectState.BufferSize, 0, new AsyncCallback(RecieveCallBack), state);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            private static void RecieveCallBack(IAsyncResult ar)
            {
                try
                {
                    ObjectState state = (ObjectState)ar.AsyncState;
                    var client = State.wSocket;
                    int byteRead = client.EndRecieve(ar);
                    if (byteRead > 0)
                    {
                        state sb.Append(Encoding.ASCII.GetString(state.Buffer, 0, byteRead));
                        client.BeginReceive(state.Buffer, 0, ObjectState.BufferSize, 0, new AsyncCallback(RecieveCallBack), state);
                    }
                    else
                    {
                        if (state.sb.Length > 1)
                        {
                            FileWebResponse = state.sb.ToString();
                        }
                        recievecompleted.Set();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                }
            }

            private static void Send(Socket client, string data)
            {
                byte[] byteData = Encoding.ASCII.GetBytes(data);
                client.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallBack(SendCallBack), client);
            }

            private static void SendCallBack(IAsyncResult ar)
            {
                try
                {
                    Socket client = (Socket)ar.AsyncState;
                    int byteSent = client.EndSend(ar);
                    Console.WriteLine($"Sent: {byteSent} bytes to Server");
                    sendCompleted.Set();

                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            private static void ConnectionCallBack(IAsyncResult ar)
            {
                try
                {
                    Socket client = (Socket)ar.AsyncState();
                    client.EndConnect(ar);
                    Console.WriteLine($"Socket Connection : {client.RemoteEndPoint.ToString()}");
                    connectCompeleted.Set();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to continue..");
        }
    }
}
