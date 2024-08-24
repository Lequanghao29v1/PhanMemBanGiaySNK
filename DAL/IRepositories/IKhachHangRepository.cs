using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IKhachHangRepository
    {
        public List<Khachhang> GetAllKhachhang(string search);
        public List<Hoadon> GetAllHoadon();
        public List<Hinhthucthanhtoan> GetHinhthucthanhtoans();
        public bool AddKhachHang(Khachhang khachhang);
        public bool UpdateKhachHang(Khachhang khachhang);

    }
}
