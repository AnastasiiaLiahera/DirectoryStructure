using DirectoryStructure.Models;
using Microsoft.EntityFrameworkCore;

namespace DirectoryStructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Models.Directory> Directory { get; set; }
    }
}
