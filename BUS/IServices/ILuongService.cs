using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ILuongService
    {
        public List<Bangluong> bangluongs(string search);
        public List<Giaocanhanvien> giaocanhanvien();
        public List<Taikhoan> taikhoans();
        public string AddLuong(Bangluong bangluong);
        public string UdateLuong(Bangluong bangluong);
        public string Huybangluong(Bangluong bangluong);
    }
}
