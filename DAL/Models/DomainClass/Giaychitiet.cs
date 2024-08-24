using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("GIAYCHITIET")]
public partial class Giaychitiet
{
    [Key]
    [Column("MAGIAYCHITIET")]
    public int Magiaychitiet { get; set; }

    [Column("MAGIAY")]
    public int? Magiay { get; set; }

    [Column("MACHATLIEU")]
    public int? Machatlieu { get; set; }

    [Column("MAMAUSAC")]
    public int? Mamausac { get; set; }

    [Column("MAKICHCO")]
    public int? Makichco { get; set; }

    [Column("MATHUONGHIEU")]
    public int? Mathuonghieu { get; set; }

    [Column("MAKIEUDANG")]
    public int? Makieudang { get; set; }

    [Column("SOLUONGCON")]
    public int? Soluongcon { get; set; }

    [Column("NGAYTAO", TypeName = "datetime")]
    public DateTime? Ngaytao { get; set; }

    [Column("NGAYSUA", TypeName = "datetime")]
    public DateTime? Ngaysua { get; set; }

    [Column("NGUOITAO")]
    public int? Nguoitao { get; set; }

    [Column("NGUOISUA")]
    public int? Nguoisua { get; set; }

    [Column("GIA")]
    public double? Gia { get; set; }

    [Column("MOTA")]
    [StringLength(300)]
    public string? Mota { get; set; }

    [Column("TRANGTHAI")]
    public bool? Trangthai { get; set; }

    [InverseProperty("MagiaychitietNavigation")]
    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();

    [ForeignKey("Machatlieu")]
    [InverseProperty("Giaychitiets")]
    public virtual Chatlieu? MachatlieuNavigation { get; set; }

    [ForeignKey("Magiay")]
    [InverseProperty("Giaychitiets")]
    public virtual Giay? MagiayNavigation { get; set; }

    [ForeignKey("Makichco")]
    [InverseProperty("Giaychitiets")]
    public virtual Kichco? MakichcoNavigation { get; set; }

    [ForeignKey("Makieudang")]
    [InverseProperty("Giaychitiets")]
    public virtual Kieudang? MakieudangNavigation { get; set; }

    [ForeignKey("Mamausac")]
    [InverseProperty("Giaychitiets")]
    public virtual Mausac? MamausacNavigation { get; set; }

    [ForeignKey("Mathuonghieu")]
    [InverseProperty("Giaychitiets")]
    public virtual Thuonghieu? MathuonghieuNavigation { get; set; }

    [ForeignKey("Nguoisua")]
    [InverseProperty("GiaychitietNguoisuaNavigations")]
    public virtual Taikhoan? NguoisuaNavigation { get; set; }

    [ForeignKey("Nguoitao")]
    [InverseProperty("GiaychitietNguoitaoNavigations")]
    public virtual Taikhoan? NguoitaoNavigation { get; set; }
}
