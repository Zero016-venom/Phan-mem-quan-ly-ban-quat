using _1.DAL.IRepositories;
using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class PtttRepos : PTTT_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public PtttRepos()
        {

        }

        public PtttRepos(OnlyFansContext context)
        {
            _context = context;
        }

        public List<Pttt> GetPTTT()
        {
            return _context.Pttts.ToList();
        }

        public bool CreatePTTT(Pttt pttt)
        {
            try
            {
                _context.Pttts.Add(pttt);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdatePTTT(Guid id, Pttt pttt)
        {
            try
            {
                var updatePttt = _context.Pttts.FirstOrDefault(a => a.IdPttt == id);

                updatePttt.Ten = pttt.Ten;

                _context.Pttts.Update(updatePttt);
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
