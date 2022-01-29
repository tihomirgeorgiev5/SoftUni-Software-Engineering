﻿using WebServer.Server.HTTP;
using WebServer.Server.Routing;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Server
{
    public class HttpServer
    {
        private readonly IPAddress ipAddress;
        private readonly int port;
        private readonly TcpListener serverListener;

        private readonly RoutingTable routingTable;

        const string NewLine = "\r\n";



        public HttpServer(string ipAddress, int port,
            Action<IRoutingTable> routingTableConfiguration)
        {
            this.ipAddress = IPAddress.Parse(ipAddress);
            this.port = port;

            this.serverListener = new TcpListener(this.ipAddress, port);

            routingTableConfiguration(this.routingTable = new RoutingTable());

        }
        public HttpServer(int port, Action<IRoutingTable> routingTable)
            : this("127.0.0.1", port, routingTable)
        {

        }
        public HttpServer(Action<IRoutingTable> routingTable)
          : this(8080, routingTable)
        {

        }


        public async Task Start()
        {
            this.serverListener.Start();

            Console.WriteLine($"Server started on port {port}.");
            Console.WriteLine("Listening for requests...");


            while (true)
            {
                var connection = await serverListener.AcceptTcpClientAsync();

                _ = Task.Run(async () =>
                {
                    var networkStream = connection.GetStream();
                    var requestText = await this.ReadRequest(networkStream);

                    Console.WriteLine(requestText);


                    var request = Request.Parse(requestText);

                    var response = this.routingTable.MatchRequest(request);

                    
                    AddSession(request, response);

                    await WriteResponse(networkStream, response);

                    connection.Close();

                });
            }
        }
        private async Task<string> ReadRequest(NetworkStream networkStream)
        {
            var bufferLength = 1024;
            var buffer = new byte[bufferLength];
            int totalBytes = 0;
            StringBuilder request = new StringBuilder();

            do
            {
                var bytesRead = await networkStream.ReadAsync(buffer, 0, bufferLength);
                totalBytes += bytesRead;
                if (totalBytes > 10 * 1024)
                {
                    throw new InvalidOperationException("Request is too large!");
                }

                request.Append(Encoding.UTF8.GetString(buffer, 0, bytesRead));

            }
            while (networkStream.DataAvailable);

            return request.ToString();
        }

        private async Task WriteResponse(NetworkStream networkStream, Response response)
        {

            var responseBytes = Encoding.UTF8.GetBytes(response.ToString());

            await networkStream.WriteAsync(responseBytes);
        }

        private static void AddSession(Request request, Response response)
        {
            var sessionExists = request.Session
                .ContainsKey(Session.SessionCurrentDateKey);

            if (!sessionExists)
            {
                request.Session[Session.SessionCurrentDateKey]
                    = DateTime.Now.ToString();

                response.Cookies
                    .Add(Session.SessionCookieName, request.Session.Id);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


    }

}

