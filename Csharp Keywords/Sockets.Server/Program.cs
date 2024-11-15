﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Sockets.Server
{
    class Program
    {
        public class SyncServerSocket
        {
            public static string data = null;
            public static void startListener()
            {
                byte[] bytes = new byte[1024];

                IPHostEntry iPHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress iPAddress = iPHost.AddressList[0];
                IPEndPoint localEndPoint = new IPEndPoint(iPAddress, 45323);
                Socket listener = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    listener.Bind(localEndPoint);
                    listener.Listen(10);
                    while (true)
                    {
                        Console.WriteLine($"Waiting for a connection...");
                        Socket handler = listener.Accept();
                        while (true)
                        {
                            int byteRec = handler.Receive(bytes);
                            data += Encoding.ASCII.GetString(bytes, 0, byteRec);
                            if (data.IndexOf("{EOF}") > -1)
                            {
                                break;
                            }
                        }
                        Console.WriteLine($"Text Recieved: {data}");
                        byte[] msg = Encoding.ASCII.GetBytes(data);
                        handler.Send(msg);
                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Press any key to exit program..");
                    Console.ReadLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key continue...");
            Console.ReadLine();
            SyncServerSocket.startListener();
            Console.ReadLine();
        }
    }
}
