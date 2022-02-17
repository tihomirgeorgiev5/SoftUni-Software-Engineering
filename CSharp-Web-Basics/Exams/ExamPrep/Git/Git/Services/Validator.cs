using Git.Models.Users;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static Git.Data.DataConstants;

namespace Git.Services
{
    public class Validator : IValidator
    {
        public ICollection<string> ValidateUser(RegisterUserFormModel model)
        {
            var errors = new List<string>();

            if (model.Username.Length < UserMinUsername || model.Username.Length > UserMaxDefaultLength)
            {
                errors.Add($"Username must be between {UserMinUsername} and {UserMaxDefaultLength} characters long: {model.Username}.");
            }

            if (!Regex.IsMatch(model.Email, UserEmailRegEx))
            {
                errors.Add($"Email {model.Email} is not a valid e-mail address.");
            }

            if (model.Password.Length < UserMinPassword || model.Password.Length > UserMaxDefaultLength)
            {
                errors.Add($"Password '{model.Password}'is not valid.It must be between {UserMinPassword} and {UserMaxDefaultLength} characters long.");
            }

            if (model.Password.Any(x => x == ' '))
            {
                errors.Add($"The provided password cannot contain whitespaces.");
            }

            if (model.Password != model.ConfirmPassword)
            {
                errors.Add($"Password and its confirmation are different.");
            }

            return errors;
        }
    }
}
