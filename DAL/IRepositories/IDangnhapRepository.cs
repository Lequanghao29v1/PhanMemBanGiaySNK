using DAL.Models.Context;
using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IDangnhapRepository
    {
        public List<Taikhoan> GetAll();
        public bool ValidateUser(string username, string password, out int? role);
    }
}
