using CarShop.ViewModels.Users;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CarShop.Services
{
    public class Validator : IValidator
    {
        public ICollection<string> ValidateUserRegistration(RegisterUserFormModel model)
        {
            var errors = new List<string>();

            if (model.Username.Length < 4 || model.Username.Length > 20 )
            {
                errors.Add($"Username '{model.Username}' is not valid. It must between 4 and 20 characters");
            }

            if (!Regex.IsMatch(model.Email, @"^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$"))
            {
                errors.Add($"Email {model.Email} is not a valid e-mail address.");
            }

            if (model.Password.Length < 5 || model.Password.Length > 20)
            {
                errors.Add($"The provided password is not valid. It must between 5 and 20 characters.");
            }

            if (model.Password != model.ConfirmPassword)
            {
                errors.Add($"Password and its confirmation do not match.");
            }

            if (model.UserType != "Client" && model.UserType != "Mechanic")
            {
                errors.Add($"User should be either a 'Mechanic' or 'Client'.");
            }
            return errors;
        }
    }
}
