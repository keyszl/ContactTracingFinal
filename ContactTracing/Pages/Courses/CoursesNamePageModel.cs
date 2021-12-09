using System;
using ContactTracing.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ContactTracing.Models;

namespace ContactTracing.Pages.Courses
{
    public class CoursesNamePageModel : PageModel
    {
        public SelectList CourseNameSL { get; set; }

        public void PopulateCoursesDropDownList(ContactTracingContext _context,
            object selectedCourses = null)
        {
            var coursesQuery = from d in _context.Courses
                                   orderby d.Name // Sort by name.
                                   select d;

            CourseNameSL = new SelectList(coursesQuery.AsNoTracking(),
                        "CourseID", "Name", selectedCourses);
        }
    }
}
