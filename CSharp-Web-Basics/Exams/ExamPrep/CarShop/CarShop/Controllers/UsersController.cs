using CarShop.Models.Users;
using MyWebServer.Controllers;
using MyWebServer.Http;

namespace CarShop.Controllers
{
    
    public class UsersController : Controller
    {
        public HttpResponse Register() => View();

        [HttpPost]
        public HttpResponse Register(RegisterUserFormModel model)
        {
            return View();
        } 
    }
}
