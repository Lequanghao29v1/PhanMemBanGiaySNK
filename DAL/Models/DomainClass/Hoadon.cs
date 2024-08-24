using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("HOADON")]
public partial class Hoadon
{
    [Key]
    [Column("MAHOADON")]
    public int Mahoadon { get; set; }

    [Column("MATAIKHOAN")]
    public int? Mataikhoan { get; set; }

    [Column("MAUUDAI")]
    public int? Mauudai { get; set; }

    [Column("MAKHACHHANG")]
    public int? Makhachhang { get; set; }

    [Column("MAHINHTHUCTHANHTOAN")]
    public int? Mahinhthucthanhtoan { get; set; }

    [Column("TENCUAHANG")]
    [StringLength(100)]
    public string? Tencuahang { get; set; }

    [Column("DIACHICUAHANG")]
    [StringLength(200)]
    public string? Diachicuahang { get; set; }

    [Column("SDTCUAHANG")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Sdtcuahang { get; set; }

    [Column("EMAILCUAHANG")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Emailcuahang { get; set; }

    [Column("NGAYTAO", TypeName = "datetime")]
    public DateTime? Ngaytao { get; set; }

    [Column("TONGTIEN")]
    public double? Tongtien { get; set; }

    [Column("TRANGTHAI")]
    public bool? Trangthai { get; set; }

    [Column("GHICHU")]
    [StringLength(200)]
    public string? Ghichu { get; set; }

    [InverseProperty("MahoadonNavigation")]
    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();

    [ForeignKey("Mahinhthucthanhtoan")]
    [InverseProperty("Hoadons")]
    public virtual Hinhthucthanhtoan? MahinhthucthanhtoanNavigation { get; set; }

    [ForeignKey("Makhachhang")]
    [InverseProperty("Hoadons")]
    public virtual Khachhang? MakhachhangNavigation { get; set; }

    [ForeignKey("Mataikhoan")]
    [InverseProperty("Hoadons")]
    public virtual Taikhoan? MataikhoanNavigation { get; set; }

    [ForeignKey("Mauudai")]
    [InverseProperty("Hoadons")]
    public virtual Uudai? MauudaiNavigation { get; set; }
}
