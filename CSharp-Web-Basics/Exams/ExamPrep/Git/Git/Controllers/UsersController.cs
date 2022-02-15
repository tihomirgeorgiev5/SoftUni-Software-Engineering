using Git.Models.Users;
using MyWebServer.Controllers;
using MyWebServer.Http;

namespace Git.Controllers
{
    public class UsersController : Controller
    {
        public HttpResponse Register()
            => View();

        [HttpPost]
        public HttpResponse Register(RegisterUserFormModel model)
        {
            return View();
        }
    }
}
