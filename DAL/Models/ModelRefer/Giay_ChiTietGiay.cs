using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.ModelRefer
{
    public class Giay_ChiTietGiay
    {
        public Giaychitiet giaychitiet { get; set; }
        public string? tenChatLieu { get; set; }
        public string? tenMauSac { get; set; }
        public string? tenKichCo { get; set; }
        public string? tenGiay { get; set; }
        public string? tenNguoiTao { get; set; }
        public string? tenNguoiSua { get; set; }
        public string? tenThuongHieu { get; set; }
        public string? tenKieuDang { get; set; }
        public int? soLuongCon { get; set; }
        public bool? trangThai { get; set; }
        public double? gia { get; set; }

    }
}
