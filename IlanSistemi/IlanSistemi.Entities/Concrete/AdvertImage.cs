using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.Entities.Concrete
{
    public class AdvertImage
    {
        public int Id { get; set; }
        public int AdvertId { get; set; }

        [MaxLength(200,ErrorMessage ="{0} {1} karakterden uzun olamaz")]
        public string ImagePath { get; set; }
    }
}
