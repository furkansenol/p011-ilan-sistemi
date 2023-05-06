using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.Entities.Concrete
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("İlan Adı")]
        [MaxLength(100,ErrorMessage ="{0} {1} karakterden uzun olamaz")]
        public string Name { get; set; }

        [DisplayName("Açıklama")]
        [MaxLength(200, ErrorMessage = "{0} {1} karakterden uzun olamaz")]
        public string Description { get; set; }
    }
}
