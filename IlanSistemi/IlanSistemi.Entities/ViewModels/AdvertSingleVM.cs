using IlanSistemi.Entities.Concrete;

namespace IlanSistemi.Entities.ViewModels
{
	public class AdvertSingleVM
	{
		public Advert Advert { get; set; }
		public AdvertComment comment { get; set; }
		public string CategoryName { get; set; }
		public Users User { get; set; }
		public List<AdvertImage> AdvertImages { get; set; }
		public List<AdvertComment> mert { get; set; }

		public Advert SelectedAdvert { get; set; } // SelectedAdvert özelliği eklenmiştir
	}

}
