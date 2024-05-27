using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface MauSac_IRepos
    {
        List<Mau> GetMau(string name);
        bool CreateMau(Mau Mau);
        bool UpdateMau(Mau Mau);
    }
}
