using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("CHUCVU")]
public partial class Chucvu
{
    [Key]
    [Column("MACHUCVU")]
    public int Machucvu { get; set; }

    [Column("TENCHUCVU")]
    [StringLength(50)]
    public string? Tenchucvu { get; set; }

    [Column("MOTACHUCVU")]
    [StringLength(200)]
    public string? Motachucvu { get; set; }

    [InverseProperty("MachucvuNavigation")]
    public virtual ICollection<Taikhoan> Taikhoans { get; set; } = new List<Taikhoan>();
}
