using BUS.IServices;
using DAL.Models.ModelRefer;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class Giay_ChiTietGiayService : IGiay_ChiTietGiayService
    {
        Giay_ChiTietGiayRepository _Rep;
        public Giay_ChiTietGiayService()
        {
            _Rep = new();
        }
        public List<Giay_ChiTietGiay> GetAll(string? txtTimKiem, string? searchType)
        {
            return _Rep.GetAll(txtTimKiem,searchType);
        }
        public Giay_ChiTietGiay GetById(int? id)
        {
            return _Rep.GetById(id);

        }

    }
}
