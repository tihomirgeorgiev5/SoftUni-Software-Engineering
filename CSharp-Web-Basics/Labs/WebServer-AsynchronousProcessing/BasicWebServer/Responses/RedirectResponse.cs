﻿using BasicWebServer.HTTP;

namespace BasicWebServer.Responses
{
    public class RedirectResponse : Response
    {
        public RedirectResponse(string location) : base(StatusCode.Found)
        {
            this.Headers.Add(Header.Location, location);
        }
    }
}
