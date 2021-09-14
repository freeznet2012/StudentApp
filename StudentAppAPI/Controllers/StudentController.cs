using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentAppAPI.DTOs;
using StudentAppAPI.Interfaces;

namespace StudentAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet("Test")]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents()
        {
            return Ok(await _service.GetAllStudents());
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllStudentsFormatted()
        {
            return Ok(await _service.GetAllStudentsFormatted());
        }
    }
}