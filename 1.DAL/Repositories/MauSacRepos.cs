using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class MauSacRepos
    {
        private OnlyFansContext _onFansContext = new OnlyFansContext();
        public MauSacRepos(OnlyFansContext onFansContext)
        {
            _onFansContext = onFansContext;
        }
        public MauSacRepos()
        {

        }
        public bool CreateMau(Mau Mau)
        {
            try
            {
                var obj = _onFansContext.Maus.Add(Mau);
                _onFansContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Mau> GetMau(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _onFansContext.Maus.ToList();
            }
            return _onFansContext.Maus.Where(x => x.TenMau.ToLower().Contains(name.ToLower())).ToList();
        }

        public bool UpdateMau(Mau Mau)
        {
            try
            {
                var obj = _onFansContext.Maus.Find(Mau.IdMau);
                if(obj != null)
                {
                    _onFansContext.Entry(Mau).CurrentValues.SetValues(Mau);
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
