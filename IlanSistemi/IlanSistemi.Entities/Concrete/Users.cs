using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.Entities.Concrete
{
    public class Users : IdentityUser<int>, IAuditEntity
    {       
        public string Name { get; set; }
        public string Surname { get; set; }

      
        public string? Address { get; set; }

      
        public string? Phone { get; set; }

        public string? ImageUrl { get; set; }

        public bool? IsBanned { get; set; }
        public bool? IsSuspended { get; set; }

        // TODO
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Bağlantı

        public ICollection<AdvertComment> advertComments { get; set; } 
		public ICollection<Setting> settings { get; set; }
		public ICollection<Advert> adverts { get; set; }
        
    }
}
