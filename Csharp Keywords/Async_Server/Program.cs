using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Server
{
    class Program
    {
        public class ObjectState
        {
            public Socket wSocket = null;
            public const int bufferSize = 1024;
            public byte[] buffer = new byte[bufferSize];
            public StringBuilder sb = new StringBuilder();
        }

        public class AsyncSocketListener
        {
            public static ManualResetEvent allcompeleted = new ManualResetEvent(false);

            public static void startlistener()
            {
                byte[] bytes = new byte[1024];
                IPHostEntry iPHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ip = iPHost.AddressList[0];
                IPEndPoint localEndPoint = new IPEndPoint(ip, 4343);
                Socket listener = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    listener.Bind(localEndPoint);
                    listener.Listen(100);
                    while (true)
                    {
                        allcompeleted.Reset();
                        Console.WriteLine($"Waiting for incoming connection...");
                        listener.BeginAccept(new AsyncCallback(AcceptCallBack), listener);
                        allcompeleted.WaitOne();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            private static void AcceptCallBack(IAsyncResult ar)
            {
                allcompeleted.Set();
                Socket listener = (Socket)ar.AsyncState;
                Socket handler = listener.EndAccept(ar);

                ObjectState state = new ObjectState();
                state.wSocket = handler;
                handler.BeginReceive(state.buffer, 0, ObjectState.bufferSize, 0, new AsyncCallback(ReadCallBack), state);
            }
            private static void ReadCallBack(IAsyncResult ar)
            {
                string content = String.Empty;
                ObjectState state = (ObjectState)ar.AsyncState;
                Socket handler = state.wSocket;
                int bytesRead = handler.EndReceive(ar);
                if (bytesRead > 0)
                {
                    state.sb.ToString();
                    if (content.IndexOf("<EOF>", StringComparison.Ordinal) > -1)
                    {
                        Console.WriteLine($"Read: {content.Length} bytes from /n  socket data: {content}");
                        Send(handler, content);
                    }
                    else
                    {
                        handler.BeginReceive(state.buffer, 0, ObjectState.bufferSize, 0, new AsyncCallback(ReadCallBack), state);
                    }
                }
            }

            private static void Send(Socket handler, string content)
            {
                byte[] byteData = Encoding.ASCII.GetBytes(content);
                handler.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallBack), handler);
            }

            private static void SendCallBack(IAsyncResult ar)
            {
                try
                {
                    Socket hander = (Socket)ar.AsyncState;
                    int byteSent = hander.EndSend((ar));
                    Console.WriteLine($"Sent: {byteSent} to client");

                    hander.Shutdown(SocketShutdown.Both);
                    hander.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        
        static void Main(String[] Args)
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            AsyncSocketListener.startlistener();
            Console.ReadLine();
        }
    }
}
