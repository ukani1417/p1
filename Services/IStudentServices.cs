using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using p1.Models;

namespace p1.Services
{
    public interface IStudentServices
    {
        public List<Student> GetAllStudents();

        public Student? GetStudent(int id);

        public Student? AddStudent(Student student);

        public Student? UpdateStudent(int id,Student student);

        public Student? RemoveStudent(int id);
    }
}