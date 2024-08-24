using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IKhachHangService
    {
        public List<Khachhang> GetAllKhachhang(string search);
        public List<Hinhthucthanhtoan> GetHinhthucthanhtoans();
        public List<Hoadon> GetAllHoadon();
        public string AddKhachHang(Khachhang khachhang);
        public string UpdateKhachHang(Khachhang khachhang);
        public string Khoa_MoKhoa(Khachhang khachhang);

    }
}
