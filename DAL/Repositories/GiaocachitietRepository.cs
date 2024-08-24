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
    public class GiaocachitietRepository : IGiaocachitietRepository
    {
        DBContext dbContext;
        public GiaocachitietRepository()
        {
            dbContext = new DBContext();
        }

        public bool AddCaCT(Giaocanhanvien cact)
        {         
                dbContext.Add(cact);
                dbContext.SaveChanges();
                return true;
        }
        public List<Giaoca> GetGiaocas(string searchs)
        {
            if (searchs == null)
            {
                return dbContext.Giaocas.ToList();
            }
            else
            {
                return dbContext.Giaocas.Where(x => x.Tenca.Contains(searchs)).ToList();
            }
        }

        public List<Taikhoan> GetTaikhoans(string searchss)
        {
            if (searchss == null)
            {
                return dbContext.Taikhoans.ToList();
            }
            else
            {
                return dbContext.Taikhoans.Where(x => x.Mataikhoan.ToString().StartsWith(searchss) || x.Hovaten.StartsWith(searchss) || x.Sodienthoai.StartsWith(searchss)).ToList();
            }
        }

        public List<Giaocanhanvien> giaocanhanviens(string search)
        {
            if (search == null)
            {
                return dbContext.Giaocanhanviens.ToList();
            }
            else
            {
                return dbContext.Giaocanhanviens.Where(x => x.Trangthai.ToString().StartsWith(search) || x.Mataikhoan.ToString().StartsWith(search)).ToList();
            }
        }

        public bool HuyCaCT(Giaocanhanvien cact)
        {
            dbContext.Update(cact);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateCaCT(Giaocanhanvien cact)
        {
            dbContext.Update(cact);
            dbContext.SaveChanges();
            return true;
        }
    }
}
