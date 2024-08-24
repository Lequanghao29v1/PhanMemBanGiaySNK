using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("KIEUDANG")]
public partial class Kieudang
{
    [Key]
    [Column("MAKIEUDANG")]
    public int Makieudang { get; set; }

    [Column("TENKIEUDANG")]
    [StringLength(50)]
    public string? Tenkieudang { get; set; }

    [Column("MOTA")]
    [StringLength(200)]
    public string? Mota { get; set; }

    [Column("TRANGTHAI")]
    public bool? Trangthai { get; set; }

    [Column("MATAIKHOAN")]
    public int? Mataikhoan { get; set; }

    [InverseProperty("MakieudangNavigation")]
    public virtual ICollection<Giaychitiet> Giaychitiets { get; set; } = new List<Giaychitiet>();

    [ForeignKey("Mataikhoan")]
    [InverseProperty("Kieudangs")]
    public virtual Taikhoan? MataikhoanNavigation { get; set; }
}
