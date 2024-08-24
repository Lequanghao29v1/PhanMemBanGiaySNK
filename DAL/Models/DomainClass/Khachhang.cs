using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("KHACHHANG")]
public partial class Khachhang
{
    [Key]
    [Column("MAKHACHHANG")]
    public int Makhachhang { get; set; }

    [Column("TENKHACHHANG")]
    [StringLength(50)]
    public string? Tenkhachhang { get; set; }

    [Column("SDT")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Sdt { get; set; }

    [Column("DIEMKHACHHANG")]
    public int? Diemkhachhang { get; set; }

    [Column("TRANGTHAI")]
    public bool? Trangthai { get; set; }

    [InverseProperty("MakhachhangNavigation")]
    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
