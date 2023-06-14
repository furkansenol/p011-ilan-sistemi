using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace IlanSistemi.UI.Areas.Admin.Models
{
    public class UserLoginViewModel
    {
        [Display(Name = "Kullanici Adi")]
        [Required(ErrorMessage = "Lutfen Kullanici Adinizi Giriniz!")]
        public string Username { get; set; }
        [Display(Name = "Sifre")]
        [Required(ErrorMessage = "Lutfen Sifrenizi Giriniz!")]
        public string Password { get; set; }
    }
}
