using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("BANGLUONG")]
public partial class Bangluong
{
    [Key]
    [Column("MALUONG")]
    public int Maluong { get; set; }

    [Column("THANGLAM")]
    public int? Thanglam { get; set; }

    [Column("LUONGCOBAN")]
    public double? Luongcoban { get; set; }

    [Column("TIENTHUONG")]
    public double? Tienthuong { get; set; }

    [Column("TIENKHAUTRU")]
    public double? Tienkhautru { get; set; }

    [Column("TONGTHUNHAP")]
    public double? Tongthunhap { get; set; }

    [Column("MATAIKHOAN")]
    public int? Mataikhoan { get; set; }

    [ForeignKey("Mataikhoan")]
    [InverseProperty("Bangluongs")]
    public virtual Taikhoan? MataikhoanNavigation { get; set; }
}
