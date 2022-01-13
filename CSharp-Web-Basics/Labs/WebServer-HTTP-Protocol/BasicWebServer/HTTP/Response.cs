using System;

namespace BasicWebServer.HTTP
{
    public class Response
    {
        public Response(StatusCode _statusCode)
        {
            this.StatusCode = _statusCode;
            this.Headers.Add("Server", "SoftUni Server");
            this.Headers.Add("Date", $"{DateTime.UtcNow:r}");
        }
        public StatusCode StatusCode { get; init; }

        public HeaderCollection Headers { get; } = new HeaderCollection();

        public string Body { get; set; }
    }

}
