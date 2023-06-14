using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IlanSistemi.Entities.Concrete
{
    public class Advert : IAuditEntity
	{
		[Key]
		public int Id { get; set; }
		public int UserId { get; set; }

		[MaxLength(200, ErrorMessage = "{0} {1} karakterden uzun olamaz")]
		public string Title { get; set; }	

		[Column(TypeName = "ntext")]
		public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Bağlantı

        public virtual User User { get; set; }
		public ICollection<AdvertComment> advertComments { get; set; }
		public ICollection<CategoryAdvert> categoryAdverts { get; set; }
		public ICollection<AdvertImage> advertImages { get; set; }

    }
}
