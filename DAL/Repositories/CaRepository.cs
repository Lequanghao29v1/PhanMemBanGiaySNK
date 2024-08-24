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
    public class CaRepository : ICaRepository
    {
        DBContext dbContext;
        public CaRepository()
        {
            dbContext = new DBContext();
        }
        public bool AddCa(Giaoca ca)
        {
            dbContext.Add(ca);
            dbContext.SaveChanges();
            return true;
        }
        public List<Giaoca> Giaocas(string search)
        {
            if (search == null)
            {
                return dbContext.Giaocas.ToList();
            }
            else
            {
                return dbContext.Giaocas.Where(x => x.Tenca.Contains(search)).ToList();
            }
        }
        public bool UpdateCa(Giaoca ca)
        {
            dbContext.Update(ca);
            dbContext.SaveChanges();
            return true;
        }
    }
}
