﻿using CarShop.Models.Users;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static CarShop.Data.DataConstants;

namespace CarShop.Services
{
    public class Validator : IValidator
    {
        public ICollection<string> ValidateUserRegistration(RegisterUserFormModel model)
        {
            var errors = new List<string>();
            if (model.Username.Length < UserMinUsername || model.Username.Length > DefaultMaxLength)
            {
                errors.Add($"Username must be between {UserMinUsername} and {DefaultMaxLength} characters long: {model.Username}");
            }

            if (!Regex.IsMatch(model.Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                errors.Add($"Email {model.Email} is not a valid e-mail address");
            }

            if (model.Password.Length < UserMinPassword || model.Password.Length > DefaultMaxLength)
            {
                errors.Add($"Password '{model.Password}'is not valid.It must be between {UserMinPassword} and {DefaultMaxLength} characters long.");
            }

            if (model.UserType != UserTypeMechanic && model.UserType != UserTypeClient)
            {
                errors.Add($"User should be either a '{UserTypeMechanic}' and '{UserTypeClient}'");
            }

            return errors;

              






        }
    }
}
