using _1.DAL.Model1s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class KhachHangService
    {
        KhachHangRepos _khachRepos = new KhachHangRepos();
        public KhachHangService()
        {
            
        }

        public KhachHangService(KhachHangRepos khachRepos)
        {
            _khachRepos = khachRepos;
        }
        public List<KhachHang> GetKhach(string input)
        {
            return _khachRepos.GetKhach(input).ToList();
        }
        public bool AddKhach(string ten, DateTime ngaySinh, string sdt, string email, bool gioiTinh, string diaChi)
        {
            var khachHang = new KhachHang
            {
                TenKh = ten,
                NgaySinh = ngaySinh,
                Sdt = sdt,
                Email = email,
                GioiTinh = gioiTinh,
                DiaChi = diaChi
            };
            return _khachRepos.CreateKhach(khachHang);
        }
        public bool UpdateKhach(Guid id, string ten, DateTime ngaySinh, string sdt, string email, bool gioiTinh, string diaChi)
        {
            var khachHang = new KhachHang
            {
                IdKh = id,
                TenKh = ten,
                NgaySinh = ngaySinh,
                Sdt = sdt,
                Email = email,
                GioiTinh = gioiTinh,
                DiaChi = diaChi
            };
            try
            {
                return _khachRepos.UpdateKhach(khachHang);
            }
            catch
            {
                return _khachRepos.UpdateKhach(khachHang);
            }
        }
    }
}
