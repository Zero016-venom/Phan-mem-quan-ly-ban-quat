using _1.DAL.IRepositories;
using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HoaDonRepos : HoaDon_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public HoaDonRepos()
        {
            
        }

        public HoaDonRepos(OnlyFansContext context)
        {
            _context = context;
        }

        public bool CreateHoaDon(HoaDon hoaDon)
        {
            try
            {
                _context.HoaDons.Add(hoaDon);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }       

        public List<HoaDon> GetHoaDon(string input)
        {
            if(input == null)
            {
                return _context.HoaDons.ToList();
            }
           
            return _context.HoaDons.Where(a=>a.IdHoaDon.ToString().Substring(a.IdHoaDon.ToString().Length - 10).Contains(input.ToLower())).ToList();
        }

        public bool UpdateHoaDon(Guid id, HoaDon hoaDon)
        {
            try
            {
                var updateHoaDon = _context.HoaDons.FirstOrDefault(a => a.IdHoaDon == id);

                updateHoaDon.IdNv = hoaDon.IdNv;
                updateHoaDon.IdKh = hoaDon.IdKh;
                updateHoaDon.IdVc = hoaDon.IdVc;
                updateHoaDon.NgayGd = hoaDon.NgayGd;
                updateHoaDon.TrangThai = hoaDon.TrangThai;

                _context.HoaDons.Update(updateHoaDon);
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
