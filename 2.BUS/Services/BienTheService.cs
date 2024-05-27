using _1.DAL.Model1s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class BienTheService
    {
        private BienTheRepos _repos = new BienTheRepos();
        public BienTheService()
        {

        }
        public BienTheService(BienTheRepos repos)
        {
            _repos = repos;
        }

        public List<BienThe> GetBienThe(string name)
        {
            return _repos.GetBienThe(name);
        }
        public bool CreateBienThe(BienThe BienThe)
        {
            var obj = new BienThe()
            {
                IdBienThe = BienThe.IdBienThe,
                MaBienThe = BienThe.MaBienThe,
                GiaTien = BienThe.GiaTien,
                TgbaoHanh = BienThe.TgbaoHanh,
                CongSuat = BienThe.CongSuat,
                SoLuong = BienThe.SoLuong,
                ChieuCao = BienThe.ChieuCao,
                BanKinh = BienThe.BanKinh,
                HinhAnh = BienThe.HinhAnh,
                IdChatLieu = BienThe.IdChatLieu,
                IdMau = BienThe.IdMau,
                IdCanh = BienThe.IdCanh,
                IdSanPham = BienThe.IdSanPham,
            };
            return _repos.CreateBienThe(obj);
        }
        public bool UpdateBienThe(BienThe BienThe)
        {
            var obj = new BienThe()
            {
                IdBienThe = BienThe.IdBienThe,
                MaBienThe = BienThe.MaBienThe,
                GiaTien = BienThe.GiaTien,
                TgbaoHanh = BienThe.TgbaoHanh,
                CongSuat = BienThe.CongSuat,
                SoLuong = BienThe.SoLuong,
                ChieuCao = BienThe.ChieuCao,
                BanKinh = BienThe.BanKinh,
                HinhAnh = BienThe.HinhAnh,
                IdChatLieu = BienThe.IdChatLieu,
                IdMau = BienThe.IdMau,
                IdCanh = BienThe.IdCanh,
                IdSanPham = BienThe.IdSanPham,
            };
            return _repos.UpdateBienThe(obj);
        }
    }
}
