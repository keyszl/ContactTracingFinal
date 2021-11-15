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
    public class IndexModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public IndexModel(ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

        public IList<Seating> Seating { get;set; }

        public async Task OnGetAsync()
        {
            Seating = await _context.SeatingAssignments
                .Include(s => s.Account)
                .Include(s => s.Course)
                .Include(s => s.Seat).ToListAsync();
        }
    }
}
