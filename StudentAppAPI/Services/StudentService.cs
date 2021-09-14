using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAppAPI.DTOs;
using StudentAppAPI.Helpers;
using StudentAppAPI.Interfaces;

namespace StudentAppAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;
        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _repository.GetAllStudents().ContinueWith(x => x.Result.Select(x => x.MapToStudentDto()));
        }
    }
}