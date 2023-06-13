using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.DataAccess.Concrete
{
    public class DataContext : IdentityDbContext<AdminUser, AdminRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=EFE\\SQL2019; Database=IlanSistemi; User Id=sa; Password =123");
            // Sql de bunu nasıl public yapacağımızı bilemedik yaparsanız seviniriz... =)


        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
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

			base.OnModelCreating(modelBuilder);
		}

		public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<Advert> adverts { get; set; }
        public DbSet<CategoryAdvert> categoryAdverts { get; set; }
        public DbSet<AdvertComment> advertComments { get; set; }
        public DbSet<AdvertImage> AdvertImages { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Page> pages { get; set; }
        public DbSet<Setting> settings { get; set; }
        public DbSet<User> users { get; set; }

    }
}

