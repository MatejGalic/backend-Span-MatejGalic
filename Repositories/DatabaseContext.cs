using backend_Span_MatejGalic.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_Span_MatejGalic.Repositories
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opt) : base(opt)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
