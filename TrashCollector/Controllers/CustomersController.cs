using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Customers.Include(c => c.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,FirstName,LastName,StreetAddress,City,State,ZipCoded,PhoneNumber,PickupDay,OneTimePickUpDate,Balance,TempSuspendStart,TempSuspendEnd,PriceForPickup,IdentityUserId")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                var customerInDB = _context.Customers.Single(m => m.CustomerId == customer.CustomerId);
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customerInDB.PriceForPickup = 15;
                customerInDB.IdentityUserId = userId;
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(CustomerHome));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int userId)
        {
            var customer = _context.Customers.Where(i => i.CustomerId == userId).FirstOrDefault();

            if (customer == null)
            {
                return NotFound();
            }


            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Customer customer)
        {
            var customerInDB = _context.Customers.Where(m => m.IdentityUserId == customer.IdentityUserId).FirstOrDefault();
            customerInDB.LastPickup = customer.LastPickup;
            customerInDB.Balance = customerInDB.Balance + customerInDB.PriceForPickup;

            _context.SaveChanges();
            return RedirectToAction("EmployeeDefaultView", "Employees");
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }

        // GET: CustomerHome
        public IActionResult CustomerHome()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(m => m.IdentityUserId == userId).FirstOrDefault();
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: CustomerHome
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CustomerHome(Customer customer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customerInDb = _context.Customers.Where(m => m.IdentityUserId == userId).FirstOrDefault();
            customerInDb.PickupDay = customer.PickupDay;
            customerInDb.OneTimePickUpDate = customer.OneTimePickUpDate;
            customerInDb.TempSuspendStart = customer.TempSuspendStart;
            customerInDb.TempSuspendEnd = customer.TempSuspendEnd;
            _context.SaveChanges();
            return RedirectToAction("CustomerHome", "Customers");
        }


    }
}
