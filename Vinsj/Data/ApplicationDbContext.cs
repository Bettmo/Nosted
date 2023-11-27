using Microsoft.EntityFrameworkCore;
using Vinsj.Models;


namespace Vinsj.Data;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /*
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
        */
        
        /* Eric: Legg alle modellene under: */
        public DbSet<Funksjons_test> FunksjonsTests { get; set; }
        public DbSet<Komponent_service> KomponentServices { get; set; }
        public DbSet<Kunde_informasjon> KundeInformasjons { get; set; }
        public DbSet<Produkt_informasjon> ProduktInformasjons { get; set; } 
        public DbSet<ServiceOrdre> ServiceOrdres { get; set; }
        public DbSet <ServiceSkjema> ServiceSkjemas { get; set; }
        public DbSet<ServiceSkjemaView> ServiceSkjema { get; set; }
        public DbSet<SignaturerModel> SignaturerModels { get; set; }
        public DbSet<SjekklisteView> SjekklisteViews { get; set; }
        public DbSet<trykk_settinger> TrykkSettingers { get; set; }

        
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
            
            
            
        }
        
    }

