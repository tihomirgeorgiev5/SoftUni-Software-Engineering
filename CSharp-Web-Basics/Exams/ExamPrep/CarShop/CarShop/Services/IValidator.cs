using CarShop.Models.Users;
using System.Collections.Generic;
namespace CarShop.Services
{
    public interface IValidator
    {
        IEnumerable<string> ValidateUserRegistration(RegisterUserFormModel model);
        

    }
}
