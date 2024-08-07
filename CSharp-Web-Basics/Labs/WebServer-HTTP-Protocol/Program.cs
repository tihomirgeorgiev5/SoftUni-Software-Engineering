﻿using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const string NewLine = "\r\n";
            TcpListener tcpListener = new TcpListener(IPAddress.Loopback, 12345);
            tcpListener.Start();
            while (true)
            {
                var client = tcpListener.AcceptTcpClient();
                using (var stream = client.GetStream())
                {

                    byte[] buffer = new byte[1000000];
                    var length = stream.Read(buffer, 0, buffer.Length);

                    string requestString = Encoding.UTF8.GetString(buffer, 0, length);
                    Console.WriteLine(requestString);
                    string html = $"<h1>Hello from TishoServer {DateTime.Now}</h1>";

                    string response = "HTTP/1.1 307 Redirect" + NewLine +
                        "Server: TishoServer 2022" + NewLine +
                        //"Location: https://www.google.com" + NewLine +
                        "Content-Type: text/json; charset=utf-8" + NewLine +
                        //"Content-Disposition: attachment; filename=tisho.txt" + NewLine +
                        "Content-Length: " + html.Length + NewLine + NewLine + html + NewLine;

                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    stream.Write(responseBytes);
                    Console.WriteLine(new string('=', 70));
                }
            }

        }
        public static async Task ReadData()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string url = "https://softuni.bg/courses/csharp-web-basics";

            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            Console.WriteLine(response.StatusCode);
            Console.WriteLine(string.Join(Environment.NewLine,response.Headers.Select(x => x.Key + ": " + x.Value.First())));
            //var html = await httpClient.GetStringAsync(url);
            //Console.WriteLine(html);
        }
    }
}
