using IlanSistemi.Entities.Concrete;

namespace IlanSistemi.UI.Areas.Admin.Models
{
    public class ReportListViewModel
    {
        public List<Users> Users { get; set; }
        public List<Category> Categories { get; set; }
        public List<Advert> Adverts { get; set; }

        public Users _Users { get; set; }

        public Advert _Advert { get; set; }
		public ReportListViewModel()
		{
			_Advert = new Advert(); // veya null olarak başlatın
		}
	}
}
