using Microsoft.EntityFrameworkCore;

namespace time_table_project
{
    public class TimeTableDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        
    }
}
