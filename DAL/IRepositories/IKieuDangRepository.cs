using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IKieuDangRepository
    {
        public List<Kieudang> GetAll(string? txtSearch, string? searchType);
        public Kieudang GetByID(int id);
        public bool Them(Kieudang Kieudang);
        public bool Sua(int id, Kieudang Kieudang);
        public bool Khoa_MoKhoa(int id);

    }
}
