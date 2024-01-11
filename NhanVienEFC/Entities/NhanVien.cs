using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVienEFC.Entities
{
    public class NhanVien
    {
        public int NhanVienId { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public double HeSoLuong { get; set; }
        public IEnumerable<PhanCong> danhSachPhanCong { get; set; }
        public void NhapThongTIn()
        {
            NhanVienId = 0;
            Console.WriteLine("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap so dien thoai: ");
            SDT = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap Email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Nhap he so luong: ");
            HeSoLuong = double.Parse(Console.ReadLine());
        }
    }
}
