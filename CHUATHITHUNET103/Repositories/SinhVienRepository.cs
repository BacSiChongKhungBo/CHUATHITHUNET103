using CHUATHITHUNET103.Context;
using CHUATHITHUNET103.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHUATHITHUNET103.Repositories
{
    internal class SinhVienRepository
    {
        DBContext _context;
        public SinhVienRepository()
        {
            _context = new DBContext();
        }

        public List<Sinhvien> GetSinhviens()
        {
            return _context.Sinhviens.ToList();
        }

        public bool AddObj(Sinhvien obj)
        {
            if (obj == null)
            {
                return false;
            }
            _context.Sinhviens.Add(obj);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateObj(Sinhvien obj)
        {
            if (obj == null)
            {
                return false;
            }
            _context.Sinhviens.Update(obj);
            _context.SaveChanges();
            return true;
        }
        public bool RemoveObj(Sinhvien obj)
        {
            if (obj == null)
            {
                return false;
            }
            _context.Sinhviens.Remove(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
