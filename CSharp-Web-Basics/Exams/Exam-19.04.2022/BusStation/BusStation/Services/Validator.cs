using BusStation.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusStation.Services
{
    public class Validator : IValidator
    {
        public ICollection<string> ValidateUserRegistration(RegisterUserFormModel model)
        {
            var errors = new List<string>();

            if (model.Username.Length < 5 || model.Username.Length > 20)
            {
                errors.Add($"Username '{model.Username}' is not valid. It must between 5 and 20 characters");
            }

            if (!Regex.IsMatch(model.Email, @"^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$"))
            {
                errors.Add($"Email {model.Email} is not a valid e-mail address.");
            }

            if (model.Password.Length < 5 || model.Password.Length > 20)
            {
                errors.Add($"The provided password is not valid. It must between 5 and 20 characters.");
            }

            if (model.Password == model.RepeatPassword)
            {
                errors.Add($"Password and its confirmation do not match.");
            }

            return errors;
        }
    }
}
