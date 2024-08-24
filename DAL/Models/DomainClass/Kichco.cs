using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("KICHCO")]
public partial class Kichco
{
    [Key]
    [Column("MAKICHCO")]
    public int Makichco { get; set; }

    [Column("TENKICHCO")]
    [StringLength(50)]
    public string? Tenkichco { get; set; }

    [Column("MOTA")]
    [StringLength(200)]
    public string? Mota { get; set; }

    [Column("TRANGTHAI")]
    public bool? Trangthai { get; set; }

    [Column("MATAIKHOAN")]
    public int? Mataikhoan { get; set; }

    [InverseProperty("MakichcoNavigation")]
    public virtual ICollection<Giaychitiet> Giaychitiets { get; set; } = new List<Giaychitiet>();

    [ForeignKey("Mataikhoan")]
    [InverseProperty("Kichcos")]
    public virtual Taikhoan? MataikhoanNavigation { get; set; }
}
