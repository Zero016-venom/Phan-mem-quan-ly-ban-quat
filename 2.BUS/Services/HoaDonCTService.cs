using _1.DAL.Model1s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class HoaDonCTService
    {
        HoaDonCTRepos _hoaDonCTRepos = new HoaDonCTRepos();
        public HoaDonCTService()
        {

        }

        public HoaDonCTService(HoaDonCTRepos hoaDonRepos)
        {
            _hoaDonCTRepos = hoaDonRepos;
        }

        public List<HoaDonCt> GetHoaDonCts(string input)
        {
            return _hoaDonCTRepos.GetHoaDonCts(input);
        }

        public bool AddHoaDonCT(HoaDonCt hoaDonCt)
        {           
            return _hoaDonCTRepos.CreateHoaDonCT(hoaDonCt);
        }

        public bool UpdateHoaDonCT(Guid id, HoaDonCt hoaDonCt)
        {
            return _hoaDonCTRepos.UpdateHoaDonCT(id, hoaDonCt);
        }

        public bool DeleteHoaDonCT(Guid id)
        {
            return _hoaDonCTRepos.DeleteHoaDonCT(id);
        }
    }
}
