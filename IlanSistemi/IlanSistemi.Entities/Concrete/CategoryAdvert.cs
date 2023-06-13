using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.Entities.Concrete
{
	public class CategoryAdvert : IAuditEntity
	{

		[Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AdvertId { get; set; }


		//Bağlantı

		public virtual Advert adverts { get; set; }
		public virtual Category category { get; set; }

        //TODO
        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public DateTime? UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public DateTime? DeletedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
