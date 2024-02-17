using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class CourseController : Controller
{
    // course
    // course/index
    public string Index()
    {
        return "course/index";
    }

    // course/list
    public string List()
    {
        return "course/list";
    }
}
