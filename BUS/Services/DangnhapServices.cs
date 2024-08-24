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
    public class DangnhapServices : IDangnhapServices
    {
        DangnhapRepository _repos;
        public DangnhapServices()
        {
            _repos = new DangnhapRepository();
        }

        public List<Taikhoan> GetAll()
        {
          return _repos.GetAll();
        }

        public bool ValidateUser(string username, string password, out int? role)
        {
            return _repos.ValidateUser(username, password, out role);
        }
    }
}
