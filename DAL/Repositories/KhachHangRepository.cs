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
    public class KhachHangRepository : IKhachHangRepository
    {
        DBContext dbContext;
        public KhachHangRepository()
        {
            dbContext = new DBContext();
        }
        public bool AddKhachHang(Khachhang khachhang)
        {
            dbContext.Add(khachhang);
            dbContext.SaveChanges();
            return true;
        }

        public List<Hoadon> GetAllHoadon()
        {
            return dbContext.Hoadons.ToList();
        }

        public List<Khachhang> GetAllKhachhang(string search)
        {
            if (search == null)
            {
                return dbContext.Khachhangs.ToList();
            }
            else
            {
                return dbContext.Khachhangs.Where(x => x.Sdt.StartsWith(search)).ToList();
            }
        }

        public List<Hinhthucthanhtoan> GetHinhthucthanhtoans()
        {
            return dbContext.Hinhthucthanhtoans.ToList();
        }

        public bool UpdateKhachHang(Khachhang khachhang)
        {
            dbContext.Update(khachhang);
            dbContext.SaveChanges();
            return true;
        }
    }

}
