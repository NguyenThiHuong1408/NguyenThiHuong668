using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenThiHuong668.Models
{
    public class PersonNTH668
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        public string PersonId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PersonName { get; set; }

    }
}
