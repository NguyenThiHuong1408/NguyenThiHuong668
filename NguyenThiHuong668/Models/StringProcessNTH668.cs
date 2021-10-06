using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenThiHuong668.Models
{
    public class StringProcessNTH668
    {
    [Key]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        public string Rating { get; set; }
    }
}
