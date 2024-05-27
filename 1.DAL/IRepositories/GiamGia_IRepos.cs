using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface GiamGia_IRepos
    {
        List<GiamGium> GetGiamGia(string input);

        bool CreateGiamGia(GiamGium giamGia);

        bool UpdateGiamGia(GiamGium giamGia);
    }
}
