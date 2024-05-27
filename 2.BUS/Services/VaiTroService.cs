using _1.DAL.Model1s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class VaiTroService
    {
        VaiTroRepos rpos = new VaiTroRepos();
        public VaiTroService()
        {

        }

        public VaiTroService(VaiTroRepos context)
        {
            rpos = context;
        }

        public List<VaiTro> GetVaiTros()
        {
            return rpos.GetVaiTros().ToList();
        }
    }
}
