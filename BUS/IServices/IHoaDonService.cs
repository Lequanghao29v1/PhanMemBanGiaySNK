using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IHoaDonService
    {
        public List<HoaDon_Model> GetAll(string? txtTimKiem, string? searchType);
        public Hoadon GetByID(int id);
        public bool Them(Hoadon hoadon);
        public bool Sua(int id, Hoadon hoadon);
        public bool Xoa(int id);
        public List<Hinhthucthanhtoan> GetHinhthucthanhtoans();
        public List<Giaychitiet> GetGiaychitiets();
        public List<Hoadonchitiet> GetHoadonchitiets();
        public List<Hoadon> GetHoadons(string search);
        public List<Taikhoan> GetTaikhoans();
        public List<Uudai> GetUudais();
        public List<Khachhang> GetKhachhangs();
        public List<Giay> GetGiays();
        public List<HoaDonNhe> hoaDonNhes(string searchText, string searchType);

    }
}
