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
            return View(_context.Issue.ToList());
        }

        // GET: Issues/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Issue issue = _context.Issue.Single(m => m.Id == id);
            if (issue == null)
            {
                return HttpNotFound();
            }

            return View(issue);
        }

        // GET: Issues/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Issues/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, SeriesName, IssueNumber, StoryArc, Writer, Penciller, Inker, Colorist, Letterer")]Issue issue)
        {
            if (ModelState.IsValid)
            {
                _context.Issue.Add(issue);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(issue);
        }

        // GET: Issues/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Issue issue = _context.Issue.Single(m => m.Id == id);
            if (issue == null)
            {
                return HttpNotFound();
            }
            return View(issue);
        }

        // POST: Issues/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id, SeriesName, IssueNumber, StoryArc, Writer, Penciller, Inker, Colorist, Letterer")] Issue issue)
        {
            if (ModelState.IsValid)
            {
                _context.Update(issue);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(issue);
        }

        // GET: Issues/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Issue issue = _context.Issue.Single(m => m.Id == id);
            if (issue == null)
            {
                return HttpNotFound();
            }

            return View(issue);
        }

        // POST: Issues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed([Bind("Id, SeriesName, IssueNumber, StoryArc, Writer, Penciller, Inker, Colorist, Letterer")]int id)
        {
            Issue issue = _context.Issue.Single(m => m.Id == id);
            _context.Issue.Remove(issue);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
