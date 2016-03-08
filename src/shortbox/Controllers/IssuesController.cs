using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using shortbox.Models;

namespace shortbox.Controllers
{
    public class IssuesController : Controller
    {
        private ApplicationDbContext _context;

        public IssuesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Issues
        public IActionResult Index()
        {
            return View(_context.Issues.ToList());
        }

        // GET: Issues/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Issues issues = _context.Issues.Single(m => m.IssueId == id);
            if (issues == null)
            {
                return HttpNotFound();
            }

            return View(issues);
        }

        // GET: Issues/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Issues/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Issues issues)
        {
            if (ModelState.IsValid)
            {
                _context.Issues.Add(issues);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(issues);
        }

        // GET: Issues/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Issues issues = _context.Issues.Single(m => m.IssueId == id);
            if (issues == null)
            {
                return HttpNotFound();
            }
            return View(issues);
        }

        // POST: Issues/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Issues issues)
        {
            if (ModelState.IsValid)
            {
                _context.Update(issues);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(issues);
        }

        // GET: Issues/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Issues issues = _context.Issues.Single(m => m.IssueId == id);
            if (issues == null)
            {
                return HttpNotFound();
            }

            return View(issues);
        }

        // POST: Issues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Issues issues = _context.Issues.Single(m => m.IssueId == id);
            _context.Issues.Remove(issues);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
