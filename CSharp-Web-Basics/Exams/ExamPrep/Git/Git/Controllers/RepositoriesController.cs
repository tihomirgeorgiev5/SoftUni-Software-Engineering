using Git.Data;
using Git.Data.Models;
using Git.Models.Repositories;
using Git.Services;
using MyWebServer.Controllers;
using MyWebServer.Http;
using System.Linq;
using static Git.Data.DataConstants;

namespace Git.Controllers
{
    public class RepositoriesController : Controller
    {
        private readonly GitDbContext data;
        private readonly IValidator validator;

        public RepositoriesController(GitDbContext data, IValidator validator)
        {
            this.validator = validator;   
            this.data = data;
        }

        

        public HttpResponse All()
        {
            var user = this.data.Users
                .Where(u => u.Id == this.User.Id)
                .Select(u => u.Id)
                .FirstOrDefault();

            var repositories = this.data
                .Repositories
                .Where(r => r.IsPublic || r.Owner.Id == user )
                .Select(r => new RepositoryListingViewModel {
                    Id = r.Id,
                    Name = r.Name,
                    Owner = r.Owner.Username,
                    CreatedOn = r.CreatedOn.ToLongTimeString(),
                    Commits = r.Commits.Count()      
                }).ToList();

            return View(repositories);
        }

        public HttpResponse Create()
            => this.View();

        [HttpPost]
        [Authorize]
        public HttpResponse Create(CreateRepositoryFormModel model)
        {
            var modelErrors = this.validator.ValidateRepository(model);

            if (modelErrors.Any())
            {
                return Error(modelErrors);
            }

            var repository = new Repository
            {
                Name = model.Name,
                IsPublic = model.RepositoryType == RepositoryPublicType,
                OwnerId = this.User.Id
            };

            this.data.Repositories.Add(repository);

            this.data.SaveChanges();

            return Redirect("/Repositories/All");

        }
    }
}
