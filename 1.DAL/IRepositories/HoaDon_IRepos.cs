using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface HoaDon_IRepos
    {
        List<HoaDon> GetHoaDon(string input);

        bool CreateHoaDon(HoaDon hoaDon);

        bool UpdateHoaDon(Guid id,HoaDon hoaDon);
    }
}
