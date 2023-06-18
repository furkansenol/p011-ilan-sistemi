using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IlanSistemi.Entities.Concrete
{
    public class Advert : IAuditEntity
	{
		[Key]
		public int Id { get; set; }
		public int UsersId { get; set; }
		public string Title { get; set; }	

		public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Bağlantı

        public virtual Users User { get; set; }
		public ICollection<AdvertComment> advertComments { get; set; }
		public ICollection<CategoryAdvert> categoryAdverts { get; set; }
		public ICollection<AdvertImage> advertImages { get; set; }

    }
}
