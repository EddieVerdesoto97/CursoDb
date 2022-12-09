using Microsoft.EntityFrameworkCore;
using CursoDb.Models.DataModels;


namespace CursoDb.DataAccess
{
    public class CoursesDBContext : DbContext
    {
        public CoursesDBContext(DbContextOptions<CoursesDBContext> options) : base(options)
        {



        }

        // TODO: Add Dbsets (Tables of our Data base)
        public DbSet<Course>? Courses { get; set; }
    }
}
