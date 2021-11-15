using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactTracing.Data;
using ContactTracing.Models;

namespace ContactTracing.Pages.SeatingAssignments
{
    public class DetailsModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public DetailsModel(ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
