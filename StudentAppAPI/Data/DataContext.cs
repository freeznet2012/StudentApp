using Microsoft.EntityFrameworkCore;
using StudentAppAPI.Entities;

namespace StudentAppAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}