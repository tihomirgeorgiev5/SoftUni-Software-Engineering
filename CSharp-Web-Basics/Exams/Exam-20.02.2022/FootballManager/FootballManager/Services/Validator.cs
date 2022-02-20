using FootballManager.ViewModels.Users;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static FootballManager.Data.DataConstants;

namespace FootballManager.Services
{
    public class Validator : IValidator
    {
        public ICollection<string> ValidateUser(RegisterUserFormModel model)
        {
            var errors = new List<string>();
            if (model.Username.Length < UserMinUsername || model.Username.Length > UserMaxUsername)
            {
                errors.Add($"Username must be between {UserMinUsername} and {UserMaxUsername} characters long: {model.Username}");
            }

            if (!Regex.IsMatch(model.Email, UserEmailRegEx))
            {
                errors.Add($"Email {model.Email} is not a valid e-mail address");
            }

            if (model.Password.Length <UserMaxPassword)
            {
                errors.Add($"Password '{model.Password}'is not valid.It must be between {UserMinPassword} and {UserMaxPassword} characters long.");
            }
            if (model.Password.Any(x => x == ' '))
            {
                errors.Add($"The provided password cannot be only whitespaces!");
            }
            if (model.Password != model.ConfirmPassword)
            {
                errors.Add($"Password and its confirmation are different.");
            }
            return errors;

        }
    }
}
