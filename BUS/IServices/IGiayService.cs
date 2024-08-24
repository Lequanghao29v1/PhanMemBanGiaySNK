using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IGiayService
    {
        public List<Giay> GetAll(string? txtSearch, string? searchType);
        public Giay GetByID(int id);
        public bool Them(Giay giay);
        public bool Sua(int id, Giay giay);
        public bool Khoa_MoKhoa(int id);

    }
}
