using System;
using ContactTracing.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ContactTracing.Models;

namespace ContactTracing.Pages.Enrollments
{
    public class CoursesNamePageModel : PageModel
    {
        public SelectList CourseNameSL { get; set; }

        public void PopulateCoursesDropDownList(ContactTracingContext _context,
            object selectedCourses = null)
        {
            var coursesQuery = from d in _context.Courses
                               orderby d.Code // Sort by name.
                               select d;

            CourseNameSL = new SelectList(coursesQuery.AsNoTracking(),
                        "CourseID", "Code", selectedCourses);
        }

        public SelectList AccountNameSL { get; set; }

        public void PopulateAccountsDropDownList(ContactTracingContext _context,
            object selectedAccounts = null)
        {
            var accountsQuery = from d in _context.Accounts
                                orderby d.Email // Sort by name.
                                select d;

            AccountNameSL = new SelectList(accountsQuery.AsNoTracking(),
                        "AccountID", "Email", selectedAccounts);
        }
    }
}
