using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealEstate.Areas.Identity.Data;
using RealEstate.Models;

namespace RealEstate.Controllers
{
    public class ListingsController : Controller
    {
        private readonly RealEstateContext _context;

        public ListingsController(RealEstateContext context)
        {
            _context = context;
        }

        // GET: Listings
        public async Task<IActionResult> Index()
        {
            var realEstateContext = _context.Listing.Include(l => l.Agent).Include(l => l.Seller);
            return View(await realEstateContext.ToListAsync());
        }

        // GET: Listings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Listing == null)
            {
                return NotFound();
            }

            var listing = await _context.Listing
                .Include(l => l.Agent)
                .Include(l => l.Seller)
                .FirstOrDefaultAsync(m => m.ListingID == id);
            if (listing == null)
            {
                return NotFound();
            }

            return View(listing);
        }

        // GET: Listings/Create
        public IActionResult Create()
        {
            ViewData["AgentID"] = new SelectList(_context.Agent, "AgentID", "AgentID");
            ViewData["SellerID"] = new SelectList(_context.Set<Seller>(), "SellerID", "SellerID");
            return View();
        }

        // POST: Listings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ListingID,ListingAddress,SellerID,AgentID")] Listing listing)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(listing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgentID"] = new SelectList(_context.Agent, "AgentID", "AgentID", listing.AgentID);
            ViewData["SellerID"] = new SelectList(_context.Set<Seller>(), "SellerID", "SellerID", listing.SellerID);
            return View(listing);
        }

        // GET: Listings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Listing == null)
            {
                return NotFound();
            }

            var listing = await _context.Listing.FindAsync(id);
            if (listing == null)
            {
                return NotFound();
            }
            ViewData["AgentID"] = new SelectList(_context.Agent, "AgentID", "AgentID", listing.AgentID);
            ViewData["SellerID"] = new SelectList(_context.Set<Seller>(), "SellerID", "SellerID", listing.SellerID);
            return View(listing);
        }

        // POST: Listings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ListingID,ListingAddress,SellerID,AgentID")] Listing listing)
        {
            if (id != listing.ListingID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(listing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListingExists(listing.ListingID))
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
            ViewData["AgentID"] = new SelectList(_context.Agent, "AgentID", "AgentID", listing.AgentID);
            ViewData["SellerID"] = new SelectList(_context.Set<Seller>(), "SellerID", "SellerID", listing.SellerID);
            return View(listing);
        }

        // GET: Listings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Listing == null)
            {
                return NotFound();
            }

            var listing = await _context.Listing
                .Include(l => l.Agent)
                .Include(l => l.Seller)
                .FirstOrDefaultAsync(m => m.ListingID == id);
            if (listing == null)
            {
                return NotFound();
            }

            return View(listing);
        }

        // POST: Listings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Listing == null)
            {
                return Problem("Entity set 'RealEstateContext.Listing'  is null.");
            }
            var listing = await _context.Listing.FindAsync(id);
            if (listing != null)
            {
                _context.Listing.Remove(listing);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListingExists(int id)
        {
          return (_context.Listing?.Any(e => e.ListingID == id)).GetValueOrDefault();
        }
    }
}
