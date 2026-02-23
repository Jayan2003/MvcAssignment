using MvcAssignment.Models;
using MvcAssignment.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MvcAssignment.Services
{
    public class CourseService : ICourseService
    {
        private static List<Course> courses = new List<Course>()
        {
            new Course { Id = 1, Title = "Math", Hours = 30 },
            new Course { Id = 2, Title = "Programming", Hours = 40 }
        };

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course GetById(int id)
        {
            return courses.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Course course)
        {
            course.Id = courses.Count + 1;
            courses.Add(course);
        }
    }
}