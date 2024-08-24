using DAL.IRepositories;
using DAL.Models.DomainClass;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class KichCoService : IKichCoRepository
    {
        KichCoRepository _Rep;
        public KichCoService()
        {
            _Rep = new KichCoRepository();
        }
        public List<Kichco> GetAll(string? txtSearch, string? searchType)
        {
            return _Rep.GetAll(txtSearch, searchType);
        }

        public Kichco GetByID(int id)
        {
            return _Rep.GetByID(id);
        }

        public bool Khoa_MoKhoa(int id)
        {
            if (id == 0 || id == null)
            {
                return false;
            }

            return _Rep.Khoa_MoKhoa(id);
        }

        public bool Sua(int id, Kichco Kichco)
        {
            if (id == 0 || id == null)
            {
                return false;
            }
            else if (Kichco == null)
            {
                return false;
            }
            else if (Kichco.Tenkichco == "" || Kichco.Mota == "")
            {
                return false;
            }

            return _Rep.Sua(id, Kichco);
        }

        public bool Them(Kichco Kichco)
        {
            if (Kichco == null)
            {
                return false;
            }
            else if (Kichco.Tenkichco == "" || Kichco.Mota == "")
            {
                return false;
            }
            else if (Kichco.Mataikhoan == 0 || Kichco.Mataikhoan == null)
            {
                return false;
            }

            return _Rep.Them(Kichco);
        }
    }
}
