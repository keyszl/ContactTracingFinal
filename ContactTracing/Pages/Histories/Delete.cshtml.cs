using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactTracing.Data;
using ContactTracing.Models;

namespace ContactTracing.Pages.Histories
{
    public class DeleteModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public DeleteModel(ContactTracing.Data.ContactTracingContext context)
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

            History = await _context.Histories
                .Include(h => h.Account).FirstOrDefaultAsync(m => m.ID == id);

            if (History == null)
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

            History = await _context.Histories.FindAsync(id);

            if (History != null)
            {
                _context.Histories.Remove(History);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
