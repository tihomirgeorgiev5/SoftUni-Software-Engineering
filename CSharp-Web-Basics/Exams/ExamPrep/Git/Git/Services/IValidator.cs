using Git.Models.Users;
using System.Collections.Generic;

namespace Git.Services
{
    public interface IValidator
    {
        ICollection<string> ValidateUser(RegisterUserFormModel model);
    }
}
