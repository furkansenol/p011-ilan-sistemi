namespace IlanSistemi.UI.Areas.User.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string password { get; set; }
        public string passwordConfirm { get; set; }
        public string PictureURL { get; set; }
        public IFormFile Picture { get; set; }
    }
}
