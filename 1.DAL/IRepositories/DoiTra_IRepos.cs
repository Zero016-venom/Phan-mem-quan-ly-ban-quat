using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface DoiTra_IRepos
    {
        List<DoiTra> GetDoiTra(string input);

        bool CreateDoiTra(DoiTra doiTra);


    }
}
