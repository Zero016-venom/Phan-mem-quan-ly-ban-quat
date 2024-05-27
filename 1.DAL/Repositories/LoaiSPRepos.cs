using _1.DAL.IRepositories;
using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class LoaiSPRepos : LoaiSP_IRepos
    {
        private OnlyFansContext _onFansContext = new OnlyFansContext();
        public LoaiSPRepos(OnlyFansContext onFansContext)
        {
            _onFansContext = onFansContext;
        }
        public LoaiSPRepos()
        {

        }
        public bool CreateLoaiSanPham(LoaiSanPham LoaiSanPham)
        {
            try
            {
                var obj = _onFansContext.LoaiSanPhams.Add(LoaiSanPham);
                _onFansContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<LoaiSanPham> GetLoaiSanPham(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _onFansContext.LoaiSanPhams.ToList();
            }
            return _onFansContext.LoaiSanPhams.Where(x => x.TenLoai.ToLower().Contains(name.ToLower())).ToList();
        }

        public bool UpdateLoaiSanPham(LoaiSanPham LoaiSanPham)
        {
            try
            {
                var obj = _onFansContext.LoaiSanPhams.Find(LoaiSanPham.IdLoaiSanPham);
                if(obj != null)
                {
                    _onFansContext.Entry(obj).CurrentValues.SetValues(LoaiSanPham);
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
