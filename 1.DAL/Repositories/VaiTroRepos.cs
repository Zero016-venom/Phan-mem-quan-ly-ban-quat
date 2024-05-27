using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class VaiTroRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public VaiTroRepos()
        {

        }

        public VaiTroRepos(OnlyFansContext context)
        {
            _context = context;
        }

        public List<VaiTro> GetVaiTros()
        {
            return _context.VaiTros.ToList();
        }
    }
}
