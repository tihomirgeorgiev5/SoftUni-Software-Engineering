namespace BasicWebServer.HTTP
{
    public class HtmlResponse : ContentResponse
    {
        public HtmlResponse(string text) : base(text, ContentType.Html)
        {
        }
    }
}
