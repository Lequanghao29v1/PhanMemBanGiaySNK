using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface ICaRepository
    {
        public List<Giaoca> Giaocas(string search);
        public bool AddCa(Giaoca ca);
        public bool UpdateCa(Giaoca ca);
    }
}
