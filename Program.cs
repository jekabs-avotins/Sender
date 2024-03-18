using System.Net.Sockets;
using System.Text;

namespace Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient(11000);

            string receiverIP = "127.0.0.1";
            int receiverPort = 11001;

            Console.WriteLine("Enter text to send. Type 'exit' to close.");

            while (true)
            {
                string message = Console.ReadLine()!;
                byte[] bytesToSend = Encoding.ASCII.GetBytes(message);
                udpClient.Send(bytesToSend, bytesToSend.Length, receiverIP, receiverPort);
                

                if (message.ToLower() == "exit")
                {
                    Console.WriteLine("Sender closed.");
                    break;
                }
            }
            
        }
    }
}
