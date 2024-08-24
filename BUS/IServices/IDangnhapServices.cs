using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IDangnhapServices
    {
        public List<Taikhoan> GetAll();
        public bool ValidateUser(string username, string password, out int? role);
    }
}
