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

namespace ContactTracing.Pages.Histories
{
    public class EditModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public EditModel(ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public History History { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            History = await _context.History
                .Include(h => h.Account).FirstOrDefaultAsync(m => m.ID == id);

            if (History == null)
            {
                return NotFound();
            }
           ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID");
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

            _context.Attach(History).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistoryExists(History.ID))
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

        private bool HistoryExists(int id)
        {
            return _context.History.Any(e => e.ID == id);
        }
    }
}
