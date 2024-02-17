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
        getCourse.Image = "aspnetcore.jpg";

        return View(getCourse);
    }

    // course/list
    public IActionResult List()
    {
        var getCourses = new List<Course>()
        {
            new Course() {
                Id = 1,
                Title = "ASPNET Core Kursu",
                Description = "ASPNET Core ile alakalı güzel bir kurs",
                Image = "aspnetcore.jpg"
            },
            new Course() {
                Id = 2,
                Title = "PHP Kursu",
                Description = "PHP ile alakalı güzel bir kurs",
                Image = "php.jpg"
            },
            new Course() {
                Id = 3,
                Title = "Django Kursu",
                Description = "Django ile alakalı güzel bir kurs",
                Image = "django.jpg"
            },
            new Course() {
                Id = 4,
                Title = "Javascript Kursu",
                Description = "Javascript ile alakalı güzel bir kurs",
                Image = "javascript.jpg"
            }
        };
        return View("CourseList", getCourses);
    }
}
