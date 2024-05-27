using _1.DAL.IRepositories;
using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HoaDonCTRepos : HoaDonCT_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public HoaDonCTRepos()
        {

        }

        public HoaDonCTRepos(OnlyFansContext context)
        {
            _context = context;
        }

        public bool CreateHoaDonCT(HoaDonCt hoaDonCt)
        {
            try
            {
                _context.HoaDonCts.Add(hoaDonCt);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }      

        public List<HoaDonCt> GetHoaDonCts(string input)
        {
            if (input == null)
            {
                return _context.HoaDonCts.ToList();
            }

            return _context.HoaDonCts.Where(a => a.IdHoaDon.ToString().Substring(a.IdHoaDon.ToString().Length - 10).Contains(input.ToLower())).ToList();

        }

        public bool UpdateHoaDonCT(Guid id, HoaDonCt hoaDonCt)
        {
            try
            {
                var updateHoaDonCT = _context.HoaDonCts.FirstOrDefault(a=>a.IdHoaDonCt == id);

                updateHoaDonCT.IdBienThe = hoaDonCt.IdBienThe;
                updateHoaDonCT.IdGiamGia = hoaDonCt.IdGiamGia;
                updateHoaDonCT.SoLuong = hoaDonCt.SoLuong;
                updateHoaDonCT.Gia = hoaDonCt.Gia;
                updateHoaDonCT.IdHoaDon = hoaDonCt.IdHoaDon;

                _context.HoaDonCts.Update(updateHoaDonCT);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteHoaDonCT(Guid id)
        {
            var result = _context.HoaDonCts.FirstOrDefault(a => a.IdHoaDonCt == id);
            if (result == null)
                return false;

            _context.Remove(result);
            _context.SaveChanges();
            return true;
        }
    }
}
