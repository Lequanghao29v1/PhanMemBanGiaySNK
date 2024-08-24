using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IHinhThucTTService
    {
        public List<Hinhthucthanhtoan> GetHinhthucTT(string search);
        public string AddHTTT(Hinhthucthanhtoan ht);
        public string UpdateHTTT(Hinhthucthanhtoan ht);
    }
}
