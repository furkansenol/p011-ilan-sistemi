using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public DateTime UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public DateTime DeletedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		// Bağlantı

		public virtual User User { get; set; }
		public ICollection<AdvertComment> advertComments { get; set; }
		public ICollection<CategoryAdvert> categoryAdverts { get; set; }
		public ICollection<AdvertImage> advertImages { get; set; }
	}
}
