using System.Collections.Generic;

namespace StudentAppAPI.DTOs
{  
    public class StudentInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Marks { get; set; }
        public int Total { get; set; }
    }
}