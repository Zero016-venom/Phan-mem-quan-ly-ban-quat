using _1.DAL.Model1s;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class SanPhamRepos
    {
        private OnlyFansContext _onFansContext = new OnlyFansContext();
        public SanPhamRepos(OnlyFansContext onFansContext)
        {
            _onFansContext = onFansContext;
        }
        public SanPhamRepos()
        {

        }
        public bool CreateSanPham(SanPham SanPham)
        {
            try
            {
                var obj = _onFansContext.SanPhams.Add(SanPham);
                _onFansContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<SanPham> GetSanPham(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _onFansContext.SanPhams.ToList();
            }
            return _onFansContext.SanPhams.Where(x => x.Ten.ToLower().Contains(name.ToLower())).ToList();
        }

        public bool UpdateSanPham(SanPham SanPham)
        {
            try
            {
                var existingSanPham = _onFansContext.SanPhams.Find(SanPham.IdSanPham);
                if (existingSanPham != null)
                {
                    _onFansContext.Entry(existingSanPham).State = EntityState.Detached;
                    _onFansContext.Entry(SanPham).State = EntityState.Modified;
                    _onFansContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
