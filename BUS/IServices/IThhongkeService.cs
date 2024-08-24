using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IThhongkeService
    {
        List<Hoadonchitet_hoadon_giay> GetHD(string type);
        List<Taikhoan> GetTaikhoans();
        List<Hoadonchitiet> GetHoadonchitiets();
        List<Hoadon> GetHoadons();
        List<Giaychitiet> GetGiaychitiets();
        List<Giay> GetGiays();
    }
}
