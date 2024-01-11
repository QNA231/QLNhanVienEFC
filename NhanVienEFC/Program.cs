using NhanVienEFC.Entities;
using NhanVienEFC.IServices;
using NhanVienEFC.Services;

static void Main()
{
    Console.InputEncoding = System.Text.Encoding.UTF8;
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    INhanVienServices nhanVienServices = new NhanVienServices();
    IDuAnServices duAnServices = new DuAnServices();
    IPhanCongServices phanCongServices = new PhanCongServices();

    Console.WriteLine("------------Quan ly nhan vien------------");
    Console.WriteLine("1. Them du an");
    Console.WriteLine("2. Them nhan vien");
    Console.WriteLine("3. Them phan cong");
    Console.WriteLine("4. Sua thong tin du an");
    Console.WriteLine("5. Xoa nhan vien");
    Console.WriteLine("6. Tinh luong cua 1 nhan vien bat ky");
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Chon: ");
    string s = Console.ReadLine();
    switch (s)
    {
        case "1":
            DuAn da = new DuAn();
            duAnServices.ThemDuAn(da);
            break;
        case "2":
            NhanVien nv = new NhanVien();
            nhanVienServices.ThemNhanVien(nv);
            break;
        case "3":
            Console.WriteLine("Nhap Id du an muon them nhan vien: ");
            int daId = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Id nhan vien duoc phan cong: ");
            int nvId = int.Parse(Console.ReadLine());
            phanCongServices.ThemPhanCong(daId, nvId);
            break;
        case "4":
            Console.WriteLine("Nhap Id du an can sua: ");
            int DaId = int.Parse(Console.ReadLine());
            duAnServices.SuaDuAn(DaId);
            break;
        case "5":
            Console.WriteLine("Nhap Id nhan vien muon xoa: ");
            int NvId = int.Parse(Console.ReadLine());
            nhanVienServices.XoaNhanVien(NvId);
            break;
        case "6":
            Console.WriteLine("Nhap Id cua nhan vien muon tinh luong: ");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine(phanCongServices.TinhLuong(ID));
            break;
    }
}
Main();