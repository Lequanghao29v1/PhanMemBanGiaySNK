using BUS.IServices;
using DAL.Models.DomainClass;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class LuongService : ILuongService
    {
        LuongRepository _repos;
        public LuongService()
        {
            _repos = new LuongRepository();
        }

        public string AddLuong(Bangluong bangluong)
        {
            try
            {
                _repos.AddLuong(bangluong);
                return "Thêm thành công";
            }
            catch (Exception)
            {

                return "Thêm thất bại";
            }
        }

        public List<Bangluong> bangluongs(string search)
        {
          return  _repos.bangluongs(search);
        }

        public List<Giaocanhanvien> giaocanhanvien()
        {
            return _repos.giaocanhanvien();
        }

        public string Huybangluong(Bangluong bangluong)
        {
            throw new NotImplementedException();
        }

        public List<Taikhoan> taikhoans()
        {
            return _repos.taikhoans();
        }
        
        public string UdateLuong(Bangluong bangluong)
        {
            var coler = _repos.bangluongs(null).FirstOrDefault(x => x.Maluong == bangluong.Maluong);
            try
            {
                if(coler != null)
                {
                    coler.Thanglam = bangluong.Thanglam;
                    coler.Luongcoban = bangluong.Luongcoban;
                    coler.Tienthuong = bangluong.Tienthuong;
                    coler.Tienkhautru = bangluong.Tienkhautru;
                    coler.Tongthunhap = bangluong.Tongthunhap;
                    coler.Mataikhoan = bangluong.Mataikhoan;
                    _repos.UdateLuong(coler);
                    return "Sửa thành công";
                }
                else
                {
                    return "Sửa thất bại";
                }
            }
            catch (Exception)
            {
                return "Có lỗi xảy ra";
            }
        }
    }
}
