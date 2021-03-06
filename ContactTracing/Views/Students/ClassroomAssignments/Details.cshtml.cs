using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactTracing.Data;
using ContactTracing.Models;

namespace ContactTracing.Views.Students.ClassroomAssignments
{
    public class DetailsModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public DetailsModel(ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

        public ClassroomAssignment ClassroomAssignment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ClassroomAssignment = await _context.ClassroomAssignments
                .Include(c => c.Classroom)
                .Include(c => c.Course).FirstOrDefaultAsync(m => m.ID == id);

            if (ClassroomAssignment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
