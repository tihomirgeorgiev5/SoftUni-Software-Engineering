﻿using WebServer.Server.Controllers;
using WebServer.Server.HTTP;

namespace WebServer.Demo.Controllers
{
    public class UsersController : Controller
    {
        private const string LoginForm = @"<form action='/Login' method='POST'>
   Username: <input type='text' name='Username'/>
   Password: <input type='text' name='Password'/>
   <input type='submit' value ='Log In' /> 
</form>";

        private const string Username = "user";

        private const string Password = "user123";
        public UsersController(Request request) : base(request)
        {

        }

        public Response Login() => View();

        public Response LogInUser()
        {
            this.Request.Session.Clear();

            var usernameMatches = this.Request.Form["Username"] == UsersController.Username;

            var passwordMatches = this.Request.Form["Password"] == UsersController.Password;

            if (usernameMatches && passwordMatches)
            {
                if (!this.Request.Session.ContainsKey(Session.SessionUserkey))
                {
                    this.Request.Session[Session.SessionUserkey] = "MyUserId";

                    var cookies = new CookieCollection();

                    cookies.Add(Session.SessionCookieName, this.Request.Session.Id);

                    return Html("<h3>Logged successfully!</h3>", cookies);
                }
                return Html("<h3>Logged successfully!</h3>");

            }
            return Redirect("/Login");

        }

        public Response Logout()
        {
            this.Request.Session.Clear();

            return Html("<h3>Logged out successfully!</h3>");
        }

        public Response GetUserData()
        {
            if (this.Request.Session.ContainsKey(Session.SessionUserkey))
            {
                return Html($"<h3>Currently logged-in user " + $"is with username '{UsersController.Username}'</h3>");
            }
            return Redirect("/Login");
        }
        
    }
}
