using BUS.IServices;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ThhongkeService : IThhongkeService
    {
        Thongkerepository _repos;
        public ThhongkeService()
        {
            _repos = new Thongkerepository();
        }

        public List<Giaychitiet> GetGiaychitiets()
        {
         return  _repos.GetGiaychitiets();
        }

        public List<Giay> GetGiays()
        {
            return _repos.GetGiays();
        }

        public List<Hoadonchitet_hoadon_giay> GetHD(string type)
        {
           return _repos.GetHD(type);
        }

        public List<Hoadonchitiet> GetHoadonchitiets()
        {
           return _repos.GetHoadonchitiets();
        }

        public List<Hoadon> GetHoadons()
        {
           return _repos.GetHoadons();
        }

        public List<Taikhoan> GetTaikhoans()
        {
           return _repos.GetTaikhoans();
        }
    }
}
