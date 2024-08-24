using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("GIAY")]
public partial class Giay
{
    [Key]
    [Column("MAGIAY")]
    public int Magiay { get; set; }

    [Column("TENGIAY")]
    [StringLength(50)]
    public string? Tengiay { get; set; }

    [InverseProperty("MagiayNavigation")]
    public virtual ICollection<Giaychitiet> Giaychitiets { get; set; } = new List<Giaychitiet>();
}
