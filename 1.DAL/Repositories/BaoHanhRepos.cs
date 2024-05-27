using _1.DAL.IRepositories;
using _1.DAL.Model1s;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace _1.DAL.Repositories
{
    public class BaoHanhRepos : BaoHanh_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public BaoHanhRepos()
        {
            
        }

        public BaoHanhRepos(OnlyFansContext context)
        {
            _context = context;
        }

        public List<BaoHanh> GetBaoHanh(string input)
        {
            if (input == null)
            {
                return _context.BaoHanhs.ToList();
            }
            else
            {
                var BaoHanh1 = _context.BaoHanhs
                .Include(a => a.LichSuBaoHanhs)
                .ThenInclude(b => b.IdHoaDonCtNavigation)
                .Where(a => a.LichSuBaoHanhs.Any(b => b.IdHoaDonCtNavigation != null))
                .Where(a => a.LichSuBaoHanhs.Any(a => a.IdHoaDonCtNavigation.IdBienTheNavigation.MaBienThe.Contains(input)))
                .ToList();


                var BaoHanh2 = (from a in _context.BaoHanhs
                               join b in _context.LichSuBaoHanhs on a.IdBaoHanh equals b.IdBaoHanh
                               join c in _context.HoaDonCts on b.IdHoaDonCt equals c.IdHoaDonCt
                               where c.IdBienTheNavigation.MaBienThe.Contains(input)
                               select a).ToList();


                //return BaoHanh1;
                return BaoHanh2;
            }
        }

        public bool CreateBaoHanh(BaoHanh baoHanh)
        {
            try
            {
                _context.BaoHanhs.Add(baoHanh);
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
