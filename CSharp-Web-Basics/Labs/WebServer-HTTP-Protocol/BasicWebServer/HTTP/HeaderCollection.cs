using System.Collections.Generic;
using System.Linq;

namespace BasicWebServer.HTTP
{
    public class HeaderCollection
    {
        private readonly Dictionary<string, Header> headers =
            new Dictionary<string, Header>();

        public int Count => headers.Count();

        public void Add(string name, string value)
        {
            var header = new Header(name, value);
            this.headers.Add(name, header);
        }
    }
}
