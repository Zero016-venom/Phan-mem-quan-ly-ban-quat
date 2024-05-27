using _1.DAL.IRepositories;
using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class TaiKhoanRepos : TaiKhoan_IRepos
    {
        OnlyFansContext _context = new OnlyFansContext();
        public TaiKhoanRepos()
        {

        }

        public TaiKhoanRepos(OnlyFansContext context)
        {
            _context = context;
        }

        public List<TaiKhoan> GetKhoans()
        {
            return _context.TaiKhoans.ToList();
        }
    }
}

