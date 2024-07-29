using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CHUATHITHUNET103.DomainClass;

[Table("SINHVIEN")]
public partial class Sinhvien
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Ten { get; set; }

    public int? Tuoi { get; set; }

    [StringLength(50)]
    public string? CoSo { get; set; }
}
