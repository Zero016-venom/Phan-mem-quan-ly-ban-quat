using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface KhachHang_IRepos
    {
        List<KhachHang> GetKhach(string input);
        bool CreateKhach(KhachHang khach);
        bool UpdateKhach(KhachHang khach);
    }
}
