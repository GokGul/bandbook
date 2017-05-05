using Bandbook.Models;
using Bandbook.ViewModels;
using Microsoft.AspNet.Identity;
using System;
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

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new BandFormViewModel
            {
                Genres = context.Genres.ToList()
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(BandFormViewModel b)
        {
            var gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = b.DateTime,
                GenreId = b.Genre,
                Place = b.Place
            };

            context.Gigs.Add(gig);
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}