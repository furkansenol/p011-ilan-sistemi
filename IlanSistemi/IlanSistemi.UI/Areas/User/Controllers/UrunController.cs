using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IlanSistemi.UI.Areas.User.Controllers
{
    public class UrunAdvertViewModel
    {
        public Advert Advert { get; set; }
        public List<Category> Categories { get; set; }
    }
    public class EditAdvertViewModel
    {
        public Advert Advert { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<int> SelectedCategoryIds { get; set; }
        public List<CategoryAdvert> CategoryAdverts { get; set; }
        public List<AdvertComment> AdvertComments { get; set; }
        public List<AdvertImage> AdvertImages { get; set; }
        public Users User { get; set; }
    }

    public class AddAdvertViewModel
    {
        [Required(ErrorMessage = "User is required")]
        public Users User { get; set; }

        [Required(ErrorMessage = "The Advert field is required.")]
        public Advert Advert { get; set; }

        [Required(ErrorMessage = "The Categories field is required.")]
        public Category Category { get; set; }

      

        

        [Required(ErrorMessage = "The AdvertComments field is required.")]
        public List<AdvertComment>? AdvertComments { get; set; }

        [Required(ErrorMessage = "The AdvertImages field is required.")]
        public AdvertImage AdvertImage { get; set; }

        
    }




    [Area("User")]
    [Route("User/[controller]/[action]")]
    public class UrunController : Controller
    {
        private readonly AdvertManager _advertManager = new AdvertManager(new EfAdvertDal());
        private readonly CategoryAdvertManager _categoryAdvertManager = new CategoryAdvertManager(new EfCategoryAdvertDal());
        private readonly CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        private readonly UserManager _userManager = new UserManager(new EfUserDal());
        private readonly AdvertCommentManager _advertComentManager = new AdvertCommentManager(new EfAdvertCommentDal());
        private readonly AdvertImageManager _advertImageManager = new AdvertImageManager(new EfAdvertImageDal());


        public IActionResult Index()
        {
            var userId = _userManager.TGetListbyFilter(u => u.UserName == User.Identity.Name)
                                     .FirstOrDefault()?.Id;

            if (userId == null)
            {
                return RedirectToAction("Error");
            }

            var adverts = _advertManager.TGetListbyFilter(ad => ad.UsersId == userId);
            var categoryAdverts = _categoryAdvertManager.TGetList();
            var categories = _categoryManager.TGetList();

            var values = adverts.Select(ad => new AdvertViewModel
            {
                Advert = ad,
                Categories = categoryAdverts.Where(ca => ca.AdvertId == ad.Id)
                                            .Join(categories, ca => ca.CategoryId, c => c.Id, (ca, c) => c)
                                            .ToList()
            }).ToList();

            return View(values);
        }
        public IActionResult EditAdvert(int id)
        {
            var userId = _userManager.TGetListbyFilter(u => u.UserName == User.Identity.Name)
                                     .FirstOrDefault()?.Id;

            if (userId == null)
            {
                // Kullanıcı bulunamadı, uygun bir hata işleme stratejisi uygulayın
                // Örneğin, bir hata sayfasına yönlendirme yapabilirsiniz.
                return RedirectToAction("Error");
            }

            var advert = _advertManager.TGetListbyFilter(ad => ad.Id == id && ad.UsersId == userId)
                                      .FirstOrDefault();

            if (advert == null)
            {
                // Kullanıcının düzenlemeye yetkisi olmayan bir kaydı düzenlemeye çalışması durumunda uygun bir işlem yapın
                // Örneğin, bir hata sayfasına yönlendirme yapabilirsiniz veya başka bir aksiyon alabilirsiniz.
                return RedirectToAction("Error");
            }

            // Gerekli verileri hazırlayın ve düzenleme sayfasına yönlendirin
            // Örneğin, bir view model kullanarak advert ve gerekli diğer verileri düzenleme sayfasına gönderin.
            var model = new EditAdvertViewModel
            {
                Advert = advert,
                Categories = _categoryManager.TGetList()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditAdvert(EditAdvertViewModel model)
        {
            if (ModelState.IsValid)
            {
                var advert = model.Advert;
                // Advert güncelleme işlemleri...
                _advertManager.TUpdate(advert);

                // CategoryAdvert ilişkisini güncelleme
                var selectedCategoryIds = model.SelectedCategoryIds;
                var existingCategoryAdverts = _categoryAdvertManager.TGetListbyFilter(ca => ca.AdvertId == advert.Id);
                var deletedCategoryAdverts = existingCategoryAdverts.Where(ca => !selectedCategoryIds.Contains(ca.CategoryId)).ToList();
                var addedCategoryAdverts = selectedCategoryIds.Where(categoryId => !existingCategoryAdverts.Any(ca => ca.CategoryId == categoryId)).Select(categoryId => new CategoryAdvert { CategoryId = categoryId, AdvertId = advert.Id }).ToList();

                foreach (var deletedCategoryAdvert in deletedCategoryAdverts)
                {
                    _categoryAdvertManager.TDelete(deletedCategoryAdvert);
                }

                foreach (var addedCategoryAdvert in addedCategoryAdverts)
                {
                    _categoryAdvertManager.TAdd(addedCategoryAdvert);
                }

                // Diğer işlemler...
                TempData["SuccessMessage"] = "Ürün başarıyla güncellendi.";
                return RedirectToAction("Index", "Urun");
            }

            // Hata durumuyla ilgili işlemler...
            model.Categories = _categoryManager.TGetList();
            var categoryAdverts = _categoryAdvertManager.TGetList();
            var advertComments = _advertComentManager.TGetList();
            var advertImages = _advertImageManager.TGetList();
            model.CategoryAdverts = categoryAdverts;
            model.AdvertComments = advertComments;
            model.AdvertImages = advertImages;
            TempData["ErrorMessage"] = "Geçerli bir model sağlanmadı. Ürün güncelleme işlemi başarısız.";
            return View(model);
        }

        [HttpGet]
        public IActionResult AddAdvert()
        {
            var user = _userManager.TGetListbyFilter(u => u.UserName == User.Identity.Name).FirstOrDefault().Id;
            TempData["id"] = user;
            TempData["Categories"] = _categoryManager.TGetList();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAdvert(AddAdvertViewModel model, List<IFormFile> advertImages)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.TGetListbyFilter(u => u.UserName == User.Identity.Name).FirstOrDefault();

                var advert = new Advert
                {
                    UsersId = user.Id,
                    Title = model.Advert.Title,
                    Description = model.Advert.Description,

                };

                _advertManager.TAdd(advert);

               
                   
                

                foreach (var image in advertImages)
                {
                    if (image != null && image.Length > 0)
                    {
                        var imageName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                        var imagePath = Path.Combine("wwwroot", "UserImage", imageName);

                        using (var stream = new FileStream(imagePath, FileMode.Create))
                        {
                            await image.CopyToAsync(stream);
                        }

                        var advertImage = new AdvertImage
                        {
                            AdvertId = advert.Id,
                            ImagePath = imageName
                        };

                        _advertImageManager.TAdd(advertImage);
                    }
                }

                TempData["SuccessMessage"] = "Advertisement added successfully.";
                return RedirectToAction("Index", "Advert");
            }

            TempData["ErrorMessage"] = "Invalid model provided. Failed to add the advertisement.";
           
           
            model.AdvertComments = _advertComentManager.TGetList();
          

            return View("Index","Urun");
        }












        public IActionResult DeleteAdvert(int id)
        {
            var values = _advertManager.TGetByID(id);
            _advertManager.TDelete(values);
            return RedirectToAction("Index");
        }





    }

}
