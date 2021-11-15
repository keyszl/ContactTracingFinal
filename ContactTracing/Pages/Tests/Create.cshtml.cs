using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContactTracing.Data;
using ContactTracing.Models;

namespace ContactTracing.Pages.Tests
{
    public class CreateModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public CreateModel(ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AccountID"] = new SelectList(_context.Accounts, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Test Test { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tests.Add(Test);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
