using Git.Data;
using Git.Models.Repositories;
using MyWebServer.Controllers;
using MyWebServer.Http;
using System.Linq;

namespace Git.Controllers
{
    public class RepositoriesController : Controller
    {
        private readonly GitDbContext data;

        public RepositoriesController(GitDbContext data)
        {
            this.data = data;
        }

        public HttpResponse All()
        {
            var repositories = this.data
                .Repositories
                .Where(r => r.IsPublic)
                .Select(r => new RepositoryListingViewModel {
                    Id = r.Id,
                    Name = r.Name,
                    Owner = r.Owner.Username,
                    CreatedOn = r.CreatedOn.ToLongTimeString(),
                    Commits = r.Commits.Count()      
                }).ToList();

            return View(repositories);
        }
    }
}
