using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ITaiKhoanService
    {
        public List<Taikhoan> GetAll(string? txtSearch, string? SearchType);
        public bool Sua(int? id, Taikhoan taikhoan);

    }
}
