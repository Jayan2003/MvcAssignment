using MvcAssignment.Models;
using MvcAssignment.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MvcAssignment.Services
{
    public class StudentService : IStudentService
    {
        private static List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "Ali", Age = 20 },
            new Student { Id = 2, Name = "Sara", Age = 22 }
        };

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public void Add(Student student)
        {
            student.Id = students.Count + 1;
            students.Add(student);
        }
    }
}