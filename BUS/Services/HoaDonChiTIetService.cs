using BUS.IServices;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HoaDonChiTIetService : IHoaDonChiTietService
    {
        HoaDonChiTietRepository _Rep;
        public HoaDonChiTIetService()
        {
            _Rep = new HoaDonChiTietRepository();
        }
        public List<HoaDonChiTiet_SP> GetAll(string? txtTimKiem, string? searchType)
        {
           return _Rep.GetAll(txtTimKiem, searchType);
        }

        public Hoadonchitiet GetByID(int? id)
        {
            return _Rep.GetByID(id);
        }

        public bool Sua(int? id, Hoadonchitiet hoadonchitiet)
        {
            return _Rep.Sua(id, hoadonchitiet);
        }

        public bool Them(Hoadonchitiet hoadonchitiet)
        {
            return _Rep.Them(hoadonchitiet);
        }

        public bool Xoa(int? id)
        {
            return _Rep.Xoa(id);
        }
    }
}
