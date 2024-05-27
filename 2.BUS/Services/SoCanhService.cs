using _1.DAL.Model1s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class SoCanhService
    {
        private SoCanhRepos _repos = new SoCanhRepos();
        public SoCanhService()
        {

        }
        public SoCanhService(SoCanhRepos repos)
        {
            _repos = repos;
        }

        public List<SoCanh> GetSoCanh(int? name)
        {
            return _repos.GetSoCanh(name);
        }
        public bool CreateSoCanh(SoCanh SoCanh)
        {
            var obj = new SoCanh()
            {
                IdCanh = SoCanh.IdCanh,
                SoCanh1 = SoCanh.SoCanh1,
            };
            return _repos.CreateSoCanh(obj);
        }
    }
}
