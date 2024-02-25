using Microsoft.EntityFrameworkCore;
using NajotCRUD.Domain.Entities.Models;

namespace NajotCRUD.Infrastruct.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base (options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
