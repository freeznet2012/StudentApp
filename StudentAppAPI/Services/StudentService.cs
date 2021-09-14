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
        public async Task<IEnumerable<StudentInfo>> GetAllStudentsFormatted()
        {
            var result = await _repository.GetAllStudents().ContinueWith(x => x.Result.Select(x => x.MapToStudentDto()));

            var query = result
                .GroupBy(c => c.StudentID)
                .Select(g => new StudentInfo{
                    Id = g.Key,
                    Name = g.FirstOrDefault(c => c.StudentID == g.Key).StudentName,
                    Marks = new int[]{
                        g.FirstOrDefault(c => c.Subject == "EC1").Marks,
                        g.FirstOrDefault(c => c.Subject == "EC2").Marks,
                        g.FirstOrDefault(c => c.Subject == "EC3").Marks,
                        g.FirstOrDefault(c => c.Subject == "EC4").Marks,
                        g.FirstOrDefault(c => c.Subject == "EC5").Marks
                    },
                    Total = g.Sum(c => c.Marks)
                }).OrderByDescending(x => x.Total);
            return query.ToArray();
        }
    }
}