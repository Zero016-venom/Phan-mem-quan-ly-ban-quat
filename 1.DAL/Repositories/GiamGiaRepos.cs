using _1.DAL.IRepositories;
using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class GiamGiaRepos : GiamGia_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public GiamGiaRepos()
        {

        }

        public GiamGiaRepos(OnlyFansContext context)
        {
            _context = context;
        }

        public bool CreateGiamGia(GiamGium giamGia)
        {
            try
            {
                _context.GiamGia.Add(giamGia);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<GiamGium> GetGiamGia(string input)
        {
            return _context.GiamGia.ToList();
        }

        public bool UpdateGiamGia(GiamGium giamGia)
        {
            try
            {
                var updateGiamGia = _context.GiamGia.Find(giamGia.IdGiamGia);

                updateGiamGia.NgayBatDau = giamGia.NgayBatDau;
                updateGiamGia.NgayKetThuc = giamGia.NgayKetThuc;
                updateGiamGia.DieuKien = giamGia.DieuKien;
                updateGiamGia.GiaTri = giamGia.GiaTri;

                _context.GiamGia.Update(updateGiamGia);
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
