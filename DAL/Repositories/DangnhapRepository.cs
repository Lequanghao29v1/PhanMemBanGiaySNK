using DAL.IRepositories;
using DAL.Models.Context;
using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DangnhapRepository : IDangnhapRepository
    {
        DBContext dbContext;
        public DangnhapRepository()
        {
            dbContext = new DBContext();
        }

        public List<Taikhoan> GetAll()
        {
           return dbContext.Taikhoans.ToList();
        }

        public bool ValidateUser(string username, string password, out int? role)
        {
            Taikhoan taikhoan = dbContext.Taikhoans.FirstOrDefault(u => u.Username == username && u.Pasword == password);

            if (taikhoan != null)
            {
               
                role = taikhoan.Machucvu; 
            }
            else
            {
                role = 0;
            }

            return taikhoan != null;
        }
    }
}
