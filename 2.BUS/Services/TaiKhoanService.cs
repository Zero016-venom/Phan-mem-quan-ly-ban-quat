using _1.DAL.Model1s;
using _1.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class TaiKhoanService 
    {
        TaiKhoanRepos _context = new TaiKhoanRepos();
        public TaiKhoanService()
        {

        }

        public TaiKhoanService(TaiKhoanRepos context)
        {
            _context = context;
        }

        public List<TaiKhoan> GetKhoans()
        {
            return _context.GetKhoans().ToList();
        }
    }
}
