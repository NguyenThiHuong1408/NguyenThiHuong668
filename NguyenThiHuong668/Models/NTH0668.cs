using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenThiHuong668.Models
{
    public class NTH0668
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        public string NTHId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string NTHName { get; set; }
        [Column(TypeName = "boolean")]
        public string NTHGende { get; set; }
    }
}
