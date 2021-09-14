using StudentAppAPI.Entities;

namespace StudentAppAPI.Helpers
{
    public static class Extensiona
    {
        public static StudentAppAPI.DTOs.Student MapToStudentDto(this Student student)
            => new StudentAppAPI.DTOs.Student
                    {
                        StudentName = student.FStudentName,
                        StudentID = (int)student.FStudentId,
                        Subject = student.FSubject,
                        Marks = (int)student.FMarks,
                    };
    }

}