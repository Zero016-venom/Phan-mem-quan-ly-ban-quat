using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface HoaDonCT_IRepos
    {
        List<HoaDonCt> GetHoaDonCts(string input);

        bool CreateHoaDonCT(HoaDonCt hoaDonCt);

        bool UpdateHoaDonCT(Guid id, HoaDonCt hoaDonCt);

        bool DeleteHoaDonCT(Guid id);
    }
}
