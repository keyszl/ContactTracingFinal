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
    public class IndexModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public IndexModel(ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

        public IList<Dose> Dose { get;set; }

        public async Task OnGetAsync()
        {
            Dose = await _context.Dose
                .Include(d => d.Account)
                .Include(d => d.VaccineType).ToListAsync();
        }
    }
}
