﻿using WebServer.Server.HTTP;

namespace WebServer.Server.Responses
{
    public class TextResponse : ContentResponse
    {
        public TextResponse(string text) 
            : base(text, ContentType.PlainText)
        {
        }
    }
}
