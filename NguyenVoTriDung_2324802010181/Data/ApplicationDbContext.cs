using Microsoft.EntityFrameworkCore;
using NguyenVoTriDung_2324802010181.Models;

namespace NguyenVoTriDung_2324802010181.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
    }

}
