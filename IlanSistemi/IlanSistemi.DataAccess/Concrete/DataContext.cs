using IlanSistemi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.DataAccess.Concrete
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-TSBCP7B\\SQL2019; Database=IlanSistemi; User Id=sa; Password =123");
            // Sql de bunu nasıl public yapacağımızı bilemedik yaparsanız seviniriz... =)
        }

        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<Advert> adverts { get; set; }
        public DbSet<AdvertComment> advertComments { get; set; }
        public DbSet<AdvertImage> AdvertImages { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Page> pages { get; set; }
        public DbSet<Setting> settings { get; set; }
        public DbSet<User> users { get; set; }

    }
}

