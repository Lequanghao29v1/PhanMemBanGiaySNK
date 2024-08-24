using DAL.Models.DomainClass;

namespace DAL.Models.ModelRefer
{
    public class Hoadonchitet_hoadon_giay
    {
        public Hoadonchitiet Hoadonchitiet { get; set; }
        public Hoadon GetHoadon { get; set; }
        public int? Mataikhoan { get; set; }
        public string Ngaytao { get; set; } // Correct casing
        public string Tentaikhoan { get; set; } // Correct casing
        public string Tengiay { get; set; } // Correct casing
        public int Soluongmua { get; set; }
        public double Gia { get; set; }
    }
}
