using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface NhanVien_IRepos
    {
        List<NhanVien> GetNV(string input);
        bool CreateNhanVien(NhanVien nhanVien);
        bool UpdateNhanVien(NhanVien nhanVien);
    }
}
