using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("THUONGHIEU")]
public partial class Thuonghieu
{
    [Key]
    [Column("MATHUONGHIEU")]
    public int Mathuonghieu { get; set; }

    [Column("TENTHUONGHIEU")]
    [StringLength(50)]
    public string? Tenthuonghieu { get; set; }

    [Column("EMAIL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("SDT")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Sdt { get; set; }

    [Column("TRANGTHAI")]
    public bool? Trangthai { get; set; }

    [Column("MOTA")]
    [StringLength(200)]
    public string? Mota { get; set; }

    [Column("MATAIKHOAN")]
    public int? Mataikhoan { get; set; }

    [InverseProperty("MathuonghieuNavigation")]
    public virtual ICollection<Giaychitiet> Giaychitiets { get; set; } = new List<Giaychitiet>();

    [ForeignKey("Mataikhoan")]
    [InverseProperty("Thuonghieus")]
    public virtual Taikhoan? MataikhoanNavigation { get; set; }
}
