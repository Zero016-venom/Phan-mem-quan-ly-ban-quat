using _1.DAL.Model1s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class MauSacService
    {
        private MauSacRepos _repos = new MauSacRepos();
        public MauSacService()
        {

        }
        public MauSacService(MauSacRepos repos)
        {
            _repos = repos;
        }

        public List<Mau> GetMau(string name)
        {
            return _repos.GetMau(name);
        }
        public bool CreateMau(Mau Mau)
        {
            var obj = new Mau()
            {
                IdMau = Mau.IdMau,
                TenMau = Mau.TenMau,
            };
            return _repos.CreateMau(obj);
        }
        public bool UpdateMau(Mau Mau)
        {
            var obj = new Mau()
            {
                IdMau = Mau.IdMau,
                TenMau = Mau.TenMau,
            };
            return _repos.UpdateMau(obj);
        }
    }
}
