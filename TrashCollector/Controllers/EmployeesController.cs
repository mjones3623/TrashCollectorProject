﻿using System;
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
    public class EmployeesController : Controller
    {


        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Employees
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Employees.Include(e => e.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,FirstName,LastName,StreetAddress,City,State,ZipCoded,ServiceZip,IdentityUserId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                
                var employeeInDB = _context.Employees.Single(m => m.EmployeeId == employee.EmployeeId);
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employeeInDB.IdentityUserId = userId;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(EmployeeDefaultView));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var customer = _context.Customers.Where(i => i.CustomerId == id).FirstOrDefault();

            if (customer == null)
            {
                return NotFound();
            }


            return View(customer);

        }
            
        

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Customer customer )
        {
            var customerInDB = _context.Customers.Where(m => m.CustomerId == customer.CustomerId).FirstOrDefault();
            customerInDB.LastPickup = customer.LastPickup;
            customerInDB.Balance = customerInDB.Balance + customerInDB.PriceForPickup;
            
            _context.SaveChanges();
            return RedirectToAction("EmployeeDefaultView", "Employees");

            //if (id != employee.EmployeeId)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(employee);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!EmployeeExists(employee.EmployeeId))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            //return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }

        //Employee Default View
        public async Task<IActionResult> EmployeeDefaultView()
        {
            DateTime dt = DateTime.Today;
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var employee = _context.Employees.Where(i => i.IdentityUserId == userId).FirstOrDefault();

            var applicationDbContext = _context.Customers
                .Where(e => (dt < e.TempSuspendStart || dt > e.TempSuspendEnd) && 
                (e.PickupDay == dt.DayOfWeek) && (e.ZipCoded == employee.ServiceZip) ||
                (e.OneTimePickUpDate == dt && e.ZipCoded == employee.ServiceZip));

            
            return View(await applicationDbContext.ToListAsync());
        }
        //Employee FilterByDay
        public async Task<IActionResult> FilterByDay(DayOfWeek dayOfWeek)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employees.Where(i => i.IdentityUserId == userId).FirstOrDefault();
                                    
            DateTime dt = DateTime.Today;
            DayOfWeek dw = dayOfWeek;

            int num = (int)DateTime.Today.DayOfWeek;
            int num2 = (int)dw;

            DateTime qd = DateTime.Today.AddDays(num2 - num);
                                    
            var applicationDbContext = _context.Customers
                .Where(e => (qd < e.TempSuspendStart || qd > e.TempSuspendEnd) &&
                (e.PickupDay == dw) && (e.ZipCoded == employee.ServiceZip) ||
                (e.OneTimePickUpDate == qd && e.ZipCoded == employee.ServiceZip));


            return View(await applicationDbContext.ToListAsync());
        }
        


    }
}
