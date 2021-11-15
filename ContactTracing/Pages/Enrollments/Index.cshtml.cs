using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactTracing.Data;
using ContactTracing.Models;

namespace ContactTracing.Pages.Enrollments
{
    public class IndexModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public IndexModel(ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

        public IList<Enrollment> Enrollment { get;set; }

        public async Task OnGetAsync()
        {
            Enrollment = await _context.Enrollments
                .Include(e => e.Account)
                .Include(e => e.Course).ToListAsync();
        }
    }
}
