using _1.DAL.Model1s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class NhanVienService
    {
        NhanVienRepos _repos = new NhanVienRepos();
        public NhanVienService()
        {
            
        }

        public NhanVienService(NhanVienRepos repos)
        {
            _repos = repos;
        }
        public List<NhanVien> GetNhanVien(string input)
        {
            return _repos.GetNV(input).ToList();
        }
        public bool AddNhanVien(string ten, string sdt, string diaChi, DateTime ngaySinh, bool gioiTinh, bool trangThai)
        {
            var nv = new NhanVien
            {
                Ten = ten,
                Sdt = sdt,
                DiaChi = diaChi,
                NgaySinh = ngaySinh,
                GioiTinh = gioiTinh,
                TrangThai = trangThai
            };
            return _repos.CreateNhanVien(nv);
        }
        public bool UpdateNV(Guid id, string ten, string sdt, string diaChi, DateTime ngaySinh, bool gioiTinh, bool trangThai)
        {
            var nv = new NhanVien
            {
                IdNv = id,
                Ten = ten,
                Sdt = sdt,
                DiaChi = diaChi,
                NgaySinh = ngaySinh,
                GioiTinh = gioiTinh,
                TrangThai = trangThai
            };
            try
            {
                return _repos.UpdateNhanVien(nv);
            }
            catch 
            {
                return _repos.UpdateNhanVien(nv);
            }
        }
    }
}
