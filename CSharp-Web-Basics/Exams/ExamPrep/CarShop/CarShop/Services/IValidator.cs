using CarShop.Models.Users;
using System.Text.RegularExpressions;
using static CarShop.Data.DataConstants;
namespace CarShop.Services
{
    public interface IValidator
    {
        bool ValidateUserRegistration(RegisterUserFormModel model)
        

    }
}
