using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IlanSistemi.DataAccess.Concrete
{
    public class DataContext : IdentityDbContext<Users, AdminRole, int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=MERT; Database=IlanProjesi5; Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            // Sql de bunu nasıl public yapacağımızı bilemedik yaparsanız seviniriz... =)


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<AdvertComment>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<AdvertComment>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdvertComment>()
                .HasOne(c => c.Advert)
                .WithMany()
                .HasForeignKey(c => c.Id)
                .OnDelete(DeleteBehavior.Restrict);

            //Seed Data for Category Model
            modelBuilder.Entity<Category>().HasData(
                new List<Category>()
                {
                    new Category
                    {
                        Id = 1,
                        Name = "Elektronik",
                        Description = "Elektronik"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Moda",
                        Description = "Envai çeşit sizi çıplaklıktan koruyacak kıyafetler."
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Ev-Yasam",
                        Description = "Ev Tekstili, Mutfak Gereçleri"
                    },
                    new Category
                    {
                        Id = 4,
                        Name = "Spor-Outdoor",
                        Description = "Aradığınız tüm spor ürünleri"
                    },
                    new Category
                    {
                        Id = 5,
                        Name = "Kozmetik",
                        Description = "Kişisel bakım ve makyaj malzemeleri"
                    },
                }
            );



        }

        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<Advert> adverts { get; set; }
        public DbSet<CategoryAdvert> CategoryAdverts { get; set; }
        public DbSet<AdvertComment> advertComments { get; set; }
        public DbSet<AdvertImage> AdvertImages { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Page> pages { get; set; }
        public DbSet<Setting> settings { get; set; }
        public DbSet<Users> users { get; set; }

    }
}

