using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactTracing.Data;
using ContactTracing.Models;

namespace ContactTracing.Pages.Doses
{
    public class DeleteModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public DeleteModel(ContactTracing.Data.ContactTracingContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dose = await _context.Doses.FindAsync(id);

            if (Dose != null)
            {
                _context.Doses.Remove(Dose);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
