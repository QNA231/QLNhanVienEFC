using NhanVienEFC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVienEFC.IServices
{
    public interface INhanVienServices
    {
        void ThemNhanVien(NhanVien nv);
        void XoaNhanVien(int nvId);
    }
}
