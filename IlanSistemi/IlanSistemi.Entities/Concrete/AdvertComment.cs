using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.Entities.Concrete
{
	public class AdvertComment : IAuditEntity
	{

		[Key]
		public int Id { get; set; }

		
		

		[Column(TypeName = "text")]
		public string Comment { get; set; }
		public bool IsActive { get; set; }


		//Bağlantı

		
		public virtual Advert Advert { get; set; }

		
		public virtual User User { get; set; }

		// TODO
		public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public DateTime UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public DateTime DeletedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
