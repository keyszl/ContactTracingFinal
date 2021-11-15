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

namespace ContactTracing.Pages.ClassroomAssignments
{
    public class EditModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public EditModel(ContactTracing.Data.ContactTracingContext context)
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

            ClassroomAssignment = await _context.ClassroomAssignment
                .Include(c => c.Classroom)
                .Include(c => c.Course).FirstOrDefaultAsync(m => m.ID == id);

            if (ClassroomAssignment == null)
            {
                return NotFound();
            }
           ViewData["ClassroomID"] = new SelectList(_context.Classroom, "ID", "ID");
           ViewData["CourseID"] = new SelectList(_context.Course, "ID", "ID");
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

            _context.Attach(ClassroomAssignment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassroomAssignmentExists(ClassroomAssignment.ID))
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

        private bool ClassroomAssignmentExists(int id)
        {
            return _context.ClassroomAssignment.Any(e => e.ID == id);
        }
    }
}
