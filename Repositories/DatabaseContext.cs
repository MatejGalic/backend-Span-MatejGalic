using backend_Span_MatejGalic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace backend_Span_MatejGalic.Repositories
{
    public class DatabaseContext : DbContext
    {
        private string ConnectionString { get; }

        public DatabaseContext(DbContextOptions<DatabaseContext> opt) : base(opt)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false);

            var configuration = builder.Build();

            ConnectionString = configuration.GetConnectionString("DatabaseConnection").ToString();
        }

        public string GetConnectionString()
        {
            return ConnectionString;
        }

        public DbSet<Person> People { get; set; }
    }
}
