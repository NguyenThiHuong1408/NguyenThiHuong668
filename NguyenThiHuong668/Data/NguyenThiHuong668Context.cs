using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenThiHuong668.Models;

namespace NguyenThiHuong668.Data
{
    public class NguyenThiHuong668Context : DbContext
    {
        public NguyenThiHuong668Context (DbContextOptions<NguyenThiHuong668Context> options)
            : base(options)
        {
        }

        public DbSet<NguyenThiHuong668.Models.PersonNTH668> PersonNTH668 { get; set; }

        public DbSet<NguyenThiHuong668.Models.NTH0668> NTH0668 { get; set; }
    }
}
