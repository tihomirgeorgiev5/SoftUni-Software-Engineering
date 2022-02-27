using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class CatsController : Controller
    {
        public IActionResult All()
        {
            var cats = new List<CatViewModel>
            {
                new CatViewModel {Name="Pesho", Age = 6 },
                new CatViewModel {Name="Sara", Age= 10 }
            };

            return View(cats);
        }
    }
}
