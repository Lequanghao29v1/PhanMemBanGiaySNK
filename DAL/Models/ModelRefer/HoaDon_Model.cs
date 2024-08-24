using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.ModelRefer
{
    public class HoaDon_Model
    {
        public Hoadon Hoadon { get; set; }
        public string tenTaiKhoan { get; set; }
        public string tenUuDai { get; set; }
        public string tenKhachHang { get; set; }
        public int? diemKhachHang { get; set; }
        public string tenHinhThucThanhToan { get; set; }


    }
}
