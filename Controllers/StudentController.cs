using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using p1.Models;
using p1.Services;

namespace p1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _istudentservices;
        public StudentController(IStudentServices istudentservices)
        {
            _istudentservices = istudentservices;
        }
        [HttpGet]
        // [Route("")]
        public ActionResult<List<Student>> GetAllStudents()
        {
            List<Student> students= _istudentservices.GetAllStudents();
            if(students == null){
                return NoContent();
            }
            return Ok(students);
        }

        [HttpGet("{id}")]
        // [Route("id:int")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = _istudentservices.GetStudent(id);
            if (student == null)
            {
                return NotFound("Student is not exist with given Id");
            }
            return Ok(student);

        }

        [HttpPost]
        public ActionResult<Student> AddStudent(Student student)
        {
            var request = _istudentservices.AddStudent(student);
            if(request == null){
                return NotFound("Already exists with Id");
            }
            return Ok(student);
        }

        [HttpPut("{id}")]
        // [Route("id:int")]
        public ActionResult<Student> UpdateStudent(int id, Student student)
        {
            var request = _istudentservices.UpdateStudent(id,student);
            if(request == null){
                return NotFound("Student not exists");
            }
            return Ok(request);
        }

        [HttpDelete("{id}")]
        // [Route("id:int")]
        public ActionResult<Student> RemoveStudent(int id)
        {
            var request = _istudentservices.RemoveStudent(id);
            if(request == null){
                return NotFound("Student is not Found");
            }
            return Ok(request);
        }
    }
}