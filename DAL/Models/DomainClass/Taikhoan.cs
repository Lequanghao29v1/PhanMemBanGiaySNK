using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.DomainClass;

[Table("TAIKHOAN")]
public partial class Taikhoan
{
    [Key]
    [Column("MATAIKHOAN")]
    public int Mataikhoan { get; set; }

    [Column("USERNAME")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Username { get; set; }

    [Column("PASWORD")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Pasword { get; set; }

    [Column("HOVATEN")]
    [StringLength(50)]
    public string? Hovaten { get; set; }

    [Column("GIOITINH")]
    public bool? Gioitinh { get; set; }

    [Column("SODIENTHOAI")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Sodienthoai { get; set; }

    [Column("DIACHI")]
    [StringLength(200)]
    public string? Diachi { get; set; }

    [Column("EMAIL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("NGAYSINH", TypeName = "date")]
    public DateTime? Ngaysinh { get; set; }

    [Column("NGAYTAOTAIKHOAN", TypeName = "date")]
    public DateTime? Ngaytaotaikhoan { get; set; }

    [Column("MACHUCVU")]
    public int Machucvu { get; set; }

    [Column("TRANGTHAI")]
    public bool? Trangthai { get; set; }

    [InverseProperty("MataikhoanNavigation")]
    public virtual ICollection<Bangluong> Bangluongs { get; set; } = new List<Bangluong>();

    [InverseProperty("MataikhoanNavigation")]
    public virtual ICollection<Chatlieu> Chatlieus { get; set; } = new List<Chatlieu>();

    [InverseProperty("MataikhoanNavigation")]
    public virtual ICollection<Giaocanhanvien> Giaocanhanviens { get; set; } = new List<Giaocanhanvien>();

    [InverseProperty("NguoisuaNavigation")]
    public virtual ICollection<Giaychitiet> GiaychitietNguoisuaNavigations { get; set; } = new List<Giaychitiet>();

    [InverseProperty("NguoitaoNavigation")]
    public virtual ICollection<Giaychitiet> GiaychitietNguoitaoNavigations { get; set; } = new List<Giaychitiet>();

    [InverseProperty("MataikhoanNavigation")]
    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    [InverseProperty("MataikhoanNavigation")]
    public virtual ICollection<Kichco> Kichcos { get; set; } = new List<Kichco>();

    [InverseProperty("MataikhoanNavigation")]
    public virtual ICollection<Kieudang> Kieudangs { get; set; } = new List<Kieudang>();

    [ForeignKey("Machucvu")]
    [InverseProperty("Taikhoans")]
    public virtual Chucvu MachucvuNavigation { get; set; } = null!;

    [InverseProperty("MataikhoanNavigation")]
    public virtual ICollection<Mausac> Mausacs { get; set; } = new List<Mausac>();

    [InverseProperty("MataikhoanNavigation")]
    public virtual ICollection<Thuonghieu> Thuonghieus { get; set; } = new List<Thuonghieu>();

    [InverseProperty("MataikhoanNavigation")]
    public virtual ICollection<Uudai> Uudais { get; set; } = new List<Uudai>();
}
