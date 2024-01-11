using NhanVienEFC.Entities;
using NhanVienEFC.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVienEFC.Services
{
    public class NhanVienServices : INhanVienServices
    {
        private readonly AppDbContext DbContext;

        public NhanVienServices()
        {
            DbContext = new AppDbContext();
        }

        public void ThemNhanVien(NhanVien nv)
        {
                nv.NhapThongTIn();
                DbContext.Add(nv);
                DbContext.SaveChanges();
                Console.WriteLine("Them nhan vien thanh cong!");
        }

        public void XoaNhanVien(int nvId)
        {
            if(DbContext.NhanVien.Any(x => x.NhanVienId == nvId))
            {
                var nvCanXoa = DbContext.NhanVien.Find(nvId);
                DbContext.Remove(nvCanXoa);
                DbContext.SaveChanges();
                Console.WriteLine("Xoa nhan vien thanh cong!");
            }
            else
            {
                Console.WriteLine("Xoa nhan vien that bai");
            }
        }
    }
}
