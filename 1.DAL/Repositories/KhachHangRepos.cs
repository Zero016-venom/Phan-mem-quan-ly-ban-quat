using _1.DAL.IRepositories;
using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class KhachHangRepos : KhachHang_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public KhachHangRepos()
        {
            
        }

        public KhachHangRepos(OnlyFansContext context)
        {
            _context = context;
        }


        public List<KhachHang> GetKhach(string input)
        {
            if (input == null)
            {
                return _context.KhachHangs.ToList();
            }
            else
            {
                return _context.KhachHangs.Where(a => a.TenKh.Contains(input)).ToList();
            }
        }
        public bool CreateKhach(KhachHang khach)
        {
            try
            {
                _context.KhachHangs.Add(khach);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateKhach(KhachHang khach)
        {
            try
            {
                var updatedKhach = _context.KhachHangs.Find(khach.IdKh);
                updatedKhach.TenKh = khach.TenKh;
                updatedKhach.NgaySinh = khach.NgaySinh;
                updatedKhach.Sdt = khach.Sdt;
                updatedKhach.Email = khach.Email;
                updatedKhach.GioiTinh = khach.GioiTinh;
                updatedKhach.DiaChi = khach.DiaChi;
                _context.KhachHangs.Update(updatedKhach);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
