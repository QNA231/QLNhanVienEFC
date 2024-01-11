using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVienEFC.IServices
{
    public interface IPhanCongServices
    {
        void ThemPhanCong(int nvId, int daId);
        double TinhLuong(int nvId);
    }
}
