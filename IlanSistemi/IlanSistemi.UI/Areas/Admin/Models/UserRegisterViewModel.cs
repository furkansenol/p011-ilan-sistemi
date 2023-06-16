using System.ComponentModel.DataAnnotations;

namespace IlanSistemi.UI.Areas.Admin.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lutfen Adinizi Girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lutfen Soyadinizi Girin")]
        public string Surname { get; set; }

        public string? ImagURL { get; set; }

        [Required(ErrorMessage = "Lutfen Kullanici Adinizi Girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lutfen Bir Sifre Girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lutfen Sifrenizi Tekrar Girin")]
        [Compare("Password", ErrorMessage = "Sifreler Uyumlu Degil!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lutfen Mail Adresinizi Girin")]
        public string Mail { get; set; }
    }
}
