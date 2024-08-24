using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.ModelRefer
{
    public class HoaDonNhe
    {
        public Hoadon Hoadone { get; set; }  
        public string tenhinhthuc { get; set; }
        public string tenkhachhang { get; set; }
        public string sdtkhach { get; set; }
        public string hovatentaikhoan { get; set; }
        public string tengiay { get; set; }
        public string tenuudai { get; set; }
    }
}
