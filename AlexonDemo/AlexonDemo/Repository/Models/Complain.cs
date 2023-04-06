using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AlexonDemo.Repository.Models;

public partial class Complain
{
    [Key]
    public int Id { get; set; }

    [Column("ComplainTYpe")]
    [StringLength(50)]
    public string ComplainType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ComplainDate { get; set; }

    [StringLength(25)]
    public string City { get; set; } = null!;

    [StringLength(10)]
    public string Department { get; set; } = null!;

    [StringLength(50)]
    public string Status { get; set; } = null!;
    [StringLength(100)]
    public string Display { get; set; } = null!;
}
