using NhanVienEFC.Entities;
using NhanVienEFC.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVienEFC.Services
{
    public class PhanCongServices : IPhanCongServices
    {
        private readonly AppDbContext DbContext;

        public PhanCongServices()
        {
            DbContext = new AppDbContext() ;
        }

        public void ThemPhanCong(int nvId, int daId)
        {
            NhanVien nv = DbContext.NhanVien.FirstOrDefault(x => x.NhanVienId == nvId);
            DuAn da = DbContext.DuAn.FirstOrDefault(x => x.DuAnId == daId);
            PhanCong pc = new PhanCong();
            if(nv != null && da != null)
            {
                pc.NhapThongTIn(nvId, daId);
                DbContext.Add(pc);
                DbContext.SaveChanges();
                Console.WriteLine("Them phan cong thanh cong!");
            }
            else
            {
                Console.WriteLine("Phan cong chua duoc them thanh cong!");
            }
        }

        public double TinhLuong(int nvId)
        {
            NhanVien nv = DbContext.NhanVien.FirstOrDefault(x => x.NhanVienId == nvId);
            double result = 0;
            if(nv != null)
            {
                var pc = DbContext.PhanCong.Find(nvId);
                result += SoGioLamCua1DuAn(pc.NhanVienId) * nv.HeSoLuong * 15;
            }
            return result;
        }
        private int SoGioLamCua1DuAn(int nvID)
        {
            var rs = DbContext.PhanCong.Where(x => x.NhanVienId == nvID).Sum(x => x.SoGioLam);
            return rs;
        }
    }
}
