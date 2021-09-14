using System.Collections.Generic;
using System.Threading.Tasks;
using StudentAppAPI.DTOs;

namespace StudentAppAPI.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudents();
        Task<IEnumerable<StudentInfo>> GetAllStudentsFormatted();
    }
}