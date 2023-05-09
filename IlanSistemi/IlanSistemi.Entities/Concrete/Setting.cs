using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.Entities.Concrete
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }

        [DisplayName("Ayar")]
        [MaxLength(200, ErrorMessage = "{0} {1} karakterden uzun olamaz")]
        public string Name { get; set; }

        [MaxLength(400, ErrorMessage = "{0} {1} karakterden uzun olamaz")]
        public string Value { get; set; }
        public User? User { get; set; }
    }
}
