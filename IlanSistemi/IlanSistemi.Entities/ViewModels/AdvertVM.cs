using IlanSistemi.Entities.Concrete;

namespace IlanSistemi.Entities.ViewModels
{
    public class AdvertVM
    {
        public Advert Advert { get; set; }
        public List<AdvertImage> AdvertImages { get; set; }
        public string? CategoryName { get; set; }
    }
}
