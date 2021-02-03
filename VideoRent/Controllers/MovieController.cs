using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRent.Models;
using System.Data.Entity;
namespace VideoRent.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;

        public MovieController()
        {

            _context = new ApplicationDbContext();
         }
        protected override void Dispose(bool disposing)
        {
           _context.Dispose();
        }

        // GET: Movie
        public ActionResult Index()
        {
            var movie = _context.Movies.Include(c => c.Genre).ToList();
            
            
            return View(movie);
        }
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m =>m.Genre).SingleOrDefault(c => c.id == id);

            if(movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
    }
}