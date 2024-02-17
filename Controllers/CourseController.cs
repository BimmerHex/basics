using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class CourseController : Controller
{
    // course/details
    public IActionResult Details(int? id)
    {
        if (id == null) {
            // return Redirect("/Course/List");
            return RedirectToAction("List", "Course");
        }

        var getCourse = Repository.GetById(id);

        return View(getCourse);
    }

    // course/list
    public IActionResult List()
    {
        return View("CourseList", Repository.Courses);
    }
}
