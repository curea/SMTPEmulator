using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SMTPEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new SMTPServer();
            server.RunServer();
        }
    }
}
