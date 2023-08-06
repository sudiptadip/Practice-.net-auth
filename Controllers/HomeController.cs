using Microsoft.AspNetCore.Mvc;
using auth.Data;
using Microsoft.EntityFrameworkCore;
using auth.Models;

namespace auth.Controllers
{
    public class HomeController : Controller
    {
        private readonly AplicationDbContext _db;

        public HomeController(AplicationDbContext db)
        {
            _db = db;
        }

        public  IActionResult Index()
        {
            List<MovieDetail> objMovieDetails = _db.MovieDetail.ToList();
            return View(objMovieDetails);
        }

        public IActionResult Create(int? id)
        {
            if (id != null)
            {
                MovieDetail movieDetail = _db.MovieDetail.Find(id);
                if (movieDetail == null)
                {
                    return NotFound();
                }
                return View(movieDetail);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Create(MovieDetail obj)
        {
            if (ModelState.IsValid)
            {
                MovieDetail movieDetail = _db.MovieDetail.Find(obj.Id);

                if (movieDetail == null)
                {
                    _db.MovieDetail.Add(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    _db.Entry(movieDetail).CurrentValues.SetValues(obj);
                    _db.Entry(movieDetail).State = EntityState.Modified;
                    _db.SaveChanges();
                    return RedirectToAction($"Index", "Home");
                }
            }
            return View();
        }

        public IActionResult ShowDetails(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            MovieDetail movieDetail = _db.MovieDetail.Find(id);
            if (movieDetail == null)
            {
                return NotFound();
            }
            return View(movieDetail);
        }

    }
}