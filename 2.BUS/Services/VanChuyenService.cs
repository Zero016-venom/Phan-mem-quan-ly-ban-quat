using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class VanChuyenService
    {
        OnlyFansContext _context = new OnlyFansContext();
        public VanChuyenService()
        {
            
        }

        public VanChuyenService(OnlyFansContext context)
        {
            _context = context;
        }

        public List<VanChuyen> GetVanChuyen()
        {
            return _context.VanChuyens.ToList();
        }
    }
}
