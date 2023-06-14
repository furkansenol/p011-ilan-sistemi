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
    public class User : IAuditEntity
    {
        [Key]
        public int Id { get; set; }


        [DisplayName("Email")]
        [EmailAddress]
        [Column(TypeName ="varchar")]
        [MaxLength(200,ErrorMessage ="{0} {1} karakterden uzun olamaz")]
        public string Email { get; set; }

        [DisplayName("Şifre")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakterden uzun olamaz")]
        public string Password { get; set; }

        [DisplayName("İsim")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakterden uzun olamaz")]
        public string Name { get; set; }

        [DisplayName("Adres")]
        [MaxLength(200, ErrorMessage = "{0} {1} karakterden uzun olamaz")]
        public string Address { get; set; }

        [DisplayName("Telefon Numarası")]
        [Column(TypeName = "varchar")]
        [MaxLength(20, ErrorMessage = "{0} {1} karakterden uzun olamaz")]
        public string Phone { get; set; }

        // TODO
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Bağlantı

        public ICollection<AdvertComment> advertComments { get; set; } 
		public ICollection<Setting> settings { get; set; }
		public ICollection<Advert> adverts { get; set; }
        
    }
}
