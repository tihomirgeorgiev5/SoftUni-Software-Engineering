using CarShop.Data;
using CarShop.Data.Models;
using CarShop.Models.Users;
using CarShop.Services;
using MyWebServer.Controllers;
using MyWebServer.Http;
using System.Linq;
using static CarShop.Data.DataConstants;

namespace CarShop.Controllers
{

    public class UsersController : Controller
    {
        private readonly IValidator validator;
        private readonly CarShopDbContext data;

        public UsersController(IValidator validator)
        {
            this.validator = validator;
            this.data = data;
        }
        public HttpResponse Register() => View();

        [HttpPost]
        public HttpResponse Register(RegisterUserFormModel model)
        {
            var modelErrors = this.validator.ValidateUserRegistration(model);

            if (this.data.Users.Any(u => u.Username == model.Username))
            {
                modelErrors.Add($"User '{model.Username}' username already exists");
            }

            if (this.data.Users.Any(u => u.Email == model.Email))
            {
                modelErrors.Add($"User '{model.Email}' e-mail already exists");
            }

            if (modelErrors.Any())
            {
                return Error(modelErrors);
            }

            var user = new User
            {
                Username = model.Username,
                Password = null,
                Email = model.Email,
                IsMechanic = model.UserType == UserTypeMechanic,

            };

            data.Users.Add(user);
            data.SaveChanges();



            return Redirect("/Users/Login");
        } 
    }
}
