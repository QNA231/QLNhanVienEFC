using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVienEFC.Entities
{
    public class DuAn
    {
        public int DuAnId { get; set; }
        [Required]
        [MaxLength(10)]
        public string TenDuAn { get; set; }
        public string MoTa { get; set; }
        public string GhiChu { get; set; }
        public IEnumerable<PhanCong> danhSachPhanCong { get; set; }
        public void NhapThongTin()
        {
            DuAnId = 0;
            Console.WriteLine("Nhap ten du an: ");
            TenDuAn = Console.ReadLine();
            Console.WriteLine("Nhap mo ta: ");
            MoTa = Console.ReadLine();
            Console.WriteLine("Nhap ghi chu: ");
            GhiChu = Console.ReadLine();
        }
    }
}
