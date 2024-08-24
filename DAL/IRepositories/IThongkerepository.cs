using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using System.Collections.Generic;

namespace DAL.IRepositories
{
    public interface IThongkerepository
    {
        List<Hoadonchitet_hoadon_giay> GetHD(string type);
        List<Taikhoan> GetTaikhoans();
        List<Hoadonchitiet> GetHoadonchitiets();
        List <Hoadon> GetHoadons();
        List< Giaychitiet> GetGiaychitiets();
        List<Giay> GetGiays();
    }
}
