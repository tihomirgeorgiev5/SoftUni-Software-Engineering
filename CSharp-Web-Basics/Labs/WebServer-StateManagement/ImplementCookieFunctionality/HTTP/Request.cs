﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicWebServer.HTTP
{
    public class Request
    {
        
        public Method Method { get; private set; }

        public string Url { get; private set; }

        public HeaderCollection Headers { get; private set; }

        public CookieCollection Cookies { get; private set; }

        public string Body { get; private set; }

        public IReadOnlyDictionary<string, string> Form { get; private set; }

        public static Request Parse(string request)
        {
            string newLine = "\r\n";
            var lines = request.Split(newLine);
            var startLine = lines
                .First()
                .Split(" ");
            var method = ParseMethod(startLine[0]);

            var url = startLine[1];

            var headers = ParseHeaders(lines.Skip(1));

            var cookies = ParseCookies(headers);
            var bodyLines = lines.Skip(headers.Count + 2).ToArray();
            string body = string.Join(newLine, bodyLines);
            var form = ParseForm(headers, body);

            return new Request
            {
                Method = method,
                Url = url,
                Headers = headers,
                Cookies = cookies,
                Body = body,
                Form = form
            };
        }

        public static CookieCollection ParseCookies(HeaderCollection headers)
        {
            var cookieCollection = new CookieCollection();

            if (headers.Contains(Header.Cookie))
            {
                var cookieHeader = headers[Header.Cookie];

                var allCookies = cookieHeader.Split(';');

                foreach (var cookieText in allCookies)
                {
                    var cookieParts = cookieText.Split('=');

                    var cookieName = cookieParts[0].Trim();

                    var cookieValue = cookieParts[1].Trim();

                    cookieCollection.Add(cookieName, cookieValue);
                }
            }

            return cookieCollection;
        }

        private static IReadOnlyDictionary<string, string> ParseForm(HeaderCollection headers, string body)
        {
            var formCollection = new Dictionary<string, string>();

            if (headers.Contains(Header.ContentType) && headers[Header.ContentType] == ContentType.FormUrlEncoded)

            {

                var parsedResult = ParseFormData(body);

                foreach (var (name, value) in parsedResult)
                {
                    formCollection.Add(name, value);
                }
            }
            return formCollection;
        }
        private static Dictionary<string, string> ParseFormData(string bodyLines)
            => HttpUtility.UrlDecode(bodyLines)
            .Split('&')
            .Select(part => part.Split('='))
            .Where(part => part.Length == 2)
            .ToDictionary(
               part => part[0],
               part => part[1],
              StringComparer.InvariantCultureIgnoreCase);

        private static HeaderCollection ParseHeaders(IEnumerable<string> lines)
        {
            var headers = new HeaderCollection();
            foreach (var line in lines)
            {
                if (line == String.Empty)
                {
                    break;
                }

                var parts = line.Split(":", 2);

                if (parts.Length != 2)
                {
                    throw new InvalidOperationException("Request headers is not valid!");

                }
                var headerName = parts[0];
                var headerValue = parts[1].Trim();
                headers.Add(headerName, headerValue);


            }
            return headers;
        }

        private static Method ParseMethod(string method)
        {
            try
            {
                return (Method)Enum.Parse(typeof(Method),method,true);
            }
            catch (Exception)
            {

                throw new InvalidOperationException($"Method '{method}' is not supported.");
            }
        }
    }
}
