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
                TheLoaiIds = entity.TheLoaiCuaPhims.Select(tlcp => tlcp.TheLoaiId).ToList() // Lấy danh sách TheLoaiIds từ TheLoaiCuaPhims
            };
        }

        public static Phim MapCreateVMToEntity(PhimCreateVM createVM)
        {
            var phim = new Phim()
            {
                TenPhim = createVM.TenPhim,
                ThoiGianPhatHanh = createVM.ThoiGianPhatHanh,
                DaoDien = createVM.DaoDien,
                ThoiLuong = createVM.ThoiLuong,
                TrangThai = createVM.TrangThai,
                MoTa = createVM.MoTa
            };

            foreach (var theLoaiId in createVM.TheLoaiIds)
            {
                phim.TheLoaiCuaPhims.Add(new TheLoaiCuaPhim
                {
                    TheLoaiId = theLoaiId,
                    Phim = phim
                });
            }

            return phim;
        }

        public static Phim MapUpdateVMToEntity(PhimUpdateVM updateVM)
        {
            var phim = new Phim()
            {
                PhimId = updateVM.PhimId,
                TenPhim = updateVM.TenPhim,
                ThoiGianPhatHanh = updateVM.ThoiGianPhatHanh,
                DaoDien = updateVM.DaoDien,
                ThoiLuong = updateVM.ThoiLuong,
                TrangThai = updateVM.TrangThai,
                MoTa = updateVM.MoTa
            };

            foreach (var theLoaiId in updateVM.TheLoaiIds)
            {
                phim.TheLoaiCuaPhims.Add(new TheLoaiCuaPhim
                {
                    TheLoaiId = theLoaiId,
                    Phim = phim
                });
            }

            return phim;
        }
    }
}
