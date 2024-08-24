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
    public class NhanVienRepository : INhanVienRepository
    {
        DBContext dbContext;
        public NhanVienRepository()
        {
            dbContext = new DBContext();
        }
        public bool AddNhanVien(Taikhoan taikhoan)
        {
            dbContext.Add(taikhoan);
            dbContext.SaveChanges();
            return true;
        }

        public List<Chucvu> GetChucvu()
        {
            return dbContext.Chucvus.ToList();
        }

        public List<Taikhoan> GetTaikhoan(string search)
        {
            if (search == null)
            {
                return dbContext.Taikhoans.ToList();
            }
            else
            {
                return dbContext.Taikhoans.Where(x => x.Mataikhoan.ToString().StartsWith(search)|| x.Hovaten.StartsWith(search) || x.Sodienthoai.StartsWith(search)).ToList();
            }
        }

        public bool Khoa_Mokhoa(Taikhoan taikhoan)
        {
            dbContext.Update(taikhoan);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateNhanVien(Taikhoan taikhoan)
        {
            dbContext.Update(taikhoan);
            dbContext.SaveChanges();
            return true;
        }
    }
}
