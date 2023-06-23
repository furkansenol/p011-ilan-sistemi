using System.ComponentModel.DataAnnotations;

namespace IlanSistemi.Entities.Concrete
{
    public class AdvertImage
    {
        [Key]
        public int Id { get; set; }


        public int? AdvertId { get; set; }

        [MaxLength(200,ErrorMessage ="{0} {1} karakterden uzun olamaz")]
        public string ImagePath { get; set; }
        //Bağlantı 
        public virtual Advert adverts { get; set; }
    }
}
