using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContactTracing.Data;
using ContactTracing.Models;

namespace ContactTracing.Pages.SeatingAssignments
{
    public class EditModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public EditModel(ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Seating Seating { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seating = await _context.SeatingAssignments
                .Include(s => s.Account)
                .Include(s => s.Course)
                .Include(s => s.Seat).FirstOrDefaultAsync(m => m.ID == id);

            if (Seating == null)
            {
                return NotFound();
            }
           ViewData["AccountID"] = new SelectList(_context.Accounts, "ID", "ID");
           ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "ID");
           ViewData["SeatID"] = new SelectList(_context.Set<Seat>(), "ID", "ID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Seating).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeatingExists(Seating.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SeatingExists(int id)
        {
            return _context.SeatingAssignments.Any(e => e.ID == id);
        }
    }
}
