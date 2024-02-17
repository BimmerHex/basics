using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class CourseController : Controller
{
    // course
    // course/index
    public IActionResult Index()
    {
        return View();
    }

    // course/list
    public IActionResult List()
    {
        return View("CourseList");
    }
}
