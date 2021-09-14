using System.Collections.Generic;
using System.Threading.Tasks;
using StudentAppAPI.Entities;

namespace StudentAppAPI.Interfaces
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudents();
    }
}