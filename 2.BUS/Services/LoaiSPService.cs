using _1.DAL.Model1s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class LoaiSPService
    {
        private LoaiSPRepos _repos = new LoaiSPRepos();
        public LoaiSPService()
        {

        }
        public LoaiSPService(LoaiSPRepos repos)
        {
            _repos = repos;
        }


        public List<LoaiSanPham> GetLoaiSanPham(string name)
        {
            return _repos.GetLoaiSanPham(name);
        }
        public bool CreateLoaiSanPham(LoaiSanPham LoaiSanPham)
        {
            var obj = new LoaiSanPham()
            {
                IdLoaiSanPham = LoaiSanPham.IdLoaiSanPham,
                TenLoai = LoaiSanPham.TenLoai,
                MoTa = LoaiSanPham.MoTa,
            };
            return _repos.CreateLoaiSanPham(obj);
        }
        public bool UpdateLoaiSanPham(LoaiSanPham LoaiSanPham)
        {
            var obj = new LoaiSanPham()
            {
                IdLoaiSanPham = LoaiSanPham.IdLoaiSanPham,
                TenLoai = LoaiSanPham.TenLoai,
                MoTa = LoaiSanPham.MoTa,
            };
            return _repos.UpdateLoaiSanPham(obj);
        }
    }
}
