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
    public class MauSacService : IMauSacService
    {
        MauSacRepository _Rep;
        public MauSacService()
        {
            _Rep = new MauSacRepository();
        }
        public List<Mausac> GetAll(string? txtSearch, string? searchType)
        {
            return _Rep.GetAll(txtSearch, searchType);
        }

        public Mausac GetByID(int id)
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

        public bool Sua(int id, Mausac Mausac)
        {
            if (id == 0 || id == null)
            {
                return false;
            }
            else if (Mausac == null)
            {
                return false;
            }
            else if (Mausac.Tenmausac == "" || Mausac.Mota == "")
            {
                return false;
            }

            return _Rep.Sua(id, Mausac);
        }

        public bool Them(Mausac Mausac)
        {
            if (Mausac == null)
            {
                return false;
            }
            else if (Mausac.Tenmausac == "" || Mausac.Mota == "")
            {
                return false;
            }
            else if (Mausac.Mataikhoan == 0 || Mausac.Mataikhoan == null)
            {
                return false;
            }

            return _Rep.Them(Mausac);
        }
    }
}
