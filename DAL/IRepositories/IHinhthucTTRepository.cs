using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IHinhthucTTRepository
    {
        public List<Hinhthucthanhtoan> GetHinhthucTT(string search);
        public bool AddHTTT(Hinhthucthanhtoan ht);
        public bool UpdateHTTT(Hinhthucthanhtoan ht);

    }
}
