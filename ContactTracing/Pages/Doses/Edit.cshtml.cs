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

namespace ContactTracing.Pages.Doses
{
    public class EditModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public EditModel(ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Dose Dose { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dose = await _context.Doses
                .Include(d => d.Account)
                .Include(d => d.VaccineType).FirstOrDefaultAsync(m => m.ID == id);

            if (Dose == null)
            {
                return NotFound();
            }
           ViewData["AccountID"] = new SelectList(_context.Accounts, "ID", "ID");
           ViewData["VaccineTypeID"] = new SelectList(_context.Set<VaccineType>(), "ID", "ID");
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

            _context.Attach(Dose).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoseExists(Dose.ID))
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

        private bool DoseExists(int id)
        {
            return _context.Doses.Any(e => e.ID == id);
        }
    }
}
