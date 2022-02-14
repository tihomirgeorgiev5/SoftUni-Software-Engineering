﻿using CarShop.Data;
using CarShop.Models.Issues;
using CarShop.Services;
using MyWebServer.Controllers;
using MyWebServer.Http;
using System.Linq;

namespace CarShop.Controllers
{
    public class IssuesController : Controller
    {
        private readonly IUserService userService;
        private readonly IValidator validator;
        private readonly CarShopDbContext data;

        public IssuesController(IUserService userService,
            IValidator validator,
            CarShopDbContext data)
        {
            this.userService = userService;
            this.validator = validator;
            this.data = data;
        }

        [Authorize]
        public HttpResponse CarIssues(string carId)
        {
            if (!this.userService.IsMechanic(this.User.Id))
            {
                var userOwnsCar = this.data.Cars
                    .Any(c => c.Id == carId && c.OwnerId == this.User.Id);

                if (!userOwnsCar)
                {
                    return Error("You do not have access to this car.");
                }
            }

            var carIssues = this.data
                .Cars
                .Where(c => c.Id == carId)
                .Select(c => new CarIssuesViewModel
                {
                    Id = c.Id,
                    Model = c.Model,
                    Year = c.Year,
                    //UserIsMechanic = this.userService.IsMechanic(this.User.Id),
                    Issues = c.Issues.Select(i => new IssueListingViewModel
                    {
                        Id = i.Id,
                        Description = i.Description,
                        IsFixed = i.IsFixed
                    })
                })
                .FirstOrDefault();
            if (carIssues == null)
            {
                return Error($"Car with ID '{carId}' does not exist.");
            }

            return View(carIssues);

        }
    }
}
