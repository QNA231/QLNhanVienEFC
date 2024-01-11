using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVienEFC.Entities
{
    public class PhanCong
    {
        public int PhanCongId { get; set; }
        public int NhanVienId { get; set; }
        public int DuAnId { get; set; }
        public int SoGioLam { get; set; }
        public NhanVien NhanVien { get; set; }
        public DuAn DuAn { get; set; }
        public void NhapThongTIn(int nvId, int daId)
        {
            PhanCongId = 0;
            NhanVienId = nvId;
            DuAnId = daId;
            Console.WriteLine("Nhap so gio lam: ");
            SoGioLam = int.Parse(Console.ReadLine());
        }
    }
}
