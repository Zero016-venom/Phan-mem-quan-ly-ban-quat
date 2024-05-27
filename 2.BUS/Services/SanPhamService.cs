using _1.DAL.Model1s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class SanPhamService
    {
        private SanPhamRepos _repos = new SanPhamRepos();
        public SanPhamService()
        {

        }
        public SanPhamService(SanPhamRepos repos)
        {
            _repos = repos;
        }

        public List<SanPham> GetSanPham(string name)
        {
            return _repos.GetSanPham(name);
        }
        public bool CreateSanPham(SanPham SanPham)
        {
            var obj = new SanPham()
            {
                IdLoaiSanPham = SanPham.IdLoaiSanPham,
                MaSanPham = SanPham.MaSanPham,
                Ten = SanPham.Ten,
                SoLuong = SanPham.SoLuong,
                IdSanPham = SanPham.IdSanPham
            };
            return _repos.CreateSanPham(obj);
        }
        public bool UpdateSanPham(SanPham SanPham)
        {
            var obj = new SanPham()
            {
                IdLoaiSanPham = SanPham.IdLoaiSanPham,
                MaSanPham = SanPham.MaSanPham,
                Ten = SanPham.Ten,
                SoLuong = SanPham.SoLuong,
                IdSanPham = SanPham.IdSanPham
            };
            return _repos.UpdateSanPham(obj);
        }
    }
}
