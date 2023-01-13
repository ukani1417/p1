using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using p1.Models;
namespace p1.Services
{
    public class StudentServices : IStudentServices
    {
        private static List<Student> StudentList = new List<Student> {
                new Student{
                    Id = 201901417,
                    Name = "Dhruv Ukani",
                    Email = "201901417@daiict.ac.in",
                    Class = "Btech",
                    CGPA = 7.03F,
                },
                new Student{
                    Id = 201901418,
                    Name = "Fenil Kamdar",
                    Email = "201901418@daiict.ac.in",
                    Class = "Btech",
                    CGPA = 10.00F,
                },
            };
        // POST
        public Student? AddStudent(Student student)
        {
            bool isexists = StudentList.Exists(x=>x.Id == student.Id);
            if(isexists == true){
                return null;
            }
            // Console.WriteLine(student.Id);
            StudentList.Add(student);
            return student;
        }
        // GET ALL
        public List<Student> GetAllStudents()
        {
            return StudentList;
        }
        // GET - id
        public Student? GetStudent(int id)
        {
           var studentId = StudentList.FindIndex(x=> x.Id == id);
           if(studentId == -1){
                return null;
           }
           return StudentList[studentId];
        }

        public Student? RemoveStudent(int id)
        {
            var student = StudentList.Find(x => x.Id == id);
            if (student == null)
            {
                return null;
            }

            StudentList.RemoveAt(StudentList.FindIndex(x=>x.Id == id));
            return student;
        }

        public Student? UpdateStudent(int id, Student student)
        {
            var studentId = StudentList.FindIndex(x => x.Id == id);
            if (studentId == -1)
            {
                return null;
            }
            student.Id = id;
            StudentList[studentId] = student;
            return student;
        }
    }
}