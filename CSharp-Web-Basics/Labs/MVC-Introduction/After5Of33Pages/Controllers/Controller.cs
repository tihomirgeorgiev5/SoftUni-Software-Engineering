

using BasicWebServer.HTTP;
using BasicWebServer.Responses;

namespace BasicWebServer.Controllers
{
    public abstract class Controller
    {
        private readonly Request request;

        protected Controller(Request request)
        {
            this.Request = request;
        }

        protected Request Request { get; private init; }

        protected Response Text(string text)
            => new TextResponse(text);

        protected Response Html(string text)
            => new HtmlResponse(text);

        protected Response BadRequest()
            => new BadRequestResponse();

        protected Response Unauthorized()
            => new UnauthorizedResponse();

        protected Response NotFound()
            => new NotFoundResponse();

        protected Response Redirect(string location)
            => new RedirectResponse(location);

        protected Response File(string fileName)
            => new TextFileResponse(fileName);


    }
}
