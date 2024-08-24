using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface INhanVienRepository
    {
        public List<Taikhoan> GetTaikhoan(string search);
        public List<Chucvu> GetChucvu();
        public bool AddNhanVien(Taikhoan taikhoan);
        public bool UpdateNhanVien(Taikhoan taikhoan);
        public bool Khoa_Mokhoa(Taikhoan taikhoan);
    }
}
