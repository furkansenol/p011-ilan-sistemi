using System.ComponentModel.DataAnnotations;

namespace IlanSistemi.Entities.Concrete
{
    public class AdvertImage
    {
        [Key]
        public int Id { get; set; }
        public int AdvertId { get; set; }
        public string ImagePath { get; set; }
        //Bağlantı 
        public virtual Advert adverts { get; set; }
    }
}
