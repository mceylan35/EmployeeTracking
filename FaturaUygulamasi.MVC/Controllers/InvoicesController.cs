using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Concrete.EntityFramework.Contexts; 
using BusinessLogicLayer.Abstract;
using Entities.Models;

namespace FaturaUygulamasi.MVC.Controllers
{
    public class InvoicesController : Controller
    { 
        private readonly IInvoiceService _invoicesService;

        public InvoicesController(IInvoiceService invoicesService)
        {
            _invoicesService = invoicesService;
        }

        // GET: Invoices
        public async Task<IActionResult> Index()
        {
            //var efDatabaseContext = _invoicesService.Invoices.Include(i => i.Customer);
            return View(_invoicesService.GetList());
        }

        // GET: Invoices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var invoices = await _invoicesService.Invoices
            //    .Include(i => i.Customer)
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (invoices == null)
            //{
            //    return NotFound();
            //}

            return View();
        }

        // GET: Invoices/Create
        public IActionResult Create()
        {
            //ViewData["CustomerId"] = new SelectList(_invoicesService.Customers, "Id", "Id");
            return View();
        }

        // POST: Invoices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerId,CreatedOn,ExpiredOn,Total,Discount")] Invoices invoices)
        {
            if (ModelState.IsValid)
            {
                _invoicesService.Add(invoices); 
                return RedirectToAction(nameof(Index));
            }
           // ViewData["CustomerId"] = new SelectList(_invoicesService.Customers, "Id", "Id", invoices.CustomerId);
            return View(invoices);
        }

        // GET: Invoices/Edit/5
        public IActionResult  Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var invoices =    _invoicesService.GetById(id);
            if (invoices == null)
            {
                return NotFound();
            }
            //ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", invoices.CustomerId);
            return View(invoices);
        }

        // POST: Invoices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CustomerId,CreatedOn,ExpiredOn,Total,Discount")] Invoices invoices)
        {
            if (id != invoices.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _invoicesService.Update(invoices); 
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoicesExists(invoices.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
           // ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id", invoices.CustomerId);
            return View(invoices);
        }

        // GET: Invoices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var invoices = await _context.Invoices
            //    .Include(i => i.Customer)
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if ( == null)
            //{
            //    return NotFound();
            //}

            return View();
        }

        // POST: Invoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invoices = _invoicesService.GetById(id);
            _invoicesService.Delete(invoices.Data); 
            return RedirectToAction(nameof(Index));
        }

        private bool InvoicesExists(int id)
        {
            return _invoicesService.GetList().Data.Any(e => e.Id == id);
        }
    }
}
