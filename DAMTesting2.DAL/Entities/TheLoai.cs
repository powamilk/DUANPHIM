using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAMTesting2.DAL.Entities;

public partial class TheLoai
{
    public int TheLoaiId { get; set; }
    public string? TenTheLoai { get; set; }

    public virtual ICollection<TheLoaiCuaPhim> TheLoaiCuaPhims { get; set; } = new List<TheLoaiCuaPhim>();
}
