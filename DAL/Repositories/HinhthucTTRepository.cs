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
    public class HinhthucTTRepository : IHinhthucTTRepository
    {
        DBContext dbContext;
        public HinhthucTTRepository()
        {
            dbContext = new DBContext();
        }
        public bool AddHTTT(Hinhthucthanhtoan ht)
        {
            dbContext.Add(ht);
            dbContext.SaveChanges();
            return true;
        }

        public List<Hinhthucthanhtoan> GetHinhthucTT(string search)
        {
            if(search == null)
            {
                return dbContext.Hinhthucthanhtoans.ToList();
            }
            else
            {
                return dbContext.Hinhthucthanhtoans.Where(x =>x.Tenhinhthuc.StartsWith(search)).ToList();
            }
        }

        public bool UpdateHTTT(Hinhthucthanhtoan ht)
        {
            dbContext.Update(ht);
            dbContext.SaveChanges();
            return true;
        }
    }
}
