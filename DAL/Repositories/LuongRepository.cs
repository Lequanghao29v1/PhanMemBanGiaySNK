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
    public class LuongRepository : ILuongRepository
    {
        DBContext dBContext;
        public LuongRepository()
        {
            dBContext = new DBContext();
        }

        public bool AddLuong(Bangluong bangluong)
        {
            dBContext.Add(bangluong);
            dBContext.SaveChanges();
            return true;
        }

        public List<Bangluong> bangluongs(string search)
        { 
           if( search == null)
            {
                return dBContext.Bangluongs.ToList();
            }
           return dBContext.Bangluongs.Where(x => x.Maluong.ToString().StartsWith(search) || x.Mataikhoan.ToString().StartsWith(search) ).ToList();
        }

        public List<Giaocanhanvien> giaocanhanvien()
        {
            return dBContext.Giaocanhanviens.ToList();
        }

        public bool Huybangluong(Bangluong bangluong)
        {
            dBContext.Update(bangluong);
            dBContext.SaveChanges();
            return true;
        }

        public List<Taikhoan> taikhoans()
        {
            return dBContext.Taikhoans.ToList();
        }

        public bool UdateLuong(Bangluong bangluong)
        {
            dBContext.Update(bangluong);
            dBContext.SaveChanges();
            return true;
        }
    }
}
