﻿using FootballManager.ViewModels.Users;
using System.Collections.Generic;

namespace FootballManager.Services
{
    public interface IValidator
    {
        ICollection<string> ValidateUser(RegisterUserFormModel model);
    }
}
