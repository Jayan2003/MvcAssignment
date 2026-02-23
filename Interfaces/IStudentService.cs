using MvcAssignment.Models;
using System.Collections.Generic;

namespace MvcAssignment.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(int id);
        void Add(Student student);
    }
}