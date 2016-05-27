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
            return View(_context.Account.ToList());
        }

        // GET: Account/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Account account = _context.Account.Single(m => m.ID == id);
            if (account == null)
            {
                return HttpNotFound();
            }

            return View(account);
        }

        // GET: Account/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Account.Add(account);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(account);
        }

        // GET: Account/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Account account = _context.Account.Single(m => m.ID == id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
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

            Account account = _context.Account.Single(m => m.ID == id);
            if (account == null)
            {
                return HttpNotFound();
            }

            return View(account);
        }

        // POST: Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Account account = _context.Account.Single(m => m.ID == id);
            _context.Account.Remove(account);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
