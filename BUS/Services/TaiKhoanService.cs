using BUS.IServices;
using DAL.Models.DomainClass;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class TaiKhoanService : ITaiKhoanService
    {
        TaiKhoanRepository _Rep;
        public TaiKhoanService()
        {
            _Rep = new TaiKhoanRepository();
        }
        public List<Taikhoan> GetAll(string? txtSearch, string? SearchType)
        {
            return _Rep.GetAll(txtSearch, SearchType);
        }

        public bool Sua(int? id, Taikhoan taikhoan)
        {
            return _Rep.Sua(id, taikhoan);
        }
    }
}
