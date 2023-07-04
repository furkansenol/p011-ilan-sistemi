using IlanSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.UI.Models
{
	public class AdvertCommentListViewModel
	{
		public int AdvertId { get; set; }

		public int UserId { get; set; }

		public Users User { get; set; }
		public List<AdvertComment> AdvertComments { get; set; }
		
		
		
		public string Comment { get; set; }
	}


}
