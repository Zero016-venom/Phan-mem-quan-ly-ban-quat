using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface LoaiSP_IRepos
    {
        List<LoaiSanPham> GetLoaiSanPham(string name);
        bool CreateLoaiSanPham(LoaiSanPham LoaiSanPham);
        bool UpdateLoaiSanPham(LoaiSanPham LoaiSanPham);
    }
}
