using Microsoft.EntityFrameworkCore;


namespace Vinsj.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Herman.db");
        }
        
        public DbSet<Elektrisk> elektrisk { get; set; }
        
        public DbSet<Mekanisk> mekanisk { get; set; }
        
        public DbSet<Hydraulisk> hydraulisk { get; set; }
        
    }
}
