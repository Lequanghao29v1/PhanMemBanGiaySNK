using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IUudaiService
    {
        public List<Uudai> GetUudais(string search);
        public List<Taikhoan> GetTaikhoan();
        public string AddUudai(Uudai uudai);
        public string Updateuudai(Uudai uudai);
        public string Trangthai(Uudai uudai);
        public Uudai GetUudai_InTime();

    }
}
