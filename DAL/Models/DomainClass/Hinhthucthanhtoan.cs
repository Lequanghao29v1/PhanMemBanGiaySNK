using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("HINHTHUCTHANHTOAN")]
public partial class Hinhthucthanhtoan
{
    [Key]
    [Column("MAHINHTHUCTHANHTOAN")]
    public int Mahinhthucthanhtoan { get; set; }

    [Column("TENHINHTHUC")]
    [StringLength(50)]
    public string? Tenhinhthuc { get; set; }

    [Column("MOTA")]
    [StringLength(200)]
    public string? Mota { get; set; }

    [InverseProperty("MahinhthucthanhtoanNavigation")]
    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
