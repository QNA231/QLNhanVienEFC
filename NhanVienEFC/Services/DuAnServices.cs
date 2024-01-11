using NhanVienEFC.Entities;
using NhanVienEFC.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVienEFC.Services
{
    public class DuAnServices : IDuAnServices
    {
        private readonly AppDbContext DbContext;

        public DuAnServices()
        {
            DbContext = new AppDbContext();
        }

        public void SuaDuAn(int daId)
        {
            if(DbContext.DuAn.Any(x => x.DuAnId == daId))
            {
                var daCanSua = DbContext.DuAn.Find(daId);
                Console.WriteLine("Nhap ten du an: ");
                daCanSua.TenDuAn = Console.ReadLine();
                Console.WriteLine("Nhap mo ta: ");
                daCanSua.MoTa = Console.ReadLine();
                Console.WriteLine("Nhap ghi chu: ");
                daCanSua.GhiChu = Console.ReadLine();
                DbContext.Update(daCanSua);
                DbContext.SaveChanges();
                Console.WriteLine("Sua du an thanh cong!");
            }
            else
            {
                Console.WriteLine("Du an khong ton tai!");
            }
        }

        public void ThemDuAn(DuAn da)
        {
            da.NhapThongTin();
            DbContext.Add(da);
            DbContext.SaveChanges();
            Console.WriteLine("Them du an thanh cong!");
        }
    }
}
