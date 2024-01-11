using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVienEFC.Entities
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<DuAn> DuAn { get; set; }
        public virtual DbSet<PhanCong> PhanCong { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server = LAPTOP-1600EKM7\\SQLEXPRESS; Database = QLNhanVien; Trusted_Connection = True; TrustServerCertificate = True");
        }
    }
}
