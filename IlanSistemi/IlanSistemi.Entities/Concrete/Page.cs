using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.Entities.Concrete
{
    public class Page : IAuditEntity
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200, ErrorMessage = "{0} {1} karakterden uzun olamaz")]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }
        public bool IsActive { get; set; }


        // TODO
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
