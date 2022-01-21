﻿using BasicWebServer.HTTP;
using BasicWebServer.Routing;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BasicWebServer
{
    public class HttpServer
    {
        private readonly IPAddress ipAddress;
        private readonly int port;
        private readonly TcpListener serverListener;

        private readonly RoutingTable routingTable;
       
        const string NewLine = "\r\n";

        public HttpServer(int port, Action<IRoutingTable> routingTable)
            : this("127.0.0.1", port, routingTable)
        {
        
        }

       public HttpServer(Action<IRoutingTable> routingTable)
           : this(8080, routingTable)
       {
      
       }
        public HttpServer(string ipAddress, int port,
            Action<IRoutingTable> routingTableConfiguration)
        {
            this.ipAddress = IPAddress.Parse(ipAddress);
            this.port = port;

            this.serverListener = new TcpListener(this.ipAddress, port);

            routingTableConfiguration(this.routingTable = new RoutingTable());

        }

      //public HttpServer(Func<object, object> p)
      //{
      //    this.p = p;
      //}
      //
        public void Start()
        {
            this.serverListener.Start();

            Console.WriteLine($"Server started on port {port}.");
            Console.WriteLine("Listening for requests...");


            while (true)
            {
                var connection = serverListener.AcceptTcpClient();
                var networkStream = connection.GetStream();
                var requestText = this.ReadRequest(networkStream);
                Console.WriteLine(requestText);

                var request = Request.Parse(requestText);

                var response = this.routingTable.MatchRequest(request);

                if (response.PreRenderAction != null)
                
                    response.PreRenderAction(request, response);
                

                
                WriteResponse(networkStream, response);

                connection.Close();
            }
        }

        private void WriteResponse(NetworkStream networkStream, Response response)
        {
           //var buffer = new byte[1000000];
           //var length = networkStream.Read(buffer, 0, buffer.Length);
           //var requestString = Encoding.UTF8.GetString(buffer, 0, length);
            


            //var contentLength = Encoding.UTF8.GetByteCount(content);

            //var response = $@"HTTP/1.1 200 OK" + NewLine +
        /*"Content-Type: text/plain; charset=UTF-8" + NewLine +
        "Content-Length: " + content.Length + NewLine + NewLine + content + NewLine;*/
            var responseBytes = Encoding.UTF8.GetBytes(response.ToString());

            networkStream.Write(responseBytes);
        }
        private string ReadRequest(NetworkStream networkStream)
        {
            var buffer = new byte[1024];
            StringBuilder request = new StringBuilder();
            int totalBytes = 0;
            //
            //var requestString = Encoding.UTF8.GetString(buffer, 0, length);

            do
            {
                var length = networkStream.Read(buffer, 0, 1024);
                //totalBytes += length;
                if (totalBytes > 10 * 1024)
                {
                    throw new InvalidOperationException("Request is too large!");
                }

                request.Append(Encoding.UTF8.GetString(buffer, 0, length));

            } while (networkStream.DataAvailable);

            return request.ToString();
        }
    }
}
