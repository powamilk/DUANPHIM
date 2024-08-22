using DAMTesting2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMTesting2.DAL.Entities;

namespace DAMTesting2.BUS.Utils
{
    public class PhimMapping
    {
        public static PhimVM MapEntityToVM(Phim entity)
        {
            return new PhimVM()
            {
                PhimId = entity.PhimId,
                TenPhim = entity.TenPhim,
                ThoiGianPhatHanh = entity.ThoiGianPhatHanh,
                DaoDien = entity.DaoDien,
                ThoiLuong = entity.ThoiLuong,
                TrangThai = entity.TrangThai,
                MoTa = entity.MoTa,
                TheLoais = entity.TheLoais.Select(tl => tl.TenTheLoai).ToList()
            };
        }

        public static Phim MapCreateVMToEntity(PhimCreateVM createVM)
        {
            return new Phim()
            {
                TenPhim = createVM.TenPhim,
                ThoiGianPhatHanh = createVM.ThoiGianPhatHanh,
                DaoDien = createVM.DaoDien,
                ThoiLuong = createVM.ThoiLuong,
                TrangThai = createVM.TrangThai,
                MoTa = createVM.MoTa,
                TheLoais = createVM.TheLoaiIds.Select(id => new TheLoai { TheLoaiId = id }).ToList()
            };
        }

        public static Phim MapUpdateVMToEntity(PhimUpdateVM updateVM)
        {
            return new Phim()
            {
                PhimId = updateVM.PhimId,
                TenPhim = updateVM.TenPhim,
                ThoiGianPhatHanh = updateVM.ThoiGianPhatHanh,
                DaoDien = updateVM.DaoDien,
                ThoiLuong = updateVM.ThoiLuong,
                TrangThai = updateVM.TrangThai,
                MoTa = updateVM.MoTa,
                TheLoais = updateVM.TheLoaiIds.Select(id => new TheLoai { TheLoaiId = id }).ToList()
            };
        }
    }
}
