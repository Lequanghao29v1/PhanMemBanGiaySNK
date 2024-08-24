using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("HOADONCHITIET")]
public partial class Hoadonchitiet
{
    [Key]
    [Column("MAHOADONCHITIET")]
    public int Mahoadonchitiet { get; set; }

    [Column("MAGIAYCHITIET")]
    public int? Magiaychitiet { get; set; }

    [Column("MAHOADON")]
    public int? Mahoadon { get; set; }

    [Column("SOLUONGMUA")]
    public int? Soluongmua { get; set; }

    [Column("GIA")]
    public double? Gia { get; set; }

    [ForeignKey("Magiaychitiet")]
    [InverseProperty("Hoadonchitiets")]
    public virtual Giaychitiet? MagiaychitietNavigation { get; set; }

    [ForeignKey("Mahoadon")]
    [InverseProperty("Hoadonchitiets")]
    public virtual Hoadon? MahoadonNavigation { get; set; }
}
