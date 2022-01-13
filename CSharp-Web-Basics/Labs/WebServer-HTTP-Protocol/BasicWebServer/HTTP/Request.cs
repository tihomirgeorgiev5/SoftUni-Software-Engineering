﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer.HTTP
{
    public class Request
    {
        const string NewLine = "\r\n";
        public Method Method { get; private set; }

        public string Url { get; private set; }

        public HeaderCollection Headers { get; private set; }

        public string Body { get; private set; }

        public static Request Parse(string request)
        {
            var lines = request.Split(NewLine);
            var startLine = lines
                .First()
                .Split(" ");

            var url = startLine[1];
            Method method = ParseMethod(startLine[0]);
            HeaderCollection headers = ParseHeaders(lines.Skip(1));
            var bodyLines = lines.Skip(headers.Count + 2);
            string body = string.Join(NewLine, bodyLines);

            return new Request()
            {
                Method = method,
                Url = url,
                Headers = headers,
                Body = body

            };
        }

        private static HeaderCollection ParseHeaders(IEnumerable<string> lines)
        {
            var headers = new HeaderCollection();
            foreach (var line in lines)
            {
                if (line == String.Empty)
                {
                    break;
                }

                var parts = line.Split(":");

                if (parts.Length != 2)
                {
                    throw new InvalidOperationException($"Request headers is not valid!");
                   
                }
                headers.Add(parts[0], parts[1].Trim());


            }
            return headers;
        }

        private static Method ParseMethod(string method)
        {
            try
            {
                return Enum.Parse<Method>(method);
            }
            catch (Exception)
            {

                throw new InvalidOperationException($"Method '{method}' is not supported");
            }
        }
    }
}
