using NhanVienEFC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVienEFC.IServices
{
    public interface IDuAnServices
    {
        void ThemDuAn(DuAn da);
        void SuaDuAn(int daId);
    }
}
