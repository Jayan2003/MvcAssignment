using Microsoft.AspNetCore.Mvc;
using MvcAssignment.Models;
using MvcAssignment.Interfaces;

namespace MvcAssignment.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            var courses = _courseService.GetAll();
            return View(courses);
        }

        public IActionResult Details(int id)
        {
            var course = _courseService.GetById(id);
            return View(course);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            _courseService.Add(course);
            return RedirectToAction("Index");
        }
    }
}