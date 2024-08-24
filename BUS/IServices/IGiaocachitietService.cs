using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IGiaocachitietService
    {
        public List<Giaocanhanvien> giaocanhanviens(string search);
        public List<Giaoca> GetGiaocas(string search);
        public List<Taikhoan> GetTaikhoans(string search);
        public string AddCaCT(Giaocanhanvien cact);
        public string UpdateCaCT(Giaocanhanvien cact);
        public string HuyCaCT(Giaocanhanvien cact);
    }
}
