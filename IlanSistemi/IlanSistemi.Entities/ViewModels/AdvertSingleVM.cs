using IlanSistemi.Entities.Concrete;

namespace IlanSistemi.Entities.ViewModels
{
    public class AdvertSingleVM
    {
        public Advert Advert { get; set; }
        public string CategoryName { get; set; }
        public Users User { get; set; }
        public List<AdvertImage> AdvertImages { get; set; }

    }
}
