using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactTracing.Data;
using ContactTracing.Models;

namespace ContactTracing.Pages.Classrooms
{
    public class DetailsModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public DetailsModel(ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

        public Classroom Classroom { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Classroom = await _context.Classrooms.FirstOrDefaultAsync(m => m.ID == id);

            if (Classroom == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
