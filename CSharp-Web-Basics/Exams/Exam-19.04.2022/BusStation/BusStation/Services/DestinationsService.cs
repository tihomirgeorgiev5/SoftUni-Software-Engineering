using BusStation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.Services
{
   public class DestinationsService : BaseService<Destination>, IDestinationsService
    {
        private readonly IUserService UserService;
    }
}
