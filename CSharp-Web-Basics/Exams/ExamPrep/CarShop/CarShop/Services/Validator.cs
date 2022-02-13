using CarShop.Data.Models;
using CarShop.Models.Cars;
using CarShop.Models.Users;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static CarShop.Data.DataConstants;

namespace CarShop.Services
{
    public class Validator : IValidator
    {
        public ICollection<string> ValidateCar(AddCarFormModel model)
        {
            var errors = new List<string>();
            if (model.Model.Length < CarModelMinLength || model.Model.Length > DefaultMaxLength)
            {
                errors.Add($"Model '{model.Model}' is not valid. It must be between {CarModelMinLength} and {DefaultMaxLength} characters long: {model.Model}");
            }

            if (model.Year < CarYearMinValue || model.Year > CarYearMaxValue)
            {
                errors.Add($"Year '{model.Year}' is not valid. It must be between {CarYearMinValue} and {CarYearMaxValue} characters long: {model.Year}");
            }

           

            if (Regex.IsMatch(model.PlateNumber, CarPlateNumberRegEx))
            {
                errors.Add($"Plate number {model.PlateNumber} is not a valid Plate.It should be in format 'AA0000AA'.");
            }


            return errors;
        }

        public ICollection<string> ValidateUser(RegisterUserFormModel model)
        {
            var errors = new List<string>();
            if (model.Username.Length < UserMinUsername || model.Username.Length > DefaultMaxLength)
            {
                errors.Add($"Username must be between {UserMinUsername} and {DefaultMaxLength} characters long: {model.Username}");
            }

            if (!Regex.IsMatch(model.Email, UserEmailRegEx))
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
