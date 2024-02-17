using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class CourseController : Controller
{
    // course
    // course/index
    public IActionResult Index()
    {
        var getCourse = new Course();

        getCourse.Id = 1;
        getCourse.Title = "ASPNET Core Kursu";
        getCourse.Description = "ASPNET Core ile alakalı güzel bir kurs";

        return View(getCourse);
    }

    // course/list
    public IActionResult List()
    {
        return View("CourseList");
    }
}
