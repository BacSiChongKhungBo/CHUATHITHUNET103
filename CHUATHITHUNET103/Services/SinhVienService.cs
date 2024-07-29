using CHUATHITHUNET103.DomainClass;
using CHUATHITHUNET103.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHUATHITHUNET103.Services
{
    internal class SinhVienService
    {
        SinhVienRepository _repos;
        public SinhVienService()
        {
            _repos = new SinhVienRepository();
        }

        public List<Sinhvien> GetDanhSach()
        {
            return _repos.GetSinhviens();
        }

        public string ThemSV(Sinhvien sv)
        {
            if (_repos.AddObj(sv))
            {
                return "Thêm Thành Công";
            }
            return "Thêm Thất bại";
        }
        public string SuaSV(Sinhvien sv)
        {
            if (_repos.UpdateObj(sv))
            {
                return "Cập Nhật Thành Công";
            }
            return "Cập Nhật Thất bại";
        }
        public string XoaSV(Sinhvien sv)
        {
            if (_repos.RemoveObj(sv))
            {
                return "Xóa Thành Công";
            }
            return "Xóa Thất bại";
        }
    }
}
