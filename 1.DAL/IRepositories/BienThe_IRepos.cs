using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface BienThe_IRepos
    {
        List<BienThe> GetBienThe(string name);
        bool CreateBienThe(BienThe BienThe);
        bool UpdateBienThe(BienThe BienThe);
    }
}
