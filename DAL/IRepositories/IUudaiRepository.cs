using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IUudaiRepository
    {
        public List<Uudai> GetUudais(string search);
        public List<Taikhoan> GetTaikhoan();
        public bool AddUudai(Uudai uudai);
        public bool Updateuudai(Uudai uudai);
        public bool Trangthai(Uudai uudai);
        public Uudai GetUudai_InTime();

    }
}
