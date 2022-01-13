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

        const string NewLine = "\r\n";

        public HttpServer(string _ipAddress, int _port)
        {
            this.ipAddress = IPAddress.Parse(_ipAddress);
            this.port = _port;

            this.serverListener = new TcpListener(this.ipAddress, port);

        }

        public void Start()
        {
            this.serverListener.Start();

            Console.WriteLine($"Server started on port {port}.");
            Console.WriteLine("Listening for requests...");


            while (true)
            {
                var connection = serverListener.AcceptTcpClient();
                var networkStream = connection.GetStream();
                string request = ReadRequest(networkStream);
                Console.WriteLine(request);

                
                WriteResponse(networkStream, "Hello from the Server!");

                connection.Close();
            }
        }

        private void WriteResponse(NetworkStream networkStream, string content)
        {
           //var buffer = new byte[1000000];
           //var length = networkStream.Read(buffer, 0, buffer.Length);
           //var requestString = Encoding.UTF8.GetString(buffer, 0, length);
            


            var contentLength = Encoding.UTF8.GetByteCount(content);

            var response = $@"HTTP/1.1 200 OK" + NewLine +
        "Content-Type: text/plain; charset=UTF-8" + NewLine +
        "Content-Length: " + content.Length + NewLine + NewLine + content + NewLine;
            var responseBytes = Encoding.UTF8.GetBytes(response);

            networkStream.Write(responseBytes, 0, responseBytes.Length);
        }
        private string ReadRequest(NetworkStream networkStream)
        {
            var buffer = new byte[1000000];
            StringBuilder request = new StringBuilder();
            int totalBytes = 0;
            //
            //var requestString = Encoding.UTF8.GetString(buffer, 0, length);

            do
            {
                var length = networkStream.Read(buffer, 0, buffer.Length);
                totalBytes += length;
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
