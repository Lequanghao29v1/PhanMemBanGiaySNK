using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ICaService
    {
        public List<Giaoca> Giaocas(string search);
        public string AddCa(Giaoca ca);
        public string UpdateCa(Giaoca ca);
    }
}
