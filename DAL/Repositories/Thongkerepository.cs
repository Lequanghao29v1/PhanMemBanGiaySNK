using DAL.IRepositories;
using DAL.Models.Context;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class Thongkerepository : IThongkerepository
    {
        DBContext dbContext;

        public Thongkerepository()
        {
            dbContext = new DBContext();
        }

        public List<Giaychitiet> GetGiaychitiets()
        {
            return dbContext.Giaychitiets.ToList();
        }

        public List<Giay> GetGiays()
        {
            return dbContext.Giays.ToList();
        }

        public List<Hoadonchitet_hoadon_giay> GetHD(string type)
        {
            IQueryable<Hoadonchitiet> query = dbContext.Hoadonchitiets.AsQueryable();
            if (!string.IsNullOrEmpty(type))
            {
                var result = (
                    from hoadonchitiet in query
                    join hoadon in dbContext.Hoadons on hoadonchitiet.Mahoadon equals hoadon.Mahoadon
                    join taikhoan in dbContext.Taikhoans on hoadon.Mataikhoan equals taikhoan.Mataikhoan
                    where hoadonchitiet.Mahoadon != null
                    select new Hoadonchitet_hoadon_giay
                    {
                        GetHoadon = hoadon,
                        Tentaikhoan = taikhoan != null ? taikhoan.Hovaten : "N/A",
                    })
                    .ToList();

                return result;
            }

            return new List<Hoadonchitet_hoadon_giay>();
        }
        public List<Taikhoan> GetTaikhoans()
        {
            return dbContext.Taikhoans.ToList();
        }
        public List<Hoadonchitiet> GetHoadonchitiets()
        {
            return dbContext.Hoadonchitiets.ToList();
        }
        public List<Hoadon> GetHoadons()
        {
            return dbContext.Hoadons.ToList();
        }
    }
}

