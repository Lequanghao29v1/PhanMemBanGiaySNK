using DAL.Models.Context;
using DAL.Models.DomainClass;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IHoadonRepository_Chuan
    {
        public List<Hoadon> GetHoadons();
        public List<Hoadonchitiet> GetHoadonchitiets();
        public List<Taikhoan> GetTaikhoans();
        public List<Hinhthucthanhtoan> GetHinhthucthanhtoans();
        public List<Uudai> GetUudais();
        public List<Khachhang> GetKhachhangs();
        public List<Giay> GetGiays();
        public List<Giaychitiet> GetGiaychitiets();
        
    }
}
