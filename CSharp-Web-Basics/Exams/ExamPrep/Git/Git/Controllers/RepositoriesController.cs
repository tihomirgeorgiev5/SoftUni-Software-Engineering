using Git.Data;
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
            var repositoriesQuery = this.data.Repositories.AsQueryable();

            
                repositoriesQuery = repositoriesQuery
                    .Where(r => r.IsPublic);
           
            return View();
        }
    }
}
