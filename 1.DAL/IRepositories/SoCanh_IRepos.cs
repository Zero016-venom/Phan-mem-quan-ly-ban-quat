using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface SoCanh_IRepos
    {
        List<SoCanh> GetSoCanh(int name);
        bool CreateSoCanh(SoCanh SoCanh);
        bool UpdateSoCanh(SoCanh SoCanh);
    }
}
