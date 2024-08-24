using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface ILuongRepository
    {
        public List<Bangluong> bangluongs(string search);
        public List<Giaocanhanvien> giaocanhanvien();
        public List<Taikhoan> taikhoans();
        public bool AddLuong(Bangluong bangluong);
        public bool UdateLuong(Bangluong bangluong);
        public bool Huybangluong(Bangluong bangluong);
    }
}
