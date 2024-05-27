using _1.DAL.IRepositories;
using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class LichSuttRepos : LichSutt_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public LichSuttRepos()
        {

        }

        public LichSuttRepos(OnlyFansContext context)
        {
            _context = context;
        }

        public List<LichSuTt> GetLichSuTt(string input)
        {
            if (input == null)
                return _context.LichSuTts.ToList();

            return _context.LichSuTts.Where(a => a.IdHoaDon.ToString().Substring(a.IdHoaDon.ToString().Length - 10).Contains(input.ToLower())).ToList();
        }

        public bool CreateLSTT(LichSuTt lichSuTt)
        {
            try
            {
                _context.LichSuTts.Add(lichSuTt);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }           

        public bool UpdateLSTT(Guid id, LichSuTt lichSuTt)
        {
            try
            {
                var updateLstt = _context.LichSuTts.FirstOrDefault(a => a.IdHoaDon == id);

                updateLstt.IdPttt = lichSuTt.IdPttt;
                updateLstt.IdHoaDon = lichSuTt.IdHoaDon;
                updateLstt.Ngay = lichSuTt.Ngay;              
                updateLstt.TongTien = lichSuTt.TongTien;

                _context.LichSuTts.Update(updateLstt);
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
