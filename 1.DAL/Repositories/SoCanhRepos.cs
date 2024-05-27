using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class SoCanhRepos
    {
        private OnlyFansContext _onFansContext = new OnlyFansContext();
        public SoCanhRepos(OnlyFansContext onFansContext)
        {
            _onFansContext = onFansContext;
        }
        public SoCanhRepos()
        {

        }
        public bool CreateSoCanh(SoCanh SoCanh)
        {
            try
            {
                var obj = _onFansContext.SoCanhs.Add(SoCanh);
                _onFansContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<SoCanh> GetSoCanh(int? name)
        {
            if (name == null)
            {
                return _onFansContext.SoCanhs.ToList();
            }
            return _onFansContext.SoCanhs.Where(x => x.SoCanh1 == name).ToList();
        }

        public bool UpdateSoCanh(SoCanh SoCanh)
        {

            try
            {
                var obj = _onFansContext.SoCanhs.Find(SoCanh.IdCanh);
                if (obj != null)
                {
                    _onFansContext.Entry(obj).CurrentValues.SetValues(SoCanh);
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
