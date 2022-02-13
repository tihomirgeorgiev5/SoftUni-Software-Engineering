using CarShop.Models.Users;
using CarShop.Services;
using MyWebServer.Controllers;
using MyWebServer.Http;
using System.Linq;

namespace CarShop.Controllers
{

    public class UsersController : Controller
    {
        private readonly IValidator validator;

        public UsersController(IValidator validator)
        {
            this.validator = validator;
        }
        public HttpResponse Register() => View();

        [HttpPost]
        public HttpResponse Register(RegisterUserFormModel model)
        {
            var modelErrors = this.validator.ValidateUserRegistration(model);
            if (modelErrors.Any())
            {
                return Error(modelErrors);
            }

            return View(); 
        } 
    }
}
