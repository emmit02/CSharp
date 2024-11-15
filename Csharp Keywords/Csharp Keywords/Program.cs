using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Csharp_Keywords
{
    class Program
    {
        public class SyncSocketClient
        {
            public static void StartClient()
            {
                byte[] bytes = new byte[1024];
                try
                {
                    var hostName = Dns.GetHostName();
                    IPHostEntry iPHost = Dns.GetHostEntry(hostName);
                    Console.WriteLine($"Host: {hostName}");
                    IPAddress ip = iPHost.AddressList[0];
                    IPEndPoint remoteip = new IPEndPoint(ip, 45323);

                    Socket sender = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        sender.Connect(remoteip);
                        Console.WriteLine("Socket Connected");
                        sender.RemoteEndPoint.ToString();
                        byte[] msg = Encoding.ASCII.GetBytes("Just for Testing");
                        int byteSend = sender.Send(msg);
                        int byteRec = sender.Receive(bytes);
                        Console.WriteLine($"Echoed Test: {Encoding.ASCII.GetString(bytes, 0, byteRec)}");

                        sender.Close();
                    }
                    catch(ArgumentNullException e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                    catch(SocketException e)
                    {
                        Console.WriteLine(e.Message);
                        
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        
                    }
                }
                catch(Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            SyncSocketClient.StartClient();
            Console.ReadLine();
        }
    }
}