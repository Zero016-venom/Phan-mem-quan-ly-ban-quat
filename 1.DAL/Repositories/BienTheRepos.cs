using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class BienTheRepos
    {
        private OnlyFansContext _onFansContext = new OnlyFansContext();
        public BienTheRepos(OnlyFansContext onFansContext)
        {
            _onFansContext = onFansContext;
        }
        public BienTheRepos()
        {

        }
        public bool CreateBienThe(BienThe BienThe)
        {
            try
            {
                _onFansContext.BienThes.Add(BienThe);
                _onFansContext.SaveChanges();
                return true;
            }
            catch 
            {
                   return false;
            }
           
        }

        public List<BienThe> GetBienThe(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _onFansContext.BienThes.ToList();
            }
            return _onFansContext.BienThes.Where(x => x.MaBienThe.ToLower().Contains(name.ToLower())).ToList();
        }

        public bool UpdateBienThe(BienThe BienThe)
        {
            try
            {
                var existingBienThe = _onFansContext.BienThes.Find(BienThe.IdBienThe);
                if (existingBienThe != null)
                {
                    _onFansContext.Entry(existingBienThe).CurrentValues.SetValues(BienThe);
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
