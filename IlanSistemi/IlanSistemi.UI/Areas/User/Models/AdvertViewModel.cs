using IlanSistemi.Entities.Concrete;

namespace IlanSistemi.UI.Areas.User.Models
{
	public class AdvertViewModel
	{
		public Advert? Advert { get; set; }
		public string ImagePath { get; set; }
		public List<Category> Categories { get; set; }
	}
}
