using System;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Threading;


namespace gitConsoleTest
{
    class ServerSideApp
    {
        Thread thread = new Thread(new ThreadStart(StartServer));
        public ServerSideApp()
        {
            thread.Start();
        }

        static void StartServer()
        {
            Console.WriteLine("server Starting");
            Thread.Sleep(8000);
            Console.WriteLine("server Closing");
            Console.Beep();
        }


    }
}
