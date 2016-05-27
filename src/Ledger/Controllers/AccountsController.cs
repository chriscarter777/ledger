using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Ledger.Models;

namespace Ledger.Controllers
{
    public class AccountsController : Controller
    {
        private LedgerDbContext _context;

        public AccountsController(LedgerDbContext context)
        {
            _context = context;    
        }

        // GET: Account
        public IActionResult Index()
        {
            return View(_context.User.ToList());
        }

        // GET: Account/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            User user = _context.User.Single(m => m.ID == id);
            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        // GET: Account/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.User.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Account/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            User user = _context.User.Single(m => m.ID == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Account/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Update(account);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(account);
        }

        // GET: Account/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            User user = _context.User.Single(m => m.ID == id);
            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        // POST: Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            User user = _context.User.Single(m => m.ID == id);
            _context.User.Remove(user);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
