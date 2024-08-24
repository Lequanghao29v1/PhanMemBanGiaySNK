using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IGiaocachitietRepository
    {
        public List<Giaocanhanvien> giaocanhanviens(string search);
        public List<Giaoca> GetGiaocas(string searchs);
        public List<Taikhoan> GetTaikhoans(string searchss);
        public bool AddCaCT(Giaocanhanvien cact);
        public bool UpdateCaCT(Giaocanhanvien cact);
        public bool HuyCaCT(Giaocanhanvien cact);
    }
}
