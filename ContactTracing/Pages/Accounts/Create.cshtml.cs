using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContactTracing.Data;
using ContactTracing.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactTracing.Pages.Accounts
{
    public class CreateModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public CreateModel(ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

        //new shit

        public IList<Account> Accounts1 { get; set; }

        public async Task OnGetAsync()
        {
            Accounts1 = await _context.Accounts.ToListAsync();
        }

        // ----

       /* public IActionResult OnGet()    // so apparently you can't have two OnGets because then it bugs out
        *                                   //bc it's trying to redirect to two different places at once -zk
        {
            return Page();
        }*/

        [BindProperty]
        public Account Account { get; set; }

       

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Accounts.Add(Account);
            Account.Email = User.Identity.Name;     //This changes email to be their microsoft email by default
            await _context.SaveChangesAsync();      //it actually updates the value here, in the cshtml it's just for show -zk

            return RedirectToPage("./Index"); 
        }
    }
}
