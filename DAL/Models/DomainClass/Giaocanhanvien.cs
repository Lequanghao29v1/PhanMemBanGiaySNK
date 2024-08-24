using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("GIAOCANHANVIEN")]
public partial class Giaocanhanvien
{
    [Key]
    [Column("MAGIAOCANHANVIEN")]
    public int Magiaocanhanvien { get; set; }

    [Column("MATAIKHOAN")]
    public int? Mataikhoan { get; set; }

    [Column("MAGIAOCA")]
    public int? Magiaoca { get; set; }

    [Column("NGAYGIAOCA", TypeName = "date")]
    public DateTime? Ngaygiaoca { get; set; }

    [Column("THOIGIANDEN")]
    public TimeSpan? Thoigianden { get; set; }

    [Column("THOIGIANVE")]
    public TimeSpan? Thoigianve { get; set; }

    [Column("SANPHAMDAGIAO")]
    [StringLength(100)]
    public string? Sanphamdagiao { get; set; }

    [Column("TIENDAGIAO")]
    public double? Tiendagiao { get; set; }

    [Column("GHICHU")]
    [StringLength(300)]
    public string? Ghichu { get; set; }

    [Column("TRANGTHAI")]
    public int? Trangthai { get; set; }

    [ForeignKey("Magiaoca")]
    [InverseProperty("Giaocanhanviens")]
    public virtual Giaoca? MagiaocaNavigation { get; set; }

    [ForeignKey("Mataikhoan")]
    [InverseProperty("Giaocanhanviens")]
    public virtual Taikhoan? MataikhoanNavigation { get; set; }
}
