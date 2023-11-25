
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Vinsj.Models;
namespace Vinsj.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

// Bør ikke dette være i Program.cs?
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlite(connectionString);
            }
        }
        
        /* Eric: Legg alle modellene under: */
        //public DbSet<Elektrisk> elektrisk { get; set; }
        
       // public DbSet<Mekanisk> mekanisk { get; set; }
        
        //public DbSet<Hydraulisk> hydraulisk { get; set; }
        
        
        /* OnModelCreating konfigurer detaljene i modellen. */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*.HasOne at forholdet har en 1 av instansen
          .HasKey at det er en composite key.
          .withMany at forholdet kan ha mange av instansen.
          .HasForeignKey at det er en foreign key

          forkortelsene er bare variabel navnet brukt i et lambda utrykk for en instant av entiteten som blir konfigurert */
            
            modelBuilder.Entity<ApplicationUser>().ToTable("Users"); // Customize the Users table name
            modelBuilder.Entity<IdentityRole>().ToTable("Roles"); // Customize the Roles table name
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles"); 
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins"); 
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims"); 
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens"); 
        }
    }
}

            
            
        }
        
    }
    
}
