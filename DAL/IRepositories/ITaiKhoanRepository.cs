using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface ITaiKhoanRepository
    {
        public List<Taikhoan> GetAll(string? txtSearch, string? SearchType);
        public bool Sua(int? id, Taikhoan taikhoan);

    }
}
