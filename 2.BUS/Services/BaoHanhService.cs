using _1.DAL.Model1s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class BaoHanhService
    {
        BaoHanhRepos _repos = new BaoHanhRepos();
        public BaoHanhService()
        {
            
        }

        public BaoHanhService(BaoHanhRepos repos)
        {
            _repos = repos;
        }

        public List<BaoHanh> GetBaoHanh(string input)
        {
            return _repos.GetBaoHanh(input);
        }

        public bool AddBaoHanh (Guid idBh, Guid idNv)
        {
            var baoHanh = new BaoHanh()
            {
                IdBaoHanh = idBh,
                IdNv = idNv
            };

            return _repos.CreateBaoHanh(baoHanh);
        }
    }
}
