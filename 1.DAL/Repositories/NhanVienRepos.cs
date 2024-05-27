using _1.DAL.IRepositories;
using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class NhanVienRepos : NhanVien_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public NhanVienRepos()
        {
            
        }

        public NhanVienRepos(OnlyFansContext context)
        {
            _context = context;
        }


        public List<NhanVien> GetNV(string input)
        {
            if (input == null)
            {
                return _context.NhanViens.ToList();
            }
            else
            {
                return _context.NhanViens.Where(nv => nv.Ten.Contains(input)).ToList();
            }
        }

        public bool CreateNhanVien(NhanVien nhanVien)
        {
            try
            {
                _context.NhanViens.Add(nhanVien);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            try
            {
                var updatedNV = _context.NhanViens.Find(nhanVien.IdNv);
                updatedNV.Ten = nhanVien.Ten;
                updatedNV.Sdt = nhanVien.Sdt;
                updatedNV.DiaChi = nhanVien.DiaChi;
                updatedNV.NgaySinh = nhanVien.NgaySinh;
                updatedNV.GioiTinh = nhanVien.GioiTinh;
                updatedNV.TrangThai = nhanVien.TrangThai;
                _context.NhanViens.Update(updatedNV);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
