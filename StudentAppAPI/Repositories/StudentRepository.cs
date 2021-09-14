using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentAppAPI.Data;
using StudentAppAPI.Entities;
using StudentAppAPI.Interfaces;

namespace StudentAppAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _dataContext;

        public StudentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _dataContext.Students.ToListAsync();
        }
    }
}