using Bandbook.Models;
using Bandbook.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace Bandbook.Controllers
{
    public class GigController : Controller
    {
        private readonly ApplicationDbContext context;
        public GigController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Gig
        public ActionResult Create()
        {
            var viewModel = new BandFormViewModel
            {
                Genres = context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}