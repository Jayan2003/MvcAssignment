using MvcAssignment.Models;
using System.Collections.Generic;

namespace MvcAssignment.Interfaces
{
    public interface ICourseService
    {
        List<Course> GetAll();
        Course GetById(int id);
        void Add(Course course);
    }
}