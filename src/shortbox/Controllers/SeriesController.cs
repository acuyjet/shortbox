using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using shortbox.Models;

namespace shortbox.Controllers
{
    public class SeriesController : Controller
    {
        private ApplicationDbContext _context;

        public SeriesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Series
        public IActionResult Index()
        {
            return View(_context.Series.ToList());
        }

        // GET: Series/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Series series = _context.Series.Single(m => m.SeriesId == id);
            if (series == null)
            {
                return HttpNotFound();
            }

            return View(series);
        }

        // GET: Series/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Series/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Series series)
        {
            if (ModelState.IsValid)
            {
                _context.Series.Add(series);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(series);
        }

        // GET: Series/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Series series = _context.Series.Single(m => m.SeriesId == id);
            if (series == null)
            {
                return HttpNotFound();
            }
            return View(series);
        }

        // POST: Series/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Series series)
        {
            if (ModelState.IsValid)
            {
                _context.Update(series);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(series);
        }

        // GET: Series/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Series series = _context.Series.Single(m => m.SeriesId == id);
            if (series == null)
            {
                return HttpNotFound();
            }

            return View(series);
        }

        // POST: Series/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Series series = _context.Series.Single(m => m.SeriesId == id);
            _context.Series.Remove(series);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
