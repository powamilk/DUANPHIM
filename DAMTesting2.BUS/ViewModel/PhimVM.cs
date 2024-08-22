using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMTesting2.BUS.ViewModel
{
    public class PhimVM
    {
        public int PhimId { get; set; }

        public string TenPhim { get; set; } = null!;

        public DateOnly? ThoiGianPhatHanh { get; set; }

        public string? DaoDien { get; set; }

        public int? ThoiLuong { get; set; }

        public int? TrangThai { get; set; }

        public string? MoTa { get; set; }
        public List<string>? TheLoais { get; set; }

    }
}
