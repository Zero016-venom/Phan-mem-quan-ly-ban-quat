using _1.DAL.Model1s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class HoaDonService
    {
        HoaDonRepos _hoaDonRepos = new HoaDonRepos();

        public HoaDonService()
        {

        }

        public HoaDonService(HoaDonRepos hoaDonRepos)
        {
            _hoaDonRepos = hoaDonRepos;
        }

        public List<HoaDon> GetHoaDon(string inptut)
        {
            return _hoaDonRepos.GetHoaDon(inptut);
        }

        public bool AddHoaDon(HoaDon hoaDon)
        {       
            return _hoaDonRepos.CreateHoaDon(hoaDon);
        }

        public bool UpdateHoaDon(Guid id,HoaDon hoaDon)
        {
            return _hoaDonRepos.UpdateHoaDon(id,hoaDon);
        }
    }
}
