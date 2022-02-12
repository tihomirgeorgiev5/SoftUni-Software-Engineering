using CarShop.Models.Users;
using CarShop.Data.

namespace CarShop.Services
{
    public class Validator : IValidator
    {
        public bool ValidateUserRegistration(RegisterUserFormModel model)
        {
            if (model.Username.Length < UserMinUsername || model.Username.Length > DefaultMaxLength)
            {
                return false;
            }

            if (Regex.IsMatch(model.Email))
            {

            }


        }
    }
}
