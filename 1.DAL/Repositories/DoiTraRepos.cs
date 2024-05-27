using _1.DAL.IRepositories;
using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class DoiTraRepos : DoiTra_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public DoiTraRepos()
        {
            
        }

        public DoiTraRepos(OnlyFansContext context)
        {
            _context = context;
        }

        public List<DoiTra> GetDoiTra(string input)
        {
            if(input == null)
            {
                return _context.DoiTras.ToList();
            }
            else
            {
                var DoiTra1 = from a in _context.DoiTras
                              join b in _context.LichSuDoiTras on a.IdDoiTra equals b.IdDoiTra
                              where b.IdDoiTraNavigation.IdDoiTra.Equals(Guid.Parse(input))
                              select a;

                return DoiTra1.ToList();
            }
        }

        public bool CreateDoiTra(DoiTra doiTra)
        {
            try
            {
                _context.DoiTras.Add(doiTra);
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
