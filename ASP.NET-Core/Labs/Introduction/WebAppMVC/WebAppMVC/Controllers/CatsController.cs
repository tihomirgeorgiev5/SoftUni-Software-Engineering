using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class CatsController : Controller
    {
        public IActionResult Create() => View();
        
        [HttpPost]
        public IActionResult Create(CatFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return Ok();
        } 
        
            

            
        
    }
}
