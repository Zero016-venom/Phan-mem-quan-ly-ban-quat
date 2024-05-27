using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface SanPham_IRepos
    {
        List<SanPham> GetSanPham(string name);
        bool CreateSanPham(SanPham SanPham);
        bool UpdateSanPham(SanPham SanPham);
    }
}
