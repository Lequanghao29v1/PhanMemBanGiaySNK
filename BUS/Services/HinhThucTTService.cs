using BUS.IServices;
using DAL.Models.DomainClass;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HinhThucTTService : IHinhThucTTService
    {
        HinhthucTTRepository _repos;
        public HinhThucTTService()
        {
            _repos = new HinhthucTTRepository();
        }
        public string AddHTTT(Hinhthucthanhtoan ht)
        {
            try
            {
                _repos.AddHTTT(ht);
                return "Thêm thành công";
            }
            catch (Exception)
            {

                return "Thêm thất bại";
            }
        }

        public List<Hinhthucthanhtoan> GetHinhthucTT(string search)
        {
            return _repos.GetHinhthucTT(search);
        }

        public string UpdateHTTT(Hinhthucthanhtoan ht)
        {
            var coler = _repos.GetHinhthucTT(null).FirstOrDefault(x => x.Mahinhthucthanhtoan == ht.Mahinhthucthanhtoan);
            try
            {
                if (coler != null)
                {
                    coler.Tenhinhthuc = ht.Tenhinhthuc;
                    coler.Mota = ht.Mota;
                    _repos.UpdateHTTT(coler);
                    return "Sửa thành công";
                }
                else
                {
                    return "Sửa thất bại";
                }
            }
            catch (Exception)
            {

                return "Có lỗi xảy ra";
            }
            
        }
    }
}
