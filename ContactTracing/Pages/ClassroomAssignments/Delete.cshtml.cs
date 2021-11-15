using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactTracing.Data;
using ContactTracing.Models;

namespace ContactTracing.Pages.ClassroomAssignments
{
    public class DeleteModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public DeleteModel(ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ClassroomAssignment = await _context.ClassroomAssignments.FindAsync(id);

            if (ClassroomAssignment != null)
            {
                _context.ClassroomAssignments.Remove(ClassroomAssignment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
