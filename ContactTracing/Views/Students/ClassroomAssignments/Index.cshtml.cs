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
    public class IndexModel : PageModel
    {
        private readonly ContactTracing.Data.ContactTracingContext _context;

        public IndexModel(ContactTracing.Data.ContactTracingContext context)
        {
            _context = context;
        }

        public IList<ClassroomAssignment> ClassroomAssignment { get;set; }

        public async Task OnGetAsync()
        {
            ClassroomAssignment = await _context.ClassroomAssignments
                .Include(c => c.Classroom)
                .Include(c => c.Course).ToListAsync();
        }
    }
}
