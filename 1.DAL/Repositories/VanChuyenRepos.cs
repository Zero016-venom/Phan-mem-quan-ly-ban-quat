using _1.DAL.IRepositories;
using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class VanChuyenRepos : VanChuyen_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public VanChuyenRepos()
        {
            
        }

        public VanChuyenRepos(OnlyFansContext context)
        {
            _context = context;
        }

        public List<VanChuyen> GetVanChuyen()
        {
            return _context.VanChuyens.ToList();
        }
    }
}
