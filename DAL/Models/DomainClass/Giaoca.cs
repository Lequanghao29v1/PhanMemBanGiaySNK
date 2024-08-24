using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("GIAOCA")]
public partial class Giaoca
{
    [Key]
    [Column("MAGIAOCA")]
    public int Magiaoca { get; set; }

    [Column("TENCA")]
    [StringLength(50)]
    public string? Tenca { get; set; }

    [Column("THOIGIANBATDAU")]
    public TimeSpan? Thoigianbatdau { get; set; }

    [Column("THOIGIANKETTHUC")]
    public TimeSpan? Thoigianketthuc { get; set; }

    [InverseProperty("MagiaocaNavigation")]
    public virtual ICollection<Giaocanhanvien> Giaocanhanviens { get; set; } = new List<Giaocanhanvien>();
}
