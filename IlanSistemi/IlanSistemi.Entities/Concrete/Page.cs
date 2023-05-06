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
        public int Id { get; set; }

        [MaxLength(200, ErrorMessage = "{0} {1} karakterden uzun olamaz")]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }
        public bool IsActive { get; set; }

        // TODO
        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DeletedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }   
    }
}
