using Microsoft.EntityFrameworkCore;
using testtask.Models.PersonModel;

namespace testtask.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
