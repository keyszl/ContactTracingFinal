using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContactTracing.Data;
using ContactTracing.Models;

namespace ContactTracing.Pages.Enrollments
{
    public class CreateModel : CoursesNamePageModel 
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public CreateModel (ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            PopulateCoursesDropDownList(_context);
            PopulateAccountsDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public Enrollment Enrollment { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyEnrollment = new Enrollment();

            if (await TryUpdateModelAsync<Enrollment>(
                 emptyEnrollment,
                 "enrollment",   // Prefix for form value.
                 s => s.ID, s => s.Professor, s => s.AccountID, s => s.CourseID))
            {
                _context.Enrollments.Add(emptyEnrollment);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            // Select DepartmentID if TryUpdateModelAsync fails.
            PopulateCoursesDropDownList(_context, emptyEnrollment.CourseID);
            PopulateAccountsDropDownList(_context, emptyEnrollment.AccountID);
            return Page();
        }
    }
}
